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
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form21 adminl = new Form21();
            adminl.Show();
            
         }

        private void button2_Click(object sender, EventArgs e)
        {
            Form22 teacherl = new Form22();
            teacherl.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form23 studentl = new Form23();
            studentl.Show();
            

        }
    }
}
