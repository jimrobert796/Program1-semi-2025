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
           
        }
        /*
            Monedas
            Longitud
            Masa
            Volumen
            Almacenamiento
            Tiempo
            Area
         */

        String[][] etiquetas = new string[][] {
            new string[]{"Dolar", "Pesos Mexicanos", "Quetzal", "Lempira", "Colon SV", "Cordobas", "Colon CR"}, //Monedas
            new string[]{"Metros", "Cm", "Pulgadas","Pie", "Varas", "Yardas", "Km", "Millas"}, //Longitud
            new string[]{"Libra", "Onza", "Gramo", "Kg", "Quintal", "Tonelada Corta"}, //Masa
            new string[]{"Galon Us", "Litros", "Pinta Us", "Ml"}, //Volumen
            new string[]{"GB", "Bit", "Byte", "KB", "MG", "TB"}, //Almacenamiento
            new string[]{"Dia", "Segundos", "Minutos", "Horas", "Semana", "Meses", "Año"}, //Tiempo
            new string[]{"Km^2","Metro", "Milla", "Yarda", "Pie", "Pulgada", "Hectaria"}, //Area 
        };

        // Matriz con los valores de conversion de uno el inical a los demas
        // dollar a los demas y asi con los demas 
        double[][] valores = new double[][]{
            new double []{1,18.78, 7.66, 26.15, 8.75, 36.78, 504.12}, //Monedas
            new double []{1, 100, 39.37, 3.28084, 1.193, 1.09361, 0.001, 0.000621371}, //Longitud
            new double []{1, 16, 453.592, 0.453592, 0.01, 0.001,0.0005}, //Masa
            new double []{1, 3.78541, 8, 3785.41}, //Volumen
            new double []{1, 8e+9, 1e+9, 1e+6, 1000, 0.001}, //Almacenamiento
            new double []{1, 86400, 1440, 24, 0.142857, 0.0328767, 0.00273973}, //Tiempo
            new double []{1, 1e+6, 0.386102, 1.196e+6, 1.076e+7, 1.55e+9, 100 } //Tiempo
        };

        private void btnCalcular_Click(object sender, EventArgs e){
            try
            {
                double cantidad = double.Parse(txtCantidadConversor.Text);

                int tipo = cboTipoConversor.SelectedIndex; // Tipo de conversion
                int de = cboDeConversor.SelectedIndex; // De que unidad
                int a = cboAConversor.SelectedIndex; // A que unidad

                // Ejemplo :  cantidad -> 12 dolares ejemplo alor[0][0] -> 18.87 / valor[0][1] -> 1
                /// 12$ * 18.78 pesos
                ///        ----------   =   255.36 pesos
                ///           1$

                // Funciona esta formula para cualquier conversion
                double respuesta = cantidad * valores[tipo][a] / valores[tipo][de];

                lblRespuestaConversor.Text = "RESPUESTA: " + respuesta;
            }
            catch(Exception er)
            {
                lblRespuestaConversor.Text = "ERROR"; 
            }

        }
        // Para subirlo 
        // Se agrego el conversor de area y validaciones

        private double convertir( int tipo, int de, int a, double cantidad)
        {
            if (cantidad <= 0)
            {
                return 0;
            }
            return cantidad * valores[tipo][a] / valores[tipo][de];

        }

        // Cuando cambie el cboTipoConversor
        private void cboTipoConversor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboAConversor.Items.Clear();
            cboDeConversor.Items.Clear();

            // Segun la pocicion, llenara segun el indice tomara la matriz
            // si seleciona longitud, tomaray agregara los contenidos de la matriz de longitud en su pocicion
            cboAConversor.Items.AddRange(etiquetas[cboTipoConversor.SelectedIndex]);
            cboDeConversor.Items.AddRange(etiquetas[cboTipoConversor.SelectedIndex]);

        }
    }
}
