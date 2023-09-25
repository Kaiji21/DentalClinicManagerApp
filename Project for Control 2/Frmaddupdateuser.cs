using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_for_Control_2
{
    public partial class Frmaddupdateuser : Form
    {
        UserDataContext us;
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
   
        protected override void WndProc(ref Message m) { base.WndProc(ref m); if (m.Msg == WM_NCHITTEST) m.Result = (IntPtr)(HT_CAPTION); }
        private const int WM_NCHITTEST = 0x84; private const int HT_CLIENT = 0x1; private const int HT_CAPTION = 0x2;

        public Frmaddupdateuser()
        {
            InitializeComponent();
        }

        private void Frmaddupdateuser_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            dateobuser.Region = new Region(new Rectangle(3, 3, dateobuser.Width - 3, dateobuser.Height - 7));
            label3.Select();


        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtfullname_Enter(object sender, EventArgs e)
        {
            if (txtfullname.ForeColor != Color.Black)
            {
                txtfullname.Text = "";
                txtfullname.ForeColor = Color.Black;
            }
        }

        private void txtfullname_Leave(object sender, EventArgs e)
        {
            if (txtfullname.Text == "")
            {
                txtfullname.Text = "User fullname";
                txtfullname.ForeColor = Color.Gray;
            }
        }

        private void txtlogin_Enter(object sender, EventArgs e)
        {
            if (txtlogin.ForeColor != Color.Black)
            {
                txtlogin.Text = "";
                txtlogin.ForeColor = Color.Black;
            }
        }

        private void txtlogin_Leave(object sender, EventArgs e)
        {
            if (txtlogin.Text == "")
            {
                txtlogin.Text = "User Login";
                txtlogin.ForeColor = Color.Gray;
            }
        }

        private void txtaddress_Enter(object sender, EventArgs e)
        {
            if (txtaddress.ForeColor != Color.Black)
            {
                txtaddress.Text = "";
                txtaddress.ForeColor = Color.Black;
            }
        }

        private void txtaddress_Leave(object sender, EventArgs e)
        {
            if (txtaddress.Text == "")
            {
                txtaddress.Text = "User Address";
                txtaddress.ForeColor = Color.Gray;
            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtpassword.ForeColor != Color.Black)
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.Black;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "User Password";
                txtpassword.ForeColor = Color.Gray;
            }
        }

        private void txtphone_Enter(object sender, EventArgs e)
        {
            txtphone.ForeColor = Color.Black;

        }

        private void txtphone_Leave(object sender, EventArgs e)
        {
            if (txtphone.Text == "0")
            {
                txtphone.ForeColor = Color.Gray;
            }
        }

        private void btnaddduser_Click(object sender, EventArgs e)
        {
            List<Control> liste = new List<Control>();
            int id = 0;
            int comp = 0;
            liste.Add(txtfullname); liste.Add(txtphone); liste.Add(txtaddress); liste.Add(txtlogin); liste.Add(txtpassword); liste.Add(cmbrole);
            while (id < liste.Count)
            {
                if (liste[id].ForeColor == Color.Gray )
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

          if (comp == 0)
            {
                try
                {
                    if (btnaddduser.Text == "Add User")
                    {
                        us = new UserDataContext();
                        tbUser user = new tbUser();
                        user.name = txtfullname.Text;
                        user.Login = txtlogin.Text;
                        user.phone = txtphone.Text;
                        user.role = cmbrole.Text;
                        user.address = txtaddress.Text;
                        user.password = txtpassword.Text;
                        user.Dateofbirth = dateobuser.Value;
                        user.Created_at = DateTime.Now;
                        user.Created_by = LoginForm.Fullname;
                        us.tbUser.InsertOnSubmit(user);
                        us.SubmitChanges();
                        Cos c = new Cos();
                        c.label1.Text = "User Added successfully";
                        c.button1.Text = "OK";
                        c.Closed += (s, args) => this.Close();
                        c.ShowDialog();
                    }
                    else
                    {
                        us = new UserDataContext();
                        tbUser user = new tbUser();
                        user.id = UserandClinic.IDUSer;
                        user = us.tbUser.SingleOrDefault(U => U.id == user.id);
                        user.name = txtfullname.Text;
                        user.Login = txtlogin.Text;
                        user.password = txtpassword.Text;
                        user.phone = txtphone.Text;
                        user.role = cmbrole.Text;
                        user.address = txtaddress.Text;
                        user.Dateofbirth = dateobuser.Value;
                        us.SubmitChanges();
                        Cos c = new Cos();
                        c.label1.Text = "User Updated successfully";
                        c.button1.Text = "OK";
                        c.Closed += (s, args) => this.Close();
                        c.ShowDialog();



                    }
                }
                catch(System.Data.SqlClient.SqlException ex)
                {
                    Cos c = new Cos();

                    if (ex.Message.Contains("Dateofbirth"))
                    {
                        LoginForm.ERORMESSAGEBOX(c, "layomkin dkhel lina brhoch ");
                        c.Show();
                    }
                    else if (ex.Message.Contains("Phone"))
                    {
                        LoginForm.ERORMESSAGEBOX(c, "Invalide Phone number");
                        c.Show();
                    }
                    else if (ex.Message.Contains("Email"))
                    {
                        LoginForm.ERORMESSAGEBOX(c, "Please enter a valide email");
                        c.Show();
                    }
                    else if (ex.Message.Contains("UNIQUE KEY"))
                    {
                        LoginForm.ERORMESSAGEBOX(c, "there is already a user with this name");
                        c.Show();
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            
            }
        }

        private void txtfullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (Char.IsLetter(pressedKey) || Char.IsSeparator(pressedKey) || (char)Keys.Back == pressedKey)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
