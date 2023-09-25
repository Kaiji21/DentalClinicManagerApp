
namespace Project_for_Control_2
{
    partial class Frmaddupdatepayement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmaddupdatepayement));
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.bntaddpayement = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbpattientfullname = new System.Windows.Forms.ComboBox();
            this.cmbappointment = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Project_for_Control_2.Properties.Resources.Close_64px;
            this.pictureBox7.Location = new System.Drawing.Point(371, 1);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(23, 23);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // bntaddpayement
            // 
            this.bntaddpayement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(159)))), ((int)(((byte)(249)))));
            this.bntaddpayement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntaddpayement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bntaddpayement.FlatAppearance.BorderSize = 0;
            this.bntaddpayement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.bntaddpayement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(237)))));
            this.bntaddpayement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntaddpayement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntaddpayement.ForeColor = System.Drawing.Color.Transparent;
            this.bntaddpayement.Location = new System.Drawing.Point(112, 444);
            this.bntaddpayement.Name = "bntaddpayement";
            this.bntaddpayement.Size = new System.Drawing.Size(187, 35);
            this.bntaddpayement.TabIndex = 13;
            this.bntaddpayement.Text = "Add Payement";
            this.bntaddpayement.UseVisualStyleBackColor = false;
            this.bntaddpayement.Click += new System.EventHandler(this.bntaddpayement_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.label3.Location = new System.Drawing.Point(77, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 42);
            this.label3.TabIndex = 19;
            this.label3.Text = "Add New Payement";
            // 
            // cmbpattientfullname
            // 
            this.cmbpattientfullname.BackColor = System.Drawing.Color.White;
            this.cmbpattientfullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbpattientfullname.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpattientfullname.FormattingEnabled = true;
            this.cmbpattientfullname.Location = new System.Drawing.Point(181, 251);
            this.cmbpattientfullname.Name = "cmbpattientfullname";
            this.cmbpattientfullname.Size = new System.Drawing.Size(159, 21);
            this.cmbpattientfullname.TabIndex = 20;
            this.cmbpattientfullname.SelectedIndexChanged += new System.EventHandler(this.cmbpattientfullname_SelectedIndexChanged);
            // 
            // cmbappointment
            // 
            this.cmbappointment.BackColor = System.Drawing.Color.White;
            this.cmbappointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbappointment.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbappointment.FormattingEnabled = true;
            this.cmbappointment.Location = new System.Drawing.Point(180, 298);
            this.cmbappointment.Name = "cmbappointment";
            this.cmbappointment.Size = new System.Drawing.Size(159, 21);
            this.cmbappointment.TabIndex = 21;
            this.cmbappointment.SelectedIndexChanged += new System.EventHandler(this.cmbappointment_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Cash",
            "Checks",
            "Credit cards",
            "Bank transfers"});
            this.comboBox2.Location = new System.Drawing.Point(180, 348);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // txttotalprice
            // 
            this.txttotalprice.BackColor = System.Drawing.Color.White;
            this.txttotalprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotalprice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalprice.ForeColor = System.Drawing.Color.Gray;
            this.txttotalprice.Location = new System.Drawing.Point(180, 393);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.ReadOnly = true;
            this.txttotalprice.Size = new System.Drawing.Size(158, 16);
            this.txttotalprice.TabIndex = 23;
            this.txttotalprice.Text = "Total price";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // Frmaddupdatepayement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::Project_for_Control_2.Properties.Resources.Group_13__3_;
            this.ClientSize = new System.Drawing.Size(397, 497);
            this.Controls.Add(this.txttotalprice);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cmbappointment);
            this.Controls.Add(this.cmbpattientfullname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bntaddpayement);
            this.Controls.Add(this.pictureBox7);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmaddupdatepayement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmaddupdatepayement";
            this.Load += new System.EventHandler(this.Frmaddupdatepayement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.Button bntaddpayement;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbpattientfullname;
        public System.Windows.Forms.ComboBox cmbappointment;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.TextBox txttotalprice;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}