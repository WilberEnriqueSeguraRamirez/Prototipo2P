using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class frmEliminar : Form
    {
        clsControlador cn = new clsControlador();
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea dar de baja al Empleado?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = int.Parse(txtID.Text);
                cn.Eliminar(id);
                MessageBox.Show("Empleado ha sido dado de baja con éxito");
            }
            else
            {
                MessageBox.Show("No se dio de baja al empleado");
            }
        }
    }
}
