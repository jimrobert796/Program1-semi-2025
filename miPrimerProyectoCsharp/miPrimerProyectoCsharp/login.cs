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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            actualizarDs();
        }
        Conexion_base_datos objConexion = new Conexion_base_datos(); // Instancia de la clase conexion
        DataSet objDs = new DataSet(); // Creacion del objeto dataset este tendra la informacion de todas las tablas
        DataTable objDt = new DataTable(); // Creacion del objeto datatable este tendra la informacion de una tabla en especifico


        private void actualizarDs()
        {
            objDs.Clear(); // limpiar el dataset
            objDs = objConexion.obtenerDatos();

            objDt = objDs.Tables["usuarios"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idUsuario"] };

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
               // txtUsuario.Text = objDt.Rows[posicion]["usuario"].ToString();
                //txtClaveUsuario.Text = objDt.Rows[posicion]["clave"].ToString();
            }
        }
    }
}
