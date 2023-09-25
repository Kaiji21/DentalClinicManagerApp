
namespace Project_for_Control_2
{
    partial class Frmadddupdateappointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmadddupdateappointment));
            this.label3 = new System.Windows.Forms.Label();
            this.dateappointment = new System.Windows.Forms.DateTimePicker();
            this.txtHourappointment = new System.Windows.Forms.MaskedTextBox();
            this.cmbpatienfullname = new System.Windows.Forms.ComboBox();
            this.cmbdentistfullname = new System.Windows.Forms.ComboBox();
            this.cmbremained = new System.Windows.Forms.ComboBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnadddappointment = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label3.Font = new System.Drawing.Font("Poppins ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.label3.Location = new System.Drawing.Point(65, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "ADD New Appointment";
            // 
            // dateappointment
            // 
            this.dateappointment.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateappointment.Location = new System.Drawing.Point(155, 223);
            this.dateappointment.Name = "dateappointment";
            this.dateappointment.Size = new System.Drawing.Size(221, 21);
            this.dateappointment.TabIndex = 8;
            // 
            // txtHourappointment
            // 
            this.txtHourappointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHourappointment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourappointment.ForeColor = System.Drawing.Color.Black;
            this.txtHourappointment.Location = new System.Drawing.Point(158, 276);
            this.txtHourappointment.Mask = "00:00";
            this.txtHourappointment.Name = "txtHourappointment";
            this.txtHourappointment.Size = new System.Drawing.Size(218, 19);
            this.txtHourappointment.TabIndex = 9;
            this.txtHourappointment.ValidatingType = typeof(System.DateTime);
            this.txtHourappointment.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtHourappointment_MaskInputRejected);
            this.txtHourappointment.TextChanged += new System.EventHandler(this.txtHourappointment_TextChanged);
            // 
            // cmbpatienfullname
            // 
            this.cmbpatienfullname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbpatienfullname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbpatienfullname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpatienfullname.FormattingEnabled = true;
            this.cmbpatienfullname.Location = new System.Drawing.Point(158, 319);
            this.cmbpatienfullname.Name = "cmbpatienfullname";
            this.cmbpatienfullname.Size = new System.Drawing.Size(218, 25);
            this.cmbpatienfullname.TabIndex = 10;
            this.cmbpatienfullname.SelectedIndexChanged += new System.EventHandler(this.cmbpatienfullname_SelectedIndexChanged);
            // 
            // cmbdentistfullname
            // 
            this.cmbdentistfullname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdentistfullname.FormattingEnabled = true;
            this.cmbdentistfullname.Location = new System.Drawing.Point(158, 373);
            this.cmbdentistfullname.Name = "cmbdentistfullname";
            this.cmbdentistfullname.Size = new System.Drawing.Size(218, 25);
            this.cmbdentistfullname.TabIndex = 10;
            this.cmbdentistfullname.SelectedIndexChanged += new System.EventHandler(this.cmbdentistfullname_SelectedIndexChanged);
            // 
            // cmbremained
            // 
            this.cmbremained.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbremained.FormattingEnabled = true;
            this.cmbremained.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbremained.Location = new System.Drawing.Point(157, 424);
            this.cmbremained.Name = "cmbremained";
            this.cmbremained.Size = new System.Drawing.Size(218, 25);
            this.cmbremained.TabIndex = 10;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Project_for_Control_2.Properties.Resources.Close_64px;
            this.pictureBox7.Location = new System.Drawing.Point(386, 1);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(23, 23);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // btnadddappointment
            // 
            this.btnadddappointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnadddappointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadddappointment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnadddappointment.FlatAppearance.BorderSize = 0;
            this.btnadddappointment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnadddappointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(237)))));
            this.btnadddappointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadddappointment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadddappointment.ForeColor = System.Drawing.Color.Transparent;
            this.btnadddappointment.Location = new System.Drawing.Point(93, 487);
            this.btnadddappointment.Name = "btnadddappointment";
            this.btnadddappointment.Size = new System.Drawing.Size(222, 39);
            this.btnadddappointment.TabIndex = 12;
            this.btnadddappointment.Text = "Add Appointment";
            this.btnadddappointment.UseVisualStyleBackColor = false;
            this.btnadddappointment.Click += new System.EventHandler(this.btnadddappointment_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // Frmadddupdateappointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Project_for_Control_2.Properties.Resources.Group_7__5_;
            this.ClientSize = new System.Drawing.Size(413, 569);
            this.Controls.Add(this.btnadddappointment);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.cmbremained);
            this.Controls.Add(this.cmbdentistfullname);
            this.Controls.Add(this.cmbpatienfullname);
            this.Controls.Add(this.txtHourappointment);
            this.Controls.Add(this.dateappointment);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmadddupdateappointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmadddupdateappointment";
            this.Load += new System.EventHandler(this.Frmadddupdateappointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.Button btnadddappointment;
        public System.Windows.Forms.DateTimePicker dateappointment;
        public System.Windows.Forms.MaskedTextBox txtHourappointment;
        public System.Windows.Forms.ComboBox cmbpatienfullname;
        public System.Windows.Forms.ComboBox cmbdentistfullname;
        public System.Windows.Forms.ComboBox cmbremained;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}