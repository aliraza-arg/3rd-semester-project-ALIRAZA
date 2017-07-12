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

namespace _3rd_Semester_Project_Ali_Raza
{
    public partial class Signup : Form
    {
        //database db = new database();
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }



        private void label5_Click_1(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        public string conString = "Data Source=DESKTOP-79I1IHK;Initial Catalog=ARG_Rickshaw;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please insert complete data");
            }
            else
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Select * From signup_details", con);
                SqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    if (textBox2.Text == dr["phno"].ToString())
                    {
                        MessageBox.Show("This num is already registered..!!");
                        break;
                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into signup_details(username,phno,pw,emailid)values(@username,@phno,@pw,@emailid)", con);

                        cmd.Parameters.AddWithValue("@username", textBox1.Text);
                        cmd.Parameters.AddWithValue("@phno", textBox2.Text);
                        cmd.Parameters.AddWithValue("@pw", textBox3.Text);
                        cmd.Parameters.AddWithValue("@emailid", textBox4.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sigup process completed, Now Login please");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        break;
                        //con.Close();
                    }
                }
                con.Close();
            }
        }

        private void Signup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == '-' || e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == '-' || e.KeyChar == '@' || e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }


    }
}