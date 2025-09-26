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
            Form1 objAlumnos = new Form1();
            objAlumnos.MdiParent = this; // Establecer el formulario principal como padre
            objAlumnos.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 objMaterias = new Form3();
            objMaterias.MdiParent = this; // Establecer el formulario principal como padre
            objMaterias.Show();
        }

        private void periodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPeriodos objPeriodos = new FrmPeriodos();
            objPeriodos.MdiParent = this; // Establecer el formulario principal como padre
            objPeriodos.Show();
        }
    }
}
