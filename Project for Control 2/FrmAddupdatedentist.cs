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
using System.IO;
using System.Runtime.InteropServices;

namespace Project_for_Control_2
{
    public partial class FrmAddupdatedentist : Form
    {
        public  string imgadded = "no image added";
       
        SqlConnection con;
        public FrmAddupdatedentist()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtfullname_Leave(object sender, EventArgs e)
        {
            if (txtfullname.Text == "")
            {
                txtfullname.Text = "Dentist Full Name";
                txtfullname.ForeColor = Color.Gray;
            }
        }

        private void txtfullname_Enter(object sender, EventArgs e)
        {
            if (txtfullname.ForeColor == Color.Gray)
            {
                txtfullname.Text = "";
                txtfullname.ForeColor = Color.Black;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "DentistEmail@gmail.com";
                txtemail.ForeColor = Color.Gray;
            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.ForeColor == Color.Gray)
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.Black;
            }
        }

        private void txtadress_Leave(object sender, EventArgs e)
        {
            if (txtadress.Text == "")
            {
                txtadress.Text = "Dentiste Adresse Av Hay nahda Guelmim";
                txtadress.ForeColor = Color.Gray;
            }
        }

        private void txtadress_Enter(object sender, EventArgs e)
        {
            if (txtadress.ForeColor == Color.Gray)
            {
                txtadress.Text = "";
                txtadress.ForeColor = Color.Black;
            }
        }
     

