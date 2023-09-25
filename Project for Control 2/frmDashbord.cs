using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_for_Control_2
{
    public partial class frmDashbord : Form
    {
        public frmDashbord()
        {
            InitializeComponent();
        }
        void getdata()
        {
          Clininc c=  ClinincForm.clinics();
            lbaddress.Text = c.Clininc_Address;
            lbclinicname.Text = c.Clininc_Name;
            lbclinincdescr.Text = c.Clininc_Description;
            lbname.Text = c.Clininc_Name;
            byte[] data = (byte[])c.Clinic_Image;
            if (data != null)
            {
                MemoryStream stream = new MemoryStream(data);
                imglogo.Image = Image.FromStream(stream);
            }
          
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmDashbord_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
