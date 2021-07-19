using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Globalization;

namespace capaDatos
{
    public abstract class dts_RepositorioMaster:dts_Repositorio
    {
        protected DataTable dataTable;
        protected DataTable Datos()
        {
            //Lector del archivo
            string pathOnly = Path.GetDirectoryName(RutaArchivo());
            string fileName = Path.GetFileName(RutaArchivo());
            string sql = @"SELECT * FROM [" + fileName + "]";

            using (OleDbConnection connection = new OleDbConnection(
                    @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathOnly +
                    ";Extended Properties=\"Text;HDR=No\""))
            using (OleDbCommand command = new OleDbCommand(sql, connection))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                dataTable.Locale = CultureInfo.CurrentCulture;
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
    }
}
