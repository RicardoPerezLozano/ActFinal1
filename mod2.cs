using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ActFinal1
{
    public partial class mod2 : Form
    {
        public mod2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double basee = Convert.ToDouble(txtBase.Text);
            Double altura = Convert.ToDouble(txtAltura.Text);
            Double area = (basee * altura) / 2;

            lblArea.Text = "El area del triangulo es: " + area.ToString();
        }
    }
}
