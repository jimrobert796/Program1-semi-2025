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

        // Es esta matriz usamos loa valores de metro cuadrado como base 
        private double[] conversiones = { 10.7639/*Pie cuadrado*/, 1.4308280488/*Vara cuadrada*/, 1.19599/*Yarda cuadrada*/, 1/*Metro cuadrado*/, 0.002285741/*Tarea*/, 0.000142857/*manzana*/, 0.00010/*hectarea*/ };

        // Funcion para convertir entre diferentes unidades de medida
        public double conver(double cantidad, int origen, int a)
        {

            double respuesta = 0;
            if (cantidad <= 0)
            {
                return 0;
            }
            else
            {
                respuesta = cantidad * conversiones[a] / conversiones[origen];
                return respuesta;
            }

        }


        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            double cantidad = 0;

            int origen = cboOrigen.SelectedIndex;
            int a = cboAconv.SelectedIndex;
            double respuesta = 0;

            //Si no se ningun valor en el textbox
            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
                return;
            }
            // si no se ingresa un numero 
            if (!double.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("La cantidad ingresada no es un número válido.");
                return;
            }

            cantidad = double.Parse(txtCantidad.Text);

            // si no se seleciona una medida de origen o a convertir
            if (cboOrigen.SelectedIndex == -1 | cboAconv.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecione la medida que desea");
                return;
            }

            respuesta = cantidad * conversiones[a] / conversiones[origen];
            respuesta = Math.Round(respuesta, 2);
            lblRespuesta.Text = "Respuesta: " + respuesta;
        }
    }
}
