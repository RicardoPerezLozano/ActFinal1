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
    }
}
