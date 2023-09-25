using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_for_Control_2
{
    public partial class FrmAppointmentsDetails : Form
    {
        public FrmAppointmentsDetails()
        {
            InitializeComponent();
        }
        GESTION_DENTAL_CLINICEntities2 dc;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmAppointmentsDetails_Load(object sender, EventArgs e)
        {
            getdashboarddata();

        }
 

        private void getdashboarddata()
        {
            label3.Text = "";
            dc = new GESTION_DENTAL_CLINICEntities2();
            lbfullname.Text = LoginForm.Fullname;
            var appdetailsid = dc.AppointmentDetails.Select(a => a.AppointmentID).ToList();
            var teste = (from A in dc.Appointment where A.Dentist.DentistFullName == LoginForm.Fullname && !appdetailsid.Contains(A.AppointmentID) select new { A.AppointmentID }).ToList().Count();
            lbstillhave.Text = teste.ToString();
            var appointmentdetails = from Ap in dc.AppointmentDetails
                                     where Ap.Appointment.Dentist.DentistFullName == LoginForm.Fullname
                                     select new
                                     {
                                         Ap.AppointmentID,
                                         Ap.Appointment.Dentist.DentistFullName,
                                         Ap.Appointment.Patient.PatientFullName,
                                         Ap.TreatmentID,
                                         Ap.TreatmentDetails,
                                         Ap.Treatment.TreatmentName,

                                     };
            string date = DateTime.Now.ToShortDateString();
            var TESTE = (from A in dc.Appointment where A.Dentist.DentistFullName == LoginForm.Fullname && SqlFunctions.DateDiff("Day", A.AppointmentDate, date) > 1 && !appdetailsid.Contains(A.AppointmentID) select new { A.AppointmentID }).ToList(); ;
            foreach (var id in TESTE)
            {
                label3.Text += id.ToString()+"\n"; 
            }
            
            Dvgappointmentdetails.DataSource = appointmentdetails.ToList();
        
        }

        private void lbfullname_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAddupdateAPPdetails f = new FrmAddupdateAPPdetails();
            f.ShowDialog();
            getdashboarddata();
        }

        private void FrmAppointmentsDetails_Click(object sender, EventArgs e)
        {
            pictureBox1.Select();
        }
         public static int APPID;
        private void Dvgappointmentdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==1 &&   e.RowIndex >= 0)
            {
                FrmAddupdateAPPdetails f = new FrmAddupdateAPPdetails();
                f.label3.Location = new Point(30, 9);
                f.label3.Text = "Update Appointment Details";
                f.btnaddappdetails.Text = "Update Appointment Details";
                f.getcombodata();
                f.cmbpattientfullname.Text = Dvgappointmentdetails.CurrentRow.Cells["patientfullname"].Value.ToString();
                APPID = int.Parse(Dvgappointmentdetails.CurrentRow.Cells["AppointmentID"].Value.ToString());
                f.cmbTreatement.Text = Dvgappointmentdetails.CurrentRow.Cells["treatementname"].Value.ToString();
                f.cmbAppointmentId.Text = Dvgappointmentdetails.CurrentRow.Cells["AppointmentID"].Value.ToString();
                f.txttreatedtails.Text= Dvgappointmentdetails.CurrentRow.Cells["Treatmentdetails"].Value.ToString();
                f.comboBox3.SelectedIndex = 0;
                f.cmbAppointmentId.Enabled = false;
                f.cmbpattientfullname.Enabled = false;
                f.txttreatedtails.ForeColor = Color.Black;
                f.ShowDialog();
                getdashboarddata();
            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                if (Dvgappointmentdetails.CurrentRow != null)
                {
                    if (MessageBox.Show("Are you shure that you wanna delete this Appointment Details?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            AppointmentDetails obj = new AppointmentDetails();
                            obj.AppointmentID = int.Parse(Dvgappointmentdetails.CurrentRow.Cells["AppointmentID"].Value.ToString());
                            obj.TreatmentID = int.Parse(Dvgappointmentdetails.CurrentRow.Cells["TreatmentID"].Value.ToString());
                            obj = dc.AppointmentDetails.SingleOrDefault(AppointmentDT => AppointmentDT.AppointmentID == obj.AppointmentID && AppointmentDT.TreatmentID== obj.TreatmentID);
                            dc.AppointmentDetails.Remove(obj);
                            Cos c = new Cos();
                            c.label1.Text = "Deleted successfully ";
                            c.button1.Text = "OK";
                            c.ShowDialog();
                            dc.SaveChanges();

                            getdashboarddata();
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
    }
}