        string imglocation;
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Bitmaps|*.bmp|PNG files|*.png|JPEG files|*.jpg|GIF files|*.gif|TIFF files|*.tif|Image files|*.bmp;*.jpg;*.gif;*.png";
                open.Title = "Upload Your Img";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Dentistimg.Image = Image.FromFile(open.FileName);
                    imglocation = open.FileName;
                    Dentistimg.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox8.BackColor = Color.Transparent;
                    imgadded = "image added";
                }
            }
            catch (Exception ex)
            {

                Cos c = new Cos();
                LoginForm.ERORMESSAGEBOX(c, ex.Message);
                c.ShowDialog();


            }
        }

        private void paneladddentist_Click(object sender, EventArgs e)
        {
           


        }

        private void FrmAddupdatedentist_Load(object sender, EventArgs e)
        {
            label3.Select();
            cmbgender.Region = new Region(new Rectangle(3, 3, cmbgender.Width - 3, cmbgender.Height - 7));

        }
      
        private void btnadddentist_Click(object sender, EventArgs e)
        {
            List<Control> liste = new List<Control>();
            int id = 0;
            int comp = 0;
            liste.Add(txtfullname); liste.Add(txtphone); liste.Add(txtadress); liste.Add(cmbgender);
            while (id < liste.Count)
            {
                if (liste[id].ForeColor == Color.Gray || liste[id].Text == ""|| liste[id].Text=="0")
                {
                    errorProvider1.SetError(liste[id], "required field");
                    comp++;

                }
                else
                {
                    errorProvider1.SetError(liste[id], "");
                }

                id++;
            }
           
            if (comp==0)
            {
                try
                {
                    if (btnadddentist.Text=="Add Dentist")
                    {
                        using (con = new SqlConnection(Dentists.cs))
                        {
                            SqlCommand cmd = new SqlCommand("insert into dentist values (@fullname,@phone,@email,@adress,@dob,@gender,@dsw,@createdat,@img)", con);
                            cmd.Parameters.AddWithValue("@fullname", txtfullname.Text);
                            cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                            cmd.Parameters.AddWithValue("@email", txtemail.ForeColor == Color.Gray ? (object)DBNull.Value : txtemail.Text);
                            cmd.Parameters.AddWithValue("@adress", txtadress.Text);
                            cmd.Parameters.AddWithValue("@gender", cmbgender.Text);
                            cmd.Parameters.AddWithValue("@createdat", DateTime.Now);
                            cmd.Parameters.AddWithValue("@dob", datatimeDOB.Value.ToShortDateString());
                            cmd.Parameters.AddWithValue("@dsw", datetimepickerDSW.Value.ToShortDateString());
                            if (imgadded== "image added")
                            {
                                byte[] img;
                                FileStream fs = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                                BinaryReader br = new BinaryReader(fs);
                                img = br.ReadBytes((int)fs.Length);
                                cmd.Parameters.AddWithValue("@img", img);
                            }
                            else
                            {

                                cmd.Parameters.Add("@img", SqlDbType.Image).Value = DBNull.Value;


                            }
                            con.Open();
                            int rowaffected = cmd.ExecuteNonQuery();
                            if (rowaffected > 0)
                            {
                                Cos c = new Cos();
                                c.label1.Text = "A new Dentist was added successfully and a new account user for the dentist was created automatically";
                                c.button1.Text = "OK";
                                c.Show();
                                c.Closed += (s, args) => this.Close();


                            }
                            else
                            {
                                MessageBox.Show("tfooo");
                            }

                        }
                    }
                    else
                    {
                        using (con = new SqlConnection(Dentists.cs))
                        {
                            SqlCommand cmd = new SqlCommand("update  dentist set  [DentistFullName]=@fullname ,[Phone]=@phone, [Email]=@email ,[Adress]=@adress ,[Dateofbirth]=@dob ,[Gender]=@gender ,[Date start work]=@dsw  ,[Image]=@img where DentistID=@id", con);
                            cmd.Parameters.AddWithValue("@fullname", txtfullname.Text);
                            cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                            cmd.Parameters.AddWithValue("@id", Dentists.DentistID);
                            cmd.Parameters.AddWithValue("@email", txtemail.ForeColor == Color.Gray ? (object)DBNull.Value : txtemail.Text);
                            cmd.Parameters.AddWithValue("@adress", txtadress.Text);
                            cmd.Parameters.AddWithValue("@gender", cmbgender.Text);
                            //cmd.Parameters.AddWithValue("@createdat", DateTime.Now);
                            cmd.Parameters.AddWithValue("@dob", datatimeDOB.Value.ToShortDateString());
                            cmd.Parameters.AddWithValue("@dsw", datetimepickerDSW.Value.ToShortDateString());
                            if (imgadded== "image added") // ila jabha mn open open file
                            {
                                byte[] img;
                                FileStream fs = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                                BinaryReader br = new BinaryReader(fs);
                                img = br.ReadBytes((int)fs.Length);
                                cmd.Parameters.AddWithValue("@img", img);
                            }
                            
                            else if (imgadded== "no image added") // ila majab walo mn open file 
                            {

                                cmd.Parameters.Add("@img", SqlDbType.Image).Value = DBNull.Value;

                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@img", Dentists.data);

                            }
                            con.Open();
                            int rowaffected = cmd.ExecuteNonQuery();
                            if (rowaffected > 0)
                            {
                                Cos c = new Cos();
                                c.label1.Text = "the Dentist was updated successfully and his account user was updated automatically";
                                c.button1.Text = "OK";
                                c.Show();
                                c.Closed += (s, args) => this.Close();


                            }
                        }
                    }
                    
                }
                catch(SqlException ex)
                {
                    Cos c = new Cos();

                    if (ex.Message.Contains("Dateofbirth"))
                    {
                        LoginForm.ERORMESSAGEBOX(c, "Dentist must have at least 20 years old ");
                        c.ShowDialog();
                    }
                    else if (ex.Message.Contains("Phone"))
                    {
                        LoginForm.ERORMESSAGEBOX(c, "Invalide Phone number");
                        c.ShowDialog();
                    }
                    else if (ex.Message.Contains("Email"))
                    {
                        LoginForm.ERORMESSAGEBOX(c, "Please enter a valide email");
                        c.ShowDialog();
                    }
                    else if (ex.Message.Contains("Gender"))
                    {
                        LoginForm.ERORMESSAGEBOX(c, "please pick a gender from the combobox");
                        c.ShowDialog();
                    }
                    else if (ex.Message.Contains("UNIQUE KEY"))
                    {
                        LoginForm.ERORMESSAGEBOX(c, "there is already a user with this name");
                        c.Show();
                    }
                    else
                    {
                        MessageBox.Show(ex.Message) ;
                    }
                    
                }
                catch (Exception ex)
                {
                    
                    Cos c = new Cos();
                    LoginForm.ERORMESSAGEBOX(c, ex.Message);
                    c.ShowDialog();

                    //MessageBox.Show(ex.Message);
                }
            }

        }

        private void paneladddentist_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
       
        private void paneladddentist_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dentistimg_Click(object sender, EventArgs e)
        {

        }

        private void txtfullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_Enter(object sender, EventArgs e)
        {
            
            
                txtphone.ForeColor = Color.Black;
            
        }

        private void txtphone_Leave(object sender, EventArgs e)
        {
            if (txtphone.Text == "0")
            {
                txtphone.ForeColor = Color.FromArgb(109, 109, 109);
            }
        }

        private void txtfullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (Char.IsLetter(pressedKey) || Char.IsSeparator(pressedKey) || (char)Keys.Back==pressedKey)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
    
   

