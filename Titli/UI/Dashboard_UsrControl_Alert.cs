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
using Core.Helper;
using Core.ViewModel;

namespace Titli.UI
{
    public partial class Dashboard_UsrControl_Alert : UserControl
    {
        //private ILoggingServiceHelper Log;
        private I_VM_Alert _vm_Alert;
        public enum Mode
        {
            SideWindow, Ribbon, Standalone
        }
        public Dashboard_UsrControl_Alert(ServiceContainer services, Mode mode)
        {
            //Log = services.GetInstance<ILoggingServiceHelper>();
            _vm_Alert = services.GetInstance<I_VM_Alert>();
            InitializeComponent();
            AdditionalDesignSettings(mode);
            //this.Load += Dashboard_UsrControl_Alert_ControlAdded;
            this.Load += Dashboard_UsrControl_Alert_Load;
        }

        private void Dashboard_UsrControl_Alert_Load(object sender, EventArgs e)
        {

            //Log.LogTrace("Test Logging");
            this.Width = this.Parent.Width;
            this.Font = new Font("Arial", 10f);
            frm_FlowPanel_AlertWrapper.FlowDirection = FlowDirection.LeftToRight;
            frm_FlowPanel_AlertWrapper.MaximumSize = new Size(this.Width, 10000);
            //frm_FlowPanel_AlertWrapper.AutoScroll = true;
            //frm_FlowPanel_AlertWrapper.MaximumSize = new Size(this.Width - 5, this.Height - 5);
            //this.AutoScroll = true;
            //this.AutoScrollMinSize = new Size(this.Parent.Width, this.Parent.Height);
            frm_FlowPanel_AlertWrapper.WrapContents = true;
            frm_FlowPanel_AlertWrapper.Padding = new Padding(0);
        }



        private Button alert_btn_Add;
        private Button alert_btn_Del;
        private Button alert_btn_IncreaseFont;
        private Button alert_btn_DecreaseFont;
        private Button alert_btn_IncreaseSize;
        private Button alert_btn_DecreaseSize;

        private void AdditionalDesignSettings(Mode mode)
        {
           
            switch (mode)
            {
                case Mode.SideWindow:

                    DrawAlertControlSet();
                    alert_btn_Add = new Button() { Text = "+", MaximumSize = new Size(20, 20), Margin = new Padding(0) };
                    alert_btn_Add.Click += Alert_btn_Add_Click;
                    frm_FlowPanel_AlertWrapper.Controls.Add(alert_btn_Add);

                    alert_btn_Del = new Button() { Text = "-", MaximumSize = new Size(20, 20), Margin = new Padding(0) };
                    alert_btn_Del.Click += Alert_btn_Del_Click; ;
                    frm_FlowPanel_AlertWrapper.Controls.Add(alert_btn_Del);
                    //frm_FlowPanel_AlertWrapper.SetFlowBreak(alert_btn_Add, true);
                    //frm_FlowPanel_AlertWrapper.SetFlowBreak(alert_btn_Add, true);
                    //frm_FlowPanel_AlertWrapper
                    //frm_FlowPanel_AlertWrapper.Controls.Add(alert_lbl_Name);
                    //frm_FlowPanel_AlertWrapper.Controls.Add(alert_lbl_Name);
                    break;
                case Mode.Ribbon:
                    //alert_lbl_Name = new Label() { Text = "Label:" };
                    //alert_lbl_Value = new Label();
                    break;
                case Mode.Standalone:
                    alert_btn_IncreaseFont = new Button() { Text = "+", Width = 20, FlatStyle = FlatStyle.Flat };
                    alert_btn_DecreaseFont = new Button() { Text = "-", Width = 20, FlatStyle = FlatStyle.Flat };
                    alert_btn_IncreaseSize = new Button() { Text = ">", Width = 20, FlatStyle = FlatStyle.Flat };
                    alert_btn_DecreaseSize = new Button() { Text = "<", Width = 20, FlatStyle = FlatStyle.Flat };
                    break;
                default:
                    break;
            }
           

        }

