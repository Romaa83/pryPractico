using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryPractico
{
    internal class clsProfesiones
    {
        public string cadena = "";
        public OleDbConnection conexion;
        public OleDbCommand comando;
        public OleDbDataAdapter adaptador;
        public DataTable tabla;


        public clsProfesiones()
        {
            cadena = "provider=microsoft.jet.oledb.4.0;data source=TP.mdb";
            conexion = new OleDbConnection(cadena);
            comando = new OleDbCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Profesiones";
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] vector = new DataColumn[1];
            vector[0] = tabla.Columns["profesion"];
            tabla.PrimaryKey = vector;

        }

        public DataTable getAll()
        {
            return tabla;
        }
    }
}
