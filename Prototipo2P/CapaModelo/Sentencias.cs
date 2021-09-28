using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Collections;
using System.Data;

namespace CapaModelo
{
    public class clsSentencias
    {
        int dato;
        // obtener datos de una tabla CAPA MODELO
        clsConexion con = new clsConexion();
        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + " where estado = 1;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public void Identificacion(int id)
        {
            dato = id;
        }
        public OdbcDataAdapter llenarTbl2(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM "+ tabla +" where codEmpleado = "+ dato +";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }
        public void insertT(int id, string nombre, string puesto, int idDepto)// metodo  para ingresar un empleado
        {
            try
            {
                string cadena = "insert into empleado values(" + id + ",'" + nombre + "','" + puesto + "',"+idDepto+",1);";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);

            }
        }
        public void Eliminar(int id)// metodo  para dar de baja a un empleado
        {
            try
            {
                string cadena = "update empleado set estado = 0 where codEmpleado = "+id+";";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);

            }
        }

        public ArrayList cnInd (int id)
        {
            var arlist = new ArrayList();
            string cadena = "select * from empleado where codEmpleado = " + id + ";";
            OdbcCommand busI = new OdbcCommand(cadena, con.conexion());
            OdbcDataReader lector = busI.ExecuteReader();
            while (lector.Read())
            {
                for (int i = 0; i < 5; i++)
                {
                    arlist.Add(lector[i].ToString());
                }
            }
            return arlist;
        }

        public void Mod(int id, string nom, string puesto, int idDepto, int estado)// metodo  para dar de baja a un empleado
        {
            try
            {
                string cadena = "update empleado set nombre = '"+nom+"', puesto = '"+puesto+"', idDepto = "+idDepto+", estado = "+estado+" where codEmpleado = " + id + ";";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);

            }
        }
    }
}