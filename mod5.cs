using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ActFinal1
{
    public partial class mod5 : Form
    {
        public mod5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String leer = txt_leer.Text;

            int n = 10000;
            String exp;
            bool pangrama = true;
            for (int i = 0; i < n; i++, pangrama = true)
            {
                exp =leer;
                for (char ascii = 'A'; ascii <= 'Z'; ascii++)
                {
                    if (!exp.ToUpper().Contains("" + ascii))
                    {
                        pangrama = false;
                        break;
                    }
                }
                salidalbl.Text=(pangrama ? "Es un Pangrama" : "NO es un Pangrama");
            }
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

