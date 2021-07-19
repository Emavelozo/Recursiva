using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos.Interfaces;
using capaDatos.Entidades;
using capaDatos.Repositorios;
using System.Data;

namespace capaEntidad.Modelos
{
    public class clsConsultas_1y2
    {
        private string nombre;
        private string edad;
        private string equipo;
        private string estado;
        private string estudios;

        private IRegitros<clsRegistros> registros;

        //PROPIEDADES
        public string Nombre { get => nombre; set => nombre = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Equipo { get => equipo; set => equipo = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Estudios { get => estudios; set => estudios = value; }

        public clsConsultas_1y2()
        {
            registros = new dts_RepositorioRegistros();
        }
        public List<clsConsultas_1y2> ObtenerRegistros()
        {
            var datos = registros.ObtenerRegistros();
            var listaRegistros = new List<clsConsultas_1y2>();

            foreach(clsRegistros registro in datos)
            {
                listaRegistros.Add(new clsConsultas_1y2
                {
                    Nombre = registro.Nombre,
                    Edad = registro.Edad,
                    Equipo = registro.Equipo,
                    Estado = registro.Estado,
                    Estudios = registro.Estudios
                });
            }
            return listaRegistros;
        }
        public double PromedioEdadRacing()
        {
            var datos = registros.ObtenerRegistros();
            double doubSumaEdades = 0;
            double doubCantidadRacing = 0;
            double doubPromedioEdad = 0;

            foreach (clsRegistros registro in datos)
            {
                if (registro.Equipo.Contains("Racing"))
                {
                    doubSumaEdades += int.Parse(registro.Edad);
                    doubCantidadRacing += 1;
                }
            }

            doubPromedioEdad = doubSumaEdades / doubCantidadRacing;

            return doubPromedioEdad;
        }
    }
}
