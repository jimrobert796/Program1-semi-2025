using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace miPrimerProyectoCsharp
{
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }


        DataSet objNotas = new DataSet();
        Conexion objConexion = new Conexion();


        private void actualizarDs()
        {
            

            // recuerda ? nullif si es ques es nullo asi devuelve el valor si da error por default
            // se necesita algo mas correcto 
            int idMateria = int.Parse(cboMateria.SelectedValue?.ToString() ?? "1");
            int idPeriodo = int.Parse(cboPeriodos.SelectedValue?.ToString() ?? "1");

            objNotas.Clear();

            objConexion.objAdaptadir = new SqlDataAdapter("SELECT alumnos.nombre, dnotas.idDetalle, dnotas.idNota, dnotas.idMateria, " +
                "dnotas.lab1, dnotas.lab2, dnotas.parcial, (dnotas.lab1*0.3 + dnotas.lab2*0.3+ dnotas.parcial*0.4) AS  nf " +
                "From dnotas INNER JOIN notas ON (notas.idNota=dnotas.idNota) INNER JOIN alumnos ON(alumnos.idAlumno=notas.idAlumno) " +
                "WHERE notas.idPeriodo=" + idPeriodo + "AND dnotas.idMateria="+ idMateria, objConexion.objConexion);

            objConexion.objAdaptadir.Fill(objNotas, "notasAlumnos");

            /* objComando.CommandText = ;*/
        }


        private void actualizarGrid()
        {
            actualizarDs();
            grdNotas.DataSource = objNotas;
            grdNotas.DataMember = "notasAlumnos";

        }




        private void FrmNotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet.periodos' Puede moverla o quitarla según sea necesario.
            this.periodosTableAdapter.Fill(this.db_academicaDataSet.periodos);
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet.materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.db_academicaDataSet.materias);
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet.dnotas' Puede moverla o quitarla según sea necesario.
            this.dnotasTableAdapter.FilldNotas(this.db_academicaDataSet.dnotas);
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet.notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.FillNotas(this.db_academicaDataSet.notas);
           
            actualizarGrid();
        }

        

        private void cboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void cboPeriodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int nfilas = grdNotas.Rows.Count;

            for (int i = 0; i < nfilas; i++) // 0 < nfilas
            {
                double lab1 = 0;
                double lab2 = 0;
                double parcial = 0;

                int idDetalle = int.Parse(grdNotas.Rows[i].Cells["idDetalle"]?.Value?.ToString() ?? "0");
                lab1 = double.Parse(grdNotas.Rows[i].Cells["lab1"]?.Value?.ToString() ?? "0");
                lab2 = double.Parse(grdNotas.Rows[i].Cells["lab2"]?.Value?.ToString() ?? "0");
                parcial = double.Parse(grdNotas.Rows[i].Cells["parcial"]?.Value?.ToString() ?? "0");

                string sql = "UPDATE dnotas set lab1=" + lab1 + ",lab2=" + lab2 + ",parcial=" + parcial + " WHERE dnotas.idDetalle=" + idDetalle + "";


                string respuestaSql = objConexion.ejecturaSql(sql);

                if (respuestaSql != "1")
                {
                    MessageBox.Show(respuestaSql, "No se pudo actualizar la nota ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            actualizarDs();
        }
    }
}
