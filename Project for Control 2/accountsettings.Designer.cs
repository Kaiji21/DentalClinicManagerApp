
namespace Project_for_Control_2
{
    partial class accountsettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accountsettings));
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(823, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 123);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(237)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Transparent;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(476, 533);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(198, 51);
            this.btnsave.TabIndex = 58;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtfullname
            // 
            this.txtfullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfullname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfullname.Location = new System.Drawing.Point(119, 146);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(555, 26);
            this.txtfullname.TabIndex = 59;
            // 
            // txtlogin
            // 
            this.txtlogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.Location = new System.Drawing.Point(119, 227);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(555, 26);
            this.txtlogin.TabIndex = 60;
            // 
            // txtaddress
            // 
            this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtaddress.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(119, 302);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(555, 33);
            this.txtaddress.TabIndex = 61;
            // 
            // txtpassword
            // 
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(119, 468);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(555, 26);
            this.txtpassword.TabIndex = 62;
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.White;
            this.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtphone.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.ForeColor = System.Drawing.Color.Black;
            this.txtphone.Location = new System.Drawing.Point(119, 385);
            this.txtphone.Mask = "\\0000000000";
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(555, 26);
            this.txtphone.TabIndex = 63;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // accountsettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Project_for_Control_2.Properties.Resources.Group_20__2_;
            this.ClientSize = new System.Drawing.Size(1034, 622);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "accountsettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "accountsettings";
            this.Load += new System.EventHandler(this.accountsettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtpassword;
        public System.Windows.Forms.MaskedTextBox txtphone;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}