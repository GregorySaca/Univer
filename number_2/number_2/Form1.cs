using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace number_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double dollars;
        double course;
        double lei; 

        private void button1_Click(object sender, EventArgs e)
        {
            dollars = Convert.ToDouble(textBox1.Text);
            course = Convert.ToDouble(textBox2.Text);
            lei = dollars * course;
            textBox3.Text = lei.ToString();

        }
    }
}
