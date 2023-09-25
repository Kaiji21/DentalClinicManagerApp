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
    public partial class UserandClinic : Form
    {
        public UserandClinic()
        {
            InitializeComponent();
        }
        UserDataContext us;
        private void UserandClinic_Load(object sender, EventArgs e)
        {
            Dvgusers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 239, 239);
            getdata();
        }

        private void getdata()
        {
            us = new UserDataContext();
            Dvgusers.DataSource = from U in us.tbUser select new { U.id, U.name, U.Login, U.address, U.phone, U.role, U.Dateofbirth, U.password, U.Created_at, U.Created_by };
            lbtotalusers.Text = (from U in us.tbUser select U).Count().ToString();
            lbtotaladmlinuser.Text = (from U in us.tbUser where U.role == "Admin" select U).Count().ToString();
            lbtotalmoduser.Text = (from U in us.tbUser where U.role == "Modérateur" select U).Count().ToString();
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            Frmaddupdateuser f = new Frmaddupdateuser();
            f.ShowDialog();
            getdata();
        }
        public static int IDUSer;
        private void Dvgusers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            us = new UserDataContext();
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                if (Dvgusers.CurrentRow != null)
                {
                    Frmaddupdateuser f = new Frmaddupdateuser();
                    foreach (Control var in f.Controls)
                    {
                        if (var is TextBox)
                        {
                            ((TextBox)var).ForeColor = Color.Black;
                        }
                    }
                    f.txtphone.ForeColor = Color.Black;
                    f.label3.Text = "Update User";
                    f.label3.Location = new Point(135, 9);
                    f.btnaddduser.Text = "Update User";
                    f.txtfullname.Text = Dvgusers.CurrentRow.Cells["Userfullname"].Value.ToString();
                    f.txtlogin.Text = Dvgusers.CurrentRow.Cells["userlogin"].Value.ToString();
                    f.cmbrole.Text = Dvgusers.CurrentRow.Cells["Role"].Value.ToString();
                    IDUSer = int.Parse(Dvgusers.CurrentRow.Cells["userid"].Value.ToString());
                    f.txtaddress.Text = Dvgusers.CurrentRow.Cells["Adress"].Value.ToString();
                    f.txtphone.Text = Dvgusers.CurrentRow.Cells["phone"].Value.ToString();
                    f.txtpassword.Text = Dvgusers.CurrentRow.Cells["password"].Value.ToString();
                    f.dateobuser.Text = Dvgusers.CurrentRow.Cells["DBO"].Value.ToString();
                    f.ShowDialog();
                    getdata();

                }
            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                if (Dvgusers.CurrentRow != null)
                {
                    if (MessageBox.Show("Are you shure that you wanna delete this User?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            tbUser obj = new tbUser();
                            obj.id = int.Parse(Dvgusers.CurrentRow.Cells["userid"].Value.ToString());
                            obj = us.tbUser.SingleOrDefault(user => user.id == obj.id);
                            us.tbUser.DeleteOnSubmit(obj);
                            Cos c = new Cos();
                            c.label1.Text = "Deleted successfully ";
                            c.button1.Text = "OK";
                            c.ShowDialog();
                            us.SubmitChanges();

                            getdata();
                        }
                        catch (Exception ex)
                        {
                            Cos c = new Cos();
                            LoginForm.ERORMESSAGEBOX(c, ex.Message);
                            c.Show();

                        }
                    }
                }
            }
        }

        private void Txtsearch_TextChanged(object sender, EventArgs e)
        {
            us = new UserDataContext();
            if (cmbsearch.SelectedIndex == -1)
            {

                var resresultat = from A in us.tbUser where A.name.Contains(Txtsearch.Text) select A;
                if (resresultat.Count() > 0)
                {
                    Dvgusers.DataSource = resresultat.ToList();
                    label7.Visible = false;
                }
                else
                {
                    Dvgusers.DataSource = resresultat.ToList();
                    label7.Visible = true;
                }
            }
            else
            {
                switch (cmbsearch.SelectedIndex)
                {
                    case 0:
                        {
                            try
                            {
                                var resresultat = from A in us.tbUser where A.id == (Txtsearch.Text == "" ? 0 : int.Parse(Txtsearch.Text)) select A;
                                if (resresultat.Count() > 0)
                                {
                                    Dvgusers.DataSource = resresultat.ToList();
                                    label7.Visible = false;
                                    
                                }
                                else
                                {
                                    Dvgusers.DataSource = resresultat.ToList();
                                    label7.Visible = true;
                                    
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("You can not insert a charachter when your are searching by ID (Number)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                          
                        }
                    case 1:
                        {
                            var resresultat = from A in us.tbUser where A.name.StartsWith(Txtsearch.Text) select A;
                            if (resresultat.Count() > 0)
                            {
                                Dvgusers.DataSource = resresultat.ToList();
                                label7.Visible = false;
                                break;
                            }
                            else
                            {
                                Dvgusers.DataSource = resresultat.ToList();
                                label7.Visible = true;
                                break;
                            }
                        }
                    case 2:
                        {
                            var resresultat = from A in us.tbUser where A.Login.Contains(Txtsearch.Text) select A;
                            if (resresultat.Count() > 0)
                            {
                                Dvgusers.DataSource = resresultat.ToList();
                                label7.Visible = false;
                                break;
                            }
                            else
                            {
                                Dvgusers.DataSource = resresultat.ToList();
                                label7.Visible = true;
                                break;
                            }
                        }
                    case 3:
                        {
                            var resresultat = from A in us.tbUser where A.address.Contains(Txtsearch.Text) select A;
                            if (resresultat.Count() > 0)
                            {
                                Dvgusers.DataSource = resresultat.ToList();
                                label7.Visible = false;
                                break;
                            }
                            else
                            {
                                Dvgusers.DataSource = resresultat.ToList();
                                label7.Visible = true;
                                break;
                            }
                        }
                    case 4:
                        {
                            var resresultat = from A in us.tbUser where A.phone.StartsWith(Txtsearch.Text) select A;
                            if (resresultat.Count() > 0)
                            {
                                Dvgusers.DataSource = resresultat.ToList();
                                label7.Visible = false;
                                break;
                            }
                            else
                            {
                                Dvgusers.DataSource = resresultat.ToList();
                                label7.Visible = true;
                                break;
                            }
                        }
                    case 5:
                        {
                            var resresultat = from A in us.tbUser where A.role.StartsWith(Txtsearch.Text) select A;
                            if (resresultat.Count() > 0)
                            {
                                Dvgusers.DataSource = resresultat.ToList();
                                label7.Visible = false;
                                break;
                            }
                            else
                            {
                                Dvgusers.DataSource = resresultat.ToList();
                                label7.Visible = true;
                                break;
                            }
                        }

                }
            }
        }
    }
}
