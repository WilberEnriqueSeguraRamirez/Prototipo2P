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
    public partial class frmIngreso : Form
    {
        clsControlador cn = new clsControlador();
        public frmIngreso()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string nombre = txtNom.Text;
            string puesto = txtPuesto.Text;
            int idDepto = int.Parse(txtIDepto.Text);
            cn.inserTC(id, nombre, puesto, idDepto);
            MessageBox.Show("Empleado ingresado con éxito");
        }
    }
}
