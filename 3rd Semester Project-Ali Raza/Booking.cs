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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
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

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Saddar" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "40".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Saddar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "60".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Saddar" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "50".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Clifton" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Clifton" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "180".ToString();
            }



            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Clifton" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "230".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Clifton" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "180".ToString();
            }


            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "160".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "210".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "190".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "220".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "270".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "160".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "140".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "190".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "170".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "230".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "320".ToString();
            }

            if (comboBox1.Text == "Saddar" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "280".ToString();
            }

            //clifton pickup

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Saddar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "220".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Saddar" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Saddar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "260".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Saddar" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "240".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Clifton" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "50".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Clifton" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "40".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Clifton" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "60".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Clifton" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "50".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "260".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "230".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "270".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "280".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "320".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "300".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "180".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "240".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "220".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "270".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "350".ToString();
            }

            if (comboBox1.Text == "Clifton" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "320".ToString();
            }

            //gulshan e iqbal pickup

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Saddar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Saddar" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "170".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Saddar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Saddar" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "220".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Clifton" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Clifton" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "220".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Clifton" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Clifton" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "270".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "50".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "40".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "60".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "50".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "180".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "240".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "220".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "180".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "160".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "220".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "170".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "Gulshan e Iqbal" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "220".ToString();
            }

            //nazimabad pickup

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Saddar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Saddar" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "180".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Saddar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Saddar" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "230".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Clifton" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Clifton" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "220".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Clifton" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Clifton" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "270".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "170".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "240".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "210".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "50".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "40".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "60".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "50".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "180".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "160".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "220".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "220".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            if (comboBox1.Text == "Nazimabad" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "270".ToString();
            }

            //pib pickup

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Saddar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Saddar" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "180".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Saddar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Saddar" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "230".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Clifton" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Clifton" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "280".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Clifton" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "350".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Clifton" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "330".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "170".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "240".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "210".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "150".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "130".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "180".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "160".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "50".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "40".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "60".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "50".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "220".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            if (comboBox1.Text == "PIB Colony" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "270".ToString();
            }

            //johar pickup

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Saddar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "250".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Saddar" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "230".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Saddar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Saddar" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "280".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Clifton" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "300".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Clifton" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "270".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Clifton" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "350".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Clifton" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "320".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "150".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "130".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Gulshan e Iqbal" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "180".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "190".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "170".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "230".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Nazimabad" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "210".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "230".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "200".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "260".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "PIB Colony" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "240".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Standard Rickshaw")
            {

                textBox3.Text = "50".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Standard Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "40".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Wifi'an Rickshaw")
            {

                textBox3.Text = "60".ToString();
            }

            if (comboBox1.Text == "Gulistan e Johar" && comboBox3.Text == "Gulistan e Johar" && comboBox2.Text == "Wifi'an Rickshaw" && textBox2.Text == "ARGPromo")
            {

                textBox3.Text = "50".ToString();
            }
        }

        public string conString = "Data Source=DESKTOP-79I1IHK;Initial Catalog=ARG_Rickshaw;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            if (textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please insert complete data");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into booking(phno,pp,dp,rt,coupon,est_fare)values(@phno,@pp,@dp,@rt,@coupon,@est_fare)", con);

                cmd.Parameters.AddWithValue("@phno", textBox1.Text);
                cmd.Parameters.AddWithValue("@pp", comboBox1.Text);
                cmd.Parameters.AddWithValue("@dp", comboBox3.Text);
                cmd.Parameters.AddWithValue("@rt", comboBox2.Text);
                cmd.Parameters.AddWithValue("@coupon", textBox2.Text);
                cmd.Parameters.AddWithValue("@est_fare", textBox3.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Booking Done. You will get call from us \n   Thanks for chosing ARG Rickshaw");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();



                con.Close();
            }
        }
    }
}