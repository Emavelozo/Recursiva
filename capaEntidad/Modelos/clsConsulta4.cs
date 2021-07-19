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
    public class clsConsulta4
    {
        private string nombre;
        private string total;

        private IRegitros<clsRegistros> registros;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Total { get => total; set => total = value; }
        public clsConsulta4()
        {
            registros = new dts_RepositorioRegistros();
        }
        public List<clsConsulta4> ObtenerRegistros()
        {
            var datos = registros.ObtenerRegistros();
            var query =
                (from lista in
                (from registro in datos
                 where registro.Equipo.Contains("River")
                 group registro by registro.Nombre into nuevoRegistro
                 select new
                 {
                     Nombre = nuevoRegistro.Key,
                     Total = nuevoRegistro.Count()
                 })
                 orderby lista.Total descending
                 select lista).Take(5);
            var listaRegistros = new List<clsConsulta4>();

            foreach (var registro in query)
            {
                listaRegistros.Add(new clsConsulta4
                {
                    Nombre = registro.Nombre,
                    Total = registro.Total.ToString()                   
                });
            }
            return listaRegistros;
        }
    }
}
