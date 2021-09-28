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
    public partial class ConsultaGen : Form
    {
        clsControlador cn = new clsControlador();
        string tabla = "empleado";
        public ConsultaGen()
        {
            InitializeComponent();
        }
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(tabla);
            dtgConsulta.DataSource = dt;

        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
