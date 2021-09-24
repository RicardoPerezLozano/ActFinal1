using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ActFinal1
{
    public partial class mod6 : Form
    {
        String palabra = "COLOMBIA";
        int letra;
        bool muestra;
        int cantMal;
        int cantBien;

        public mod6()
        {
            InitializeComponent();
            limpiar();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtLetra.Text != "")
            {
                int vcant = 0;
                if (txtPalabra.Text == "")
                    txtPalabra.Text = txtLetra.Text;
                else
                    txtPalabra.Text = txtPalabra.Text + " , " + txtLetra.Text;

                do
                {
                    if (vcant == 0)
                        letra = palabra.IndexOf(txtLetra.Text);
                    else
                        letra = palabra.IndexOf(txtLetra.Text, letra + 1);

                    muestra = mostrarLetra(letra);
                    if (cantBien == palabra.Length)
                    {
                        MessageBox.Show("Palabra correcta.");
                        limpiar();
                        txtLetra.Focus();
                    }
                    if (muestra)
                    {
                        vcant += 1;
                    }
                } while (muestra);

                if (vcant == 0)
                {
                    cantMal += 1;
                    muestraImagen(cantMal);
                }
            }

            txtLetra.Text = "";
            txtLetra.Focus();
        }

        private void mod6_Load(object sender, EventArgs e)
        {
            ubicarLetras(palabra);
        }

        public void ubicarLetras(String palabra)
        {
            int longitud = palabra.Length;
            for (int i = 0; i < longitud; i++)
            {
                switch (i)
                {
                    case 0:
                        label10.Visible = true;
                        label1.Text = palabra.Substring(i, 1);
                        break;
                    case 1:
                        label11.Visible = true;
                        label2.Text = palabra.Substring(i, 1);
                        break;
                    case 2:
                        label12.Visible = true;
                        label3.Text = palabra.Substring(i, 1);
                        break;
                    case 3:
                        label13.Visible = true;
                        label4.Text = palabra.Substring(i, 1);
                        break;
                    case 4:
                        label14.Visible = true;
                        label5.Text = palabra.Substring(i, 1);
                        break;
                    case 5:
                        label15.Visible = true;
                        label6.Text = palabra.Substring(i, 1);
                        break;
                    case 6:
                        label16.Visible = true;
                        label7.Text = palabra.Substring(i, 1);
                        break;
                    case 7:
                        label17.Visible = true;
                        label8.Text = palabra.Substring(i, 1);
                        break;
                    case 8:
                        label18.Visible = true;
                        label9.Text = palabra.Substring(i, 1);
                        break;
                }
            }
        }

        public bool mostrarLetra(int letra)
        {
            bool result = true;
            cantBien += 1;
            switch (letra)
            {
                case 0: label1.Visible = true;
                    break;
                case 1:
                    label2.Visible = true;
                    break;
                case 2:
                    label3.Visible = true;
                    break;
                case 3:
                    label4.Visible = true;
                    break;
                case 4:
                    label5.Visible = true;
                    break;
                case 5:
                    label6.Visible = true;
                    break;
                case 6:
                    label7.Visible = true;
                    break;
                case 7:
                    label8.Visible = true;
                    break;
                case 8:
                    label9.Visible = true;
                    break;

                default: cantBien -= 1;
                    result = false;
                    break;
            }
            return result;
            
        }

        public void limpiar()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

            cantMal = 0;
            cantBien = 0;
            txtPalabra.Text = "";
        }

        public void muestraImagen(int numImagen)
        {
            switch (numImagen)
            {
                case 1: pictureBox1.Visible = true;
                    break;
                case 2: pictureBox2.Visible = true;
                    break;
                case 3: pictureBox3.Visible = true;
                    break;
                case 4: pictureBox4.Visible = true;
                    MessageBox.Show("Game over.");
                    limpiar();
                    ubicarLetras(palabra);
                    break;

                default: break;

            }
        }


        
    }
}
