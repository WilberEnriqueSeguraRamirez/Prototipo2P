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
    public partial class frmMod : Form
    {
        clsControlador cn = new clsControlador();
        string tabla = "empleado";
        int codigo;
        public frmMod()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            codigo = id;
            var arlist = cn.cnInd(id);
            txtID.Text = (string)arlist[0];
            txtNom.Text = (string)arlist[1];
            txtP.Text = (string)arlist[2];
            txtIDepto.Text = (string)arlist[3];
            txtEstado.Text = (string)arlist[4];

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Modificar al Empleado?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = int.Parse(txtID.Text); 
                string nom = txtNom.Text;
                string puesto = txtP.Text;
                int depto = int.Parse(txtIDepto.Text);
                int est = int.Parse(txtEstado.Text);
                cn.Mod(codigo, nom, puesto, depto, est);
                MessageBox.Show("Empleado ha sido modificado con éxito");
                codigo = 0;
            }
            else
            {
                MessageBox.Show("No se modificó al empleado");
            }
        }
    }
}
