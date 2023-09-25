
namespace Project_for_Control_2
{
    partial class UserandClinic
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
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtsearch = new System.Windows.Forms.TextBox();
            this.Dvgusers = new System.Windows.Forms.DataGridView();
            this.Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Userfullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userlogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Createdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Createdby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edite = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbtotalusers = new System.Windows.Forms.Label();
            this.lbtotaladmlinuser = new System.Windows.Forms.Label();
            this.lbtotalmoduser = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnadduser = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dvgusers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbsearch
            // 
            this.cmbsearch.BackColor = System.Drawing.Color.White;
            this.cmbsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbsearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbsearch.Items.AddRange(new object[] {
            "User ID",
            "User Fullname",
            "User Login",
            "User Adress",
            "User Phone",
            "User Role"});
            this.cmbsearch.Location = new System.Drawing.Point(382, 177);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(173, 25);
            this.cmbsearch.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "Search by :";
            // 
            // Txtsearch
            // 
            this.Txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtsearch.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtsearch.Location = new System.Drawing.Point(46, 179);
            this.Txtsearch.Name = "Txtsearch";
            this.Txtsearch.Size = new System.Drawing.Size(172, 17);
            this.Txtsearch.TabIndex = 39;
            this.Txtsearch.TextChanged += new System.EventHandler(this.Txtsearch_TextChanged);
            // 
            // Dvgusers
            // 
            this.Dvgusers.AllowUserToAddRows = false;
            this.Dvgusers.AllowUserToDeleteRows = false;
            this.Dvgusers.AllowUserToResizeRows = false;
            this.Dvgusers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dvgusers.BackgroundColor = System.Drawing.Color.White;
            this.Dvgusers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dvgusers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dvgusers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dvgusers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dvgusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvgusers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Img,
            this.userid,
            this.Userfullname,
            this.userlogin,
            this.Adress,
            this.phone,
            this.Role,
            this.DBO,
            this.password,
            this.Createdat,
            this.Createdby,
            this.Edite,
            this.delete});
            this.Dvgusers.EnableHeadersVisualStyles = false;
            this.Dvgusers.Location = new System.Drawing.Point(34, 237);
            this.Dvgusers.MultiSelect = false;
            this.Dvgusers.Name = "Dvgusers";
            this.Dvgusers.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dvgusers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dvgusers.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = "           -";
            this.Dvgusers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dvgusers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dvgusers.Size = new System.Drawing.Size(972, 336);
            this.Dvgusers.TabIndex = 37;
            this.Dvgusers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvgusers_CellClick);
            // 
            // Img
            // 
            this.Img.FillWeight = 27.31075F;
            this.Img.HeaderText = "";
            this.Img.Image = global::Project_for_Control_2.Properties.Resources.User_free_vector_icons_designed_by_bqlqn;
            this.Img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Img.Name = "Img";
            this.Img.ReadOnly = true;
            // 
            // userid
            // 
            this.userid.DataPropertyName = "id";
            this.userid.FillWeight = 92.19623F;
            this.userid.HeaderText = "User ID ";
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            // 
            // Userfullname
            // 
            this.Userfullname.DataPropertyName = "name";
            this.Userfullname.FillWeight = 45.60145F;
            this.Userfullname.HeaderText = "User Fullname";
            this.Userfullname.Name = "Userfullname";
            this.Userfullname.ReadOnly = true;
            // 
            // userlogin
            // 
            this.userlogin.DataPropertyName = "Login";
            this.userlogin.FillWeight = 87.19424F;
            this.userlogin.HeaderText = "User Login";
            this.userlogin.Name = "userlogin";
            this.userlogin.ReadOnly = true;
            // 
            // Adress
            // 
            this.Adress.DataPropertyName = "address";
            this.Adress.FillWeight = 87.19424F;
            this.Adress.HeaderText = "User Address";
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.FillWeight = 167.0198F;
            this.phone.HeaderText = "User Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "role";
            this.Role.FillWeight = 87.19424F;
            this.Role.HeaderText = "User Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // DBO
            // 
            this.DBO.DataPropertyName = "Dateofbirth";
            this.DBO.FillWeight = 178.8408F;
            this.DBO.HeaderText = "User Date od birth";
            this.DBO.Name = "DBO";
            this.DBO.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.FillWeight = 87.19424F;
            this.password.HeaderText = "User Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // Createdat
            // 
            this.Createdat.DataPropertyName = "Created_at";
            this.Createdat.FillWeight = 144.1236F;
            this.Createdat.HeaderText = "Created at";
            this.Createdat.Name = "Createdat";
            this.Createdat.ReadOnly = true;
            // 
            // Createdby
            // 
            this.Createdby.DataPropertyName = "Created_by";
            this.Createdby.FillWeight = 92.19623F;
            this.Createdby.HeaderText = "Created By";
            this.Createdby.Name = "Createdby";
            this.Createdby.ReadOnly = true;
            // 
            // Edite
            // 
            this.Edite.FillWeight = 51.76518F;
            this.Edite.HeaderText = "";
            this.Edite.Image = global::Project_for_Control_2.Properties.Resources.edit_24px1;
            this.Edite.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edite.Name = "Edite";
            this.Edite.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.FillWeight = 26.55661F;
            this.delete.HeaderText = "";
            this.delete.Image = global::Project_for_Control_2.Properties.Resources.Delete_32px;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // lbtotalusers
            // 
            this.lbtotalusers.AutoSize = true;
            this.lbtotalusers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(230)))), ((int)(((byte)(218)))));
            this.lbtotalusers.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalusers.Location = new System.Drawing.Point(174, 80);
            this.lbtotalusers.Name = "lbtotalusers";
            this.lbtotalusers.Size = new System.Drawing.Size(32, 23);
            this.lbtotalusers.TabIndex = 43;
            this.lbtotalusers.Text = "15";
            // 
            // lbtotaladmlinuser
            // 
            this.lbtotaladmlinuser.AutoSize = true;
            this.lbtotaladmlinuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(174)))));
            this.lbtotaladmlinuser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotaladmlinuser.Location = new System.Drawing.Point(523, 80);
            this.lbtotaladmlinuser.Name = "lbtotaladmlinuser";
            this.lbtotaladmlinuser.Size = new System.Drawing.Size(32, 23);
            this.lbtotaladmlinuser.TabIndex = 44;
            this.lbtotaladmlinuser.Text = "15";
            // 
            // lbtotalmoduser
            // 
            this.lbtotalmoduser.AutoSize = true;
            this.lbtotalmoduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.lbtotalmoduser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalmoduser.Location = new System.Drawing.Point(872, 80);
            this.lbtotalmoduser.Name = "lbtotalmoduser";
            this.lbtotalmoduser.Size = new System.Drawing.Size(32, 23);
            this.lbtotalmoduser.TabIndex = 45;
            this.lbtotalmoduser.Text = "15";
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
            this.btnprint.Location = new System.Drawing.Point(715, 187);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(102, 39);
            this.btnprint.TabIndex = 49;
            this.btnprint.Text = "Print ";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Visible = false;
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
            this.btnadduser.Location = new System.Drawing.Point(876, 187);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(102, 39);
            this.btnadduser.TabIndex = 47;
            this.btnadduser.Text = "Add";
            this.btnadduser.UseVisualStyleBackColor = false;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 27.31075F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Project_for_Control_2.Properties.Resources.male_boy_person_people_avatar_icon_159358;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 23;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 51.76518F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Project_for_Control_2.Properties.Resources.edit_24px1;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 43;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.FillWeight = 26.55661F;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Project_for_Control_2.Properties.Resources.Delete_32px;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 22;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Project_for_Control_2.Properties.Resources.Rectangle_3;
            this.pictureBox7.Location = new System.Drawing.Point(697, 181);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(135, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 48;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Project_for_Control_2.Properties.Resources.Rectangle_3;
            this.pictureBox5.Location = new System.Drawing.Point(858, 181);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(135, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 46;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Project_for_Control_2.Properties.Resources.Group_4;
            this.pictureBox6.Location = new System.Drawing.Point(372, 170);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(195, 39);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 42;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Project_for_Control_2.Properties.Resources.Group_2__1_;
            this.pictureBox4.Location = new System.Drawing.Point(31, 170);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(235, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project_for_Control_2.Properties.Resources.Group_10;
            this.pictureBox3.Location = new System.Drawing.Point(659, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(347, 173);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_for_Control_2.Properties.Resources.Group_9__1_;
            this.pictureBox2.Location = new System.Drawing.Point(350, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 173);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_for_Control_2.Properties.Resources.Group_8__3_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(429, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 42);
            this.label7.TabIndex = 51;
            this.label7.Text = "No results found.";
            this.label7.Visible = false;
            // 
            // UserandClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 583);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.btnadduser);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lbtotalmoduser);
            this.Controls.Add(this.lbtotaladmlinuser);
            this.Controls.Add(this.lbtotalusers);
            this.Controls.Add(this.cmbsearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txtsearch);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Dvgusers);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserandClinic";
            this.Text = "UserandClinic";
            this.Load += new System.EventHandler(this.UserandClinic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dvgusers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cmbsearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txtsearch;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView Dvgusers;
        private System.Windows.Forms.Label lbtotalusers;
        private System.Windows.Forms.Label lbtotaladmlinuser;
        private System.Windows.Forms.Label lbtotalmoduser;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn Img;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Userfullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn userlogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBO;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Createdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Createdby;
        private System.Windows.Forms.DataGridViewImageColumn Edite;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Label label7;
    }
}