        private void Alert_btn_Del_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //private void CreateAlertControlSet()
        //{

        //    foreach (var item in  _vm_Alert.AlertValues)
        //    {
        //        //Check if GUID exists in label. if not add comtrol set (label, textbox, textbox)
        //        if (!frm_FlowPanel_AlertWrapper.Controls.Find(item.Item1, true).Any())
        //        {
        //            Label lbl = new Label() { Text = "Name:", Name = item.Item1, Anchor = AnchorStyles.Left, AutoSize = true };
        //            frm_FlowPanel_AlertWrapper.Controls.Add(lbl);
        //            //frm_FlowPanel_AlertWrapper.SetFlowBreak(lbl, true);
        //            TextBox txt = new TextBox() { Text = item.Item2, AutoSize = true };
        //            frm_FlowPanel_AlertWrapper.Controls.Add(txt);
        //            frm_FlowPanel_AlertWrapper.SetFlowBreak(txt, true);
        //            TextBox txtVal = new TextBox() { Text = item.Item3, Multiline = true, Width = frm_FlowPanel_AlertWrapper.Width - 10, Height = 40, AutoSize = true };
        //            frm_FlowPanel_AlertWrapper.Controls.Add(txtVal);
        //            frm_FlowPanel_AlertWrapper.SetFlowBreak(txtVal, true);
        //        }
        //    }
        //}


        private void DrawAlertControlSet()
        {
            int index = 0;
            foreach (var item in _vm_Alert.Alerts)
            {
                
                //Check if GUID exists in label. if not add comtrol set (label, textbox, textbox)
                if (!frm_FlowPanel_AlertWrapper.Controls.Find(item.AlertGUID, true).Any())
                {
                    Label lbl = new Label() { Text = "Label:", Name = item.AlertGUID,  Anchor = AnchorStyles.Left, AutoSize = true };

                    //frm_FlowPanel_AlertWrapper.SetFlowBreak(lbl, true);
                    TextBox txt = new TextBox() { AutoSize = true };
                    txt.DataBindings.Add(new Binding("Text", _vm_Alert.Alerts[index], "AlertLabel", false, DataSourceUpdateMode.OnPropertyChanged));

                    Label lblVal = new Label(){ AutoSize=true };
                    lblVal.DataBindings.Add(new Binding("Text", _vm_Alert.Alerts[index], "AlertValue", false, DataSourceUpdateMode.OnPropertyChanged));
                   
                    TextBox txtVal = new TextBox() {  Multiline = true, Width = frm_FlowPanel_AlertWrapper.Width - 10, Height = 40, AutoSize = true };
                    txtVal.DataBindings.Add(new Binding("Text", _vm_Alert.Alerts[index], "AlertHtml",false, DataSourceUpdateMode.OnPropertyChanged));
                    
                    frm_FlowPanel_AlertWrapper.Controls.Add(lbl);

                    frm_FlowPanel_AlertWrapper.Controls.Add(txt);
                    frm_FlowPanel_AlertWrapper.SetFlowBreak(txt, true);


                    frm_FlowPanel_AlertWrapper.Controls.Add(txtVal);
                    frm_FlowPanel_AlertWrapper.SetFlowBreak(txtVal, true);

                    frm_FlowPanel_AlertWrapper.Controls.Add(lblVal);
                    frm_FlowPanel_AlertWrapper.SetFlowBreak(lblVal, true);

                }
                index++;
            }
        }

        private void Alert_btn_Add_Click(object sender, EventArgs e)
        {
            frm_FlowPanel_AlertWrapper.Controls.Remove(alert_btn_Add);
            frm_FlowPanel_AlertWrapper.Controls.Remove(alert_btn_Del);
            //TODO: Name of alert should come from some random names generator, based on meaningful funny nouns.
            _vm_Alert.AddNewAlert();
            DrawAlertControlSet();
            frm_FlowPanel_AlertWrapper.Controls.Add(alert_btn_Add);
            frm_FlowPanel_AlertWrapper.Controls.Add(alert_btn_Del);

        }
    }

   
}

