using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3._1_GitHub_AICDAW2223
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras, sinespacio;
            double coste;

            //AIC2DAW2223
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (radioButton2.Checked)
                tipoTelegrama = 'u';

            else
                tipoTelegrama = 'o';



            //Obtengo el número de letras que forma el telegrama
            numPalabras = textoTelegrama.Length;
            //Obtengo el número de letras borrando los espacios
            sinespacio = textoTelegrama.Replace(" ", "").Length;
            //Resto los caracteres de la frase con espacios  - los de la frase sin espacios
            numPalabras = numPalabras - sinespacio;
            //Normalmente las frases tienen un espacio menos que palabras, por eso se suma 1 al numero de espacios
            numPalabras++;


            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + 0.5 * (numPalabras - 10);
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";


        }
    }
}
