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
    public partial class FrmAddupdateAPPdetails : Form
    {
        GESTION_DENTAL_CLINICEntities2 dc;
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
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        public FrmAddupdateAPPdetails()
        {
            InitializeComponent();
        }
      public  void getcombodata()
        {
            dc = new GESTION_DENTAL_CLINICEntities2();
            cmbpattientfullname.SelectedIndexChanged -= cmbpattientfullname_SelectedIndexChanged;
            cmbpattientfullname.DataSource = (from A in dc.Appointment where A.Dentist.DentistFullName == LoginForm.Fullname select new { A.PatientID, A.Patient.PatientFullName }).Distinct().ToList();
            cmbpattientfullname.DisplayMember = "PatientFullName";
            cmbpattientfullname.ValueMember = "A.PatientID";
            cmbpattientfullname.SelectedIndexChanged += cmbpattientfullname_SelectedIndexChanged;
            cmbTreatement.DataSource = (from A in dc.Treatment select A).ToList();
            cmbTreatement.DisplayMember = "TreatmentName";
            cmbTreatement.ValueMember = "TreatmentID";





        }
        private void FrmAddupdateAPPdetails_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            dateappointment.Region = new Region(new Rectangle(3, 3, dateappointment.Width - 3, dateappointment.Height - 7));
            cmbpattientfullname.Region = new Region(new Rectangle(3, 3, cmbpattientfullname.Width - 3, cmbpattientfullname.Height - 7));
            cmbAppointmentId.Region = new Region(new Rectangle(3, 3, cmbAppointmentId.Width - 3, cmbAppointmentId.Height - 7));

            pictureBox1.Select();
            if (label3.Text == "ADD New Appointment Details")
            {
                getcombodata();
                cmbpattientfullname.SelectedIndex = -1;
                cmbTreatement.SelectedIndex = -1;
            }
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbpattientfullname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbpattientfullname.SelectedIndex != -1)
            {
                var appdetailsid = dc.AppointmentDetails.Select(a => a.AppointmentID).ToList();
                int IDpatient = int.Parse(cmbpattientfullname.SelectedValue.ToString());
                var teste = (from A in dc.Appointment where A.Dentist.DentistFullName == LoginForm.Fullname && A.PatientID == IDpatient && !appdetailsid.Contains(A.AppointmentID) select new { A.AppointmentID, A }).ToList(); ;
                if (teste.Count() > 0)
                {
                    cmbAppointmentId.DataSource = teste.ToList();
                    cmbAppointmentId.DisplayMember = "AppointmentID";
                    cmbAppointmentId.ValueMember = "AppointmentID";
                }
                else
                {
                    cmbAppointmentId.DataSource = null;

                }



            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 1)
            {
                pictureBox1.Visible = dateappointment.Visible = txtHourappointment.Visible = true;
            }
            else
            {
                pictureBox1.Visible = dateappointment.Visible = txtHourappointment.Visible = false;

            }

        }
      
        private void btnadddpatient_Click(object sender, EventArgs e)
        {
            List<Control> liste = new List<Control>();
            int id = 0;
            int comp = 0;
            liste.Add(cmbAppointmentId); liste.Add(cmbpattientfullname); liste.Add(comboBox3); liste.Add(cmbTreatement); liste.Add(txttreatedtails);
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
            if (comp == 0)
            {
                dc = new GESTION_DENTAL_CLINICEntities2();
                try
                {
                    if (btnaddappdetails.Text == "Add Appointment Details")
                    {
                        AppointmentDetails appointmentDetails = new AppointmentDetails();
                        appointmentDetails.TreatmentID = int.Parse(cmbTreatement.SelectedValue.ToString());
                        appointmentDetails.AppointmentID = int.Parse(cmbAppointmentId.Text);
                        appointmentDetails.TreatmentDetails = txttreatedtails.Text;
                        dc.AppointmentDetails.Add(appointmentDetails);
                        dc.SaveChanges();
                        dc.SaveChanges();
                        Cos c = new Cos();
                        c.label1.Text = "Appointment Details Added successfully";
                        c.button1.Text = "OK";
                        c.Closed += (s, args) => this.Close();
                        c.ShowDialog();
                        //if (comboBox3.SelectedIndex == 1)
                        //{
                        //    if (teste() && txtHourappointment.MaskFull)
                        //    {

                        //    } 
                        //}
                        

                    }
                    else
                    {

                        AppointmentDetails Obj = new AppointmentDetails();
                        Obj.AppointmentID =  FrmAppointmentsDetails.APPID ;
                        Obj = dc.AppointmentDetails.SingleOrDefault(Ap => Ap.AppointmentID == Obj.AppointmentID );
                        Obj.TreatmentID = int.Parse(cmbTreatement.SelectedValue.ToString());
                        Obj.TreatmentDetails = txttreatedtails.Text;
                        dc.SaveChanges();
                        Cos c = new Cos();
                        c.label1.Text = "Appointment Details Updated successfully";
                        c.button1.Text = "OK";
                        c.Closed += (s, args) => this.Close();
                        c.ShowDialog();
                    }
                }
                //catch (System.Data.SqlClient.SqlException ex)
                //{

                //}
                catch (Exception ex)
                {
                    Cos c = new Cos();
                    LoginForm.ERORMESSAGEBOX(c, ex.Message);
                    c.Show();

                }
            }
        }

        private void cmbTreatement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txttreatedtails_Enter(object sender, EventArgs e)
        {
            if (txttreatedtails.ForeColor != Color.Black)
            {
                txttreatedtails.Text = "";
                txttreatedtails.ForeColor = Color.Black;
            }
        }

        private void txttreatedtails_Leave(object sender, EventArgs e)
        {
            if (txttreatedtails.Text == "")
            {
                txttreatedtails.Text = "Treatement Details";
                txttreatedtails.ForeColor = Color.Gray;
            }
        }
        bool teste()
        {

            if (int.Parse(txtHourappointment.Text[0].ToString() + txtHourappointment.Text[1].ToString()) < 23 && int.Parse(txtHourappointment.Text[0].ToString() + txtHourappointment.Text[1].ToString()) > 0)
            {
                if (int.Parse(txtHourappointment.Text[3].ToString() + txtHourappointment.Text[4].ToString()) < 59 && int.Parse(txtHourappointment.Text[3].ToString() + txtHourappointment.Text[4].ToString()) > 0)
                {
                    return true;
                }
                else
                {
                    errorProvider1.SetError(txtHourappointment, "3ndk ghalat f dqayeq");
                    return false;

                }

            }
            else
            {
                errorProvider1.SetError(txtHourappointment, "3ndk ghalat f swaye3");
                return false;
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txttreatedtails_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
