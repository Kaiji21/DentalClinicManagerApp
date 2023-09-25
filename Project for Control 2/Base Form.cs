using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_for_Control_2
{
    
    public partial class Form3 : Form
    {
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
        public Form3()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form3_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            if (LoginForm.role == "Admin")
            {
                btnsettings.Visible = true;
            }
            else if (LoginForm.role == "Dentist")
            {
                btnsettings.Location = new Point(0, 344);
                btnsettings.Text = "Account settings";
                btnappointment.Visible = false;
                btndentist.Image = Properties.Resources.calendarwhite_24px;
                pictureBox4.Visible = false;
                btnpayemnt.Visible = false;
                btnpatient.Text = "Dentist Patients";
                btndentist.Text = "Appointments Details";

            }
            else
            {
                btndentist.Visible = false;
                btnsettings.Text = "Account settings";
                btnsettings.Location = new Point(0, 410);
                pictureBox4.Visible = false;
                btnappointment.Visible = true;
                btnappointment.Location = new Point(0, 289);
                btnpayemnt.Visible = true;
                btnpayemnt.Location = new Point(0, 355);


            }
            getdata();
            btndashbord_Click(sender,e);

        }
         void getdata()
        {
            Clininc c = ClinincForm.clinics();
            label2.Text = c.Clininc_Name;
            byte[] data = (byte[])c.Clinic_Image;
            if (data != null)
            {
                MemoryStream stream = new MemoryStream(data);
                imglogo.Image = Image.FromStream(stream);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmClose f = new FrmClose();
            f.Closed += (s, args) => this.Hide();
            f.ShowDialog();
            //Application.Exit();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            btnsettings.ForeColor = Color.Black;
            btnsettings.Image = Properties.Resources.services_26px;
            pictureBox4.BackColor = Color.White;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {

            btnsettings.ForeColor = Color.White;
            btnsettings.Image = Properties.Resources.services_white26px;
            pictureBox4.BackColor = Color.FromArgb(33, 135, 245);

        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            if (btnsettings.Text== "Account settings")
            {
                panel3.Controls.Clear();
                accountsettings a = new accountsettings();
                a.TopLevel = false;
                panel3.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //pictureBox1.Location = new Point(164, 539);
            //pictureBox1.Visible = true;
            panel3.Controls.Clear();
            UserandClinic U = new UserandClinic();
            U.TopLevel = false;
            panel3.Controls.Add(U);
            U.Dock = DockStyle.Fill;
            U.Show();
        }

       

        private void btndentist_Click(object sender, EventArgs e)
        {
            if (btndentist.Text == "Appointments Details")
            {
                panel3.Controls.Clear();
                FrmAppointmentsDetails Apd = new FrmAppointmentsDetails();
                Apd.TopLevel = false;
                panel3.Controls.Add(Apd);
                Apd.Dock = DockStyle.Fill;
                Apd.Show();
            }
            else
            {
                panel3.Controls.Clear();
                Dentists D = new Dentists();
                D.TopLevel = false;
                panel3.Controls.Add(D);
                D.Dock = DockStyle.Fill;
                D.Show();
            }
            //pictureBox1.Location = new Point(164, 275);
            //pictureBox1.Visible = true;
         
            //btndentist.BackColor = Color.White;
            //btndentist.ForeColor = Color.Black;
            //btndentist.Image = Properties.Resources.dentist_32px;
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Tag==null)
            {
                pictureBox4.Image = Properties.Resources.chevron_down_26px;
                pictureBox4.Tag = "teste";

                panel4.Visible = true;
            }
            else 
            {
                pictureBox4.Image = Properties.Resources.chevron_up_26px;
                pictureBox4.Tag = null;
                panel4.Visible = false;
            }


            
        }

        private void btndashbord_MouseEnter(object sender, EventArgs e)
        {
            btndashbord.ForeColor = Color.Black;
            btndashbord.Image = Properties.Resources.dashboard_layout_24px;
        }

        private void btndashbord_MouseLeave(object sender, EventArgs e)
        {
            btndashbord.ForeColor = Color.White;
            btndashbord.Image = Properties.Resources.dashboard_whitelayout_24px;
        }

        private void btnpatient_MouseEnter(object sender, EventArgs e)
        {
            btnpatient.ForeColor = Color.Black;
            btnpatient.Image = Properties.Resources.person_30px;
        }

        private void btnpatient_MouseLeave(object sender, EventArgs e)
        {
            btnpatient.ForeColor = Color.White;
            btnpatient.Image = Properties.Resources.personwhite_30px;
        }

        private void btndentist_MouseEnter(object sender, EventArgs e)
        {
            btndentist.ForeColor = Color.Black;
            if (btndentist.Text== "Appointments Details")
                btndentist.Image = Properties.Resources.calendarenter_24px;
            else
                btndentist.Image = Properties.Resources.dentist_32px;

        }

        private void btndentist_MouseLeave(object sender, EventArgs e)
        {
            btndentist.ForeColor = Color.White;
            if (btndentist.Text == "Appointments Details")
                btndentist.Image = Properties.Resources.calendarwhite_24px;
            else
                btndentist.Image = Properties.Resources.dentistwhite_32px;
        }

        private void btnappointment_MouseEnter(object sender, EventArgs e)
        {
            btnappointment.ForeColor = Color.Black;
            btnappointment.Image = Properties.Resources.health_calendar_30px;
        }

        private void btnappointment_MouseLeave(object sender, EventArgs e)
        {
            btnappointment.ForeColor = Color.White;
            btnappointment.Image = Properties.Resources.health_whitecalendar_30px;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            btnusersettings.ForeColor = Color.Black;
            btnusersettings.Image = Properties.Resources.user_settings_32px;

        }

        private void btnusersettings_MouseLeave(object sender, EventArgs e)
        {
            btnusersettings.ForeColor = Color.White;
            btnusersettings.Image = Properties.Resources.user_whitesettings_32px;
        }

        private void btnclinicsettings_MouseEnter(object sender, EventArgs e)
        {
            btnclinicsettings.ForeColor = Color.Black;
            btnclinicsettings.Image = Properties.Resources.tooth_caries_30px;
        }

        private void btnclinicsettings_MouseLeave(object sender, EventArgs e)
        {
            btnclinicsettings.ForeColor = Color.White;
            btnclinicsettings.Image = Properties.Resources.tooth_whitecaries_30px;
        }

        private void btnpatient_Click(object sender, EventArgs e)
        {
            if (btnpatient.Text == "Patients")
            {
                panel3.Controls.Clear();
                Patients p = new Patients();
                p.TopLevel = false;
                panel3.Controls.Add(p);
                p.Dock = DockStyle.Fill;
                p.Show();
            }
            else
            {
                panel3.Controls.Clear();
                Patients p = new Patients();
                p.For = "For Dentist";
                p.pictureBox5.Visible = false;
                p.pictureBox7.Visible = false;
                p.btnprint.Visible = false;
                p.button1.Visible = false;
                p.TopLevel = false;
                panel3.Controls.Add(p);
                p.Dock = DockStyle.Fill;
                p.Show();
            }
            //pictureBox1.Location = new Point(164, 209);
            //pictureBox1.Visible = true;
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnappointment_Click(object sender, EventArgs e)
        {
            //pictureBox1.Location= new Point(164, 341);
            //pictureBox1.Visible = true;
            panel3.Controls.Clear();
            Appointmentcs a = new Appointmentcs();
            a.TopLevel = false;
            panel3.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            a.Show();
        }
     
        private void btndashbord_Click(object sender, EventArgs e)
        {
            //pictureBox1.Location = new Point(164, 143);
            //pictureBox1.Visible = true;
            panel3.Controls.Clear();
            frmDashbord c = new frmDashbord();
            c.TopLevel = false;
            panel3.Controls.Add(c);
            c.Dock = DockStyle.Fill;
            c.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void btnclinicsettings_Click(object sender, EventArgs e)
        {
            //pictureBox1.Location = new Point(164, 605);
            //pictureBox1.Visible = true;
            panel3.Controls.Clear();
            ClinincForm c = new ClinincForm(this);
            c.TopLevel = false;
            panel3.Controls.Add(c);
            c.Dock = DockStyle.Fill;
            c.Show();
        }

        private void btnpayemnt_MouseEnter(object sender, EventArgs e)
        {
            btnpayemnt.ForeColor = Color.Black;
            btnpayemnt.Image = Properties.Resources.add_dollarblue_24px;
        }

        private void btnpayemnt_MouseLeave(object sender, EventArgs e)
        {
            btnpayemnt.ForeColor = Color.White;
            btnpayemnt.Image = Properties.Resources.add_dollar_24px;
        }

        private void btnpayemnt_Click_1(object sender, EventArgs e)
        {
            //pictureBox1.Location = new Point(164,407);
            //pictureBox1.Visible = true;
            panel3.Controls.Clear();
            frmPayment c = new frmPayment();
            c.TopLevel = false;
            panel3.Controls.Add(c);
            c.Dock = DockStyle.Fill;
            c.Show();


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            //panel4.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
