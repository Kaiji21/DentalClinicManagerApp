using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_for_Control_2
{
    public partial class accountsettings : Form
    {
        public accountsettings()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        UserDataContext us;
        void getdata()
        {
            us = new UserDataContext();
            tbUser user = us.tbUser.SingleOrDefault(u => u.name == LoginForm.Fullname);
            label1.Text = user.Login;
            txtfullname.Text = user.name;
            txtlogin.Text = user.Login;
            txtaddress.Text = user.address;
            txtpassword.Text = user.password;
            txtphone.Text = user.phone;
        }
        private void accountsettings_Load(object sender, EventArgs e)
        {
            txtfullname.Enabled = false;
            getdata();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            List<Control> liste = new List<Control>();
            int id = 0;
            int comp = 0;
            liste.Add(txtfullname); liste.Add(txtphone); liste.Add(txtlogin);liste.Add(txtaddress);liste.Add(txtpassword);
            while (id < liste.Count)
            {
                if (liste[id].Text=="0" || liste[id].Text == "")
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
                    us = new UserDataContext();
                    tbUser user = us.tbUser.SingleOrDefault(u => u.name == LoginForm.Fullname);
                    user.address = txtaddress.Text; ;
                    user.password = txtpassword.Text;
                    user.phone = txtphone.Text;
                    user.Login = txtlogin.Text;
                    us.SubmitChanges();
                    Cos c = new Cos();
                    c.label1.Text = "Updated successfully ";
                    c.button1.Text = "OK";
                    c.ShowDialog();
                    getdata();
                }
                catch (System.Data.SqlClient.SqlException )
                {
                    Cos c = new Cos();

                    
                        LoginForm.ERORMESSAGEBOX(c, "Invalide Phone number");
                        c.Show();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
