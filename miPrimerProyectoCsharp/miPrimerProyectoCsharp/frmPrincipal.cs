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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Inicar el formulario de alumnos
            FrmAlumnos objAlumnos = new FrmAlumnos();
            objAlumnos.MdiParent = this; // Establecer el formulario principal como padre
            objAlumnos.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaterias objMaterias = new FrmMaterias();
            objMaterias.MdiParent = this; // Establecer el formulario principal como padre
            objMaterias.Show();
        }

        private void periodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPeriodos objPeriodos = new FrmPeriodos();
            objPeriodos.MdiParent = this; // Establecer el formulario principal como padre
            objPeriodos.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocentes objDocente = new FrmDocentes();
            objDocente.MdiParent = this; // Establecer el formulario principal como padre
            objDocente.Show();

        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNotas objNotas = new FrmNotas();
            objNotas.MdiParent = this; // Establecer el formulario principal como padre
            objNotas.Show();
        }
    }
}
