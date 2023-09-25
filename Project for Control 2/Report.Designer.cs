
namespace Project_for_Control_2
{
    partial class Report
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
            this.reportfile = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportfile
            // 
            this.reportfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportfile.Location = new System.Drawing.Point(0, 0);
            this.reportfile.Name = "reportfile";
            this.reportfile.ServerReport.BearerToken = null;
            this.reportfile.Size = new System.Drawing.Size(902, 602);
            this.reportfile.TabIndex = 0;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 602);
            this.Controls.Add(this.reportfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportfile;
    }
}