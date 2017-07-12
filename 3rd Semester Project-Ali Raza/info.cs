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
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Booking bk = new Booking();
            bk.Show();
            this.Hide();
        }

        private void info_Load(object sender, EventArgs e)
        {
            comboBox1.Focus();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //saddar pickup
            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Saddar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "50".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Saddar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "60".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Clifton" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Clifton" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "230".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "180".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "210".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "160".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "190".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "320".ToString();
            }

            //clifton pickup

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Saddar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "220".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Saddar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "260".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Clifton" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "50".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Clifton" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "60".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "260".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "280".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "320".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "240".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "350".ToString();
            }

            //gulshan e iqbal pickup

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Saddar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Saddar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Clifton" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Clifton" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "50".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "60".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "240".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "180".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "220".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            //nazimabad pickup

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Saddar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Saddar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Clifton" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Clifton" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "240".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "50".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "60".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "180".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "220".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            //pib pickup

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Saddar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Saddar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Clifton" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Clifton" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "350".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "240".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "150".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "180".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "50".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "60".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            //johar pickup

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Saddar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Saddar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Clifton" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Clifton" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "350".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "150".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "190".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "230".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "230".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "260".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "50".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "60".ToString();
            }

        }
    }
}
