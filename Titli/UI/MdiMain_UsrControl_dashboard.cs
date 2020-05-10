using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LightInject;

namespace Titli.UI
{
    public partial class MdiMain_UsrControl_dashboard : UserControl
    {
        public MdiMain_UsrControl_dashboard(ServiceContainer services)
        {
            this.services = services;
            InitializeComponent();
            AdditionalDesignSettings();
        }
        /// <summary>
        /// Child menu on ribbon.
        /// </summary>
        private Dashboard_UsrControl_RibbonMenu RibbonMenu;
        private FlowLayoutPanel Frm_Table_FlowPanel_SidePanel;
        private ServiceContainer services;
        private Dashboard_UsrControl_Alert Dashboard_UsrControl_Alert;
        public FlowLayoutPanel SidePanel_FlowPanel_ControlBox { get; set; }
        public Button SidePanelContrlBox_Btn_Close { get; set; }
        public Button SidePanelContrlBox_Btn_Deattach { get; set; }

        private void AdditionalDesignSettings()
        {
            this.Dock = DockStyle.Fill;
            RibbonMenu = new Titli.UI.Dashboard_UsrControl_RibbonMenu();
            Frm_Table_FlowPanel_SidePanel = new FlowLayoutPanel();
            Frm_Table_FlowPanel_SidePanel.BackColor = Color.Beige;
            Frm_Table_FlowPanel_SidePanel.Dock = DockStyle.Fill;
            Frm_Table_FlowPanel_SidePanel.FlowDirection = FlowDirection.TopDown;
            Frm_Table_FlowPanel_SidePanel.AutoScroll = true;
            Frm_Table_FlowPanel_SidePanel.MaximumSize = new Size(200, 0);

            tabPage_Home.Controls.Add(new MdiMain_UsrControl_Browser(services));

            SidePanel_FlowPanel_ControlBox = new FlowLayoutPanel();
            SidePanel_FlowPanel_ControlBox.Height = 22;
            SidePanel_FlowPanel_ControlBox.Width = Frm_Table_FlowPanel_SidePanel.Width;
            SidePanel_FlowPanel_ControlBox.FlowDirection = FlowDirection.RightToLeft;

            SidePanelContrlBox_Btn_Close = new Button();
            SidePanelContrlBox_Btn_Close.Text = "X";
            SidePanelContrlBox_Btn_Close.Font = new Font("Arial", 8f, FontStyle.Bold);
            SidePanelContrlBox_Btn_Close.Width = 18;
            SidePanelContrlBox_Btn_Close.Height = 20;
            SidePanelContrlBox_Btn_Close.Margin = new Padding(0, 1, 3, 3);
            SidePanelContrlBox_Btn_Close.Click += SidePanelContrlBox_Btn_Close_Click;

            SidePanelContrlBox_Btn_Deattach = new Button();
            SidePanelContrlBox_Btn_Deattach.Text = "O";
            SidePanelContrlBox_Btn_Deattach.Font = new Font("Arial", 8f, FontStyle.Bold);
            SidePanelContrlBox_Btn_Deattach.Width = 18;
            SidePanelContrlBox_Btn_Deattach.Height = 20;
            SidePanelContrlBox_Btn_Deattach.Margin = new Padding(3, 1, 2, 3);

            //SidePanelContrlBox_Btn_Close.FlatStyle = FlatStyle.Flat;
            SidePanel_FlowPanel_ControlBox.Controls.Add(SidePanelContrlBox_Btn_Close);
            SidePanel_FlowPanel_ControlBox.Controls.Add(SidePanelContrlBox_Btn_Deattach);
            Frm_Table_FlowPanel_SidePanel.Controls.Add(SidePanel_FlowPanel_ControlBox);

            RibbonMenu.Dock = DockStyle.Fill;
            this.frm_Table_Base.Controls.Add(RibbonMenu, 0, 1);
            frm_Table_Base.SetColumnSpan(RibbonMenu, 2);

            //Below 2 events are raisen by child user controls
            RibbonMenu.AlertsTable_Btn_Close_Clicked += RibbonMenu_AlertsTable_Btn_Close_Clicked;
            RibbonMenu.AlertTable_Btn_SideWinOpen_Clicked += RibbonMenu_AlertTable_Btn_SideWinOpen_Clicked;

            Dashboard_UsrControl_Alert = new Dashboard_UsrControl_Alert(services, Dashboard_UsrControl_Alert.Mode.SideWindow);
        }

