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
    public partial class FrmDocentes : Form
    {
        public FrmDocentes()
        {
            InitializeComponent();
        }



        private void FrmDocentes_Load(object sender, EventArgs e)
        {
            actualizarDs();
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

            objDt = objDs.Tables["docentes"]; // Asignar a la tabla objDt la tabla alumnos del dataset objDs
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idDocente"] }; // Definir la llave primaria de la tabla

            grdDocentes.DataSource = objDt.DefaultView; // Asignar el origen de datos del datagridview

            mostrarDatos();
        }

        private void mostrarDatos()
        {
            //Si almenos el conteo de las filas es mayor a 0 mandaria a llamar dicha posicion y su dato
            if (objDt.Rows.Count > 0)
            {
                try
                {
                    idDocente.Text = objDt.Rows[posicion]["idDocente"].ToString();
                    txtCodigoDocente.Text = objDt.Rows[posicion]["codigo"].ToString();
                    txtNombreDocente.Text = objDt.Rows[posicion]["nombre"].ToString();
                    txtMateriaDocente.Text = objDt.Rows[posicion]["materia"].ToString();
                    txtDuiDocente.Text = objDt.Rows[posicion]["dui"].ToString();
                    txtDireccionDocente.Text = objDt.Rows[posicion]["direccion"].ToString();
                    txtTelefonoDocente.Text = objDt.Rows[posicion]["telefono"].ToString();

                    lblRegistro.Text = (posicion + 1) + " de " + objDt.Rows.Count;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar los datos: " + ex.Message);


                }
            }
        }

        private void btnSiguientDocente_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++; // posicion = posicion + 1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro", " Navegacion de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorDocente_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--; // posicion = posicion - 1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro", " Navegacion de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoDocente_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1; // si son 12 entonces segun matrices 12-1 = 11-> ultima posicion
            mostrarDatos();
        }

        private void btnPrimeroDocente_Click(object sender, EventArgs e)
        {
            posicion = 0; // primera posicion segun matrices
            mostrarDatos();
        }

        private void limpiarDatos()
        {
            idDocente.Text = "";
            txtCodigoDocente.Text = "";
            txtNombreDocente.Text = "";
            txtMateriaDocente.Text = "";
            txtDuiDocente.Text = "";
            txtDireccionDocente.Text = "";
            txtTelefonoDocente.Text = "";
        }

        // Funcion para poder habilitar controles edicion y deshabilitar los de navegacion
        private void estadoControles(Boolean estado)
        {
            grbDatosDocente.Enabled = estado;
            grbNavegacionDocentes.Enabled = !estado;
            btnEliminarDocente.Enabled = !estado;
            grbBusquedaDocente.Enabled = !estado;

        }

        private void btnAgregarDocente_Click(object sender, EventArgs e)
        {
            // Si almenos el boton de agregar Nuevo esta segun el texto
            if (btnAgregarDocente.Text == "Nuevo")
            {
                // Cambiaremos las opciones e inabilitaremos navegacion y eliminacion
                btnAgregarDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                estadoControles(true);
                accion = "Nuevo";
                limpiarDatos();
            }// Guardar
            else
            {
                // aqui siempre que se le de guardar hara su accion a la primera no entendia pero es ingenioso
                String[] alumnos = { idDocente.Text, txtCodigoDocente.Text, txtNombreDocente.Text, txtMateriaDocente.Text, txtDuiDocente.Text, txtDireccionDocente.Text, txtTelefonoDocente.Text};
                string respuesta = objConexion.administrarDatosDocentes(alumnos, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al " + accion + " alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                mostrarDatos();
                estadoControles(false);
                btnAgregarDocente.Text = "Nuevo";
                btnModificarDocente.Text = "Modificar";
                actualizarDs();
            }
        }

        private void btnModificarDocente_Click(object sender, EventArgs e)
        {
            // Si almenos el boton de agregar Modificar esta segun el texto
            if (btnModificarDocente.Text == "Modificar")
            {
                // Cambiaremos las opciones e inabilitaremos navegacion y eliminacion
                btnAgregarDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                estadoControles(true);
                accion = "Modificar";
            }// Cancelar 
            else
            { // aqui se hace lo posible por cancelar y quedar todo normal
                mostrarDatos();
                estadoControles(false);
                btnAgregarDocente.Text = "Nuevo";
                btnModificarDocente.Text = "Modificar";
                actualizarDs();
            }
        }

        private void btnEliminarDocente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar a " + txtNombreDocente.Text, "Eliminar alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion.administrarDatosDocentes(new String[] { idDocente.Text, "", "", "", "","","" }, "Eliminar");

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

        private void txtBusquedaDocentes_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBusquedaDocentes.Text);
        }

        private void filtrarDatos(string valor)
        {
            try
            {
                DataView obDv = objDt.DefaultView;
                obDv.RowFilter = "codigo LIKE '%" + valor + "%' OR nombre LIKE '%" + valor + "%' OR materia LIKE  '%"+valor+"%'";
                grdDocentes.DataSource = obDv;

                selecionarAlumno();
            }
            catch (Exception e)
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
                if (grdDocentes.CurrentRow == null)
                {
                    MessageBox.Show("No hay filas");
                    return;
                }
                string id = grdDocentes.CurrentRow.Cells["id"].Value.ToString();
                posicion = objDt.Rows.IndexOf(objDt.Rows.Find(id));
                mostrarDatos();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void grdDocentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selecionarAlumno();
        }
    }
}
