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
    public partial class Frmaddupdatepayement : Form
    {
        GESTION_DENTAL_CLINICEntities2 dc;
        public Frmaddupdatepayement()
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
        public void getcombodata()
        {
            dc = new GESTION_DENTAL_CLINICEntities2();
            cmbpattientfullname.SelectedIndexChanged -= cmbpattientfullname_SelectedIndexChanged;
            cmbpattientfullname.DataSource = (from A in dc.Appointment select new { A.PatientID, A.Patient.PatientFullName }).Distinct().ToList();
            cmbpattientfullname.DisplayMember = "PatientFullName";
            cmbpattientfullname.ValueMember = "A.PatientID";
            cmbpattientfullname.SelectedIndexChanged += cmbpattientfullname_SelectedIndexChanged;

        }
        private void Frmaddupdatepayement_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 11, 11));
            if (label3.Text== "Add New Payement")
            {
                getcombodata();
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
                var apppayement = dc.Payment.Select(a => a.AppointmentID).ToList();
                int IDpatient = int.Parse(cmbpattientfullname.SelectedValue.ToString());
                var appdateillist = dc.AppointmentDetails.Select(a => a.AppointmentID).ToList();
                var teste = (from A in dc.Appointment where A.PatientID == IDpatient && !apppayement.Contains(A.AppointmentID) && appdateillist.Contains(A.AppointmentID) select new { A.AppointmentID, A }).ToList(); ;
                if (teste.Count() > 0)
                {
                    cmbappointment.SelectedIndexChanged -= cmbappointment_SelectedIndexChanged;
                    cmbappointment.DataSource = teste.ToList();
                    cmbappointment.DisplayMember = "AppointmentID";
                    cmbappointment.ValueMember = "AppointmentID";
                    cmbappointment_SelectedIndexChanged(null, null);



                }
                else
                {
                    cmbappointment.DataSource = null;
                    txttotalprice.ForeColor = Color.Gray;
                    txttotalprice.Text = "Total Price";

                }



            }
        }

        private void cmbappointment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbappointment.SelectedIndex != -1)
            {
                int APPID = int.Parse(cmbappointment.Text);
                txttotalprice.ForeColor = Color.Black;
                var price = (from A in dc.AppointmentDetails where A.AppointmentID == APPID select new { A.Treatment.TreatmentPrice }).ToList();
                txttotalprice.Text = price[0].TreatmentPrice.ToString() + " DH";
            }

        }

        private void bntaddpayement_Click(object sender, EventArgs e)
        {
            List<Control> liste = new List<Control>();
            int id = 0;
            int comp = 0;
            liste.Add(cmbappointment); liste.Add(cmbpattientfullname); liste.Add(comboBox2); liste.Add(txttotalprice);
            while (id < liste.Count)
            {
                if (liste[id].ForeColor == Color.Gray || liste[id].Text=="")
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
                    if (bntaddpayement.Text == "Add Payement")
                    {

                        dc = new GESTION_DENTAL_CLINICEntities2();
                        Payment obj = new Payment();
                        obj.AppointmentID = int.Parse(cmbappointment.Text);
                        obj.PaymentMethod = comboBox2.Text;
                        obj.payment_Date = DateTime.Now;
                        obj.Total_Price = decimal.Parse(txttotalprice.Text.Replace(" DH", null));
                        dc.Payment.Add(obj);
                        dc.SaveChanges();
                        Cos c = new Cos();
                        c.label1.Text = "Payement Added successfully";
                        c.button1.Text = "OK";
                        c.Closed += (s, args) => this.Close();
                        c.ShowDialog();
                    }
                    else
                    {
                        dc = new GESTION_DENTAL_CLINICEntities2();
                        Payment payment = new Payment();
                        payment.PAyementID = frmPayment.IDpayement;
                        payment = dc.Payment.SingleOrDefault(p => p.PAyementID == payment.PAyementID);
                        payment.PaymentMethod = comboBox2.Text;
                        dc.SaveChanges();
                        Cos c = new Cos();
                        c.label1.Text = "Payment Updated successfully";
                        c.button1.Text = "OK";
                        c.Closed += (s, args) => this.Close();
                        c.ShowDialog();



                    }
                }
                catch (System.Data.SqlClient.SqlException ex)
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
               

            }
           
        }
        
    }
}
