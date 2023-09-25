
namespace Project_for_Control_2
{
    partial class FrmAddupdateAPPdetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddupdateAPPdetails));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbpattientfullname = new System.Windows.Forms.ComboBox();
            this.dateappointment = new System.Windows.Forms.DateTimePicker();
            this.cmbAppointmentId = new System.Windows.Forms.ComboBox();
            this.cmbTreatement = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.txtHourappointment = new System.Windows.Forms.MaskedTextBox();
            this.txttreatedtails = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnaddappdetails = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Project_for_Control_2.Properties.Resources.Group_12;
            this.pictureBox1.Location = new System.Drawing.Point(9, 521);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // cmbpattientfullname
            // 
            this.cmbpattientfullname.BackColor = System.Drawing.Color.White;
            this.cmbpattientfullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbpattientfullname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpattientfullname.FormattingEnabled = true;
            this.cmbpattientfullname.Location = new System.Drawing.Point(159, 230);
            this.cmbpattientfullname.Name = "cmbpattientfullname";
            this.cmbpattientfullname.Size = new System.Drawing.Size(217, 24);
            this.cmbpattientfullname.TabIndex = 15;
            this.cmbpattientfullname.SelectedIndexChanged += new System.EventHandler(this.cmbpattientfullname_SelectedIndexChanged);
            // 
            // dateappointment
            // 
            this.dateappointment.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateappointment.Location = new System.Drawing.Point(159, 526);
            this.dateappointment.Name = "dateappointment";
            this.dateappointment.Size = new System.Drawing.Size(220, 21);
            this.dateappointment.TabIndex = 17;
            this.dateappointment.Visible = false;
            // 
            // cmbAppointmentId
            // 
            this.cmbAppointmentId.BackColor = System.Drawing.Color.White;
            this.cmbAppointmentId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAppointmentId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAppointmentId.FormattingEnabled = true;
            this.cmbAppointmentId.Location = new System.Drawing.Point(159, 276);
            this.cmbAppointmentId.Name = "cmbAppointmentId";
            this.cmbAppointmentId.Size = new System.Drawing.Size(217, 24);
            this.cmbAppointmentId.TabIndex = 18;
            // 
            // cmbTreatement
            // 
            this.cmbTreatement.BackColor = System.Drawing.Color.White;
            this.cmbTreatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTreatement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTreatement.FormattingEnabled = true;
            this.cmbTreatement.Location = new System.Drawing.Point(159, 327);
            this.cmbTreatement.Name = "cmbTreatement";
            this.cmbTreatement.Size = new System.Drawing.Size(217, 24);
            this.cmbTreatement.TabIndex = 19;
            this.cmbTreatement.SelectedIndexChanged += new System.EventHandler(this.cmbTreatement_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.White;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboBox3.Location = new System.Drawing.Point(161, 475);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(139, 24);
            this.comboBox3.TabIndex = 20;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // txtHourappointment
            // 
            this.txtHourappointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHourappointment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourappointment.ForeColor = System.Drawing.Color.Black;
            this.txtHourappointment.Location = new System.Drawing.Point(159, 575);
            this.txtHourappointment.Mask = "00:00";
            this.txtHourappointment.Name = "txtHourappointment";
            this.txtHourappointment.Size = new System.Drawing.Size(218, 19);
            this.txtHourappointment.TabIndex = 21;
            this.txtHourappointment.ValidatingType = typeof(System.DateTime);
            this.txtHourappointment.Visible = false;
            // 
            // txttreatedtails
            // 
            this.txttreatedtails.BackColor = System.Drawing.Color.White;
            this.txttreatedtails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttreatedtails.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttreatedtails.ForeColor = System.Drawing.Color.Gray;
            this.txttreatedtails.Location = new System.Drawing.Point(158, 379);
            this.txttreatedtails.Multiline = true;
            this.txttreatedtails.Name = "txttreatedtails";
            this.txttreatedtails.Size = new System.Drawing.Size(221, 63);
            this.txttreatedtails.TabIndex = 22;
            this.txttreatedtails.Text = "Treatement Details";
            this.txttreatedtails.TextChanged += new System.EventHandler(this.txttreatedtails_TextChanged);
            this.txttreatedtails.Enter += new System.EventHandler(this.txttreatedtails_Enter);
            this.txttreatedtails.Leave += new System.EventHandler(this.txttreatedtails_Leave);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Project_for_Control_2.Properties.Resources.Close_64px;
            this.pictureBox7.Location = new System.Drawing.Point(406, 1);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(23, 23);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // btnaddappdetails
            // 
            this.btnaddappdetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnaddappdetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddappdetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnaddappdetails.FlatAppearance.BorderSize = 0;
            this.btnaddappdetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnaddappdetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(237)))));
            this.btnaddappdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddappdetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddappdetails.ForeColor = System.Drawing.Color.Transparent;
            this.btnaddappdetails.Location = new System.Drawing.Point(103, 631);
            this.btnaddappdetails.Name = "btnaddappdetails";
            this.btnaddappdetails.Size = new System.Drawing.Size(222, 39);
            this.btnaddappdetails.TabIndex = 24;
            this.btnaddappdetails.Text = "Add Appointment Details";
            this.btnaddappdetails.UseVisualStyleBackColor = false;
            this.btnaddappdetails.Click += new System.EventHandler(this.btnadddpatient_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Poppins ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 42);
            this.label3.TabIndex = 25;
            this.label3.Text = "ADD New Appointment Details";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FrmAddupdateAPPdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Project_for_Control_2.Properties.Resources.Group_11__3_;
            this.ClientSize = new System.Drawing.Size(431, 691);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnaddappdetails);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.txttreatedtails);
            this.Controls.Add(this.txtHourappointment);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cmbTreatement);
            this.Controls.Add(this.cmbAppointmentId);
            this.Controls.Add(this.dateappointment);
            this.Controls.Add(this.cmbpattientfullname);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddupdateAPPdetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddupdateAPPdetails";
            this.Load += new System.EventHandler(this.FrmAddupdateAPPdetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox cmbpattientfullname;
        public System.Windows.Forms.DateTimePicker dateappointment;
        public System.Windows.Forms.ComboBox cmbAppointmentId;
        public System.Windows.Forms.ComboBox cmbTreatement;
        public System.Windows.Forms.ComboBox comboBox3;
        public System.Windows.Forms.MaskedTextBox txtHourappointment;
        public System.Windows.Forms.TextBox txttreatedtails;
        private System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.Button btnaddappdetails;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label3;
    }
}