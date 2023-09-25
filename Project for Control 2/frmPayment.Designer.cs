
namespace Project_for_Control_2
{
    partial class frmPayment
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
            this.lbtotalapppayer = new System.Windows.Forms.Label();
            this.lbtotalappnonpayer = new System.Windows.Forms.Label();
            this.lbtotaltodaypayement = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnadduser = new System.Windows.Forms.Button();
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtsearch = new System.Windows.Forms.TextBox();
            this.Dvgpayement = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.PAyementID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dentistfullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayementMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edite = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.print = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dvgpayement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtotalapppayer
            // 
            this.lbtotalapppayer.AutoSize = true;
            this.lbtotalapppayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.lbtotalapppayer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalapppayer.Location = new System.Drawing.Point(186, 81);
            this.lbtotalapppayer.Name = "lbtotalapppayer";
            this.lbtotalapppayer.Size = new System.Drawing.Size(49, 16);
            this.lbtotalapppayer.TabIndex = 0;
            this.lbtotalapppayer.Text = "label1";
            this.lbtotalapppayer.Click += new System.EventHandler(this.lbtotalapppayer_Click);
            // 
            // lbtotalappnonpayer
            // 
            this.lbtotalappnonpayer.AutoSize = true;
            this.lbtotalappnonpayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.lbtotalappnonpayer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalappnonpayer.Location = new System.Drawing.Point(544, 81);
            this.lbtotalappnonpayer.Name = "lbtotalappnonpayer";
            this.lbtotalappnonpayer.Size = new System.Drawing.Size(49, 16);
            this.lbtotalappnonpayer.TabIndex = 1;
            this.lbtotalappnonpayer.Text = "label2";
            this.lbtotalappnonpayer.Click += new System.EventHandler(this.lbtotalappnonpayer_Click);
            // 
            // lbtotaltodaypayement
            // 
            this.lbtotaltodaypayement.AutoSize = true;
            this.lbtotaltodaypayement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.lbtotaltodaypayement.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotaltodaypayement.Location = new System.Drawing.Point(911, 81);
            this.lbtotaltodaypayement.Name = "lbtotaltodaypayement";
            this.lbtotaltodaypayement.Size = new System.Drawing.Size(15, 16);
            this.lbtotaltodaypayement.TabIndex = 2;
            this.lbtotaltodaypayement.Text = "0";
            this.lbtotaltodaypayement.Click += new System.EventHandler(this.lbtotaltodaypayement_Click);
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
            this.btnprint.Location = new System.Drawing.Point(685, 182);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(102, 39);
            this.btnprint.TabIndex = 59;
            this.btnprint.Text = "Print ";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnadduser
            // 
            this.btnadduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnadduser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadduser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnadduser.FlatAppearance.BorderSize = 0;
            this.btnadduser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnadduser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(237)))));
            this.btnadduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadduser.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadduser.ForeColor = System.Drawing.Color.Transparent;
            this.btnadduser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadduser.Location = new System.Drawing.Point(846, 182);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(102, 39);
            this.btnadduser.TabIndex = 57;
            this.btnadduser.Text = "Add";
            this.btnadduser.UseVisualStyleBackColor = false;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // cmbsearch
            // 
            this.cmbsearch.BackColor = System.Drawing.Color.White;
            this.cmbsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbsearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbsearch.Items.AddRange(new object[] {
            "Payement ID",
            "Appointment ID",
            "Patient FullName",
            "Dentist FullName",
            "Payement Method",
            "Payement Date"});
            this.cmbsearch.Location = new System.Drawing.Point(399, 189);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(173, 25);
            this.cmbsearch.TabIndex = 54;
            this.cmbsearch.SelectedIndexChanged += new System.EventHandler(this.cmbsearch_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 53;
            this.label6.Text = "Search by :";
            // 
            // Txtsearch
            // 
            this.Txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtsearch.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtsearch.Location = new System.Drawing.Point(63, 191);
            this.Txtsearch.Name = "Txtsearch";
            this.Txtsearch.Size = new System.Drawing.Size(172, 17);
            this.Txtsearch.TabIndex = 52;
            this.Txtsearch.TextChanged += new System.EventHandler(this.Txtsearch_TextChanged);
            // 
            // Dvgpayement
            // 
            this.Dvgpayement.AllowUserToAddRows = false;
            this.Dvgpayement.AllowUserToDeleteRows = false;
            this.Dvgpayement.AllowUserToResizeRows = false;
            this.Dvgpayement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dvgpayement.BackgroundColor = System.Drawing.Color.White;
            this.Dvgpayement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dvgpayement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dvgpayement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dvgpayement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dvgpayement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvgpayement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Img,
            this.PAyementID,
            this.AppointmentID,
            this.PatientFullName,
            this.Dentistfullname,
            this.PayementMethod,
            this.TotalPrice,
            this.PayementDate,
            this.Edite,
            this.delete,
            this.print});
            this.Dvgpayement.EnableHeadersVisualStyles = false;
            this.Dvgpayement.Location = new System.Drawing.Point(34, 237);
            this.Dvgpayement.MultiSelect = false;
            this.Dvgpayement.Name = "Dvgpayement";
            this.Dvgpayement.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dvgpayement.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dvgpayement.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = "           -";
            this.Dvgpayement.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dvgpayement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dvgpayement.Size = new System.Drawing.Size(972, 336);
            this.Dvgpayement.TabIndex = 50;
            this.Dvgpayement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvgpayement_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(432, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 42);
            this.label7.TabIndex = 63;
            this.label7.Text = "No results found.";
            this.label7.Visible = false;
            // 
            // PAyementID
            // 
            this.PAyementID.DataPropertyName = "PAyementID";
            this.PAyementID.FillWeight = 90.22582F;
            this.PAyementID.HeaderText = "PayementID";
            this.PAyementID.Name = "PAyementID";
            this.PAyementID.ReadOnly = true;
            // 
            // AppointmentID
            // 
            this.AppointmentID.DataPropertyName = "AppointmentID";
            this.AppointmentID.FillWeight = 114.5439F;
            this.AppointmentID.HeaderText = "Appointment ID";
            this.AppointmentID.Name = "AppointmentID";
            this.AppointmentID.ReadOnly = true;
            // 
            // PatientFullName
            // 
            this.PatientFullName.DataPropertyName = "PatientFullName";
            this.PatientFullName.FillWeight = 85.33074F;
            this.PatientFullName.HeaderText = "Patient FullName";
            this.PatientFullName.Name = "PatientFullName";
            this.PatientFullName.ReadOnly = true;
            // 
            // Dentistfullname
            // 
            this.Dentistfullname.DataPropertyName = "DentistFullName";
            this.Dentistfullname.FillWeight = 85.33074F;
            this.Dentistfullname.HeaderText = "Dentist Full Name";
            this.Dentistfullname.MaxInputLength = 3276;
            this.Dentistfullname.Name = "Dentistfullname";
            this.Dentistfullname.ReadOnly = true;
            // 
            // PayementMethod
            // 
            this.PayementMethod.DataPropertyName = "PaymentMethod";
            this.PayementMethod.FillWeight = 163.4503F;
            this.PayementMethod.HeaderText = "Payement Method";
            this.PayementMethod.Name = "PayementMethod";
            this.PayementMethod.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "Total_Price";
            this.TotalPrice.FillWeight = 85.33074F;
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // PayementDate
            // 
            this.PayementDate.DataPropertyName = "payment_Date";
            this.PayementDate.FillWeight = 175.0187F;
            this.PayementDate.HeaderText = "Payement Date";
            this.PayementDate.Name = "PayementDate";
            this.PayementDate.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 25.19522F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Project_for_Control_2.Properties.Resources.User_free_vector_icons_designed_by_bqlqn;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 29;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 47.75538F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Project_for_Control_2.Properties.Resources.edit_24px1;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 55;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.FillWeight = 24.4995F;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Project_for_Control_2.Properties.Resources.Delete_32px;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 28;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.FillWeight = 48.2677F;
            this.dataGridViewImageColumn4.HeaderText = "";
            this.dataGridViewImageColumn4.Image = global::Project_for_Control_2.Properties.Resources.print_48px;
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.Width = 49;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project_for_Control_2.Properties.Resources.Group_19;
            this.pictureBox3.Location = new System.Drawing.Point(716, -31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(290, 204);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 62;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_for_Control_2.Properties.Resources.Group_131;
            this.pictureBox2.Location = new System.Drawing.Point(359, -8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_for_Control_2.Properties.Resources.Group_12__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Project_for_Control_2.Properties.Resources.Rectangle_3;
            this.pictureBox7.Location = new System.Drawing.Point(667, 176);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(135, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 58;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Project_for_Control_2.Properties.Resources.Rectangle_3;
            this.pictureBox5.Location = new System.Drawing.Point(828, 176);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(135, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 56;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Project_for_Control_2.Properties.Resources.Group_4;
            this.pictureBox6.Location = new System.Drawing.Point(389, 182);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(195, 39);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 55;
            this.pictureBox6.TabStop = false;
            // 
            // Img
            // 
            this.Img.FillWeight = 26.72707F;
            this.Img.HeaderText = "";
            this.Img.Image = global::Project_for_Control_2.Properties.Resources.billing_icon_7;
            this.Img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Img.Name = "Img";
            this.Img.ReadOnly = true;
            // 
            // Edite
            // 
            this.Edite.FillWeight = 50.65886F;
            this.Edite.HeaderText = "";
            this.Edite.Image = global::Project_for_Control_2.Properties.Resources.edit_24px1;
            this.Edite.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edite.Name = "Edite";
            this.Edite.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.FillWeight = 25.98905F;
            this.delete.HeaderText = "";
            this.delete.Image = global::Project_for_Control_2.Properties.Resources.Delete_32px;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // print
            // 
            this.print.FillWeight = 48.2677F;
            this.print.HeaderText = "";
            this.print.Image = global::Project_for_Control_2.Properties.Resources.print_48px;
            this.print.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.print.Name = "print";
            this.print.ReadOnly = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Project_for_Control_2.Properties.Resources.Group_2__1_;
            this.pictureBox4.Location = new System.Drawing.Point(48, 182);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(235, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 51;
            this.pictureBox4.TabStop = false;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 622);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbtotalappnonpayer);
            this.Controls.Add(this.lbtotaltodaypayement);
            this.Controls.Add(this.lbtotalapppayer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.btnadduser);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.cmbsearch);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Dvgpayement);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txtsearch);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPayment";
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dvgpayement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtotalapppayer;
        private System.Windows.Forms.Label lbtotalappnonpayer;
        private System.Windows.Forms.Label lbtotaltodaypayement;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox cmbsearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txtsearch;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView Dvgpayement;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn Img;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAyementID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dentistfullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayementMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayementDate;
        private System.Windows.Forms.DataGridViewImageColumn Edite;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewImageColumn print;
    }
}