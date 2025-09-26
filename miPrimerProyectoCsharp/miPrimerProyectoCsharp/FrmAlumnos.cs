using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerProyectoCsharp
{
    public partial class FrmAlumnos : Form
    {
        public FrmAlumnos()
        {
            InitializeComponent(); // Este método es esencial para que se cargue el diseño
        }

        Conexion objConexion = new Conexion(); // Instancia de la clase conexion
        DataSet objDs = new DataSet(); // Creacion del objeto dataset este tendra la informacion de todas las tablas
        DataTable objDt = new DataTable(); // Creacion del objeto datatable este tendra la informacion de una tabla en especifico

        public int posicion = 0;  //Se encarga de manejar la posicion de donde se estaria en la BD
        public string accion = "nuevo"; // variable que me dira si estoy agregando, modificando o eliminando un registro

        //ACTUALIZAR EL DATASET
        private void actualizarDs()
        {
            objDs.Clear(); // limpiar el dataset
            objDs = objConexion.obtenerDatos();

            objDt = objDs.Tables["alumnos"]; // Asignar a la tabla objDt la tabla alumnos del dataset objDs
            objDt.PrimaryKey = new DataColumn[] {objDt.Columns["idAlumno"] }; // Definir la llave primaria de la tabla

            grdAlumnos.DataSource = objDt.DefaultView; // Asignar el origen de datos del datagridview

            mostrarDatos();
        }

        private void mostrarDatos()
        {
            //Si almenos el conteo de las filas es mayor a 0 mandaria a llamar dicha posicion y su dato
            if (objDt.Rows.Count > 0)
            {
                idALumno.Text = objDt.Rows[posicion]["idAlumno"].ToString();
                txtCodigoAlumno.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreAlumno.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccionAlumno.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoAlumno.Text = objDt.Rows[posicion]["telefono"].ToString();

                lblRegistroAlumno.Text = (posicion + 1) + " de " + objDt.Rows.Count;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        // Boton para el siguiente alumno
        private void btnSiguienteAlumno_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++; // posicion = posicion + 1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro", " Navegacion de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Boton para el alumno anterior
        private void btnAnteriorAlumno_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--; // posicion = posicion - 1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro", " Navegacion de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Boton para ir al ultimo alumno en la base de datos 
        private void btnUltimoAlumno_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1; // si son 12 entonces segun matrices 12-1 = 11-> ultima posicion
            mostrarDatos();
        }

        // Boton para ir al primer alumno en la base de datos
        private void btnPrimeroAlumno_Click(object sender, EventArgs e)
        {
            posicion = 0; // primera posicion segun matrices
            mostrarDatos();

        }


        //LIMPIAR DATOS
        private void limpiarDatos()
        {
            idALumno.Text = "";
            txtCodigoAlumno.Text = "";
            txtNombreAlumno.Text = "";
            txtDireccionAlumno.Text = "";
            txtTelefonoAlumno.Text = "";
        }


        // Funcion para poder habilitar controles edicion y deshabilitar los de navegacion
        private void estadoControles(Boolean estado)
        {
            grbDatosAlumnos.Enabled = estado;
            grbNavegacionAlumnos.Enabled = !estado;
            btnEliminarAlumno.Enabled = !estado;
            grbBusquedaAlumnos.Enabled = !estado;

        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            // Si almenos el boton de agregar Nuevo esta segun el texto
            if (btnAgregarAlumno.Text == "Nuevo")
            {
                // Cambiaremos las opciones e inabilitaremos navegacion y eliminacion
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                estadoControles(true);
                accion = "Nuevo";
                limpiarDatos();
            }// Guardar
            else
            {
                // aqui siempre que se le de guardar hara su accion a la primera no entendia pero es ingenioso
                String[] alumnos = {idALumno.Text, txtCodigoAlumno.Text, txtNombreAlumno.Text, txtDireccionAlumno.Text, txtTelefonoAlumno.Text };
                string respuesta = objConexion.administrarDatosAlumnos(alumnos, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al " + accion + " alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                mostrarDatos();
                estadoControles(false);
                btnAgregarAlumno.Text = "Nuevo";
                btnModificarAlumno.Text = "Modificar";
                actualizarDs();
            }

        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            // Si almenos el boton de agregar Modificar esta segun el texto
            if (btnModificarAlumno.Text == "Modificar")
            {
                // Cambiaremos las opciones e inabilitaremos navegacion y eliminacion
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                estadoControles(true);
                accion = "Modificar";
            }// Cancelar 
            else
            { // aqui se hace lo posible por cancelar y quedar todo normal
                mostrarDatos();
                estadoControles(false);
                btnAgregarAlumno.Text = "Nuevo";
                btnModificarAlumno.Text = "Modificar";
                actualizarDs();
            }
        }

        // Boton para eliminar que lo unico que se necesita es saber que indice es el que se tiene de id para poder eliminarlo directamente en la tabla
        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar a " + txtNombreAlumno.Text, "Eliminar alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion.administrarDatosAlumnos(new String[] {idALumno.Text, "", "", "", ""}, "Eliminar");

                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
       

        private void txtBusquedaAlumnos_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBusquedaAlumnos.Text);

        }

        private void filtrarDatos(string valor)
        {
            try {
                DataView obDv = objDt.DefaultView;
                obDv.RowFilter = "codigo like '%" + valor + "%' OR nombre like '%" + valor + "%'";
                grdAlumnos.DataSource = obDv;

                selecionarAlumno();
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
   
        }

        private void selecionarAlumno()
        {
            // SOLUCION EN CASO NO SE ENCUENTRE NADA
            // si el conteo de filas es ninguna por algun error no entrara a mostrar los datos

            try
            {
                if (grdAlumnos.CurrentRow == null)
                {
                    MessageBox.Show("No hay filas");
                    return;
                }
                string id = grdAlumnos.CurrentRow.Cells["id"].Value.ToString();
                posicion = objDt.Rows.IndexOf(objDt.Rows.Find(id));
                mostrarDatos();
               

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);


            }
        }
        private void grdAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selecionarAlumno();
        }

        
    }
    
}