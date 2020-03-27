using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rent_a_car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hakkında hakkında = new Hakkında();
            hakkında.Show();
            this.Hide();





        }

        private void button5_Click(object sender, EventArgs e)
        {


            MusteriIslemleri musteriislemleri = new MusteriIslemleri();
            musteriislemleri.Show();
            this.Hide();




        }

        private void button6_Click(object sender, EventArgs e)
        {
            AracIslemleri aracislemleri = new AracIslemleri();
            aracislemleri.Show();
            this.Hide();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            KiralamaIslemleri kiralamaIslemleri = new KiralamaIslemleri(); 
            kiralamaIslemleri.Show();

            this.Hide();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar();
            raporlar.Show();
            this.Hide();

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    } } 

  