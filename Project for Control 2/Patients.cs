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
    public partial class Patients : Form
    {
        public static    DatasetPatient ds = new DatasetPatient();
        public static   DatasetPatientTableAdapters.PatientTableAdapter da = new DatasetPatientTableAdapters.PatientTableAdapter();
        public string For = "For Admin";
        DataSet dsd = new DataSet();
        System.Data.SqlClient.SqlDataAdapter dad;
        
        public Patients()
        {
            InitializeComponent();
        }
        void changeimg()
        {
            foreach (DataGridViewRow var in Dvgpatient.Rows)
            {
                if (var.Cells["Gender"].Value.ToString()=="male" || var.Cells["Gender"].Value.ToString() == "Male")
                {
                    var.Cells["img"].Value = Properties.Resources.male_boy_person_people_avatar_icon_159358;
                }
                else
                {
                    var.Cells["img"].Value = Properties.Resources.female_woman_avatar_people_person_white_tone_icon_159370;

                }
            }
        }
        void getdatadentist()
        {
            Dvgpatient.Columns["delete"].Visible = false;
            Dvgpatient.Columns["Edite"].Visible = false;


            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(Dentists.cs);
            dad = new System.Data.SqlClient.SqlDataAdapter($"select DentistFullName,Patient.* from Patient join Appointment  on Patient.PatientID= Appointment.PatientID join Dentist on Dentist.DentistID= Appointment.DentistID where DentistFullName='{LoginForm.Fullname}'", con);
            dad.Fill(dsd, "Dentistpatient");
            dad.Fill(dsd);
            if (dsd.Tables[0].Rows.Count > 0)
            {
                Dvgpatient.DataSource = dsd.Tables["Dentistpatient"];

            }
            else
            {
                Dvgpatient.Rows.Clear();
                label7.Visible = true;
            }
            lbtotalpatient.Text = dsd.Tables[0].Rows.Count.ToString();
            dad = new System.Data.SqlClient.SqlDataAdapter();
            foreach(DataRow row in dsd.Tables[0].Rows)
            {
                if (row[6].ToString() == "Male" || row[6].ToString() == "male")
                {
                    lbtotalmpatient.Text = (int.Parse(lbtotalmpatient.Text) + 1).ToString();
                }
                else
                {
                    lbtotalfpatient.Text = (int.Parse(lbtotalfpatient.Text) + 1).ToString();

                }
            }
            

        }
        private void Patients_Load(object sender, EventArgs e)
        {
            if (For=="For Admin")
            {
                getdataforadmin();
                changeimg();
            }
            else
            {
                getdatadentist();
                changeimg();
                cmbsearch.SelectedIndex = -1;

            }


            Dvgpatient.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(174, 238, 238);

        }

        private void getdataforadmin()
        {
            Dvgpatient.Columns["Dentistfullname"].Visible = false;
            Dvgpatient.Columns["Dentistfullname"].DataPropertyName = null;
            da.Fill(ds.Patient);
            if (ds.Patient.Count != 0)
            {
                Dvgpatient.DataSource = ds.Patient;
            }
            else
            {
                Dvgpatient.Rows.Clear();
                label7.Visible = true;

            }
            lbtotalpatient.Text = da.Totalpatient().ToString();
            lbtotalmpatient.Text = da.Totalmpatient().ToString();
            lbtotalfpatient.Text = da.Totalfpatient().ToString();
           
        }

        private void lbtotalmpatient_Click(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {

        }
        string searchby = "PatientFullName";
        void searchby1()
        {
            try
            {
                dad = new System.Data.SqlClient.SqlDataAdapter();
                dad.SelectCommand = new System.Data.SqlClient.SqlCommand($"select DentistFullName, Patient.* from Patient join Appointment  on Patient.PatientID = Appointment.PatientID join Dentist on Dentist.DentistID = Appointment.DentistID  where { searchby } like @txtsearch and DentistFullName = '{LoginForm.Fullname}'  ", new System.Data.SqlClient.SqlConnection(Dentists.cs));
                dad.SelectCommand.Parameters.AddWithValue("@txtsearch", '%' + Txtsearch.Text + '%');
                dsd.Tables[0].Rows.Clear();
                dad.Fill(dsd, "Dentistpatient");
                if (dsd.Tables["Dentistpatient"].Rows.Count > 0)
                {
                    label7.Visible = false;
                }
                else
                {
                    label7.Visible = true;
                }
                Dvgpatient.DataSource = dsd.Tables["Dentistpatient"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
        private void Txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (For!= "For Admin")
            {
                if (cmbsearch.SelectedIndex == -1)
                {
                    searchby1();
   
                }

               else if (cmbsearch.SelectedIndex <= 1)
                {
                    searchby = cmbsearch.Text.Replace(" ", "");
                    searchby1();


                }
                else
                {
                    searchby = cmbsearch.Text.Replace(" ", ".");
                    searchby1();

                }

            }
            else
            {
                Dvgpatient.DataSource = da.GetDataBy3(Txtsearch.Text + '%');
                
                if (Dvgpatient.Rows.Count == 0)
                {
                    label7.Visible = true;
                }
                else
                {
                    label7.Visible = false;
                }
            }
        }
        public static int patientID;
        private void Dvgpatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (Dvgpatient.CurrentRow != null)
                {
                    FrmAddupdatepatient f = new FrmAddupdatepatient();
                    f.label3.Text = "Update Patient";
                    f.label3.Location = new Point(107, 23);
                    f.btnadddpatient.Text = "Update Patient";
                    foreach (Control var in f.panel1.Controls)
                    {
                        if (var is TextBox)
                        {
                            ((TextBox)var).ForeColor = Color.Black;
                        }
                    }
                    f.txtphone.ForeColor = Color.Black;
                    patientID = int.Parse(Dvgpatient.CurrentRow.Cells["Patientidd"].Value.ToString());
                    f.txtfullname.Text = Dvgpatient.CurrentRow.Cells["patientfullname"].Value.ToString();
                    if (Dvgpatient.CurrentRow.Cells["Adress"].Value!= DBNull.Value)
                    {
                        f.txtaddress.Text = Dvgpatient.CurrentRow.Cells["Adress"].Value.ToString();

                    }
                    else
                    {
                        f.txtaddress.Text = "Patient Address";
                        f.txtaddress.ForeColor = Color.Gray;
                    }

                    //f.txtaddress.Text= Dvgpatient.CurrentRow.Cells["Adress"].Value.ToString();
                    f.txtemail.Text = Dvgpatient.CurrentRow.Cells["email"].Value != DBNull.Value ? Dvgpatient.CurrentRow.Cells["email"].Value.ToString() : f.txtemail.Text = "Patientemail@gmail.com" ;
                    f.txtemail.ForeColor = f.txtemail.Text == "Patientemail@gmail.com" ? Color.Gray : Color.Black;
                    f.txtphone.Text = Dvgpatient.CurrentRow.Cells["phone"].Value.ToString();
                    f.cmbgender.Text= Dvgpatient.CurrentRow.Cells["Gender"].Value.ToString();
                    f.txtallergies.Text= Dvgpatient.CurrentRow.Cells["Allergies"].Value!=DBNull.Value?Dvgpatient.CurrentRow.Cells["Allergies"].Value.ToString():f.txtallergies.Text= "Patient Allergies";
                    f.txtallergies.ForeColor = f.txtallergies.Text == "Patient Allergies" ? Color.Gray:Color.Black;
                    f.ShowDialog();
                    getdataforadmin();

                }
                
            
            }
            if (e.ColumnIndex == 3)
            {
                if (Dvgpatient.CurrentRow != null)
                {
                    if (MessageBox.Show("Are you shure that you wanna delete this Patient?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            ds.Patient.Rows[Dvgpatient.CurrentRow.Index].Delete();
                            da.Update(ds.Patient);
                            getdataforadmin();
                        }
                        catch (Exception ex)
                        {
                            //Cos c = new Cos();
                            //LoginForm.ERORMESSAGEBOX(c,ex.Message);
                            //c.Show();
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void cmbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddupdatepatient f = new FrmAddupdatepatient();
            f.ShowDialog();
            getdataforadmin();
        }
    }
}
