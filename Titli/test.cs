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
    public partial class test : Form
    {
        public float fontSize = 10f;
        Button btnup;
        Button btndwn;
        Button btnf;
        Button btnb;
        public test()
        {
            InitializeComponent();
            FlowLayoutPanel pnl = new FlowLayoutPanel();
            pnl.Width = flowLayoutPanel2.Width;
            pnl.Height = 27;
            btnup = new Button() { Text = "+", Width = 20, FlatStyle = FlatStyle.Flat};
            btndwn = new Button() { Text = "-", Width = 20, FlatStyle = FlatStyle.Flat };
            btnf = new Button() { Text = ">", Width = 20, FlatStyle = FlatStyle.Flat };
            btnb = new Button() { Text = "<", Width = 20, FlatStyle = FlatStyle.Flat };
            btnup.Click += Btnup_Click;
            btndwn.Click += Btndwn_Click;
            btnf.Click += Btnf_Click;
            btnb.Click += Btnb_Click;
            pnl.Controls.Add(btnup);
            pnl.Controls.Add(btndwn);
            pnl.Controls.Add(btnb);
            pnl.Controls.Add(btnf);

            flowLayoutPanel2.Controls.Add(pnl);

        }

        private void Btnb_Click(object sender, EventArgs e)
        {
            Size s = flowLayoutPanel2.MaximumSize;
            flowLayoutPanel2.MaximumSize = new Size(s.Width-10, s.Height);
        }

        private void Btnf_Click(object sender, EventArgs e)
        {
            Size s = flowLayoutPanel2.MaximumSize;
            flowLayoutPanel2.MaximumSize = new Size(s.Width+10,s.Height);
        }

        private void Btndwn_Click(object sender, EventArgs e)
        {
            int totalHght = 0; int totalWidth = 0;
            //FlowLayoutPanel btnWrapper = btndwn.Parent as FlowLayoutPanel;
            FlowLayoutPanel container = btndwn.Parent.Parent as FlowLayoutPanel;
            foreach (var item in container.Controls)
            {
                if (item is Label)
                {
                    Label lbl = item as Label;
                    float nf = lbl.Font.Size;
                    lbl.Font = new Font("Arial", --nf);
                    lbl.Refresh();
                    totalHght = totalHght + lbl.Height;
                    totalWidth = totalWidth + lbl.Width;
                }
            }
        }
            

        private void Btnup_Click(object sender, EventArgs e)
        {
            int totalHght = 0; int totalWidth = 0;
            //FlowLayoutPanel btnWrapper = btndwn.Parent as FlowLayoutPanel;
            FlowLayoutPanel container = btndwn.Parent.Parent as FlowLayoutPanel;
            foreach (var item in container.Controls)
            {
                if (item is Label)
                {
                    Label lbl = item as Label;
                    float nf = lbl.Font.Size;
                    lbl.Font = new Font("Arial", ++nf);
                    lbl.Refresh();
                    totalHght = totalHght + lbl.Height;
                    totalWidth = totalWidth + lbl.Width;
                }
            }
           
        }

        

       

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
