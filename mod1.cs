using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ActFinal1
{
    public partial class mod1 : Form
    {
        public mod1()
        {
            InitializeComponent();
        }

        private void verificar_Click(object sender, EventArgs e)
        {
            Double primero = Convert.ToDouble(numero1.Text);
            Double segundo = Convert.ToDouble(numero2.Text);


            if (primero > segundo) {
                medio.Text = ">"; 
                rNumero1.Text = "Este es el mayor";
                rNumero2.Text = "Este es el menor";
            } 
            else if (segundo > primero) {
                medio.Text = "<"; 
                rNumero2.Text = "Este es el mayor";
                rNumero1.Text = "Este es el menor";
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
           
        }
    }
}
