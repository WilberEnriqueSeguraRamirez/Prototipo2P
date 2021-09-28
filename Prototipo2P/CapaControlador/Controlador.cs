using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using CapaModelo;
using System.Collections;
using System.Data;
namespace CapaControlador
{
    public class clsControlador
    {
        // LLenar una tabla CAPA CONTROLADOR
        clsSentencias sn = new clsSentencias();

        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void Identificacion (int dato)
        {
            sn.Identificacion(dato);
        }
        public DataTable llenarTbl2(string tabla)
        {
            //sn.llenarTbl2(id);
            //ArrayList dt = new ArrayList();
            // dt.Add(tabla);
            //dt.Add(id);
            //DataTable table = new DataTable();
            // dt.Fill(table);
            OdbcDataAdapter dt = sn.llenarTbl2(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public void inserTC(int id, string nombre, string puesto,int idDepto)
        {
            sn.insertT(id, nombre, puesto, idDepto);
        }
        public void Eliminar(int id)
        {
            sn.Eliminar(id);
        }

        public ArrayList cnInd (int id)
        {
            var arlist = sn.cnInd(id);

            return arlist;
        }

        public void Mod(int id, string nom, string puesto, int idDepto, int estado)
        {
            sn.Mod(id, nom, puesto, idDepto, estado);
        }
    }
}
