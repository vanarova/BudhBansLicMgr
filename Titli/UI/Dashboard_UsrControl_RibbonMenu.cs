using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titli.UI
{
    public partial class Dashboard_UsrControl_RibbonMenu : UserControl
    {
        public Dashboard_UsrControl_RibbonMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        ///This event is raised by user control, against an UI action (can be button clicked etc)
        ///The handling of event is responsibility of parent control, containing this control.
        /// </summary>
        public event EventHandler<EventArgs> AlertsTable_Btn_Close_Clicked;

        public event EventHandler<EventArgs> AlertTable_Btn_SideWinOpen_Clicked;

        private void AdditionalDesignSettings()
        {
            this.Dock = DockStyle.Fill;
        }

        private void alertsTable_Btn_Close_Click(object sender, EventArgs e)
        {
            AlertsTable_Btn_Close_Clicked(this, new EventArgs());
            //frm_TabCntrl_RibbonMenu.Dock = DockStyle.None;
            //Dashboard.frm_Table_Base.Controls.Remove(frm_TabCntrl_RibbonMenu);
            //frm_Table_Base.Controls.Remove(frm_Panel_Content);
            //frm_Table_Base.Controls.Add(frm_Panel_Content, 0, 1);
            //frm_Table_Base.SetRowSpan(frm_Panel_Content, 2);
        }

      

        private void addAlertCard_Lbl_AddAlert_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Show();
        }

        private void alertTable_Btn_SideWinOpen_Click(object sender, EventArgs e)
        {
            AlertTable_Btn_SideWinOpen_Clicked(this, new EventArgs());
        }
    }
}
