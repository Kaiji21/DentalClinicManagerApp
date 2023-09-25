
namespace Project_for_Control_2
{
    partial class Patients
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
            this.btnprint = new System.Windows.Forms.Button();
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtsearch = new System.Windows.Forms.TextBox();
            this.Dvgpatient = new System.Windows.Forms.DataGridView();
            this.Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.Dentistfullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patientidd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientfullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Allergies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Createdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edite = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbtotalpatient = new System.Windows.Forms.Label();
            this.lbtotalmpatient = new System.Windows.Forms.Label();
            this.lbtotalfpatient = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dvgpatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnprint.FlatAppearance.BorderSize = 0;
            this.btnprint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(237)))));
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.Transparent;
            this.btnprint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprint.Location = new System.Drawing.Point(680, 193);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(90, 28);
            this.btnprint.TabIndex = 38;
            this.btnprint.Text = "Print ";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Visible = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // cmbsearch
            // 
            this.cmbsearch.BackColor = System.Drawing.Color.White;
            this.cmbsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbsearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbsearch.Items.AddRange(new object[] {
            "Patient ID",
            "Patient Fullname",
            "Patient Phone",
            "Patient Adress",
            "Patient Email",
            "Patient Gender"});
            this.cmbsearch.Location = new System.Drawing.Point(399, 189);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(173, 25);
            this.cmbsearch.TabIndex = 32;
            this.cmbsearch.SelectedIndexChanged += new System.EventHandler(this.cmbsearch_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 42);
            this.label7.TabIndex = 35;
            this.label7.Text = "No results found.";
            this.label7.Visible = false;
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
            this.button1.Location = new System.Drawing.Point(862, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 39);
            this.button1.TabIndex = 34;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Search by :";
            // 
            // Txtsearch
            // 
            this.Txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtsearch.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtsearch.Location = new System.Drawing.Point(63, 191);
            this.Txtsearch.Name = "Txtsearch";
            this.Txtsearch.Size = new System.Drawing.Size(172, 17);
            this.Txtsearch.TabIndex = 30;
            this.Txtsearch.TextChanged += new System.EventHandler(this.Txtsearch_TextChanged);
            // 
            // Dvgpatient
            // 
            this.Dvgpatient.AllowUserToAddRows = false;
            this.Dvgpatient.AllowUserToDeleteRows = false;
            this.Dvgpatient.AllowUserToResizeRows = false;
            this.Dvgpatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dvgpatient.BackgroundColor = System.Drawing.Color.White;
            this.Dvgpatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dvgpatient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dvgpatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dvgpatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dvgpatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvgpatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Img,
            this.Dentistfullname,
            this.Patientidd,
            this.patientfullname,
            this.phone,
            this.email,
            this.Adress,
            this.Gender,
            this.Allergies,
            this.Createdat,
            this.Edite,
            this.delete});
            this.Dvgpatient.EnableHeadersVisualStyles = false;
            this.Dvgpatient.Location = new System.Drawing.Point(34, 237);
            this.Dvgpatient.MultiSelect = false;
            this.Dvgpatient.Name = "Dvgpatient";
            this.Dvgpatient.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dvgpatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dvgpatient.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = "           -";
            this.Dvgpatient.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dvgpatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dvgpatient.Size = new System.Drawing.Size(972, 336);
            this.Dvgpatient.TabIndex = 28;
            this.Dvgpatient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvgpatient_CellClick);
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
            // Dentistfullname
            // 
            this.Dentistfullname.DataPropertyName = "DentistFullName";
            this.Dentistfullname.HeaderText = "Dentist Full Name";
            this.Dentistfullname.Name = "Dentistfullname";
            this.Dentistfullname.ReadOnly = true;
            // 
            // Patientidd
            // 
            this.Patientidd.DataPropertyName = "PatientID";
            this.Patientidd.FillWeight = 49.4613F;
            this.Patientidd.HeaderText = "Patient ID";
            this.Patientidd.Name = "Patientidd";
            this.Patientidd.ReadOnly = true;
            // 
            // patientfullname
            // 
            this.patientfullname.DataPropertyName = "PatientFullName";
            this.patientfullname.FillWeight = 94.57463F;
            this.patientfullname.HeaderText = "Patient Full Name";
            this.patientfullname.Name = "patientfullname";
            this.patientfullname.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "Phone";
            this.phone.FillWeight = 94.57463F;
            this.phone.HeaderText = "Patient Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.FillWeight = 181.1569F;
            this.email.HeaderText = "Patient Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // Adress
            // 
            this.Adress.DataPropertyName = "Adress";
            this.Adress.FillWeight = 94.57463F;
            this.Adress.HeaderText = "Patient Adress";
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.FillWeight = 94.57463F;
            this.Gender.HeaderText = "Patient Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Allergies
            // 
            this.Allergies.DataPropertyName = "Allergies";
            this.Allergies.FillWeight = 94.57463F;
            this.Allergies.HeaderText = "Allergies";
            this.Allergies.Name = "Allergies";
            this.Allergies.ReadOnly = true;
            // 
            // Createdat
            // 
            this.Createdat.DataPropertyName = "Created at";
            this.Createdat.FillWeight = 156.3226F;
            this.Createdat.HeaderText = "Created at";
            this.Createdat.Name = "Createdat";
            this.Createdat.ReadOnly = true;
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
            // lbtotalpatient
            // 
            this.lbtotalpatient.AutoSize = true;
            this.lbtotalpatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lbtotalpatient.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalpatient.Location = new System.Drawing.Point(189, 88);
            this.lbtotalpatient.Name = "lbtotalpatient";
            this.lbtotalpatient.Size = new System.Drawing.Size(32, 23);
            this.lbtotalpatient.TabIndex = 39;
            this.lbtotalpatient.Text = "15";
            // 
            // lbtotalmpatient
            // 
            this.lbtotalmpatient.AutoSize = true;
            this.lbtotalmpatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbtotalmpatient.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalmpatient.Location = new System.Drawing.Point(527, 88);
            this.lbtotalmpatient.Name = "lbtotalmpatient";
            this.lbtotalmpatient.Size = new System.Drawing.Size(21, 23);
            this.lbtotalmpatient.TabIndex = 39;
            this.lbtotalmpatient.Text = "0";
            this.lbtotalmpatient.Click += new System.EventHandler(this.lbtotalmpatient_Click);
            // 
            // lbtotalfpatient
            // 
            this.lbtotalfpatient.AutoSize = true;
            this.lbtotalfpatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lbtotalfpatient.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalfpatient.Location = new System.Drawing.Point(863, 88);
            this.lbtotalfpatient.Name = "lbtotalfpatient";
            this.lbtotalfpatient.Size = new System.Drawing.Size(21, 23);
            this.lbtotalfpatient.TabIndex = 39;
            this.lbtotalfpatient.Text = "0";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 25.38071F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Project_for_Control_2.Properties.Resources.pixlr_bg_result__1_;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 116;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 55.83756F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Project_for_Control_2.Properties.Resources.edit_24px;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 88;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.FillWeight = 60.9137F;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Project_for_Control_2.Properties.Resources.Delete_32px;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 49;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Project_for_Control_2.Properties.Resources.Group_4;
            this.pictureBox6.Location = new System.Drawing.Point(389, 182);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(195, 39);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 36;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Project_for_Control_2.Properties.Resources.Rectangle_3;
            this.pictureBox5.Location = new System.Drawing.Point(844, 185);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(135, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Project_for_Control_2.Properties.Resources.Group_2__1_;
            this.pictureBox4.Location = new System.Drawing.Point(48, 182);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(235, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_for_Control_2.Properties.Resources.Group_3__6_;
            this.pictureBox1.Location = new System.Drawing.Point(34, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_for_Control_2.Properties.Resources.Group_3__5_;
            this.pictureBox2.Location = new System.Drawing.Point(701, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 174);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project_for_Control_2.Properties.Resources.Group_6__1_;
            this.pictureBox3.Location = new System.Drawing.Point(365, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(290, 174);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Project_for_Control_2.Properties.Resources.Rectangle_11;
            this.pictureBox7.Location = new System.Drawing.Point(655, 191);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(136, 35);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 37;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 583);
            this.Controls.Add(this.lbtotalfpatient);
            this.Controls.Add(this.lbtotalmpatient);
            this.Controls.Add(this.lbtotalpatient);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.cmbsearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txtsearch);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.Dvgpatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Patients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dvgpatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbsearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox Txtsearch;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridView Dvgpatient;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbtotalpatient;
        private System.Windows.Forms.Label lbtotalmpatient;
        private System.Windows.Forms.Label lbtotalfpatient;
        private System.Windows.Forms.DataGridViewImageColumn Img;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dentistfullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patientidd;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientfullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Allergies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Createdat;
        private System.Windows.Forms.DataGridViewImageColumn Edite;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        public System.Windows.Forms.Button btnprint;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.PictureBox pictureBox7;
    }
}