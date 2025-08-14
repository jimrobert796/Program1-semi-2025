using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerProyectoCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Este método es esencial para que se cargue el diseño
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0; // Declarar variables
            num1 = double.Parse(txtNum1.Text); // Valor de caja 1
            num2 = double.Parse(txtNum2.Text); // Valor de caja 2


            // Condicional if -> LEZ GO IT 

            if (optSuma.Checked) //suma
            {
                respuesta = num1 + num2;
            }

            if (optResta.Checked)// resta 
            {
                respuesta = num1 - num2;
            }

            if (optMultiplicacion.Checked)// multi
            {
                respuesta = num1 * num2;
            }

            if (optDivision.Checked)// division
            {
                respuesta = num1 / num2;
            }

            if (optExponente.Checked)// exponente
            {
                respuesta = Math.Pow(num1, num2);
            }

            // Concatenacion de texto y un double para enviar a la etiqueta
            lblRespuesta.Text = "Respuesta: " + respuesta;

            if (optPrimo.Checked)// Primo
            {
                int i = 1, acum = 0;

                while (i <= num1 && acum < 3)
                {
                    if (num1%i == 0)
                    {
                        acum++; // acoumula es decir acum = acum + 1
                    }
                    i++;
                }
                if (acum <= 2)
                {
                   lblRespuesta.Text = "Respuesta: " + num1 + " es primo";

                }
                else
                {
                    lblRespuesta.Text = "Respuesta: " + num1 + " no es primo";
                }
            }

            if (optFactorial.Checked) //Factorial
            {
                double factorial = (int)num1; //variable contenedira 

                for (int i =(int)num1 -1; i > 1; i--)
                {
                    factorial *= i;
                }
                respuesta = factorial;
                lblRespuesta.Text = "Respuesta: " + factorial;
            }

          

            
        }

        

        private void btnCalcularOpciones_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);

            switch (cboOpciones.SelectedIndex)
            {
                case 0:
                    // Suma
                    respuesta = num1 + num2;
                    break;

                case 1:
                    respuesta = num1 - num2;
                    break;
                case 2:
                    respuesta = num1 * num2;
                    break;
                case 3:
                    respuesta = num1 * num2;
                    break;
                case 4:
                    respuesta = num1 / num2;
                    break;
            }
            // Concatenacion de texto y un double
            lblRespuesta.Text = "Respuesta: " + respuesta;
        }
    }
}
