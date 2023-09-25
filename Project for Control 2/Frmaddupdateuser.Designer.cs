
namespace Project_for_Control_2
{
    partial class Frmaddupdateuser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmaddupdateuser));
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtphone = new System.Windows.Forms.MaskedTextBox();
            this.btnaddduser = new System.Windows.Forms.Button();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.dateobuser = new System.Windows.Forms.DateTimePicker();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Project_for_Control_2.Properties.Resources.Close_64px;
            this.pictureBox7.Location = new System.Drawing.Point(384, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(23, 23);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.White;
            this.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtphone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.ForeColor = System.Drawing.Color.Gray;
            this.txtphone.Location = new System.Drawing.Point(154, 322);
            this.txtphone.Mask = "\\0000000000";
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(219, 19);
            this.txtphone.TabIndex = 9;
            this.txtphone.Enter += new System.EventHandler(this.txtphone_Enter);
            this.txtphone.Leave += new System.EventHandler(this.txtphone_Leave);
            // 
            // btnaddduser
            // 
            this.btnaddduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnaddduser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddduser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnaddduser.FlatAppearance.BorderSize = 0;
            this.btnaddduser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnaddduser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(237)))));
            this.btnaddduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddduser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddduser.ForeColor = System.Drawing.Color.Transparent;
            this.btnaddduser.Location = new System.Drawing.Point(92, 614);
            this.btnaddduser.Name = "btnaddduser";
            this.btnaddduser.Size = new System.Drawing.Size(222, 39);
            this.btnaddduser.TabIndex = 11;
            this.btnaddduser.Text = "Add User";
            this.btnaddduser.UseVisualStyleBackColor = false;
            this.btnaddduser.Click += new System.EventHandler(this.btnaddduser_Click);
            // 
            // txtfullname
            // 
            this.txtfullname.BackColor = System.Drawing.Color.White;
            this.txtfullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfullname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfullname.ForeColor = System.Drawing.Color.Gray;
            this.txtfullname.Location = new System.Drawing.Point(154, 226);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(221, 16);
            this.txtfullname.TabIndex = 12;
            this.txtfullname.Text = "User fullname";
            this.txtfullname.Enter += new System.EventHandler(this.txtfullname_Enter);
            this.txtfullname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfullname_KeyPress);
            this.txtfullname.Leave += new System.EventHandler(this.txtfullname_Leave);
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.White;
            this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtaddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.ForeColor = System.Drawing.Color.Gray;
            this.txtaddress.Location = new System.Drawing.Point(154, 373);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(221, 63);
            this.txtaddress.TabIndex = 13;
            this.txtaddress.Text = "User Address";
            this.txtaddress.Enter += new System.EventHandler(this.txtaddress_Enter);
            this.txtaddress.Leave += new System.EventHandler(this.txtaddress_Leave);
            // 
            // cmbrole
            // 
            this.cmbrole.BackColor = System.Drawing.Color.White;
            this.cmbrole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbrole.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Items.AddRange(new object[] {
            "Admin",
            "Dentist",
            "Modérateur"});
            this.cmbrole.Location = new System.Drawing.Point(155, 462);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(138, 24);
            this.cmbrole.TabIndex = 14;
            // 
            // txtlogin
            // 
            this.txtlogin.BackColor = System.Drawing.Color.White;
            this.txtlogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.ForeColor = System.Drawing.Color.Gray;
            this.txtlogin.Location = new System.Drawing.Point(154, 276);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(221, 16);
            this.txtlogin.TabIndex = 15;
            this.txtlogin.Text = "User Login";
            this.txtlogin.Enter += new System.EventHandler(this.txtlogin_Enter);
            this.txtlogin.Leave += new System.EventHandler(this.txtlogin_Leave);
            // 
            // dateobuser
            // 
            this.dateobuser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateobuser.Location = new System.Drawing.Point(153, 509);
            this.dateobuser.Name = "dateobuser";
            this.dateobuser.Size = new System.Drawing.Size(220, 21);
            this.dateobuser.TabIndex = 16;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.White;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.Gray;
            this.txtpassword.Location = new System.Drawing.Point(155, 563);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(221, 16);
            this.txtpassword.TabIndex = 17;
            this.txtpassword.Text = "User Password";
            this.txtpassword.Enter += new System.EventHandler(this.txtemail_Enter);
            this.txtpassword.Leave += new System.EventHandler(this.txtpassword_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Font = new System.Drawing.Font("Poppins ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.label3.Location = new System.Drawing.Point(117, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 42);
            this.label3.TabIndex = 18;
            this.label3.Text = "ADD New User";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // Frmaddupdateuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Project_for_Control_2.Properties.Resources.Group_10__2_;
            this.ClientSize = new System.Drawing.Size(413, 691);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.dateobuser);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.cmbrole);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.btnaddduser);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.pictureBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmaddupdateuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmaddupdateuser";
            this.Load += new System.EventHandler(this.Frmaddupdateuser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.MaskedTextBox txtphone;
        public System.Windows.Forms.Button btnaddduser;
        public System.Windows.Forms.TextBox txtfullname;
        public System.Windows.Forms.TextBox txtaddress;
        public System.Windows.Forms.ComboBox cmbrole;
        public System.Windows.Forms.TextBox txtlogin;
        public System.Windows.Forms.DateTimePicker dateobuser;
        public System.Windows.Forms.TextBox txtpassword;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}