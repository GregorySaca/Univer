using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace number_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double ves_candy;
        double ves_irish;
        double price_total_candy;
        double price_total_irish;
        double price_candy;
        double price_irish;
        double difference;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ves_candy = Convert.ToDouble(textBox1.Text);
            price_total_candy = Convert.ToDouble(textBox2.Text);
            ves_irish = Convert.ToDouble(textBox3.Text);
            price_total_irish = Convert.ToDouble(textBox4.Text);
            price_candy = price_total_candy / ves_candy;
            price_irish = price_total_irish / ves_irish;
            textBox5.Text = price_candy.ToString();
            textBox6.Text = price_irish.ToString();
            difference = price_candy / price_irish;
            textBox7.Text = difference.ToString();
        }
    }
}
