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
            InitializeComponent(); // Este método es esencial para que se cargue el diseño
        }
        private void Form1_Load(object sender, EventArgs e){
            // Hacer un ejercicio en C# haciendo uso de matricez, estructuras de repeticion y condicionales, que
            // determin el sueldo neto a pagar a un empleado descontando las deducciones corrrespondientes de la ley.
            // isss, afp, isr. esto es mensualmente
        }

        // Variable matriz o arreglo que contendra cada uno de los valores mensuales para el salario
        // Esta es una matriz dentro de otra
        private double [][] tablaIsr = new double [][]{
            new Double[] {0.01, 550.00, 0, 0},
            new Double[] {550.01, 895.24, 0.10, 17.67},
            new Double[] {895.25, 2038.10, 0.20, 60.00},
            new Double[] {2038.11, 9999999, 0.30, 288.57}
            };

        private double calculardeduciones(double sueldo, double porcentaje)
        {
            return sueldo * porcentaje;

        }

        private double calularIsr(double sueldo) {
            double isr = 0;

            for(int i = 0; i < tablaIsr.Length; i++)
            {
                // En los casos que sea entre esos valores es mas facil de calcularlo sabiendo si esta entre
                // 0.01 y 472.00, 472.01 y 895.24, 895.25 y 2038.10, o mayor a 2038.11
                if (sueldo >= tablaIsr[i][0] && sueldo <= tablaIsr[i][1]){
                    isr = (sueldo - tablaIsr[i][0]) * tablaIsr[i][2] + tablaIsr[i][3]; // Calculamos el ISR seria 
                    // aplicarle la resta de dinero al sueldo, luego el porcentaje a aplicar y sumarle el sobre de exceso
                    // ejemplo (400 -0.01) * 0 + 0 = 0 no aplica en el caso que sean unicamente 400 dls de salario
                }
            }
            return isr; // Retornamos el ISR calculado
        }

        private void btnCalcular_Click(object sender, EventArgs e){

            double sueldo = 0, isss =  0, afp = 0, isr = 0, sueldoNeto = 0;
            // Variables que usaremos 
            sueldo = double.Parse(txtSueldo.Text); // obteniendo el sueldo del textbox

            isss = calculardeduciones(sueldo, 0.03); // Calculando el ISSS-> siempre es el 3 porciento, 3/100 = 0.03 
            // ejemplo 400 * 0.03 = 12 dls de ISSS
            afp = calculardeduciones(sueldo, 0.0725); // Calculando el AFP -> siempre es el 7.25 porciento, 7.25/100 = 0.0725
            // ejemplo 400 * 0.0725 = 29 dls de AFP
            isr = calularIsr(sueldo-isss-afp); // Calculando el ISR -> se calcula sobre el sueldo menos las deducciones de ISSS y AFP
            // ejemplo 400 - 12 - 29 = 359, luego se calcula el ISR sobre 359

            sueldoNeto = sueldo - (isss + afp + isr);

            lblISSS.Text = "ISSS: " + isss.ToString("C2") + "$"; // Mostramos el ISSS en el label
            lblAFP.Text = "AFP: " + afp.ToString("C2") + "$"; // Mostramos el AFP en el label
            lblISR.Text = "ISR: " + isr.ToString("C2") + "$"; // Mostramos el ISR en el label
            lblTotalDeduciones.Text = "Total Deducciones: " + (isss + afp + isr).ToString("C2") + "$"; // Mostramos el total de deducciones
            lblSueldoNeto.Text = "Sueldo Neto: " + sueldoNeto.ToString("C2") + "$"; // Mostramos el sueldo neto

            // .ToString("C2") formatea el número agregandole el simbolo de moneda local tengo entendido, con dos decimales
        }
    }
}