        private void SidePanelContrlBox_Btn_Close_Click(object sender, EventArgs e)
        {
            //Remove Alerts
            Frm_Table_FlowPanel_SidePanel.Controls.Remove(Dashboard_UsrControl_Alert);
            //Dashboard_UsrControl_Alert = null;

            frm_Table_Base.Controls.Remove(Frm_Table_FlowPanel_SidePanel);
            frm_Table_Base.Controls.Remove(frm_Panel_Content);
            //frm_Table_Base.Controls.Add(Frm_Table_FlowPanel_SidePanel, 2, 1);
            frm_Table_Base.Controls.Add(frm_Panel_Content, 1, 1);
            frm_Table_Base.SetColumnSpan(frm_Panel_Content, 2);
            //frm_Table_Base.SetColumnSpan(Frm_Table_FlowPanel_SidePanel, 1);
        }

        private void RibbonMenu_AlertTable_Btn_SideWinOpen_Clicked(object sender, EventArgs e)
        {
            OpenSideWindow();
        }

        /// <summary>
        /// Opens side window for show steps seq etc.
        /// </summary>
        private void OpenSideWindow()
        {
            frm_Table_Base.Controls.Remove(frm_Panel_Content);
            frm_Table_Base.Controls.Add(Frm_Table_FlowPanel_SidePanel, 1, 2);
            frm_Table_Base.Controls.Add(frm_Panel_Content,0,2);
            frm_Table_Base.SetColumnSpan(frm_Panel_Content, 1);
            frm_Table_Base.SetColumnSpan(Frm_Table_FlowPanel_SidePanel, 1);
            if (Frm_Table_FlowPanel_SidePanel.Controls.Find("Dashboard_UsrControl_Alert",true).Count()==0)
            {
                //Dashboard_UsrControl_Alert = new Dashboard_UsrControl_Alert(services, Dashboard_UsrControl_Alert.Mode.SideWindow);
                Frm_Table_FlowPanel_SidePanel.Controls.Add(Dashboard_UsrControl_Alert);
            }
           
        }

        private void RibbonMenu_AlertsTable_Btn_Close_Clicked(object sender, EventArgs e)
        {
            AlertsTable_Btn_Close_Click();
        }

        private void AlertsTable_Btn_Close_Click()
        {
          

            RibbonMenu.Dock = DockStyle.None;
            //RibbonMenu.Controls["frm_Table_Base"].Controls.Remove(this);
            frm_Table_Base.Controls.Remove(RibbonMenu);
            frm_Table_Base.Controls.Remove(frm_Panel_Content);
            frm_Table_Base.Controls.Add(frm_Panel_Content, 0, 1);
            frm_Table_Base.SetRowSpan(frm_Panel_Content, 2);
            //if column span is 1, thats means another control (side panel) is in another column
            if (frm_Table_Base.GetColumnSpan(frm_Panel_Content) == 1)
            {
                frm_Table_Base.Controls.Remove(Frm_Table_FlowPanel_SidePanel);
                frm_Table_Base.Controls.Add(Frm_Table_FlowPanel_SidePanel,1,1);
                frm_Table_Base.SetRowSpan(Frm_Table_FlowPanel_SidePanel, 2);
                
            }
        }

        private void ribbonMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Table_Base.Controls.Remove(frm_Panel_Content);
            //Here column, row => 1st col and 3rd row
            frm_Table_Base.Controls.Add(frm_Panel_Content, 0, 2);
            frm_Table_Base.SetRowSpan(frm_Panel_Content, 1);
            frm_Table_Base.Controls.Add(RibbonMenu,0,1);
            RibbonMenu.Dock = DockStyle.Fill;
            if (frm_Table_Base.GetColumnSpan(frm_Panel_Content) == 1 &&
                frm_Table_Base.GetRowSpan(Frm_Table_FlowPanel_SidePanel) == 2)
            {
                frm_Table_Base.Controls.Remove(Frm_Table_FlowPanel_SidePanel);
                frm_Table_Base.Controls.Add(Frm_Table_FlowPanel_SidePanel, 1, 2);
                frm_Table_Base.SetRowSpan(Frm_Table_FlowPanel_SidePanel, 1);

            }

        }
    }
}
