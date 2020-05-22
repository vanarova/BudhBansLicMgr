using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;
using LightInject;
using Core.ViewModel;

namespace Titli.UI
{
    public partial class MdiMain_UsrControl_Browser : UserControl
    {
        private I_VM_Alert _vm_Alert;
        private TextBox UrlTextBox;
        private Button BackButton;
        private Button GoButton;
        private GeckoWebBrowser geckoWebBrowser;
        private ServiceContainer _services;
        public MdiMain_UsrControl_Browser(ServiceContainer services)
        {
            _services = services;
            _vm_Alert = services.GetInstance<I_VM_Alert>();
            InitializeComponent();
            AdditionalDesignSettings();
        }

        private void AdditionalDesignSettings()
        {
            this.Dock = DockStyle.Fill;

            UrlTextBox = new TextBox() { Width = UsrCntrlBrowser_Table_wrapper.Width, Font = new Font("Arial",10f) };
            GoButton = new Button() { Text="Go", Width = 45, FlatStyle = FlatStyle.Flat, Font = new Font("Arial", 9f) } ;
            BackButton = new Button() { Text = "<", Width = 25, FlatStyle = FlatStyle.Flat };
            geckoWebBrowser = new GeckoWebBrowser { Dock = DockStyle.Fill };
            Gecko.CertOverrideService.GetService().ValidityOverride += MdiMain_UsrControl_Browser_ValidityOverride;


            UsrCntrlBrowser_Table_wrapper.Controls.Add(UrlTextBox,1,0);
            UsrCntrlBrowser_Table_wrapper.Controls.Add(GoButton,2,0);
            UsrCntrlBrowser_Table_wrapper.Controls.Add(BackButton,0,0);
            UsrCntrlBrowser_Table_wrapper.Controls.Add(geckoWebBrowser, 0, 1);
            UsrCntrlBrowser_Table_wrapper.SetColumnSpan(geckoWebBrowser, 3);
            
            GoButton.Click += GoButton_Click;
            BackButton.Click += BackButton_Click;
            UrlTextBox.KeyPress += UrlTextBox_KeyPress;
            geckoWebBrowser.DomContextMenu += GeckoWebBrowser_DomContextMenu;
            //geckoWebBrowser.DomMouseOver += GeckoWebBrowser_DomMouseOver;
            //geckoWebBrowser.DomMouseOut += GeckoWebBrowser_DomMouseOut;
        }

        private void MdiMain_UsrControl_Browser_ValidityOverride(object sender, Gecko.Events.CertOverrideEventArgs e)
        {
            e.OverrideResult = Gecko.CertOverride.Mismatch | Gecko.CertOverride.Time | Gecko.CertOverride.Untrusted;
            e.Temporary = true;
            e.Handled = true;
        }

        //private void GeckoWebBrowser_DomMouseOut(object sender, DomMouseEventArgs e)
        //{
        //   // var element = e.Target.CastToGeckoElement();
        //    GeckoHtmlElement gelement = e.Target.CastToGeckoElement() as GeckoHtmlElement;
        //    if (gelement == null) return;
        //    gelement.SetAttribute("style", "border: none");
        //}

        //private void GeckoWebBrowser_DomMouseOver(object sender, DomMouseEventArgs e)
        //{
        //    //var element = e.Target.CastToGeckoElement();
        //    GeckoHtmlElement gelement = e.Target.CastToGeckoElement() as GeckoHtmlElement;
        //    if (gelement == null) return;
        //    gelement.SetAttribute("style", "border: thin solid orange");
        //}

        private void UrlTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                geckoWebBrowser.Navigate(UrlTextBox.Text);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            geckoWebBrowser.GoBack();
            geckoWebBrowser.HistoryGoBack += GeckoWebBrowser_HistoryGoBack;
            //UrlTextBox.Text = geckoWebBrowser.url;
        }

        private void GeckoWebBrowser_HistoryGoBack(object sender, GeckoHistoryEventArgs e)
        {
            UrlTextBox.Text = e.Url.AbsoluteUri;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            geckoWebBrowser.Navigate(UrlTextBox.Text);
        }

        private void MdiMain_UsrControl_Browser_Load(object sender, EventArgs e)
        {
            //AdditionalDesignSettings();
        }

        private void markToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeckoHtmlElement obj = (GeckoHtmlElement)Browser_ContextMenu_RightClk.Tag;
            _vm_Alert = _services.GetInstance<I_VM_Alert>();
            _vm_Alert.Alerts[_vm_Alert.Alerts.Count-1].AlertValue = obj.InnerHtml;
            _vm_Alert.Alerts[_vm_Alert.Alerts.Count-1].AlertHtml = obj.OuterHtml;

            //MessageBox.Show(obj.InnerHtml);
        }

        private void GeckoWebBrowser_DomContextMenu(object sender, DomMouseEventArgs e)
        {
            if (sender == null) return;
            if (e == null) return;
            if (e.Target == null) return;

            var element = e.Target.CastToGeckoElement();

            GeckoHtmlElement clicked = element as GeckoHtmlElement;
            if (clicked == null) return;
            //MessageBox.Show(clicked.TagName);
            e.Handled = true;
            e.PreventDefault();

            clicked.SetAttribute("style", "border: medium solid blue");
            Browser_ContextMenu_RightClk.Tag = clicked;
            Browser_ContextMenu_RightClk.Show(Cursor.Position);
            //MessageBox.Show("right clicked");
        }


    }

}
