using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace Project_for_Control_2
{
    public partial class Dentists : Form
    {
       public static string cs = "Data source =.;Initial catalog =GESTION_DENTAL_CLINIC ;Integrated security= true";
        SqlConnection con;
        DataTable source;
        string topdentist = "select top(1) Appointment.DentistID,DentistFullName,COUNT(*) as teste from Appointment join Dentist on Dentist.DentistID= Appointment.DentistID group by Appointment.DentistID,DentistFullName order by teste desc";
        string bottom = "select top(1) Appointment.DentistID,DentistFullName,COUNT(*) as teste from Appointment join Dentist on Dentist.DentistID= Appointment.DentistID group by Appointment.DentistID,DentistFullName order by teste asc";
        public Dentists()
        {
            InitializeComponent();
        }
        void getdashboarddata()
        {
            using (con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand($"select count(*) from dentist",con);
                con.Open();
                int Total = (int) cmd.ExecuteScalar();
                totaldentist.Text = Total.ToString();
                cmd = new SqlCommand($"{topdentist};{bottom}",con); 
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        label2.Text = dr[0].ToString();
                        label1.Text = dr[1].ToString();

                    }
                    dr.NextResult();
                    while (dr.Read())
                    {
                        label4.Text = dr[0].ToString();
                        label5.Text = dr[1].ToString();
                    }


                }
                dr.Close();
                cmd = new SqlCommand("Select * from dentist", con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable source = new DataTable();
                    source.Load(dr);
                    DvgDentist.DataSource = source;
                }
                else
                {
                    if (source != null)
                    {
                        source.Rows.Clear();

                    }
                    label7.Visible = true;
                }
                dr.Close();
             


            }
        }

        private void Dentists_Load(object sender, EventArgs e)
        {
            getdashboarddata();
            DvgDentist.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 249, 239);
            


        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        string searchby;
        public void searchdvgdentist()
        {
            using (con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand($"select * from dentist where {searchby} like @zoneachercher ", con);
                cmd.Parameters.AddWithValue("@zoneachercher", '%' + Txtsearch.Text + '%');
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    label7.Visible = false;
                     source = new DataTable();
                    source.Load(dr);
                    DvgDentist.DataSource = source;

                }
                else
                {
                   if (source != null)
                    {
                        source.Rows.Clear();
                    }
                    label7.Visible = true;


                }
            }
        }
        private void Txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbsearch.SelectedIndex == -1)
            {
                searchby = "Dentistfullname";
                searchdvgdentist();
        
               
            }
            else if (cmbsearch.SelectedIndex<=1)
            {
               
                    searchby = cmbsearch.Text.Replace(" ", "");
                    searchdvgdentist();
                
                


            }
            else if (cmbsearch.SelectedIndex>1)
            {
                searchby = cmbsearch.Text.Replace("Dentist", null);
                searchdvgdentist();

            }
        }

        private void Dentists_Click(object sender, EventArgs e)
        {
            pictureBox1.Select();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        public static int DentistID;
        public static Byte[] data;
        private void DvgDentist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex>=0)
            {
                FrmAddupdatedentist f = new FrmAddupdatedentist();
                f.label3.Text = "Update Dentist";
                f.label3.Location = new Point(93, 10);
                f.btnadddentist.Text = "Update Dentist";
                foreach (Control var in f.paneladddentist.Controls)
                {
                    if (var is TextBox)
                    {
                        ((TextBox)var).ForeColor = Color.Black;
                    }
                }
                if (DvgDentist.CurrentRow != null)
                {
                    DentistID = int.Parse(DvgDentist.CurrentRow.Cells["IDdentist"].Value.ToString());
                    f.txtfullname.Text = DvgDentist.CurrentRow.Cells["Dentistfullname"].Value.ToString();
                    f.txtphone.Text = DvgDentist.CurrentRow.Cells["Phone"].Value.ToString();
                    f.txtadress.Text = DvgDentist.CurrentRow.Cells["Dentistaddress"].Value.ToString();
                    f.datatimeDOB.Text = DvgDentist.CurrentRow.Cells["DOB"].Value.ToString();
                    f.datetimepickerDSW.Text = DvgDentist.CurrentRow.Cells["DOS"].Value.ToString();
                    f.cmbgender.Text = DvgDentist.CurrentRow.Cells["Gender"].Value.ToString();
                    if (DvgDentist.CurrentRow.Cells["Email"].Value != DBNull.Value)
                    {
                        f.txtemail.Text = DvgDentist.CurrentRow.Cells["Email"].Value.ToString();
                    }
                    else
                    {
                        f.txtemail.Text = "DentistEmail@gmail.com";   f.txtemail.ForeColor = Color.Gray;
                    }
                    //f.txtemail.Text = DvgDentist.CurrentRow.Cells["Email"].Value != DBNull.Value ? DvgDentist.CurrentRow.Cells["Email"].Value.ToString() : {f.txtemail.Text = "DentistEmail@gmail.com"   f.txtemail.ForeColor = Color.Gray}  ; 
                    if (DvgDentist.CurrentRow.Cells["imagedentist"].Value != DBNull.Value)
                    {
                        
                         data = new Byte[0];
                        data = (Byte[])(DvgDentist.CurrentRow.Cells["imagedentist"].Value);
                        MemoryStream mem = new MemoryStream(data);
                        f.Dentistimg.Image = Image.FromStream(mem);
                        f.Dentistimg.SizeMode = PictureBoxSizeMode.StretchImage;
                        f.imgadded = "already have image";
                        

                    }
                    else 
                        f.Dentistimg.Image = Properties.Resources.Ellipse_1;
                  
                    f.txtphone.ForeColor = Color.Black;
                    f.ShowDialog();
                    getdashboarddata();
                }

            }
            if (e.ColumnIndex == 2 && e.RowIndex>=0)
            {
                if (DvgDentist.CurrentRow != null)
                {
                    if (MessageBox.Show("Are you shure that you wanna delete this dentist?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            using (con = new SqlConnection(cs))
                            {
                                SqlCommand cmd = new SqlCommand("Delete from Dentist where DentistID=@id ", con);
                                cmd.Parameters.AddWithValue("@id", int.Parse(DvgDentist.CurrentRow.Cells["IDdentist"].Value.ToString())) ;
                                con.Open();
                                int Rowaffected = cmd.ExecuteNonQuery();
                                if (Rowaffected > 0)
                                {
                                    Cos c = new Cos();
                                    c.label1.Text = "Dentist deleted successfully and his account user was deleted successfully";
                                    c.button1.Text = "OK";
                                    getdashboarddata();
                                    c.Show();
                                }
                                else
                                {
                                    Cos c = new Cos();
                                    LoginForm.ERORMESSAGEBOX(c, "No dentist Founded");
                                    c.Show();
                                }
                            }
                        }
                        catch (Exception ex )
                        {
                            //Cos c = new Cos();
                            //LoginForm.ERORMESSAGEBOX(c,ex.Message);
                            //c.Show();
                            MessageBox.Show(ex.Message);

                        }
                    }
                  
                }

            }
            if (e.ColumnIndex==3 && e.RowIndex>=0)
            {
                if (DvgDentist.CurrentRow != null)
                {
                    string imgdentist = null;
                    Clininc c = ClinincForm.clinics();
                    Report rpdentist = new Report();
                    rpdentist.reportfile.LocalReport.ReportEmbeddedResource = "Project_for_Control_2.Rapportdentist.rdlc";
                    ReportParameter clinicname = new ReportParameter("Clinicname", c.Clininc_Name);
                    string imgclinic = Convert.ToBase64String(c.Clinic_Image);
                    ReportParameter clinicimg = new ReportParameter("imgClinic", imgclinic);
                    ReportParameter dentistid = new ReportParameter("dentistId", DvgDentist.CurrentRow.Cells["IDdentist"].Value.ToString());
                    ReportParameter dentistfullname = new ReportParameter("Dentistfullname", DvgDentist.CurrentRow.Cells["Dentistfullname"].Value.ToString());
                    ReportParameter dentistphone = new ReportParameter("dentistphone", DvgDentist.CurrentRow.Cells["Phone"].Value.ToString());
                    ReportParameter dentistemail = new ReportParameter("Dentistemail", DvgDentist.CurrentRow.Cells["Email"].Value != DBNull.Value ? DvgDentist.CurrentRow.Cells["Email"].Value.ToString() : "No email ");
                    ReportParameter dentistaddress = new ReportParameter("dentistaddress", DvgDentist.CurrentRow.Cells["Dentistaddress"].Value.ToString());
                    ReportParameter dentistdob = new ReportParameter("dentistdob", Convert.ToDateTime(DvgDentist.CurrentRow.Cells["DOB"].Value).ToLongDateString());
                    ReportParameter dentistgender = new ReportParameter("dentistgender", DvgDentist.CurrentRow.Cells["Gender"].Value.ToString());
                    ReportParameter dentistdos = new ReportParameter("dentistdos",Convert.ToDateTime(DvgDentist.CurrentRow.Cells["DOS"].Value).ToLongDateString());
                    if (DvgDentist.CurrentRow.Cells["imagedentist"].Value != DBNull.Value)
                    {

                        data = new Byte[0];
                        data = (Byte[])(DvgDentist.CurrentRow.Cells["imagedentist"].Value);
                        imgdentist = Convert.ToBase64String(data);


                    }
                    else
                    {
                        imgdentist = "no image";
                    }

                    ReportParameter dentistimg = new ReportParameter("imgdentist", imgdentist);
                    rpdentist.reportfile.LocalReport.SetParameters(new ReportParameter[] { clinicname, clinicimg, dentistid, dentistfullname, dentistphone, dentistemail, dentistaddress, dentistdob, dentistdob, dentistdos, dentistgender, dentistimg });
                    rpdentist.reportfile.RefreshReport();
                    rpdentist.ShowDialog();
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            FrmAddupdatedentist f = new FrmAddupdatedentist();
            f.ShowDialog();
            getdashboarddata();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
        }
        private void paneladddentist_Click(object sender, EventArgs e)
        {
            pictureBox1.Select();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            GESTION_DENTAL_CLINICEntities2 dc = new GESTION_DENTAL_CLINICEntities2();
            var Alldentist = dc.Dentist.ToList();
            Clininc c = ClinincForm.clinics();
            Report rpdentist = new Report();
            rpdentist.reportfile.LocalReport.ReportEmbeddedResource = "Project_for_Control_2.AllDentist.rdlc";
            rpdentist.reportfile.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", Alldentist));
            ReportParameter clinicname = new ReportParameter("clininname", c.Clininc_Name);
            string imgclinic = Convert.ToBase64String(c.Clinic_Image);
            ReportParameter clinicimg = new ReportParameter("clinicimg", imgclinic);
            ReportParameter datenow = new ReportParameter("datenow", DateTime.Now.ToShortDateString());
            rpdentist.reportfile.LocalReport.SetParameters(new ReportParameter[] { clinicname, clinicimg, datenow });
            rpdentist.reportfile.RefreshReport();
            rpdentist.ShowDialog();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {

        }
    }


   

}

