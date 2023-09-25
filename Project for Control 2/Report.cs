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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

            this.reportfile.RefreshReport();
        }
    }
}
