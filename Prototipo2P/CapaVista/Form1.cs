using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void ingresarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngreso forma = new frmIngreso();
            forma.Show();
        }

        private void darDeBajaEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminar forma = new frmEliminar();
            forma.Show();
        }

        private void modificarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMod forma = new frmMod();
            forma.Show();
        }

        private void consultaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaGen forma = new ConsultaGen();
            forma.Show();
        }
    }
}
