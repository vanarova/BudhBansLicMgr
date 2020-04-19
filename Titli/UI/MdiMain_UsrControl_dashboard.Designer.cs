namespace Titli.UI
{
    partial class MdiMain_UsrControl_dashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.frm_Table_Base = new System.Windows.Forms.TableLayoutPanel();
            this.frm_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ribbonMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frm_Panel_Content = new System.Windows.Forms.Panel();
            this.frm_Table_Base.SuspendLayout();
            this.frm_MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // frm_Table_Base
            // 
            this.frm_Table_Base.BackColor = System.Drawing.SystemColors.Control;
            this.frm_Table_Base.ColumnCount = 2;
            this.frm_Table_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.frm_Table_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.frm_Table_Base.Controls.Add(this.frm_MenuStrip, 0, 0);
            this.frm_Table_Base.Controls.Add(this.frm_Panel_Content, 0, 2);
            this.frm_Table_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_Table_Base.Location = new System.Drawing.Point(0, 0);
            this.frm_Table_Base.Name = "frm_Table_Base";
            this.frm_Table_Base.RowCount = 3;
            this.frm_Table_Base.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.frm_Table_Base.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.frm_Table_Base.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.frm_Table_Base.Size = new System.Drawing.Size(1364, 726);
            this.frm_Table_Base.TabIndex = 3;
            // 
            // frm_MenuStrip
            // 
            this.frm_Table_Base.SetColumnSpan(this.frm_MenuStrip, 2);
            this.frm_MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.frm_MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.frm_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.viewToolStripMenuItem1});
            this.frm_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.frm_MenuStrip.Name = "frm_MenuStrip";
            this.frm_MenuStrip.Size = new System.Drawing.Size(1364, 28);
            this.frm_MenuStrip.TabIndex = 1;
            this.frm_MenuStrip.Text = "frm_MenuStrip";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(46, 23);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ribbonMenuToolStripMenuItem});
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(55, 23);
            this.viewToolStripMenuItem1.Text = "View";
            // 
            // ribbonMenuToolStripMenuItem
            // 
            this.ribbonMenuToolStripMenuItem.Name = "ribbonMenuToolStripMenuItem";
            this.ribbonMenuToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.ribbonMenuToolStripMenuItem.Text = "Ribbon Menu";
            this.ribbonMenuToolStripMenuItem.Click += new System.EventHandler(this.ribbonMenuToolStripMenuItem_Click);
            // 
            // frm_Panel_Content
            // 
            this.frm_Panel_Content.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.frm_Table_Base.SetColumnSpan(this.frm_Panel_Content, 2);
            this.frm_Panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_Panel_Content.Location = new System.Drawing.Point(3, 31);
            this.frm_Panel_Content.Name = "frm_Panel_Content";
            this.frm_Panel_Content.Size = new System.Drawing.Size(1358, 692);
            this.frm_Panel_Content.TabIndex = 2;
            // 
            // MdiMain_UsrControl_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.frm_Table_Base);
            this.Name = "MdiMain_UsrControl_dashboard";
            this.Size = new System.Drawing.Size(1364, 726);
            this.frm_Table_Base.ResumeLayout(false);
            this.frm_Table_Base.PerformLayout();
            this.frm_MenuStrip.ResumeLayout(false);
            this.frm_MenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel frm_Table_Base;
        private System.Windows.Forms.Panel frm_Panel_Content;
        private System.Windows.Forms.MenuStrip frm_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ribbonMenuToolStripMenuItem;
    }
}
