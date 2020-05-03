namespace Titli.UI
{
    partial class Dashboard_UsrControl_Alert
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
            this.frm_FlowPanel_AlertWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // frm_FlowPanel_AlertWrapper
            // 
            this.frm_FlowPanel_AlertWrapper.AutoSize = true;
            this.frm_FlowPanel_AlertWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.frm_FlowPanel_AlertWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_FlowPanel_AlertWrapper.Location = new System.Drawing.Point(0, 0);
            this.frm_FlowPanel_AlertWrapper.Name = "frm_FlowPanel_AlertWrapper";
            this.frm_FlowPanel_AlertWrapper.Size = new System.Drawing.Size(234, 126);
            this.frm_FlowPanel_AlertWrapper.TabIndex = 0;
            // 
            // Dashboard_UsrControl_Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.frm_FlowPanel_AlertWrapper);
            this.Name = "Dashboard_UsrControl_Alert";
            this.Size = new System.Drawing.Size(234, 126);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel frm_FlowPanel_AlertWrapper;
    }
}
