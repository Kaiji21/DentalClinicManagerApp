using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using System.Windows.Forms;
using System.Diagnostics;

namespace Project_for_Control_2
{
    public partial class Cos : Form
    {

        public Cos()
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
        private void Form2_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (button1.Text== "continue")
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }
        public string tese = "Password";

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "OK")
            {
                this.Close();
            }
            else if (button1.Text== "continue")
            {
                Form3 f = new Form3();
                f.Show();
                this.Close();
            }
            else
            {
                Process.Start($@"https://mail.google.com/mail/u/0/?fs=1&to=elhaiba120@gmail.com&su={tese}&body=Write%20your%20Message%20here%20&&tf=cm");
                this.Close();
            }
            
        }
    }
}
