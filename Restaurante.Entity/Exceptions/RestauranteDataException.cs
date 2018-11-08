using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Entity
{
    public class RestauranteDataException: Exception
    {
        public RestauranteDataException():base()
        {
        }

        public RestauranteDataException(string mensaje) : base(mensaje)
        {

        }
        public RestauranteDataException(string mensaje,Exception exInterna) : base(mensaje, exInterna)
        {

        }
    }
}
