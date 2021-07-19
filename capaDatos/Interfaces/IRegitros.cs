using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos.Entidades;

namespace capaDatos.Interfaces
{
    public interface IRegitros<Entidad> where Entidad:class
    {
        IEnumerable<Entidad> ObtenerRegistros();        
    }
}
