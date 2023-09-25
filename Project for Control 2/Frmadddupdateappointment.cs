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
    public partial class Frmadddupdateappointment : Form
    {
        GESTION_DENTAL_CLINICEntities2 dc;
        public Frmadddupdateappointment()
        {
            InitializeComponent();
        }
        public  void getdatacmbbox()
        {
            dc = new  GESTION_DENTAL_CLINICEntities2();
            cmbdentistfullname.DataSource = (from A in dc.Dentist select new { A.DentistID, A.DentistFullName }).Distinct().ToList();
            cmbdentistfullname.DisplayMember = "DentistFullName";
            cmbdentistfullname.ValueMember = "DentistID";

           
            cmbpatienfullname.DataSource = (from A in dc.Patient select new { A.PatientID, A.PatientFullName }).Distinct().ToList();
            cmbpatienfullname.DisplayMember = "PatientFullName";
            cmbpatienfullname.ValueMember = "PatientID";
            var source = (from a in dc.Patient select new { a.PatientFullName }).ToList();
            foreach(var sources in source)
            {
                cmbpatienfullname.AutoCompleteCustomSource.Add(sources.PatientFullName);

            }
         

        }

        private void Frmadddupdateappointment_Load(object sender, EventArgs e)
        {

            if (label3.Text == "ADD New Appointment")
            {
                getdatacmbbox();
                cmbremained.SelectedIndex = 0;
                cmbremained.Enabled = false;
                cmbdentistfullname.SelectedIndex = -1;
                cmbpatienfullname.SelectedIndex = -1;
            }
            else
            {
                
                cmbremained.Enabled = true;
            }
            label3.Select();
            dateappointment.Region = new Region(new Rectangle(3, 3, dateappointment.Width - 3, dateappointment.Height - 7));
            cmbpatienfullname.Region = new Region(new Rectangle(3, 3, cmbpatienfullname.Width - 3, cmbpatienfullname.Height - 7));
            cmbdentistfullname.Region = new Region(new Rectangle(3, 3, cmbpatienfullname.Width - 3, cmbpatienfullname.Height - 7));
            cmbremained.Region= new Region(new Rectangle(3, 3, cmbpatienfullname.Width - 3, cmbpatienfullname.Height - 7));
          

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbpatienfullname_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbdentistfullname_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        int IDDENTIST;
        int IDpatient;
        private void btnadddappointment_Click(object sender, EventArgs e)
        {
            List<Control> liste = new List<Control>();
            int id = 0;
            int comp = 0;
            liste.Add(cmbremained); liste.Add(cmbpatienfullname); liste.Add(cmbdentistfullname);liste.Add(txtHourappointment);
            while (id < liste.Count)
            {
                if ( liste[id].Text == "" )
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

            if (txtHourappointment.Text.Trim().Length == 5)
            {
                if (teste() && comp == 0)
                {
                    if (btnadddappointment.Text == "Add Appointment")
                    {
                        try
                        {
                            dc = new GESTION_DENTAL_CLINICEntities2();
                            
                            DateTime X = DateTime.Parse(dateappointment.Value.ToShortDateString());
                            if (cmbdentistfullname.SelectedValue == null )
                            {

                                errorProvider1.SetError(cmbdentistfullname, "chose a valide dentist");
                                if (cmbpatienfullname.SelectedValue == null)
                                {
                                    errorProvider1.SetError(cmbpatienfullname, "chose a valide Patient");

                                }
                            }
                            else
                            {
                                IDDENTIST = int.Parse(cmbdentistfullname.SelectedValue.ToString());
                                 IDpatient = int.Parse(cmbpatienfullname.SelectedValue.ToString());
                            
                                errorProvider1.SetError(cmbdentistfullname, "");
                                errorProvider1.SetError(cmbpatienfullname, "");


                                if (dc.Appointment.SingleOrDefault(A => A.AppointmentDate == X && A.AppointmentHour == txtHourappointment.Text && A.DentistID == IDDENTIST) == null)
                                {
                                    errorProvider1.SetError(cmbdentistfullname, "");

                                    Appointment a = new Appointment();
                                    a.AppointmentDate = dateappointment.Value;
                                    a.AppointmentHour = txtHourappointment.Text;
                                    a.Remained = cmbremained.Text;
                                    a.DentistID = IDDENTIST;
                                    a.PatientID = IDpatient;
                                    dc.Appointment.Add(a);
                                    dc.SaveChanges();
                                    Cos c = new Cos();
                                    c.label1.Text = "Appointment Added successfully";
                                    c.button1.Text = "OK";
                                    c.Closed += (s, args) => this.Close();
                                    c.ShowDialog();



                                }
                                else
                                {
                                    Cos c = new Cos();
                                    c.label1.Font = new Font("Poppins ExtraBold", 11, FontStyle.Bold);
                                    c.label1.Text = "already exists an appointment with this time";
                                    c.button1.Text = "OK";
                                    c.ShowDialog();


                                }
                        }

                    }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                    }
                    else
                    {
                        dc = new GESTION_DENTAL_CLINICEntities2();
                        DateTime X = DateTime.Parse(dateappointment.Value.ToShortDateString());
                        if (dc.Appointment.SingleOrDefault(A => A.AppointmentDate == X && A.AppointmentHour == txtHourappointment.Text && A.AppointmentID!=Appointmentcs.IDappointment) == null)
                        {
                            Appointment Obj = new Appointment();
                            Obj.AppointmentID = Appointmentcs.IDappointment;
                            Obj = dc.Appointment.SingleOrDefault(Ap => Ap.AppointmentID == Obj.AppointmentID);
                            Obj.AppointmentDate = dateappointment.Value;
                            Obj.AppointmentHour = txtHourappointment.Text;
                            Obj.Remained = cmbremained.Text;
                            Obj.DentistID = int.Parse(cmbdentistfullname.SelectedValue.ToString());
                            Obj.PatientID = int.Parse(cmbpatienfullname.SelectedValue.ToString());
                            dc.SaveChanges();
                            Cos c = new Cos();
                            c.label1.Text = "Appointment Updated successfully";
                            c.button1.Text = "OK";
                            c.Closed += (s, args) => this.Close();
                            c.ShowDialog();
                        }
                        else
                        {
                            Cos c = new Cos();
                            c.label1.Font = new Font("Poppins ExtraBold", 11, FontStyle.Bold);
                            c.label1.Text = "already exists an appointment with this time";
                            c.button1.Text = "OK";
                            c.ShowDialog();


                        }



                    }
                }

            }
            else
            {
                errorProvider1.SetError(txtHourappointment, "required field");

            }
          
        }

        private void txtHourappointment_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
         bool teste()
         {
            
            if (int.Parse(txtHourappointment.Text[0].ToString()+txtHourappointment.Text[1].ToString())<23  && int.Parse(txtHourappointment.Text[0].ToString() + txtHourappointment.Text[1].ToString())>0)
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
        
        private void txtHourappointment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}