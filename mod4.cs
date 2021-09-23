using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ActFinal1
{
    public partial class mod4 : Form
    {
        public mod4()
        {
            InitializeComponent();
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            String cadena = txtFrase.Text;
            String invertida = "";


            for (int x = cadena.Length - 1; x >= 0; x--)
            {
                invertida += cadena[x]; //hola mundo = odnum aloh
            }

            String[] invertida2 = invertida.Split(' ');
            Array.Reverse(invertida2);

            lblInvert.Text = String.Join(" ", invertida2);
        }
    }
}
