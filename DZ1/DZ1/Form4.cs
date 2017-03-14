using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ1
{
    public partial class Form4 : Form
    {
        Random rnd = new Random();
        public Form4()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int red = rnd.Next(255);
            int green = rnd.Next(255);
            int blue = rnd.Next(255);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
