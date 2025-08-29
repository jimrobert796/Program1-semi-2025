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
        //funciones
        //matrices
        // LINQ -> Lenguaje de consulta integrado



        double media(int[] serie)
        {

            // entrar en cada elemento de la matriz e integrarlo en una matriz double 

            // Como se calcula la media aritmética  
            // la suma de (todos los elementos) / numero de elementos que hay 
            // 5, 8, 4, 9 -> [5, 8, 4, 9] media = (5 + 8 + 4 + 9) / 4 = 6.5

            
            return serie.Average(); // función de LINQ quec calcula la media aritmética
        }



        double tipica (int[] serie, double m)
        {

            //Como se calcula la desviación típica

            // LA SUMA DE ((cada elemento - media)^2) / numero de elementos
            // recuerda hay que hacer una suma total de la parte de arriba para proceder a dividir

            
            return Math.Sqrt(serie.Average(n=>Math.Pow(n -m, 2))); // función de LINQ que calcula la desviación típica
            // Voy a ser sincero me cuesta entenderlo es como lamba ... 
        }

        double armonica(int[] serie)
        {

            // Como se calcula la media armonica
            // seria el numero de elementos / la suma de (1 / cada elemento) <-armonica
            // para esta hay que tener la sumatoria de 1/ cada elemento para poder dividir
            // elementos / sumatoria = armonica 
            
            int n = serie.Length;


            return n / serie.Sum(num => 1.0/num); // funciona pero es mas legible ya comprendi
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] serie = txtxSerie.Text.Split(',').Select(n => int.Parse(n)).ToArray(); // 5, 8, 4, 9 -> [5, 8, 4, 9]

           

            double mediaAritmetica = media(serie); // llamo a la función media
            double desviacionTipica = tipica(serie, mediaAritmetica); // llamo a la funcion de desviacion tipica
            double armonicaa = armonica(serie); // llamo a la funcion de media armonica 

            // mostrar los resultados en los labels correspondientes

            lblMedia.Text = "Media aritmética = " + mediaAritmetica;
            lblDesviacionTipica.Text = "Desviación típica = " + desviacionTipica;
            lblbArmonica.Text = "Armonica = " + armonicaa;

        }
    }
}
