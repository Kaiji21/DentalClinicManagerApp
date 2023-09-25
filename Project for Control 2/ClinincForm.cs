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
    public partial class ClinincForm : Form
    {
        bool imgadded = false;
       GESTION_DENTAL_CLINICEntities2 dc ;
        public ClinincForm()
        {
            InitializeComponent();
        }
        Form3 baseform;
        public ClinincForm(Form3 notthis)
        {
            baseform = notthis;
            InitializeComponent();
        }
        public static Clininc  clinics()
        {
            GESTION_DENTAL_CLINICEntities2 dc = new GESTION_DENTAL_CLINICEntities2();
            Clininc clininc = new Clininc();
            clininc = dc.Clininc.SingleOrDefault();
            return clininc;
        



        }
        void getdata()
        {
            Clininc clininc = clinics();
            txtClinicname.Text = clininc.Clininc_Name;
            txtclinicdescription.Text = clininc.Clininc_Description;
            txtclinicaddress.Text = clininc.Clininc_Address;
            txtclinincpri.Text = clininc.principle;
            cmbannex.Text = clininc.Annex;
            byte[] data = (byte[])clininc.Clinic_Image;
            if (data != null)
            {
                MemoryStream stream = new MemoryStream(data);
                clinicimg.Image = Image.FromStream(stream);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ClinincForm_Load(object sender, EventArgs e)
        {
            cmbannex.Region = new Region(new Rectangle(3, 3, cmbannex.Width - 3, cmbannex.Height - 7));
            getdata();
        }
        string imglocation;
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Bitmaps|*.bmp|PNG files|*.png|JPEG files|*.jpg|GIF files|*.gif|TIFF files|*.tif|Image files|*.bmp;*.jpg;*.gif;*.png";
                open.Title = "Upload Your Img";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    imglocation = open.FileName;
                    clinicimg.Image = Image.FromFile(open.FileName);
                    imglocation = open.FileName;
                    clinicimg.SizeMode = PictureBoxSizeMode.Zoom;
                    imgadded=true;
                }
            }
            catch (Exception ex)
            {

                Cos c = new Cos();
                LoginForm.ERORMESSAGEBOX(c, ex.Message);
                c.ShowDialog();


            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            List<Control> liste = new List<Control>();
            int id = 0;
            int comp = 0;
            liste.Add(txtClinicname); liste.Add(txtclinicaddress); liste.Add(txtclinicdescription); liste.Add(txtclinincpri);liste.Add(cmbannex) ;
            while (id < liste.Count)
            {
                if (liste[id].Text == "")
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
            if (comp==0 )
            {

                using (dc = new GESTION_DENTAL_CLINICEntities2())
                {
                    Clininc c = new Clininc();
                    c = dc.Clininc.SingleOrDefault();
                    if (imgadded)
                    {
                        byte[] img;
                        FileStream fs = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        img = br.ReadBytes((int)fs.Length);
                        c.Clinic_Image = img;
                        baseform.imglogo.Image = clinicimg.Image;
                    }
                    c.Clininc_Name = txtClinicname.Text;
                    c.Clininc_Address = txtclinicaddress.Text;
                    c.Clininc_Description = txtclinicdescription.Text;
                    c.Annex = cmbannex.Text;
                    c.principle = txtclinincpri.Text;
                    dc.SaveChanges();
                    Cos cc = new Cos();
                    cc.label1.Text = "Clinic Information was Added successfully";
                    cc.button1.Text = "OK";
                    cc.ShowDialog();
                    pictureBox2.Image = Properties.Resources.icons8_save_64;


                }
            }
           

        }
    }
}
