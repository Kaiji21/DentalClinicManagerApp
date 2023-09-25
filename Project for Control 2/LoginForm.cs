using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.IO;

namespace Project_for_Control_2
{
     
    public partial class LoginForm : Form
    {
     
     
        SqlConnection con;
        public static string role ;
        public static string Fullname;
        string connectionstring = "Data source =.;initial catalog=GESTION_DENTAL_CLINIC;integrated security=true";
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        public LoginForm()
        {
            InitializeComponent();
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );

        private void Form1_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            label1.Select();
            
            Clininc c = ClinincForm.clinics();
            byte[] data = (byte[])c.Clinic_Image;
            if (data != null)
            {
                MemoryStream stream = new MemoryStream(data);
                pictureBox4.Image = Image.FromStream(stream);
            }
          


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

   

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Cos f = new Cos();
            f.pictureBox1.Image = Properties.Resources.undraw_Contact_us_re_4qqt;
            f.label1.Text = "Please Contact us";
            f.button1.Text = "Contact us";
            f.tese = "Forgot Password";
            //f.label1.Location= new Point(84, 210);
            f.ShowDialog();
            
            //MessageBox.Show("Please contact us");
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(33, 135, 245);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(185, 185, 185);
        }

        private void Textmail_Enter(object sender, EventArgs e)
        {
            if (Textmail.ForeColor == Color.FromArgb(185, 185, 185))
            {
                Textmail.Text = "";
                Textmail.ForeColor = Color.Black;
            }
        }

        private void Textmail_Leave(object sender, EventArgs e)
        {
            if (Textmail.Text == "")
            {
                Textmail.Text = "youremail@gmail.com";
                Textmail.ForeColor = Color.FromArgb(185, 185, 185);
            }
        }

        private void Textboxpassword_Leave(object sender, EventArgs e)
        {
            if (Textboxpassword.Text == "")
            {
                Textboxpassword.Text = "Password";
                Textboxpassword.UseSystemPasswordChar = false;
                Textboxpassword.ForeColor = Color.FromArgb(185, 185, 185);
                pictureBox3.Image = Properties.Resources.icons8_invisible_24px;
            }
        }

        private void Textboxpassword_Enter(object sender, EventArgs e)
        {
            if (Textboxpassword.ForeColor == Color.FromArgb(185, 185, 185))
            {
                Textboxpassword.Text = "";
                Textboxpassword.UseSystemPasswordChar = true;
                Textboxpassword.ForeColor = Color.Black;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Select();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(33, 135, 245);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(123, 123, 123);

        }
        public bool Rechercher(string condition, string parametre,string teste)
        {
            using (con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand($"select * from tbUser where {condition} =@parametre {teste} ", con);
                cmd.Parameters.AddWithValue("@parametre", parametre);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    role = dr.GetString(5);
                    Fullname = dr.GetString(1);
                    dr.Close();
                    return true;
                }
                else
                    return false;
            }
        }
        public static void ERORMESSAGEBOX(Cos c,string msg)
        {
            c.pictureBox1.Image = Properties.Resources.undraw_access_denied_re_awnf__1_;
            c.label1.Text = msg;
            // f.label1.Location = new Point(16, 212);
            c.label1.ForeColor = Color.Red;
            c.button1.BackColor = Color.Red;
            c.button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(94, 19, 15);
            c.button1.Text = "OK";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Textboxpassword.ForeColor == Color.FromArgb(185, 185, 185) || Textmail.ForeColor == Color.FromArgb(185, 185, 185))
            {
                Cos f = new Cos();
                ERORMESSAGEBOX(f, "You must fill out all required fields.");
                f.ShowDialog();
            }
            else
            {
                if (!Rechercher("Login", Textmail.Text,""))
                {
                    errorProvider1.SetError(Textmail, "The email address you entered is not associated with any account.");
                }
                else
                {
                    errorProvider1.SetError(Textmail, "");
                    if (!Rechercher("password", Textboxpassword.Text,""))
                    {
                        errorProvider1.SetError(Textboxpassword, "Invalide password.");
                    }
                    else
                    {
                        if(Rechercher("login",Textmail.Text,$"and password='{Textboxpassword.Text}'"))
                        {
                            errorProvider1.SetError(Textboxpassword, "");
                            var form2 = new Cos();
                            form2.Closed += (s, args) => this.Hide();
                            form2.ShowDialog();
                        }
                        else
                        {
                            errorProvider1.SetError(Textboxpassword, "Incompatible password.");

                        }


                    }
                }
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {
            Cos f = new Cos();
            f.pictureBox1.Image = Properties.Resources.undraw_Contact_us_re_4qqt;
            f.label1.Text = "Please Contact us";
            f.button1.Text = "Contact us";
            f.tese = "Create Account";
            //f.label1.Location = new Point(84, 210);

            f.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
            if (Textboxpassword.UseSystemPasswordChar == true && Textboxpassword.ForeColor==Color.Black)
            {
                pictureBox3.Image = Properties.Resources.icons8_eye_32px;
                    Textboxpassword.UseSystemPasswordChar = false;
            }
            else if (Textboxpassword.UseSystemPasswordChar == false && Textboxpassword.ForeColor == Color.Black)
            {
                pictureBox3.Image = Properties.Resources.icons8_invisible_24px;
                Textboxpassword.UseSystemPasswordChar = true;
            }


        }

        private void LoginForm_Click(object sender, EventArgs e)
        {
            label1.Select();
        }
    }
}
