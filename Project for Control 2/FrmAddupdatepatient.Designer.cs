
namespace Project_for_Control_2
{
    partial class FrmAddupdatepatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddupdatepatient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnadddpatient = new System.Windows.Forms.Button();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.txtphone = new System.Windows.Forms.MaskedTextBox();
            this.txtallergies = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Project_for_Control_2.Properties.Resources.Group_6__3_;
            this.panel1.Controls.Add(this.btnadddpatient);
            this.panel1.Controls.Add(this.cmbgender);
            this.panel1.Controls.Add(this.txtphone);
            this.panel1.Controls.Add(this.txtallergies);
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtfullname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 691);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnadddpatient
            // 
            this.btnadddpatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnadddpatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadddpatient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnadddpatient.FlatAppearance.BorderSize = 0;
            this.btnadddpatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnadddpatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(237)))));
            this.btnadddpatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadddpatient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadddpatient.ForeColor = System.Drawing.Color.Transparent;
            this.btnadddpatient.Location = new System.Drawing.Point(93, 614);
            this.btnadddpatient.Name = "btnadddpatient";
            this.btnadddpatient.Size = new System.Drawing.Size(222, 39);
            this.btnadddpatient.TabIndex = 10;
            this.btnadddpatient.Text = "Add Patient";
            this.btnadddpatient.UseVisualStyleBackColor = false;
            this.btnadddpatient.Click += new System.EventHandler(this.btnadddentist_Click);
            // 
            // cmbgender
            // 
            this.cmbgender.BackColor = System.Drawing.Color.White;
            this.cmbgender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbgender.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbgender.Location = new System.Drawing.Point(153, 465);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(138, 24);
            this.cmbgender.TabIndex = 9;
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.White;
            this.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtphone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.ForeColor = System.Drawing.Color.Gray;
            this.txtphone.Location = new System.Drawing.Point(153, 276);
            this.txtphone.Mask = "\\0000000000";
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(221, 19);
            this.txtphone.TabIndex = 8;
            this.txtphone.Enter += new System.EventHandler(this.txtphone_Enter);
            this.txtphone.Leave += new System.EventHandler(this.txtphone_Leave);
            // 
            // txtallergies
            // 
            this.txtallergies.BackColor = System.Drawing.Color.White;
            this.txtallergies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtallergies.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtallergies.ForeColor = System.Drawing.Color.Gray;
            this.txtallergies.Location = new System.Drawing.Point(153, 509);
            this.txtallergies.Multiline = true;
            this.txtallergies.Name = "txtallergies";
            this.txtallergies.Size = new System.Drawing.Size(221, 73);
            this.txtallergies.TabIndex = 7;
            this.txtallergies.Text = "Patient Allergies";
            this.txtallergies.Enter += new System.EventHandler(this.txtallergies_Enter);
            this.txtallergies.Leave += new System.EventHandler(this.txtallergies_Leave);
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.White;
            this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtaddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.ForeColor = System.Drawing.Color.Gray;
            this.txtaddress.Location = new System.Drawing.Point(153, 375);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(221, 63);
            this.txtaddress.TabIndex = 7;
            this.txtaddress.Text = "Patient Address";
            this.txtaddress.Enter += new System.EventHandler(this.txtaddress_Enter);
            this.txtaddress.Leave += new System.EventHandler(this.txtaddress_Leave);
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.White;
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.Gray;
            this.txtemail.Location = new System.Drawing.Point(153, 324);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(221, 16);
            this.txtemail.TabIndex = 7;
            this.txtemail.Text = "Patientemail@gmail.com";
            this.txtemail.Enter += new System.EventHandler(this.txtemail_Enter);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // txtfullname
            // 
            this.txtfullname.BackColor = System.Drawing.Color.White;
            this.txtfullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfullname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfullname.ForeColor = System.Drawing.Color.Gray;
            this.txtfullname.Location = new System.Drawing.Point(153, 225);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(221, 16);
            this.txtfullname.TabIndex = 7;
            this.txtfullname.Text = "Patient fullname";
            this.txtfullname.TextChanged += new System.EventHandler(this.txtfullname_TextChanged);
            this.txtfullname.Enter += new System.EventHandler(this.txtfullname_Enter);
            this.txtfullname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfullname_KeyPress);
            this.txtfullname.Leave += new System.EventHandler(this.txtfullname_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label3.Font = new System.Drawing.Font("Poppins ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.label3.Location = new System.Drawing.Point(99, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "ADD New Patient";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Project_for_Control_2.Properties.Resources.Close_64px;
            this.pictureBox7.Location = new System.Drawing.Point(383, 1);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(23, 23);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // FrmAddupdatepatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 691);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddupdatepatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddupdatepatient";
            this.Load += new System.EventHandler(this.FrmAddupdatepatient_Load);
            this.Click += new System.EventHandler(this.FrmAddupdatepatient_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.MaskedTextBox txtphone;
        public System.Windows.Forms.ComboBox cmbgender;
        public System.Windows.Forms.Button btnadddpatient;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtfullname;
        public System.Windows.Forms.TextBox txtaddress;
        public System.Windows.Forms.TextBox txtemail;
        public System.Windows.Forms.TextBox txtallergies;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}