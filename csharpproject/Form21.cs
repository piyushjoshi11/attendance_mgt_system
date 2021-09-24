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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\piyus\Source\Repos\attendance_mgt_system\csharpproject\Schooldb.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT *FROM Admin where id = @id and password= @password", con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (dt.Rows.Count > 0)
            {
                Form211 admindash = new Form211();
                admindash.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect id or password ");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Landing choose = new Landing();
            choose.Show();
            Close();
        }
    }
}
