using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerProyectoCsharp
{
    public partial class frm_usuarios : Form{
        public frm_usuarios(){
            InitializeComponent(); // Este método es esencial para que se cargue el diseño
        }

        Conexion_base_datos objConexion = new Conexion_base_datos(); // Instancia de la clase conexion
        DataSet objDs = new DataSet(); // Creacion del objeto dataset este tendra la informacion de todas las tablas
        DataTable objDt = new DataTable(); // Creacion del objeto datatable este tendra la informacion de una tabla en especifico

        public int posicion = 0;  //Se encarga de manejar la posicion de donde se estaria en la BD
        public string accion = "nuevo"; // variable que me dira si estoy agregando, modificando o eliminando un registro

        //ACTUALIZAR EL DATASET
        private void actualizarDs()
        {
            objDs.Clear(); // limpiar el dataset
            objDs = objConexion.obtenerDatos();

            objDt = objDs.Tables["usuarios"]; 
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idUsuario"] }; 

          

            mostrarDatos();
        }

        string clave = "";

        private void mostrarDatos()
        {
            //Si almenos el conteo de las filas es mayor a 0 mandaria a llamar dicha posicion y su dato
            if (objDt.Rows.Count > 0)
            {
                idUsuario.Text = objDt.Rows[posicion]["idUsuario"].ToString();
                txtUsuario.Text = objDt.Rows[posicion]["usuario"].ToString();
                txtClaveUsuario.Text = objDt.Rows[posicion]["clave"].ToString();
                txtNombreUsuario.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccionUsuario.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoUsuario.Text = objDt.Rows[posicion]["telefono"].ToString();
                


                lblRegistroUsuario.Text = (posicion + 1) + " de " + objDt.Rows.Count;

            }
            string clave = txtClaveUsuario.Text;
        }

        private void Form1_Load(object sender, EventArgs e){
           actualizarDs();
        }

        private void btnSiguienteUsuario_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++; // posicion = posicion + 1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro", " Navegacion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorUsuario_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--; // posicion = posicion - 1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro", " Navegacion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoUsuario_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1; // si son 12 entonces segun matrices 12-1 = 11-> ultima posicion
            mostrarDatos();
        }

        private void btnPrimeroUsuario_Click(object sender, EventArgs e)
        {
            posicion = 0; // primera posicion segun matrices
            mostrarDatos();
        }
        private void limpiarDatos()
        {
            idUsuario.Text = "";
            txtUsuario.Text = "";
            txtClaveUsuario.Text = "";
            txtNombreUsuario.Text = "";
            txtDireccionUsuario.Text = "";
            txtTelefonoUsuario.Text = "";
        }

        private void estadoControles(Boolean estado)
        {
            grbDatosUsuario.Enabled = estado;
            grbNavegacionUsuario.Enabled = !estado;
            btnEliminarUsuario.Enabled = !estado;
           

        }
        
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            // Si almenos el boton de agregar Nuevo esta segun el texto
            if (btnAgregarUsuario.Text == "Nuevo")
            {
                // Cambiaremos las opciones e inabilitaremos navegacion y eliminacion
                btnAgregarUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                estadoControles(true);
                accion = "Nuevo";
                limpiarDatos();
            }// Guardar
            else
            {
                string usuario = txtNombreUsuario.Text;
                

                String[] usuarios = { idUsuario.Text, txtUsuario.Text, txtClaveUsuario.Text, txtNombreUsuario.Text, txtDireccionUsuario.Text, txtTelefonoUsuario.Text };
                    String respuesta = objConexion.mantenimiento_usuarios(usuarios, accion);
                    if (respuesta != "1")
                    {
                        MessageBox.Show(respuesta, "Error al " + accion + " usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    mostrarDatos();
                    estadoControles(false);
                    btnAgregarUsuario.Text = "Nuevo";
                    btnModificarUsuario.Text = "Modificar";
                    actualizarDs();
                

                   
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            // Si almenos el boton de agregar Modificar esta segun el texto
            if (btnModificarUsuario.Text == "Modificar")
            {
   
                // Cambiaremos las opciones e inabilitaremos navegacion y eliminacion
                btnAgregarUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                estadoControles(true);
                accion = "Modificar";
            }// Cancelar 
            else
            { // aqui se hace lo posible por cancelar y quedar todo normal
                mostrarDatos();
                estadoControles(false);
                btnAgregarUsuario.Text = "Nuevo";
                btnModificarUsuario.Text = "Modificar";
                actualizarDs();
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar a " + txtNombreUsuario.Text, "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion.mantenimiento_usuarios(new String[] {idUsuario.Text, "", "", "", "", ""}, "Eliminar");

                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // Reiniciar la posicion y actualizar el dataset para para mostrar los datos
                    posicion = 0;
                    actualizarDs();
                }
            }
        }

        private void grbDatosUsuario_Enter(object sender, EventArgs e)
        {

        }
    }
}
