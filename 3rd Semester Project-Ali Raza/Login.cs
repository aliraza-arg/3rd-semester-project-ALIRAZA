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
    public partial class Login : Form
    {
        mainscreen ms = new mainscreen();
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Signup su = new Signup();
            su.Show();
            this.Hide();
        }

        public string conString = "Data Source=DESKTOP-79I1IHK;Initial Catalog=ARG_Rickshaw;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            
            //ms.Show();
            //this.Hide();

            SqlConnection con = new SqlConnection(conString);
            
            bool b = false;
            
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from signup_details;", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                /*MessageBox.Show("phno : " + dr["phno"].ToString() + "  pw : " + dr["pw"].ToString() + "\n" +
                                "textBox1.Text : " + textBox1.Text + "  textBox2.Text : " + textBox2.Text);
                bool a = textBox1.Text == dr["phno"].ToString();
                bool c =  textBox2.Text == dr["pw"].ToString();
                MessageBox.Show(" textBox1.Text == dr['phno'].ToString() : " + a + "  textBox2.Text == dr['pw'].ToString() : " + c);*/

                if (textBox1.Text == dr["phno"].ToString() && textBox2.Text == dr["pw"].ToString())
                {
                    b = true;
                    break;
                    
                }

            }

            if (b == true)
            {
                
                this.Hide();
                ms.Show();
            }
            else
                MessageBox.Show("Please insert correct phone no or password.");
            con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
