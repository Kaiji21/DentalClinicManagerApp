using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_for_Control_2
{
    public partial class Appointmentcs : Form
    {
        GESTION_DENTAL_CLINICEntities2 dc;
        public Appointmentcs()
        {
            InitializeComponent();
        }
        void getdadashboarddata()
        {
            dc = new GESTION_DENTAL_CLINICEntities2();
            DateTime Datetoday = DateTime.Now.Date;

            Dvgappointment.DataSource = (from A in dc.Appointment select new { A.AppointmentID, A.AppointmentDate, A.AppointmentHour, A.Remained,A.DentistID,A.PatientID ,A.Patient.PatientFullName, A.Dentist.DentistFullName }).ToList();
            lbtotalday.Text = (from A in dc.Appointment where A.AppointmentDate == Datetoday select A).Count().ToString();
            lbtotalapmonth.Text = (from A in dc.Appointment where SqlFunctions.DatePart("MONTH", A.AppointmentDate) == SqlFunctions.DatePart("MONTH", SqlFunctions.GetDate()) select A).Count().ToString();
            lbtotalapyear.Text = (from A in dc.Appointment where SqlFunctions.DatePart("Year", A.AppointmentDate) == SqlFunctions.DatePart("Year", SqlFunctions.GetDate()) select A).Count().ToString();

        }
        private void Appointmentcs_Load(object sender, EventArgs e)
        {
            Dvgappointment.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(232, 248, 250);
            getdadashboarddata();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void Txtsearch_TextChanged(object sender, EventArgs e)
        {
            dc = new GESTION_DENTAL_CLINICEntities2();
            if (cmbsearch.SelectedIndex == -1)
            {

                var resresultat = from A in dc.Appointment where A.Patient.PatientFullName.Contains(Txtsearch.Text) select new { A.AppointmentID, A.AppointmentDate, A.AppointmentHour, A.Remained, A.Patient.PatientFullName, A.Dentist.DentistFullName };
                if (resresultat.Count() > 0)
                {
                    Dvgappointment.DataSource = resresultat.ToList() ;
                    label7.Visible = false;
                }
                else
                {
                    Dvgappointment.DataSource = resresultat.ToList();
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
                                int appID = Txtsearch.Text == "" ? 0 : int.Parse(Txtsearch.Text);

                                var resresultat = from A in dc.Appointment where A.AppointmentID == appID select new { A.AppointmentID, A.AppointmentDate, A.AppointmentHour, A.Remained, A.Patient.PatientFullName, A.Dentist.DentistFullName };
                                if (resresultat.Count() > 0)
                                {
                                    Dvgappointment.DataSource = resresultat.ToList();
                                    label7.Visible = false;
                                    
                                }
                                else
                                {
                                    Dvgappointment.DataSource = resresultat.ToList();
                                    label7.Visible = true;
                                    
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("You can not insert a charachter when your are searching by ID (Number)","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                            break;


                        }
                    case 1:
                        {
                            var resresultat = from A in dc.Appointment where A.Remained.StartsWith(Txtsearch.Text) select new { A.AppointmentID, A.AppointmentDate, A.AppointmentHour, A.Remained, A.Patient.PatientFullName, A.Dentist.DentistFullName };
                            if (resresultat.Count() > 0)
                            {
                                Dvgappointment.DataSource = resresultat.ToList();
                                label7.Visible = false;
                                break;
                            }
                            else
                            {
                                Dvgappointment.DataSource = resresultat.ToList();
                                label7.Visible = true;
                                break;
                            }
                        }
                        case 2:
                        {
                            var resresultat = from A in dc.Appointment where A.Patient.PatientFullName.Contains(Txtsearch.Text) select new { A.AppointmentID, A.AppointmentDate, A.AppointmentHour, A.Remained, A.Patient.PatientFullName, A.Dentist.DentistFullName };
                            if (resresultat.Count() > 0)
                            {
                                Dvgappointment.DataSource = resresultat.ToList();
                                label7.Visible = false;
                                break;
                            }
                            else
                            {
                                Dvgappointment.DataSource = resresultat.ToList();
                                label7.Visible = true;
                                break;
                            }
                        }
                       case 3:
                       {
                            var resresultat = from A in dc.Appointment where A.Dentist.DentistFullName.Contains(Txtsearch.Text) select new { A.AppointmentID, A.AppointmentDate, A.AppointmentHour, A.Remained, A.Patient.PatientFullName, A.Dentist.DentistFullName };
                            if (resresultat.Count() > 0)
                            {
                                Dvgappointment.DataSource = resresultat.ToList();
                                label7.Visible = false;
                                break;
                            }
                            else
                            {
                                Dvgappointment.DataSource = resresultat.ToList();
                                label7.Visible = true;
                                break;
                            }
                        }
                        
                }  
            }
           
        }
        byte[] data;
        private void button1_Click(object sender, EventArgs e)
        {
            Frmadddupdateappointment f = new Frmadddupdateappointment();
            f.ShowDialog();
            getdadashboarddata();
        }
        public static int IDappointment;
        private void Dvgappointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dc = new GESTION_DENTAL_CLINICEntities2();
            if (e.ColumnIndex == 1 && e.RowIndex>=0)
            {
                if (Dvgappointment.CurrentRow != null)
                {
                    Frmadddupdateappointment f = new Frmadddupdateappointment();
                    f.label3.Text = "Update Appointment";
                    f.btnadddappointment.Text = "Update Appointment";
                    f.dateappointment.Text = Dvgappointment.CurrentRow.Cells["AppointmentDate"].Value.ToString();
                    f.txtHourappointment.Text= Dvgappointment.CurrentRow.Cells["AppointmentHour"].Value.ToString();
                    f.cmbremained.Text= Dvgappointment.CurrentRow.Cells["Remained"].Value.ToString();
                    f.getdatacmbbox();
                     IDappointment= int.Parse(Dvgappointment.CurrentRow.Cells["AppointmentID"].Value.ToString());
                    f.cmbdentistfullname.SelectedValue = int.Parse(Dvgappointment.CurrentRow.Cells["DentistID"].Value.ToString());
                    f.cmbpatienfullname.SelectedValue = int.Parse(Dvgappointment.CurrentRow.Cells["PatientID"].Value.ToString());
                    f.ShowDialog();
                    getdadashboarddata();

                }
            }
            else if (e.ColumnIndex == 2 && e.RowIndex>=0)
            {
                if (Dvgappointment.CurrentRow != null)
                {
                    if (MessageBox.Show("Are you shure that you wanna delete this Appointment?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Appointment obj = new Appointment();
                            obj.AppointmentID = int.Parse(Dvgappointment.CurrentRow.Cells["AppointmentID"].Value.ToString());
                            obj = dc.Appointment.SingleOrDefault(Appointment => Appointment.AppointmentID == obj.AppointmentID);
                            dc.Appointment.Remove(obj);
                            Cos c = new Cos();
                            c.label1.Text = "Deleted successfully ";
                            c.button1.Text = "OK";
                            c.ShowDialog();
                            dc.SaveChanges();
                            
                            getdadashboarddata();
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
            if (e.ColumnIndex ==3 && e.RowIndex >= 0)
            {
                Clininc c = ClinincForm.clinics();
                Report rpdentist = new Report();
                rpdentist.reportfile.LocalReport.ReportEmbeddedResource = "Project_for_Control_2.rapportappointment.rdlc";
                //rpdentist.reportfile.LocalReport.ReportEmbeddedResource = "Project_for_Control_2.rapportappointment.rdlc";
                ReportParameter clinicname = new ReportParameter("Clinicname", c.Clininc_Name);
                string imgclinic = Convert.ToBase64String(c.Clinic_Image);
                ReportParameter clinicimg = new ReportParameter("clinicimg", imgclinic);
                ReportParameter appid = new ReportParameter("AppointmentID", Dvgappointment.CurrentRow.Cells["AppointmentID"].Value.ToString());
                ReportParameter appdate = new ReportParameter("Appointmentdate", Convert.ToDateTime(Dvgappointment.CurrentRow.Cells["AppointmentDate"].Value).ToLongDateString());
                ReportParameter hour = new ReportParameter("AppointmentHour", Dvgappointment.CurrentRow.Cells["AppointmentHour"].Value.ToString());
                ReportParameter remained = new ReportParameter("remained", Dvgappointment.CurrentRow.Cells["Remained"].Value.ToString());
                ReportParameter patienfullname = new ReportParameter("patientfullname", Dvgappointment.CurrentRow.Cells["PatientFullname"].Value.ToString());
                ReportParameter dentistfullname = new ReportParameter("dentistfullname", Dvgappointment.CurrentRow.Cells["DentistFullname"].Value.ToString());
                string forqodeqr = $"Appointment ID = {Dvgappointment.CurrentRow.Cells["AppointmentID"].Value.ToString()}\nAppointment Date ={Convert.ToDateTime(Dvgappointment.CurrentRow.Cells["AppointmentDate"].Value).ToLongDateString()}\nAppointment Hour={Dvgappointment.CurrentRow.Cells["AppointmentHour"].Value.ToString()}\nRemained={Dvgappointment.CurrentRow.Cells["Remained"].Value.ToString()}\nPatient Full Name={Dvgappointment.CurrentRow.Cells["PatientFullname"].Value.ToString()}\nDentist Full Name={ Dvgappointment.CurrentRow.Cells["DentistFullname"].Value.ToString()}";
                QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
                QRCoder.QRCodeData qRCodeData  =qr.CreateQrCode(forqodeqr, QRCoder.QRCodeGenerator.ECCLevel.Q);
                QRCoder.QRCode qrcode = new QRCoder.QRCode(qRCodeData);
                Image img = qrcode.GetGraphic(5);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    img.Save(memoryStream, ImageFormat.Png);
                    data = memoryStream.ToArray();
                }
                ReportParameter codeqr = new ReportParameter("codeqrimg",Convert.ToBase64String(data));
                rpdentist.reportfile.LocalReport.SetParameters(new ReportParameter[] { clinicname, clinicimg, appid, appdate, hour, remained, patienfullname, dentistfullname,codeqr });
                rpdentist.reportfile.RefreshReport();
                rpdentist.ShowDialog();
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            dc = new GESTION_DENTAL_CLINICEntities2();
            var list = (from A in dc.Appointment select A).ToList();
            Report rpdentist = new Report();
            rpdentist.reportfile.LocalReport.ReportEmbeddedResource = "Project_for_Control_2.Allapointment.rdlc";
            rpdentist.reportfile.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", list));
            Clininc c = ClinincForm.clinics();
            ReportParameter clinicname = new ReportParameter("clinicname", c.Clininc_Name);
            string imgclinic = Convert.ToBase64String(c.Clinic_Image);
            ReportParameter clinicimg = new ReportParameter("Clinicimg", imgclinic);
            ReportParameter datenow = new ReportParameter("datnow", DateTime.Now.ToShortDateString());
            rpdentist.reportfile.LocalReport.SetParameters(new ReportParameter[] { clinicname, clinicimg, datenow });
            rpdentist.reportfile.RefreshReport();
            rpdentist.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
