using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titli
{
    public partial class MdiMain : Form
    {
    
        public MdiMain()
        {
            InitializeComponent();
            AdditionalDesignSettings();
        }

        private void AdditionalDesignSettings()
        {
            this.Icon = Properties.Resources.MdiMainIcon;
            this.Controls.Add(new Titli.UI.MdiMain_UsrControl_dashboard());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frm_TabCntrl_RibbonMenu.Dock = DockStyle.None;
            //frm_Table_Base.Controls.Remove(frm_TabCntrl_RibbonMenu);
            //frm_Table_Base.Controls.Remove(frm_Panel_Content);
            //frm_Table_Base.Controls.Add(frm_Panel_Content, 0, 1);
            //frm_Table_Base.SetRowSpan(frm_Panel_Content, 2);
            
        }

      

        private void ribbonMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_Table_Base.Controls.Remove(frm_Panel_Content);
            //frm_Table_Base.Controls.Add(frm_Panel_Content, 0, 2);
            //frm_Table_Base.SetRowSpan(frm_Panel_Content, 1);
            //frm_Table_Base.Controls.Add(frm_TabCntrl_RibbonMenu, 0, 1);
            //frm_TabCntrl_RibbonMenu.Dock = DockStyle.Fill;
        }
    }
}
