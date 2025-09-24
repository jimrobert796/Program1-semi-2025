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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Este método es esencial para que se cargue el diseño
        }


        Conexion objConexion = new Conexion(); // Instancia de la clase Conexion
        DataSet objDs = new DataSet(); // Instancia de la clase DataSet
        DataTable objDt = new DataTable(); // Instancia de la clase DataTable

        int posicion = 0; // Variable para la posición del registro actual
        string accion = "";

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void actualizarDatos()
        {
            // Imagina que es limpiar y conectar 
            objDs.Clear(); // Limpiar el DataSet
            objDs = objConexion.ObtenerDatos(); // Obtener los datos de la base de datos

            // Aqui imagina que es en (objdt) llenear en memoria la tabla que se necesita
            objDt = objDs.Tables["docentes"]; // Asignar la tabla "docentes" al DataTable
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["IdDocentes"] }; // Asignar la clave primaria a la creacion de tabla

            mostrarDatos();
            // No se modifique nada 
            grbDatosDocente.Enabled = false;

            lblXdeN.Text = (posicion + 1).ToString()+ " a "+ objDt.Rows.Count;

            grvBusqueda.DataSource = objDt.DefaultView;

        }
        // Se encarga de que se muestren los datos en los cuadros de texto
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idDocentes.Text = objDt.Rows[posicion]["IdDocentes"].ToString();
                txtCodigoDocente.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtMateriaDocente.Text = objDt.Rows[posicion]["materia"].ToString();
                txtNombreDocente.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccionDocente.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoDocente.Text = objDt.Rows[posicion]["telefono"].ToString();

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDatos(); // Llamar al método para actualizar los datos al cargar el formulario    
        }

        // Al pulsar el boton siguiente deberia avanzar al siguiente registro en pantalla
        private void btnSiguienteDocente_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;
                actualizarDatos();
            }
            else
            {
                // message box funciona asi, texto, texto de ventana, botones, iconos
                MessageBox.Show("Ya estas en el ultimo registro", "Navegacion Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // al presionar el boton anterior deberia retroceder al registro anterior en pantalla
        private void btnAnteriorDocente_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                actualizarDatos();
            }
            else
            {
                // message box funciona asi, texto, texto de ventana, botones, iconos
                MessageBox.Show("Ya estas en el primer registro", "Navegacion Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Al presionar el boton ultimo deberia ir al primer registro en pantalla
        private void btnPrimerDocente_Click(object sender, EventArgs e)
        {
            posicion = 0;
            actualizarDatos();
        }

        private void btnUltimoDocente_Click(object sender, EventArgs e)
        {
            // objDt.Rows.Count = el conteo total ejemplo son 2 pero en las pociciones 
            // solamente estan 0 y 1 por eso se resta 1
            posicion = objDt.Rows.Count - 1;
            actualizarDatos();
        }


        private void limpiarDatos()
        {
            idDocentes.Text = "";
            txtCodigoDocente.Text = "";
            txtMateriaDocente.Text = "";
            txtNombreDocente.Text = "";
            txtDireccionDocente.Text = "";
            txtTelefonoDocente.Text = "";
        }

        // Recuerda solamente funcionalidad del boton nuevo
        private void btnNuevoDocente_Click(object sender, EventArgs e)
        {
            if (btnNuevoDocente.Text == "Nuevo")
            {

                accion = "Nuevo";

                limpiarDatos();

                btnNuevoDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                btnEliminarDocente.Enabled = false;

                //activar funcionalidad de agregar
                grbDatosDocente.Enabled = true;
                grbNavegacionDocente.Enabled = false;
                grbBusquedaDocente.Enabled = false;
            }
            else // GUARDAR -> NUEVO
            {
                string []datos = { idDocentes.Text, txtCodigoDocente.Text, txtMateriaDocente.Text, txtNombreDocente.Text, txtDireccionDocente.Text, txtTelefonoDocente.Text };
                string respuesta = objConexion.administrarDatos(datos, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al " + accion + " docente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else {
                    btnNuevoDocente.Text = "Nuevo";
                    btnModificarDocente.Text = "Modificar";
                    btnEliminarDocente.Enabled = true;
                    actualizarDatos();
                    // mostrar datos queda sin reiniciar la consula

                    //desactivar funcionalidad de agregar
                    grbDatosDocente.Enabled = false;
                    grbNavegacionDocente.Enabled = true;
                    grbBusquedaDocente.Enabled = true;

                    MessageBox.Show("Se guardo correctamente el docente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                    
                }
                
                   
            }
        }

        private void btnModificarDocente_Click(object sender, EventArgs e)
        {
            if (btnModificarDocente.Text == "Modificar")
            {
                accion = "Modificar";

                btnNuevoDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                btnEliminarDocente.Enabled = false;

                //activar funcionalidad de agregar
                grbDatosDocente.Enabled = true;
                grbNavegacionDocente.Enabled = false;
                grbBusquedaDocente.Enabled = false;
            }
            else // CANELAR -> Modificar
            {

                btnNuevoDocente.Text = "Nuevo";
                btnModificarDocente.Text = "Modificar";
                btnEliminarDocente.Enabled = true;
                grbBusquedaDocente.Enabled = true;

                mostrarDatos();
                // mostrar datos queda sin reiniciar la consula

                //desactivar funcionalidad de agregar
                grbDatosDocente.Enabled = false;
                grbNavegacionDocente.Enabled = true;


            }
        }


        // TODO LO QUE CONLLEVA BUSQUEDA
        private void btnEliminarDocente_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Esta seguro de eliminar a " + objDt.Rows[posicion]["nombre"].ToString(), "Eliminar Docente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
           {
                accion = "Eliminar";
               
                // para borrar necesitamos su ID unico
                string[] datos = {idDocentes.Text, "", "", "","", ""};

                // Hacer lo que seria la eliminacion recordando que nos devuelve un string si hace ello
                string respuesta = objConexion.administrarDatos(datos, accion);

                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al " + accion + " docente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    posicion = 0;
                    actualizarDatos();
                }


            }
        }
        // Al hacer clic mostrar la informacion correspondiente
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarDocente();
        }

        //Esta lo que hace es consultar lo mas posivle a lo escrito
        private void filtrarDocente(string txt)
        {
            // hacer un data view que contenga la vista
            DataView objdv = objDt.DefaultView;
            //Hacemos un filtro en la memoria para buscar el parecido
            objdv.RowFilter = "Codigo LIKE '%" + txt + "%' OR Nombre LIKE '%"+txt+"%'";
            // y ahora los datos a tomar en el gridview son de la consulta
            grvBusqueda.DataSource = objdv;

            seleccionarDocente();
        }
        //Esta funcion busca especificamente la posicion selecionada en el grid
        private void seleccionarDocente()
        {
            // en el caso que no haya nada al filtrar
            if (grvBusqueda.Rows.Count > 0)
            {
                //      objDt.Filas int index(objDt.Filas.Buscar(grvBusqueda.FilaDondeestamos.Celda["Id].valor -> devolver el valor dentro del grv))
                posicion = objDt.Rows.IndexOf(objDt.Rows.Find(grvBusqueda.CurrentRow.Cells["Id"].Value));
                // este con el fin no solo de mostrar sino que sirve para mostrar los corresponidentes segun el grid
                actualizarDatos();
            }
        }
        //Al presionar que haga la busqueda
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            filtrarDocente(txtBusquedaDocente.Text);
        }
    }

}
