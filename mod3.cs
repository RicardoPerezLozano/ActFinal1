using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ActFinal1
{
    public partial class mod3 : Form
    {
        public mod3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //creamos un metodo para obtener los caracteres del arreglo
        public static string ObtenerCracter(string frase, int Index) {
            string strCaracter = frase.Substring(Index, 1);
            return strCaracter;
        
        
        }
        private void verificar_Click(object sender, EventArgs e)
        {
            string strFrase = "";
            int intPosicion = 0, IntCantidadCaracteres = 0;
            strFrase = oracion.Text;
            IntCantidadCaracteres = strFrase.Length;
            
            //creamos el arreglo 
            String[] arreglo = new string[IntCantidadCaracteres];
            //rellenamos el arreglo utilizando el metodo ObtenerCracter
            for (intPosicion=0;intPosicion<=(IntCantidadCaracteres-1);intPosicion++) {

                arreglo[intPosicion] = ObtenerCracter(strFrase, intPosicion);

            }

            int a = 0, b = 0, c = 0, d = 0, e2 = 0, f = 0, g = 0, h = 0, i2 = 0, j = 0, k = 0, l = 0, m = 0, n = 0, n2 = 0, o = 0, p = 0, q = 0, r = 0, s = 0, t = 0, u = 0, v = 0, w = 0, x = 0, y = 0, z = 0;
            String frase=oracion.Text;




           
            

                

            
           //creamos un for para recorrer el arreglo y verificar la cantidad de letras usadas

                    foreach (String aux in arreglo) {

                        for (int i = 0; i <=(intPosicion - 1); i++)

                {
                    if (arreglo[i] == "a")
                    {
                        a++;

                    }
                    else if (arreglo[i] == "A") { a++; }




                        if (arreglo[i] == "b")
                            {
                                b++;
                            }
                    else if (arreglo[i] == "B") { b++; }




                    if (arreglo[i] == "c")
                            {
                                c++;
                            }
                    else if (arreglo[i] == "C") { c++; }






                    if (arreglo[i] == "d")
                            {
                                d++;
                            }
                    else if (arreglo[i] == "D") { d++; }





                    if (arreglo[i] == "e")
                            {
                                e2++;
                            }
                    else if (arreglo[i] == "E") { e2++; }




                    if (arreglo[i] == "f")
                            {
                                f++;
                            }
                    else if (arreglo[i] == "F") { f++; }





                    if (arreglo[i] == "g")
                            {
                                g++;
                            }

                    else if (arreglo[i] == "G") { g++; }




                    if (arreglo[i] == "h")
                            {
                                h++;
                            }
                    else if (arreglo[i] == "h") { h++; }





                    if (arreglo[i] == "i")
                            {
                                i2++;
                            }

                    else if (arreglo[i] == "I") { i2++; }





                    if (arreglo[i] == "j")
                            {
                                j++;
                            }
                    else if (arreglo[i] == "J") { j++; }





                    if (arreglo[i] == "k")
                            {
                                k++;
                            }
                    else if (arreglo[i] == "K") { k++; }






                    if (arreglo[i] == "l")
                            {
                                l++;
                            }

                    else if (arreglo[i] == "L") { l++; }







                    if (arreglo[i] == "m")
                            {
                                m++;
                            }
                    else if (arreglo[i] == "M") { m++; }







                    if (arreglo[i] == "n")
                            {
                                n++;
                            }
                    else if (arreglo[i] == "N") { n++; }








                    if (arreglo[i] == "ñ")
                            {
                                n2++;
                            }
                    else if (arreglo[i] == "Ñ") { n2++; }






                    if (arreglo[i] == "o")
                            {
                                o++;
                            }
                    else if (arreglo[i] == "O") { o++; }







                    if (arreglo[i] == "p")
                            {
                                p++;
                            }
                    else if (arreglo[i] == "P") { p++; }








                    if (arreglo[i] == "q")
                            {
                                q++;
                            }
                    else if (arreglo[i] == "Q") { q++; }








                    if (arreglo[i] == "r")
                            {
                                r++;
                            }
                    else if (arreglo[i] == "R") { r++; }







                    if (arreglo[i] == "s")
                            {
                                s++;
                            }
                    else if (arreglo[i] == "S") { s++; }










                    if (arreglo[i] == "t")
                            {
                                t++;
                            }
                    else if (arreglo[i] == "T") { t++; }









                    if (arreglo[i] == "u")
                            {
                                u++;
                            }
                    else if (arreglo[i] == "U") { u++; }









                    if (arreglo[i] == "v")
                            {
                                v++;
                            }
                    else if (arreglo[i] == "V") { v++; }








                    if (arreglo[i] == "w")
                            {
                                w++;
                            }
                    else if (arreglo[i] == "W") { w++; }








                    if (arreglo[i] == "x")
                            {
                                x++;
                            }
                    else if (arreglo[i] == "X") { x++; }





                    if (arreglo[i] == "y")
                            {
                                y++;
                            }
                    else if (arreglo[i] == "Y") { y++; }







                    if (arreglo[i] == "z")
                            {
                                z++;
                            }
                    else if (arreglo[i] == "Z") { z++; }




                    //mostramos en pantalla el numero de veces que se utilizo la letra en la frase
                }
                if (a != 0)
                {
                    
                    MessageBox.Show("se uso la letra a= " + a + " veces");
                    
                }
                a = 0;
                if (b != 0)
                {
                    MessageBox.Show("se uso la letra b= " + b + " veces");
                   
                    
                }
                b = 0;

                if (c != 0)
                {
                    MessageBox.Show("se uso la letra c= " + c + " veces");
                  
                    
                }
                c = 0;
                if (d != 0)
                {
                    MessageBox.Show("se uso la letra d= " + d + " veces");
                    
                   
                }
                d = 0;
                if (e2 != 0)
                {
                    MessageBox.Show("se uso la letra e= " + e2 + " veces");
                    
                   
                }
                e2 = 0;
                if (f != 0)
                {
                    MessageBox.Show("se uso la letra f= " + f + " veces");


                }
                f = 0;
                if (g != 0)
                {
                    MessageBox.Show("se uso la letra g= " + g + " veces");


                }
                g= 0;
                if (h != 0)
                {
                    MessageBox.Show("se uso la letra h= " + h + " veces");


                }
                h = 0;
                if (i2 != 0)
                {
                    MessageBox.Show("se uso la letra i= " + i2 + " veces");


                }
                i2 = 0;
                if (j != 0)
                {
                    MessageBox.Show("se uso la letra j= " + j + " veces");


                }
                j = 0;
                if (k != 0)
                {
                    MessageBox.Show("se uso la letra k= " + k + " veces");


                }
                k = 0;
                if (l != 0)
                {
                    MessageBox.Show("se uso la letra l= " + l + " veces");


                }
                l = 0;
                if (m != 0)
                {
                    MessageBox.Show("se uso la letra m= " + m + " veces");


                }
                m = 0;
                if (n != 0)
                {
                    MessageBox.Show("se uso la letra n= " + n + " veces");


                }
                n = 0;
                if (n2 != 0)
                {
                    MessageBox.Show("se uso la letra ñ= " + n2 + " veces");


                }
                n2 = 0;
                if (o != 0)
                {
                    MessageBox.Show("se uso la letra o= " + o + " veces");


                }
                o = 0;
                if (p != 0)
                {
                    MessageBox.Show("se uso la letra p= " + p + " veces");


                }
                p= 0;
                if (q != 0)
                {
                    MessageBox.Show("se uso la letra q= " + q + " veces");


                }
                q= 0;
                if (r != 0)
                {
                    MessageBox.Show("se uso la letra r= " + r + " veces");


                }
                r = 0;
                if (s != 0)
                {
                    MessageBox.Show("se uso la letra s= " + s + " veces");


                }
                s = 0;
                if (t != 0)
                {
                    MessageBox.Show("se uso la letra t= " + t + " veces");


                }
                t= 0;
                if (u != 0)
                {
                    MessageBox.Show("se uso la letra u= " + u + " veces");


                }
                u = 0;
                if (v != 0)
                {
                    MessageBox.Show("se uso la letra v= " + v + " veces");


                }
                v = 0;
                if (w != 0)
                {
                    MessageBox.Show("se uso la letra w= " + w + " veces");


                }
                w = 0;
                if (x != 0)
                {
                    MessageBox.Show("se uso la letra x= " + x + " veces");


                }
                x = 0;
                if (y != 0)
                {
                    MessageBox.Show("se uso la letra y= " + y + " veces");


                }
                y= 0;
                if (z != 0)
                {
                    MessageBox.Show("se uso la letra z= " + z + " veces");


                }
                z = 0;
                //terminamos con un break para que no se muestre el bucle el numero de veces que se realizo 
                break;







            }

                    
                



        }
    }
}
