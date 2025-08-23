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

       

        private void btnCalcular_Click(object sender, EventArgs e){

            string[] serie = txtSerie.Text.Split(','); // 5,10,11 -> ["5","10","11"] -> string[] = new string {"5","10","11"};

            int suma = 0;

            for (int i = 0; i < serie.Length; i++)
            {
                suma = suma + int.Parse(serie[i]);
            }

            lblSuma.Text = "La suma es: " + suma;  
            //lblSuma.Text = "La suma es: " + serie.Sum();  Tiene que ser numerica la matriz 
        }
    }
}
