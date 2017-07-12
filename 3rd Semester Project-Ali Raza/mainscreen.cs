using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3rd_Semester_Project_Ali_Raza
{
    public partial class mainscreen : Form
    {
        public mainscreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            info io = new info();
            io.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Booking bk = new Booking();
            bk.Show();
            this.Hide();
        }

        private void mainscreen_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
