
namespace Project_for_Control_2
{
    partial class FrmAppointmentsDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbfullname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbstillhave = new System.Windows.Forms.Label();
            this.Dvgappointmentdetails = new System.Windows.Forms.DataGridView();
            this.Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.AppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dentistfullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientfullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TreatmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Treatmentdetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatementname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edite = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dvgappointmentdetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(272, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcom Back";
            // 
            // lbfullname
            // 
            this.lbfullname.AutoSize = true;
            this.lbfullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lbfullname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(114)))));
            this.lbfullname.Location = new System.Drawing.Point(427, 70);
            this.lbfullname.Name = "lbfullname";
            this.lbfullname.Size = new System.Drawing.Size(152, 25);
            this.lbfullname.TabIndex = 1;
            this.lbfullname.Text = "Welcom Back";
            this.lbfullname.Click += new System.EventHandler(this.lbfullname_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(275, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 72);
            this.label2.TabIndex = 1;
            this.label2.Text = "You still have 5   appointment details To fill all the appointment details .";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbstillhave
            // 
            this.lbstillhave.AutoSize = true;
            this.lbstillhave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lbstillhave.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstillhave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(114)))));
            this.lbstillhave.Location = new System.Drawing.Point(364, 107);
            this.lbstillhave.Name = "lbstillhave";
            this.lbstillhave.Size = new System.Drawing.Size(14, 23);
            this.lbstillhave.TabIndex = 2;
            this.lbstillhave.Text = "1";
            // 
            // Dvgappointmentdetails
            // 
            this.Dvgappointmentdetails.AllowUserToAddRows = false;
            this.Dvgappointmentdetails.AllowUserToDeleteRows = false;
            this.Dvgappointmentdetails.AllowUserToResizeRows = false;
            this.Dvgappointmentdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dvgappointmentdetails.BackgroundColor = System.Drawing.Color.White;
            this.Dvgappointmentdetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dvgappointmentdetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dvgappointmentdetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dvgappointmentdetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dvgappointmentdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvgappointmentdetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Img,
            this.AppointmentID,
            this.Dentistfullname,
            this.patientfullname,
            this.TreatmentID,
            this.Treatmentdetails,
            this.treatementname,
            this.Edite,
            this.delete});
            this.Dvgappointmentdetails.EnableHeadersVisualStyles = false;
            this.Dvgappointmentdetails.Location = new System.Drawing.Point(34, 282);
            this.Dvgappointmentdetails.MultiSelect = false;
            this.Dvgappointmentdetails.Name = "Dvgappointmentdetails";
            this.Dvgappointmentdetails.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dvgappointmentdetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dvgappointmentdetails.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = "           -";
            this.Dvgappointmentdetails.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dvgappointmentdetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dvgappointmentdetails.Size = new System.Drawing.Size(972, 272);
            this.Dvgappointmentdetails.TabIndex = 29;
            this.Dvgappointmentdetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvgappointmentdetails_CellClick);
            // 
            // Img
            // 
            this.Img.FillWeight = 29.62241F;
            this.Img.HeaderText = "";
            this.Img.Image = global::Project_for_Control_2.Properties.Resources.male_boy_person_people_avatar_icon_159358;
            this.Img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Img.Name = "Img";
            this.Img.ReadOnly = true;
            // 
            // AppointmentID
            // 
            this.AppointmentID.DataPropertyName = "AppointmentID";
            this.AppointmentID.FillWeight = 94.57463F;
            this.AppointmentID.HeaderText = "Appointment ID";
            this.AppointmentID.Name = "AppointmentID";
            this.AppointmentID.ReadOnly = true;
            // 
            // Dentistfullname
            // 
            this.Dentistfullname.DataPropertyName = "DentistFullName";
            this.Dentistfullname.HeaderText = "Dentist Full Name";
            this.Dentistfullname.Name = "Dentistfullname";
            this.Dentistfullname.ReadOnly = true;
            // 
            // patientfullname
            // 
            this.patientfullname.DataPropertyName = "PatientFullName";
            this.patientfullname.FillWeight = 94.57463F;
            this.patientfullname.HeaderText = "Patient Full Name";
            this.patientfullname.Name = "patientfullname";
            this.patientfullname.ReadOnly = true;
            // 
            // TreatmentID
            // 
            this.TreatmentID.DataPropertyName = "TreatmentID";
            this.TreatmentID.HeaderText = "TreatmentID";
            this.TreatmentID.Name = "TreatmentID";
            this.TreatmentID.ReadOnly = true;
            this.TreatmentID.Visible = false;
            // 
            // Treatmentdetails
            // 
            this.Treatmentdetails.DataPropertyName = "TreatmentDetails";
            this.Treatmentdetails.HeaderText = "Treatment Details";
            this.Treatmentdetails.Name = "Treatmentdetails";
            this.Treatmentdetails.ReadOnly = true;
            // 
            // treatementname
            // 
            this.treatementname.DataPropertyName = "TreatmentName";
            this.treatementname.HeaderText = "Treatment Name";
            this.treatementname.Name = "treatementname";
            this.treatementname.ReadOnly = true;
            // 
            // Edite
            // 
            this.Edite.FillWeight = 56.14674F;
            this.Edite.HeaderText = "";
            this.Edite.Image = global::Project_for_Control_2.Properties.Resources.edit_24px1;
            this.Edite.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edite.Name = "Edite";
            this.Edite.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.FillWeight = 28.80444F;
            this.delete.HeaderText = "";
            this.delete.Image = global::Project_for_Control_2.Properties.Resources.Delete_32px;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(237)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(59, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 39);
            this.button1.TabIndex = 38;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(237)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(864, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 39);
            this.button2.TabIndex = 40;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 29.62241F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Project_for_Control_2.Properties.Resources.male_boy_person_people_avatar_icon_159358;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 27;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 56.14674F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Project_for_Control_2.Properties.Resources.edit_24px1;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 51;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.FillWeight = 28.80444F;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Project_for_Control_2.Properties.Resources.Delete_32px;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 26;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project_for_Control_2.Properties.Resources.Rectangle_3;
            this.pictureBox3.Location = new System.Drawing.Point(846, 226);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(135, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Project_for_Control_2.Properties.Resources.Rectangle_3;
            this.pictureBox5.Location = new System.Drawing.Point(41, 226);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(135, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_for_Control_2.Properties.Resources.Group_11__2_;
            this.pictureBox2.Location = new System.Drawing.Point(723, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_for_Control_2.Properties.Resources.Group_1;
            this.pictureBox1.Location = new System.Drawing.Point(7, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(761, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 83);
            this.label3.TabIndex = 41;
            this.label3.Text = "label3";
            // 
            // FrmAppointmentsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 583);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Dvgappointmentdetails);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbstillhave);
            this.Controls.Add(this.lbfullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAppointmentsDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAppointmentsDetails";
            this.Load += new System.EventHandler(this.FrmAppointmentsDetails_Load);
            this.Click += new System.EventHandler(this.FrmAppointmentsDetails_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Dvgappointmentdetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbfullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbstillhave;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView Dvgappointmentdetails;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn Img;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dentistfullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientfullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn TreatmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Treatmentdetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatementname;
        private System.Windows.Forms.DataGridViewImageColumn Edite;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Label label3;
    }
}