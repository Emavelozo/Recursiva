
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos.Entidades;
using capaDatos.Interfaces;


namespace capaDatos.Repositorios
{
    public class dts_RepositorioRegistros : dts_RepositorioMaster, Interfaces.IRegitros<clsRegistros>
    {
        public IEnumerable<clsRegistros> ObtenerRegistros()
        {
            string[] strDatos;
            string strlinea;            

            DataTable dataTable = Datos();
            
            var listadoRegistros = new List<clsRegistros>();

            foreach (DataRow fila in dataTable.Rows)
            {
                strlinea = fila[0].ToString();
                strDatos = strlinea.Split(';');

                listadoRegistros.Add(new clsRegistros
                {
                    Nombre = strDatos[0],
                    Edad=strDatos[1],
                    Equipo=strDatos[2],
                    Estado=strDatos[3],
                    Estudios=strDatos[4]
                });                
            }
            return listadoRegistros;
        }
        
    }
}
