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
    public partial class frmCI : Form
    {
        clsControlador cn = new clsControlador();
        string tabla = "empleado";
        public frmCI()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
        public void actualizardatagriew()
        {
            int id = int.Parse(txtID.Text);
            cn.Identificacion(id);
            DataTable dt = cn.llenarTbl2(tabla);
            dtgConsulta.DataSource = dt;

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
