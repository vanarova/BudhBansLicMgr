namespace Titli.UI
{
    partial class MdiMain_UsrControl_Browser
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
            this.components = new System.ComponentModel.Container();
            this.UsrCntrlBrowser_Table_wrapper = new System.Windows.Forms.TableLayoutPanel();
            this.Browser_ContextMenu_RightClk = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.markToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Browser_ContextMenu_RightClk.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsrCntrlBrowser_Table_wrapper
            // 
            this.UsrCntrlBrowser_Table_wrapper.AutoSize = true;
            this.UsrCntrlBrowser_Table_wrapper.ColumnCount = 3;
            this.UsrCntrlBrowser_Table_wrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.UsrCntrlBrowser_Table_wrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.UsrCntrlBrowser_Table_wrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.UsrCntrlBrowser_Table_wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsrCntrlBrowser_Table_wrapper.Location = new System.Drawing.Point(0, 0);
            this.UsrCntrlBrowser_Table_wrapper.Name = "UsrCntrlBrowser_Table_wrapper";
            this.UsrCntrlBrowser_Table_wrapper.RowCount = 2;
            this.UsrCntrlBrowser_Table_wrapper.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.UsrCntrlBrowser_Table_wrapper.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.UsrCntrlBrowser_Table_wrapper.Size = new System.Drawing.Size(762, 556);
            this.UsrCntrlBrowser_Table_wrapper.TabIndex = 0;
            // 
            // Browser_ContextMenu_RightClk
            // 
            this.Browser_ContextMenu_RightClk.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Browser_ContextMenu_RightClk.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markToolStripMenuItem});
            this.Browser_ContextMenu_RightClk.Name = "Browser_ContextMenu_RightClk";
            this.Browser_ContextMenu_RightClk.Size = new System.Drawing.Size(211, 56);
            // 
            // markToolStripMenuItem
            // 
            this.markToolStripMenuItem.Name = "markToolStripMenuItem";
            this.markToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.markToolStripMenuItem.Text = "Mark";
            this.markToolStripMenuItem.Click += new System.EventHandler(this.markToolStripMenuItem_Click);
            // 
            // MdiMain_UsrControl_Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.UsrCntrlBrowser_Table_wrapper);
            this.Name = "MdiMain_UsrControl_Browser";
            this.Size = new System.Drawing.Size(762, 556);
            this.Load += new System.EventHandler(this.MdiMain_UsrControl_Browser_Load);
            this.Browser_ContextMenu_RightClk.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel UsrCntrlBrowser_Table_wrapper;
        private System.Windows.Forms.ContextMenuStrip Browser_ContextMenu_RightClk;
        private System.Windows.Forms.ToolStripMenuItem markToolStripMenuItem;
    }
}
