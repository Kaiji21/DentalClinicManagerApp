using Microsoft.Reporting.WinForms;
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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }
        GESTION_DENTAL_CLINICEntities2 dc;
        void loaddata()
        {
            DateTime todaydate = DateTime.Now.Date;
            dc = new GESTION_DENTAL_CLINICEntities2();
            lbtotalapppayer.Text = (from P in dc.Payment where P.AppointmentID == P.Appointment.AppointmentID select P).Count().ToString() + " / " + (from A in dc.Appointment select A).Count().ToString();
            var AppointmentID = dc.Payment.Select(p => p.AppointmentID).ToList();
            var Appointment = dc.Appointment.Where(a => !AppointmentID.Contains(a.AppointmentID)).ToList().Count();
            lbtotalappnonpayer.Text = Appointment.ToString() + " / " + (from A in dc.Appointment select A).Count().ToString();
            int teste = DateTime.Today.Day;
            Dvgpayement.DataSource = (from Pa in dc.Payment select new {Pa.PAyementID,Pa.AppointmentID,Pa.Appointment.Patient.PatientFullName,Pa.Appointment.Dentist.DentistFullName,Pa.PaymentMethod, Pa.Total_Price,Pa.payment_Date }).ToList();
            lbtotaltodaypayement.Text = (from P in dc.Payment where P.payment_Date.Value.Day ==teste  select new { P.PAyementID }).Count().ToString();
        }
        private void frmPayment_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public static int IDpayement;
        private void Dvgpayement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                Frmaddupdatepayement f = new Frmaddupdatepayement();
                f.label3.Text = "Update Payement";
                f.bntaddpayement.Text = "Update Payement";
                IDpayement = int.Parse(Dvgpayement.CurrentRow.Cells["PAyementID"].Value.ToString());
                f.comboBox2.Text = Dvgpayement.CurrentRow.Cells["PayementMethod"].Value.ToString();
                f.getcombodata();
                f.cmbpattientfullname.Text= Dvgpayement.CurrentRow.Cells["PatientFullName"].Value.ToString();
                f.cmbappointment.Text = Dvgpayement.CurrentRow.Cells["AppointmentID"].Value.ToString();
                f.txttotalprice.Text = Dvgpayement.CurrentRow.Cells["TotalPrice"].Value.ToString();
                f.txttotalprice.ForeColor = Color.Black;
                f.cmbpattientfullname.Enabled = false;
                f.cmbappointment.Enabled = false;
                f.ShowDialog();
                loaddata();

            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                if (Dvgpayement.CurrentRow != null)
                {

                    if (MessageBox.Show("Are you shure that you wanna delete this Payment?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            dc = new GESTION_DENTAL_CLINICEntities2();
                            Payment obj = new Payment();
                            obj.PAyementID = int.Parse(Dvgpayement.CurrentRow.Cells["PAyementID"].Value.ToString());
                            obj = dc.Payment.SingleOrDefault(payemment => payemment.PAyementID == obj.PAyementID);
                            dc.Payment.Remove(obj);
                            Cos c = new Cos();
                            c.label1.Text = "Deleted successfully ";
                            c.button1.Text = "OK";
                            c.ShowDialog();
                            dc.SaveChanges();

                            loaddata();
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
            else if (e.ColumnIndex==3 && e.RowIndex>=0)
            {
                dc = new GESTION_DENTAL_CLINICEntities2();
                Clininc c = ClinincForm.clinics();
                Report rppayement = new Report();
                rppayement.reportfile.LocalReport.ReportEmbeddedResource = "Project_for_Control_2.payement.rdlc";
                ReportParameter clinicname = new ReportParameter("clinicname", c.Clininc_Name);
                string imgclinic = Convert.ToBase64String(c.Clinic_Image);
                string fullname = Dvgpayement.CurrentRow.Cells["PatientFullName"].Value.ToString();
                Patient p = dc.Patient.SingleOrDefault(P => P.PatientFullName == fullname);
                ReportParameter clinicimg = new ReportParameter("clinicimg", imgclinic);
                ReportParameter patientID = new ReportParameter("patientID", p.PatientID.ToString());
                ReportParameter patientfullname = new ReportParameter("patientfullname", p.PatientFullName );
                ReportParameter patientphone = new ReportParameter("patientphone", p.Phone) ;
                ReportParameter patientemail = new ReportParameter("patientemail", p.Email == null ? "  ---------- " : p.Email) ;
                ReportParameter patientaddress = new ReportParameter("patientaddress", p.Adress==null? "  ---------- " : p.Adress );
                ReportParameter patientgender = new ReportParameter("patientgender", p.Gender);
                ReportParameter patientallergis = new ReportParameter("patientallergis", p.Allergies==null? "  ---------- ":p.Allergies);
                ReportParameter payementid = new ReportParameter("payementid", Dvgpayement.CurrentRow.Cells["PAyementID"].Value.ToString());
                ReportParameter paymentdate = new ReportParameter("payementdate", Dvgpayement.CurrentRow.Cells["PayementDate"].Value.ToString());
                ReportParameter totalprice = new ReportParameter("totalpayemen", Dvgpayement.CurrentRow.Cells["TotalPrice"].Value.ToString());
                ReportParameter payementmethode = new ReportParameter("payementmethode", Dvgpayement.CurrentRow.Cells["PayementMethod"].Value.ToString());
                int Appid = int.Parse(Dvgpayement.CurrentRow.Cells["AppointmentID"].Value.ToString());
                ReportParameter appID = new ReportParameter("appID", Appid.ToString());
                var list = (from A in dc.AppointmentDetails where A.AppointmentID == Appid select new {A.Appointment.AppointmentDate,A.Appointment.AppointmentHour,A.Appointment.Remained,A.Treatment.TreatmentName,A.TreatmentDetails }).ToList();
                ReportParameter traitementname = new ReportParameter("apptrname", list[0].TreatmentName);
                ReportParameter appdate = new ReportParameter("Appdate", list[0].AppointmentDate.ToShortDateString());
                ReportParameter apphour = new ReportParameter("apphour", list[0].AppointmentHour);
                ReportParameter appremaind = new ReportParameter("appremained", list[0].Remained);
                ReportParameter traitdetails = new ReportParameter("apptreaitmendesc", list[0].TreatmentDetails);


                rppayement.reportfile.LocalReport.SetParameters(new ReportParameter[] { clinicimg, clinicname, patientID, patientfullname, patientphone, patientemail, patientaddress, patientgender, patientallergis, payementid, payementmethode, paymentdate, totalprice, appID,traitdetails,appdate,apphour,traitementname,appremaind });
                rppayement.reportfile.RefreshReport();
                rppayement.ShowDialog();




            }
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            Frmaddupdatepayement f = new Frmaddupdatepayement();
            f.ShowDialog();
            loaddata();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lbtotalappnonpayer_Click(object sender, EventArgs e)
        {

        }

        private void lbtotaltodaypayement_Click(object sender, EventArgs e)
        {

        }

        private void lbtotalapppayer_Click(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            dc = new GESTION_DENTAL_CLINICEntities2();
            var list = dc.Payment.ToList();
            Report rpdentist = new Report();
            rpdentist.reportfile.LocalReport.ReportEmbeddedResource = "Project_for_Control_2.allpayement.rdlc";
            rpdentist.reportfile.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", list));
            Clininc c = ClinincForm.clinics();
            ReportParameter clinicname = new ReportParameter("clinicname", c.Clininc_Name);
            string imgclinic = Convert.ToBase64String(c.Clinic_Image);
            ReportParameter clinicimg = new ReportParameter("imgclinic", imgclinic);
            ReportParameter datenow = new ReportParameter("datnow", DateTime.Now.ToShortDateString());
            rpdentist.reportfile.LocalReport.SetParameters(new ReportParameter[] { clinicname, clinicimg, datenow });
            rpdentist.reportfile.RefreshReport();
            rpdentist.ShowDialog();

        }

        private void Txtsearch_TextChanged(object sender, EventArgs e)
        {
            dc = new GESTION_DENTAL_CLINICEntities2();
            if (cmbsearch.SelectedIndex == -1)
            {

                var resresultat = from Pa in dc.Payment where Pa.Appointment.Patient.PatientFullName.Contains(Txtsearch.Text) select new { Pa.PAyementID, Pa.AppointmentID, Pa.Appointment.Patient.PatientFullName, Pa.Appointment.Dentist.DentistFullName, Pa.PaymentMethod, Pa.Total_Price, Pa.payment_Date };
                if (resresultat.Count() > 0)
                {
                    Dvgpayement.DataSource = resresultat.ToList();
                    label7.Visible = false;
                }
                else
                {
                    Dvgpayement.DataSource = resresultat.ToList();
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
                                if (Txtsearch.Text.Trim() == "")
                                {
                                    loaddata();
                                }
                                else
                                {
                                    int payeID = Txtsearch.Text == "" ? 0 : int.Parse(Txtsearch.Text);
                                    var resresultat = from Pa in dc.Payment where Pa.PAyementID == payeID select new { Pa.PAyementID, Pa.AppointmentID, Pa.Appointment.Patient.PatientFullName, Pa.Appointment.Dentist.DentistFullName, Pa.PaymentMethod, Pa.Total_Price, Pa.payment_Date };

                                    if (resresultat.Count() > 0)
                                    {
                                        Dvgpayement.DataSource = resresultat.ToList();
                                        label7.Visible = false;

                                    }
                                    else
                                    {
                                        Dvgpayement.DataSource = resresultat.ToList();
                                        label7.Visible = true;

                                    }
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
                            try
                            {
                                if (Txtsearch.Text.Trim() == "")
                                {
                                    loaddata();
                                }
                                else
                                {
                                    int payeID = Txtsearch.Text.Trim() == "" ? 0 : int.Parse(Txtsearch.Text);
                                    var resresultat = from Pa in dc.Payment where Pa.AppointmentID == payeID select new { Pa.PAyementID, Pa.AppointmentID, Pa.Appointment.Patient.PatientFullName, Pa.Appointment.Dentist.DentistFullName, Pa.PaymentMethod, Pa.Total_Price, Pa.payment_Date };
                                    if (resresultat.Count() > 0)
                                    {
                                        Dvgpayement.DataSource = resresultat.ToList();
                                        label7.Visible = false;

                                    }
                                    else
                                    {
                                        Dvgpayement.DataSource = resresultat.ToList();
                                        label7.Visible = true;

                                    }
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("You can not insert a charachter when your are searching by ID (Number)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;


                        }
                    case 2:
                        {
                            var resresultat = from Pa in dc.Payment where Pa.Appointment.Patient.PatientFullName.Contains(Txtsearch.Text) select new { Pa.PAyementID, Pa.AppointmentID, Pa.Appointment.Patient.PatientFullName, Pa.Appointment.Dentist.DentistFullName, Pa.PaymentMethod, Pa.Total_Price, Pa.payment_Date };
                            if (resresultat.Count() > 0)
                            {
                                Dvgpayement.DataSource = resresultat.ToList();
                                label7.Visible = false;
                            }
                            else
                            {
                                Dvgpayement.DataSource = resresultat.ToList();
                                label7.Visible = true;
                            }
                            break;
                        }
                    case 3:
                        {
                            var resresultat = from Pa in dc.Payment where Pa.Appointment.Dentist.DentistFullName.Contains(Txtsearch.Text) select new { Pa.PAyementID, Pa.AppointmentID, Pa.Appointment.Patient.PatientFullName, Pa.Appointment.Dentist.DentistFullName, Pa.PaymentMethod, Pa.Total_Price, Pa.payment_Date };
                            if (resresultat.Count() > 0)
                            {
                                Dvgpayement.DataSource = resresultat.ToList();
                                label7.Visible = false;
                            }
                            else
                            {
                                Dvgpayement.DataSource = resresultat.ToList();
                                label7.Visible = true;
                            }
                            break;
                        }
                    case 4:
                        {
                            var resresultat = from Pa in dc.Payment where Pa.PaymentMethod.StartsWith(Txtsearch.Text) select new { Pa.PAyementID, Pa.AppointmentID, Pa.Appointment.Patient.PatientFullName, Pa.Appointment.Dentist.DentistFullName, Pa.PaymentMethod, Pa.Total_Price, Pa.payment_Date };
                            if (resresultat.Count() > 0)
                            {
                                Dvgpayement.DataSource = resresultat.ToList();
                                label7.Visible = false;
                            }
                            else
                            {
                                Dvgpayement.DataSource = resresultat.ToList();
                                label7.Visible = true;
                            }
                            break;
                        }
                }
       }      }

        private void cmbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
