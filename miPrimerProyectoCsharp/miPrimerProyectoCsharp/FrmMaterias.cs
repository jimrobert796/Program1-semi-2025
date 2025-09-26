using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace miPrimerProyectoCsharp
{
    public partial class FrmMaterias : Form
    {
        public FrmMaterias()
        {
            InitializeComponent();
        }

        Conexion objConexion = new Conexion(); // Instancia de la clase conexion
        DataSet objDs = new DataSet(); // Creacion del objeto dataset este tendra la informacion de todas las tablas
        DataTable objDt = new DataTable(); // Creacion del objeto datatable este tendra la informacion de una tabla en especifico

        public int posicion = 0;  //Se encarga de manejar la posicion de donde se estaria en la BD
        public string accion = "nuevo"; // variable que me dira si estoy agregando, modificando o eliminando un registro

        private void actualizarDs()
        {
            objDs.Clear(); // limpiar el dataset
            objDs = objConexion.obtenerDatos();

            objDt = objDs.Tables["materias"]; // Asignar a la tabla objDt la tabla alumnos del dataset objDs
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idMateria"] }; // Definir la llave primaria de la tabla

            grdMaterias.DataSource = objDt.DefaultView; // Asignar el origen de datos del datagridview

            mostrarDatos();
        }

        private void mostrarDatos()
        {
            //Si almenos el conteo de las filas es mayor a 0 mandaria a llamar dicha posicion y su dato
            if (objDt.Rows.Count > 0)
            {
                idMateria.Text = objDt.Rows[posicion]["idMateria"].ToString();
                txtCodigoMateria.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreMateria.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtUVMateria.Text = objDt.Rows[posicion]["uv"].ToString();

                lblRegistroAlumno.Text = (posicion + 1) + " de " + objDt.Rows.Count;

            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            actualizarDs();
            cboOpcionBuscarMateria.SelectedIndex = 0; // Seleccionar la primera opcion del combo al cargar el formulario
        }

       


        // Boton para el siguiente alumno
        private void btnSiguienteMateria_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++; // posicion = posicion + 1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro", " Navegacion de materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        

        //Boton para el alumno anterior
        private void btnAnteriorMateria_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--; // posicion = posicion - 1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro", " Navegacion de materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Boton para ir al primer alumno en la base de datos
        private void btnPrimeraMateria_Click(object sender, EventArgs e)
        {
            posicion = 0; // primera posicion segun matrices
            mostrarDatos();
        }

        //Boton para ir al ultimo alumno en la base de datos 
        private void btnUltimaMateria_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1; // si son 12 entonces segun matrices 12-1 = 11-> ultima posicion
            mostrarDatos();
        }

        //LIMPIAR DATOS
        private void limpiarDatos()
        {
            idMateria.Text = "";
            txtCodigoMateria.Text = "";
            txtNombreMateria.Text = "";
            txtUVMateria.Text = "";
        }

        // Funcion para poder habilitar controles edicion y deshabilitar los de navegacion
        private void estadoControles(Boolean estado)
        {
            grbDatosMateria.Enabled = estado;
            grbNavegacionMateria.Enabled = !estado;
            btnEliminarMateria.Enabled = !estado;
            grdMaterias.Enabled = !estado;

        }

        // Boton agregar materia
        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            // Si almenos el boton de agregar Nuevo esta segun el texto
            if (btnAgregarMateria.Text == "Nuevo")
            {
                // Cambiaremos las opciones e inabilitaremos navegacion y eliminacion
                btnAgregarMateria.Text = "Guardar";
                btnModificarMateria.Text = "Cancelar";
                estadoControles(true);
                accion = "Nuevo";
                limpiarDatos();
            }// Guardar
            else
            {
                // aqui siempre que se le de guardar hara su accion a la primera no entendia pero es ingenioso
                String[] alumnos = { idMateria.Text, txtCodigoMateria.Text, txtNombreMateria.Text, txtUVMateria.Text };
                string respuesta = objConexion.administrarDatosMaterias(alumnos, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al " + accion + " alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                mostrarDatos();
                estadoControles(false);
                btnAgregarMateria.Text = "Nuevo";
                btnModificarMateria.Text = "Modificar";
                actualizarDs();
            }




        }
        //Boton modificar materia
        private void btnModificarMateria_Click(object sender, EventArgs e)
        {
            // Si almenos el boton de agregar Modificar esta segun el texto
            if (btnModificarMateria.Text == "Modificar")
            {
                // Cambiaremos las opciones e inabilitaremos navegacion y eliminacion
                btnAgregarMateria.Text = "Guardar";
                btnModificarMateria.Text = "Cancelar";
                estadoControles(true);
                accion = "Modificar";
            }// Cancelar 
            else
            { // aqui se hace lo posible por cancelar y quedar todo normal
                mostrarDatos();
                estadoControles(false);
                btnAgregarMateria.Text = "Nuevo";
                btnModificarMateria.Text = "Modificar";
                actualizarDs();
            }
        }

        // Boton eliminar materia
        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar a " + txtNombreMateria.Text, "Eliminar alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion.administrarDatosMaterias(new String[] { idMateria.Text, "", "", "" }, "Eliminar");

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


        // Despues de teclear en el cuadro de busqueda hara el filtrado de datos a buscar
        private void txtBusquedaMateria_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBusquedaMateria.Text);
        }

        private void filtrarDatos(string valor)
        {
            try
            {
                DataView obDv = objDt.DefaultView;
                // adaptarlo para que busque por codigo o nombre
                switch (cboOpcionBuscarMateria.SelectedIndex)
                {
                    case 0: // Codigo -> exactitud
                        obDv.RowFilter = " codigo = " + valor ;
                        break;
                    case 1: // Nombre -> coincidencia
                        obDv.RowFilter = " nombre like '%" + valor + "%'";
                        break;
                }
                grdMaterias.DataSource = obDv;
                selecionarAlumno();
            }
            catch (Exception e)
            {
               //MessageBox.Show(e.Message);
            }

        }

        private void selecionarAlumno()
        {
            // SOLUCION EN CASO NO SE ENCUENTRE NADA
            // si el conteo de filas es ninguna por algun error no entrara a mostrar los datos

            try
            {
                if (grdMaterias.CurrentRow == null)
                {
                    // mejor que no haga nada si no es nullo
                    //MessageBox.Show("No hay filas");
                    return;
                }
                string id = grdMaterias.CurrentRow.Cells["id"].Value.ToString();
                posicion = objDt.Rows.IndexOf(objDt.Rows.Find(id));
                mostrarDatos();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);


            }
        }

        private void grdMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selecionarAlumno();
        }
    }
}
