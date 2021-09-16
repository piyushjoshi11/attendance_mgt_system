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

namespace csharpproject
{
    public partial class Formtr : Form
    {
        public Formtr()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\piyus\Source\Repos\attendance_mgt_system\csharpproject\Schooldb.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Teacher values(@name,@sex,@DOB,@subject,@id,@password)",con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@sex", textBox2.Text);
            cmd.Parameters.AddWithValue("@DOB", textBox3.Text);
            cmd.Parameters.AddWithValue("@id", textBox4.Text);
            cmd.Parameters.AddWithValue("@password", textBox5.Text);
            
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }
    }
}
