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
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent(); 
        }
        private void Form1_Load(object sender, EventArgs e){
           
        }


        // Matriz con los valores de conversion de uno el inical a los demas
        double[][] tabla = new double[][]{
            new double []{0.01 ,500, 1.5,0 }, //1
            new double []{500.01, 1000, 1.5, 3 }, //2 
            new double []{1000.01, 2000,3 ,3 }, //3
            new double []{2000.01, 3000, 6, 3 }, // 4
            new double []{3000.01, 6000, 9,2 },  //5
            new double []{8000.01, 18000, 15, 2},  // 6
            new double []{18000.01, 30000, 39, 2},  // 7
            new double []{30000.01, 60000, 63, 1},  // 8
            new double []{60000.01, 100000, 93, 0.8}, // 9
            new double []{100000.01, 200000, 125, 0.7},  //10
            new double []{200000.01, 300000, 195, 0.6},  // 11
            new double []{300000.01, 400000, 255, 0.45},  // 12
            new double []{400000.01, 500000, 300, 0.4},  //13
            new double []{500000.01, 1000000, 340, 0.30},  //14
            new double []{1000000.01, 99999999, 490, 0.18},  // 15

        };

        private double calculo(double monto)
        {
            double resultado = 0;
            // recorre la tabla para encontrar el rango en el que se encuentra el monto
            for (int i = 0; i < tabla.Length; i++)
            {
                // si el monto se encuentra en el rango esta listo para el calculo
                if (monto >= tabla[i][0] & monto <= tabla[i][1])
                {
                    // 1875.79 – 1000.01 = 875.78 / 1000 * 3 + 3 = $5.63
                    // 20000 – 18000.01 = 1999.99 / 1000 * 2 + 39 = 42.9999 = $43
                    resultado = monto - tabla[i][0];
                    resultado = resultado / 1000 * tabla[i][3] + tabla[i][2];
                }
            }
            return resultado;
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double monto = 0;
            double resultado = 0;

            // si no se ingresa un monto valido
            if (txtMonto.Text == "")
            {
                MessageBox.Show("Ingrese un monto valido");
            }
            else
            {
                monto = double.Parse(txtMonto.Text);

                resultado = calculo(monto);
                resultado = Math.Round(resultado, 2);
                

                lblPago.Text = "Su valor a pagar es: $" + resultado;
            }

        }
    }
}
