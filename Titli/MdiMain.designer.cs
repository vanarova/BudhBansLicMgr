namespace Titli
{
    partial class MdiMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frm_StatusStrip = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // frm_StatusStrip
            // 
            this.frm_StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.frm_StatusStrip.Location = new System.Drawing.Point(0, 662);
            this.frm_StatusStrip.Name = "frm_StatusStrip";
            this.frm_StatusStrip.Size = new System.Drawing.Size(1283, 22);
            this.frm_StatusStrip.TabIndex = 0;
            this.frm_StatusStrip.Text = "frm_StatusStrip";
            // 
            // MdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1283, 684);
            this.Controls.Add(this.frm_StatusStrip);
            this.IsMdiContainer = true;
            this.Name = "MdiMain";
            this.Text = "Titli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.StatusStrip frm_StatusStrip;
    }
}

