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
    public partial class FrmAddupdatepatient : Form
    {

        public FrmAddupdatepatient()
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

        private void FrmAddupdatepatient_Load(object sender, EventArgs e)
        {
            pictureBox7.Select();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            cmbgender.Region = new Region(new Rectangle(3, 3, cmbgender.Width - 3, cmbgender.Height - 7));

        }

        private void FrmAddupdatepatient_Click(object sender, EventArgs e)
        {
            pictureBox7.Select();
        }

        private void txtfullname_Enter(object sender, EventArgs e)
        {
            if (txtfullname.ForeColor!= Color.Black)
            {
                txtfullname.Text = "";
                txtfullname.ForeColor = Color.Black;
            }
        }

        private void txtfullname_Leave(object sender, EventArgs e)
        {
            if (txtfullname.Text == "")
            {
                txtfullname.Text = "Patient fullname";
                txtfullname.ForeColor = Color.Gray;
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

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.ForeColor != Color.Black)
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.Black;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "Patientemail@gmail.com";
                txtemail.ForeColor = Color.Gray;
            }
        }

        private void txtaddress_Leave(object sender, EventArgs e)
        {
            if (txtaddress.Text == "")
            {
                txtaddress.Text = "Patient Address";
                txtaddress.ForeColor = Color.Gray;
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

        private void txtallergies_Leave(object sender, EventArgs e)
        {
            if (txtallergies.Text == "")
            {
                txtallergies.Text = "Patient Allergies";
                txtallergies.ForeColor = Color.Gray;
            }
            
        }

        private void txtallergies_Enter(object sender, EventArgs e)
        {
            if (txtallergies.ForeColor != Color.Black)
            {
                txtallergies.Text = "";
                txtallergies.ForeColor = Color.Black;
            }
        }

        private void btnadddentist_Click(object sender, EventArgs e)
        {
            List<Control> liste = new List<Control>();
            int id = 0;
            int comp = 0;
            liste.Add(txtfullname); liste.Add(txtphone);  liste.Add(cmbgender);
            while (id < liste.Count)
            {
                if (liste[id].ForeColor == Color.Gray || liste[id].Text == "")
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

            if(comp==0)
            {
                try
                {
                    if (btnadddpatient.Text == "Add Patient")
                    {


                        DatasetPatient.PatientRow row = Patients.ds.Patient.NewPatientRow();
                        row.PatientFullName = txtfullname.Text;
                        row.Phone = txtphone.Text;
                        row.Email = txtemail.Text == "Patientemail@gmail.com" ? null : txtemail.Text;
                        row.Adress = txtaddress.Text == "Patient Address" ? null : txtaddress.Text;
                        row.Gender = cmbgender.Text;
                        row.Allergies = txtallergies.Text == "Patient Allergies" ? null : txtallergies.Text;
                        row.Created_at = DateTime.Now;
                        Patients.ds.Patient.Rows.Add(row);
                        Patients.da.Update(Patients.ds.Patient);
                        Cos c = new Cos();
                        c.label1.Text = "Patient Added successfully";
                        c.button1.Text = "OK";
                        c.Closed += (s, args) => this.Close();
                        c.ShowDialog();


                    }
                    else
                    {
                        foreach (DataRow row in Patients.ds.Patient.Rows)
                        {


                            if (row[0].ToString() == Patients.patientID.ToString())
                            {
                                row[1] = txtfullname.Text;
                                row[2] = txtphone.Text;
                                row[3] = txtemail.Text == "Patientemail@gmail.com" ? null : txtemail.Text;
                                row[4] = txtaddress.Text == "Patient Address" ? null : txtaddress.Text;
                                row[5] = cmbgender.Text;
                                row[6] = txtallergies.Text == "Patient Allergies" ? null : txtallergies.Text;

                                Patients.da.Update(Patients.ds.Patient);
                                Cos c = new Cos();
                                c.label1.Text = "Patient Updated successfully";
                                c.button1.Text = "OK";
                                c.Closed += (s, args) => this.Close();
                                c.ShowDialog();
                                break;
                            }



                        }

                    }
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    Cos c = new Cos();
                   
                    if (ex.Message.Contains("Phone"))
                    {
                        LoginForm.ERORMESSAGEBOX(c, "Invalide Phone number");
                        c.Show();
                    }
                    else if (ex.Message.Contains("Email"))
                    {
                        LoginForm.ERORMESSAGEBOX(c, "Please enter a valide email");
                        c.Show();
                    }
                    else if (ex.Message.Contains("Gender"))
                    {
                        LoginForm.ERORMESSAGEBOX(c, "please pick a gender from the combobox");
                        c.Show();
                    }
                    else if (ex.Message.Contains("UNIQUE KEY"))
                    {
                        LoginForm.ERORMESSAGEBOX(c, "there is already a user with this name");
                        c.Show();
                    }
                    Patients.da.Fill(Patients.ds.Patient);
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

               

            }
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtfullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

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


