
namespace Project_for_Control_2
{
    partial class FrmAddupdatedentist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddupdatedentist));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.paneladddentist = new System.Windows.Forms.Panel();
            this.Dentistimg = new Project_for_Control_2.Circlepicturebox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnadddentist = new System.Windows.Forms.Button();
            this.datetimepickerDSW = new System.Windows.Forms.DateTimePicker();
            this.datatimeDOB = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.MaskedTextBox();
            this.txtadress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.paneladddentist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dentistimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // paneladddentist
            // 
            this.paneladddentist.BackgroundImage = global::Project_for_Control_2.Properties.Resources.Group_5__4_;
            this.paneladddentist.Controls.Add(this.Dentistimg);
            this.paneladddentist.Controls.Add(this.pictureBox8);
            this.paneladddentist.Controls.Add(this.btnadddentist);
            this.paneladddentist.Controls.Add(this.datetimepickerDSW);
            this.paneladddentist.Controls.Add(this.datatimeDOB);
            this.paneladddentist.Controls.Add(this.label3);
            this.paneladddentist.Controls.Add(this.txtphone);
            this.paneladddentist.Controls.Add(this.txtadress);
            this.paneladddentist.Controls.Add(this.txtemail);
            this.paneladddentist.Controls.Add(this.txtfullname);
            this.paneladddentist.Controls.Add(this.pictureBox7);
            this.paneladddentist.Controls.Add(this.cmbgender);
            this.paneladddentist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneladddentist.Location = new System.Drawing.Point(0, 0);
            this.paneladddentist.Name = "paneladddentist";
            this.paneladddentist.Size = new System.Drawing.Size(383, 561);
            this.paneladddentist.TabIndex = 19;
            this.paneladddentist.Click += new System.EventHandler(this.paneladddentist_Click);
            this.paneladddentist.Paint += new System.Windows.Forms.PaintEventHandler(this.paneladddentist_Paint);
            this.paneladddentist.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paneladddentist_MouseMove);
            // 
            // Dentistimg
            // 
            this.Dentistimg.BackColor = System.Drawing.Color.Transparent;
            this.Dentistimg.Image = global::Project_for_Control_2.Properties.Resources.Ellipse_1;
            this.Dentistimg.Location = new System.Drawing.Point(127, 55);
            this.Dentistimg.Name = "Dentistimg";
            this.Dentistimg.Size = new System.Drawing.Size(128, 125);
            this.Dentistimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dentistimg.TabIndex = 10;
            this.Dentistimg.TabStop = false;
            this.Dentistimg.Click += new System.EventHandler(this.Dentistimg_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = global::Project_for_Control_2.Properties.Resources.add_button;
            this.pictureBox8.Location = new System.Drawing.Point(233, 157);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(22, 22);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // btnadddentist
            // 
            this.btnadddentist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnadddentist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadddentist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnadddentist.FlatAppearance.BorderSize = 0;
            this.btnadddentist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnadddentist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(237)))));
            this.btnadddentist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadddentist.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadddentist.ForeColor = System.Drawing.Color.Transparent;
            this.btnadddentist.Location = new System.Drawing.Point(79, 500);
            this.btnadddentist.Name = "btnadddentist";
            this.btnadddentist.Size = new System.Drawing.Size(222, 39);
            this.btnadddentist.TabIndex = 8;
            this.btnadddentist.Text = "Add Dentist";
            this.btnadddentist.UseVisualStyleBackColor = false;
            this.btnadddentist.Click += new System.EventHandler(this.btnadddentist_Click);
            // 
            // datetimepickerDSW
            // 
            this.datetimepickerDSW.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.datetimepickerDSW.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.datetimepickerDSW.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.datetimepickerDSW.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimepickerDSW.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimepickerDSW.Location = new System.Drawing.Point(154, 446);
            this.datetimepickerDSW.Name = "datetimepickerDSW";
            this.datetimepickerDSW.Size = new System.Drawing.Size(101, 21);
            this.datetimepickerDSW.TabIndex = 7;
            // 
            // datatimeDOB
            // 
            this.datatimeDOB.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.datatimeDOB.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.datatimeDOB.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.datatimeDOB.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datatimeDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datatimeDOB.Location = new System.Drawing.Point(23, 399);
            this.datatimeDOB.Name = "datatimeDOB";
            this.datatimeDOB.Size = new System.Drawing.Size(101, 21);
            this.datatimeDOB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label3.Font = new System.Drawing.Font("Poppins ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.label3.Location = new System.Drawing.Point(85, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "ADD New Dentist ";
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtphone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.ForeColor = System.Drawing.Color.Gray;
            this.txtphone.Location = new System.Drawing.Point(219, 238);
            this.txtphone.Mask = "\\0000000000";
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(139, 15);
            this.txtphone.TabIndex = 4;
            this.txtphone.Enter += new System.EventHandler(this.txtphone_Enter);
            this.txtphone.Leave += new System.EventHandler(this.txtphone_Leave);
            // 
            // txtadress
            // 
            this.txtadress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtadress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtadress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadress.ForeColor = System.Drawing.Color.Gray;
            this.txtadress.Location = new System.Drawing.Point(219, 304);
            this.txtadress.Multiline = true;
            this.txtadress.Name = "txtadress";
            this.txtadress.Size = new System.Drawing.Size(148, 36);
            this.txtadress.TabIndex = 3;
            this.txtadress.Text = "Dentiste Adresse Av Hay nahda Guelmim";
            this.txtadress.Enter += new System.EventHandler(this.txtadress_Enter);
            this.txtadress.Leave += new System.EventHandler(this.txtadress_Leave);
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.Gray;
            this.txtemail.Location = new System.Drawing.Point(23, 324);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(148, 15);
            this.txtemail.TabIndex = 3;
            this.txtemail.Text = "DentistEmail@gmail.com";
            this.txtemail.Enter += new System.EventHandler(this.txtemail_Enter);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // txtfullname
            // 
            this.txtfullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtfullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfullname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfullname.ForeColor = System.Drawing.Color.Gray;
            this.txtfullname.Location = new System.Drawing.Point(23, 238);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(148, 15);
            this.txtfullname.TabIndex = 3;
            this.txtfullname.Text = "Dentist Full Name";
            this.txtfullname.TextChanged += new System.EventHandler(this.txtfullname_TextChanged);
            this.txtfullname.Enter += new System.EventHandler(this.txtfullname_Enter);
            this.txtfullname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfullname_KeyPress);
            this.txtfullname.Leave += new System.EventHandler(this.txtfullname_Leave);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Project_for_Control_2.Properties.Resources.Close_64px;
            this.pictureBox7.Location = new System.Drawing.Point(354, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(23, 23);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
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
            this.cmbgender.Location = new System.Drawing.Point(221, 402);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(138, 24);
            this.cmbgender.TabIndex = 1;
            // 
            // FrmAddupdatedentist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 561);
            this.Controls.Add(this.paneladddentist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddupdatedentist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddupdatedentist";
            this.Load += new System.EventHandler(this.FrmAddupdatedentist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.paneladddentist.ResumeLayout(false);
            this.paneladddentist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dentistimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnadddentist;
        public System.Windows.Forms.DateTimePicker datetimepickerDSW;
        public System.Windows.Forms.DateTimePicker datatimeDOB;
        public System.Windows.Forms.MaskedTextBox txtphone;
        public System.Windows.Forms.TextBox txtadress;
        public System.Windows.Forms.TextBox txtemail;
        public System.Windows.Forms.TextBox txtfullname;
        public System.Windows.Forms.ComboBox cmbgender;
        public Circlepicturebox Dentistimg;
        public System.Windows.Forms.Panel paneladddentist;
    }
}