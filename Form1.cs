using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActFinal1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form modulo1 = new mod1();
            
            modulo1.Show();
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form modulo3 = new mod3();

            modulo3.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Form modulo4 = new mod4();

            modulo4.Show();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Form modulo2 = new mod2();

            modulo2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form modulo5 = new mod5();

            modulo5.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form modulo6 = new mod6();

            modulo6.Show();
        }
    }
}
