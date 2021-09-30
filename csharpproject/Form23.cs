using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpproject
{
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Landing choose = new Landing();
            choose.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
