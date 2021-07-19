using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos.Entidades;
using capaDatos.Interfaces;
using capaDatos.Repositorios;

namespace capaEntidad.Modelos
{
    public class clsConsulta3
    {
        private string nombre;
        private string edad;
        private string equipo;

        private IRegitros<clsRegistros> registros;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Equipo { get => equipo; set => equipo = value; }

        public clsConsulta3()
        {
            registros = new dts_RepositorioRegistros();
        }
        public List<clsConsulta3> ObtenerRegistros()
        {
            var datos = registros.ObtenerRegistros();
            var query =
                (from registro in datos
                 where registro.Estado.Contains("Casado")
                 where registro.Estudios.Contains("Universitario")
                 orderby registro.Edad ascending
                 select registro).Take(100);
            var listaRegistros = new List<clsConsulta3>();

            foreach (clsRegistros registro in query)
            {
                listaRegistros.Add(new clsConsulta3
                {
                    Nombre = registro.Nombre,
                    Edad = registro.Edad,
                    Equipo = registro.Equipo                    
                });
            }
            return listaRegistros;
        }
    }
}
