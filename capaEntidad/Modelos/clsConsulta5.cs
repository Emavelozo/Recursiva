using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos.Repositorios;
using capaDatos.Interfaces;
using capaDatos.Entidades;

namespace capaEntidad.Modelos
{
    public class clsConsulta5
    {
        private string Equipo;
        private string CantidadSocios;
        private string PromedioEdad;
        private string MenorEdad;
        private string MayorEdad;
        private IRegitros<clsRegistros> registros;
        public string Equipo1 { get => Equipo; set => Equipo = value; }
        public string CantidadSocios1 { get => CantidadSocios; set => CantidadSocios = value; }
        public string PromedioEdad1 { get => PromedioEdad; set => PromedioEdad = value; }
        public string MenorEdad1 { get => MenorEdad; set => MenorEdad = value; }
        public string MayorEdad1 { get => MayorEdad; set => MayorEdad = value; }
        public clsConsulta5()
        {
            registros = new dts_RepositorioRegistros();
        }
        public List<clsConsulta5> ObtenerRegistros()
        {
            var datos = registros.ObtenerRegistros();
            var query =
                from lista in
                (from registro in datos
                 group registro by registro.Equipo into nuevoRegistro
                 select new
                 {
                     Equipo = nuevoRegistro.Key,
                     CantidadSocios = nuevoRegistro.Count(),
                     PromedioEdad = nuevoRegistro.Average(c => int.Parse(c.Edad)),
                     MenorEdad = nuevoRegistro.Min(c => int.Parse(c.Edad)),
                     MayorEdad = nuevoRegistro.Max(c => int.Parse(c.Edad))
                 })
                orderby lista.CantidadSocios descending
                select lista;
            var listaRegistros = new List<clsConsulta5>();

            foreach (var registro in query)
            {
                listaRegistros.Add(new clsConsulta5
                {
                    Equipo = registro.Equipo,
                    CantidadSocios = registro.CantidadSocios.ToString(),
                    PromedioEdad=registro.PromedioEdad.ToString("N2"),
                    MenorEdad=registro.MenorEdad.ToString(),
                    MayorEdad=registro.MayorEdad.ToString()
                });
            }
            return listaRegistros;
        }
    }
}
