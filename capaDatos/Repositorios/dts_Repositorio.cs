using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public abstract class dts_Repositorio
    {
        private readonly string rutaConeccion = AppDomain.CurrentDomain.BaseDirectory + "socios.csv";

        protected string RutaArchivo()
        {
            return rutaConeccion;
        }
    }
}
