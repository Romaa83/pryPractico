using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryPractico
{
    internal class clsEncuestas
    {
        public string cadena = "";
        public OleDbConnection conexion;
        public OleDbCommand comando;
        public OleDbDataAdapter adaptador;
        public DataTable tabla;


        public clsEncuestas()
        {
            cadena = "provider=microsoft.jet.oledb.4.0;data source=TP.mdb";
            conexion = new OleDbConnection(cadena);
            comando = new OleDbCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "encuestas";
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

        }

        public DataTable getAll()
        {
            return tabla;
        }
    }
}
