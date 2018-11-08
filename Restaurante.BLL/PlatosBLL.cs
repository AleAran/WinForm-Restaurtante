using Restaurante.DAL;
using Restaurante.Entity;
using Restaurante.Entity.DataSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BLL
{
    public class PlatosBLL
    {
        public List<Plato> ObtenerPlatos()
        {
            PlatoDAL platoDAL = new PlatoDAL();
            return platoDAL.ObtenerPlatos();
        }

        public RestauranteDataSet ObtenerPlatosDataSet()
        {
            PlatoDAL platoDAL = new PlatoDAL();
            return platoDAL.ObtenerPlatosDataSet();
        }

        public void GuardarPlatosDataSet(RestauranteDataSet.platosRow platosRow)
        {
            PlatoDAL platoDAL = new PlatoDAL();
            platoDAL.GuardarPlatosDataSet(platosRow);
        }

        public void Borrar(RestauranteDataSet.platosRow platosRow)
        {
            PlatoDAL platoDAL = new PlatoDAL();
            platoDAL.BorrarPlatosDataSet(platosRow);
        }
    }
}
