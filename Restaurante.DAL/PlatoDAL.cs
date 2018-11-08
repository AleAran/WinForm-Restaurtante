
using Restaurante.Entity;
using Restaurante.Entity.DataSets;
using Restaurante.Entity.DataSets.RestauranteDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.DAL
{
    public class PlatoDAL
    {
        public PlatoDAL()
        {
            
        }

        public List<Plato> ObtenerPlatos()
        {
            //Creo la lista de platos que va a devolverse
            List<Plato> platos = new List<Plato>();

            //Creo el Dataset (Toda la estructura de datos que tomamos desde la base con el designer del dataset)
            RestauranteDataSet restauranteDS = new RestauranteDataSet();
            //Creo el adapter de la tabla "platos" para poder leer de la base esa tabla y llenar la tabla platos del dataset
            platosTableAdapter platosAdapter = new platosTableAdapter();

            //Uso el adapter para llenar la tabla platos del dataset
            platosAdapter.Fill(restauranteDS.platos);


            //recorro la tabla platos del dataset
            foreach (RestauranteDataSet.platosRow platoRow in restauranteDS.platos)
            {
                //para cada plato, creo un objeto entity "plato" y lo lleno
                Plato plato = new Plato();
                plato.Id = platoRow.Id;
                plato.Nombre = platoRow.Nombre;

                //a la lista de resultado le agrego el plato
                platos.Add(plato);
                
            }

            return platos;
        }

        //Metodo utilizado para devolver un dataset
        //y trabajar con dataset tipados en la UI
        public RestauranteDataSet ObtenerPlatosDataSet()
        {
            //Creo el Dataset (Toda la estructura de datos que tomamos desde la base con el designer del dataset)
            RestauranteDataSet restauranteDS = new RestauranteDataSet();
            //Creo el adapter de la tabla "platos" para poder leer de la base esa tabla y llenar la tabla platos del dataset
            platosTableAdapter platosAdapter = new platosTableAdapter();

            //Uso el adapter para llenar la tabla platos del dataset
            platosAdapter.Fill(restauranteDS.platos);
            //
            return restauranteDS;
        }

        public void GuardarPlatosDataSet(RestauranteDataSet.platosRow platoRow)
        {
            RestauranteDataSet datos = ObtenerPlatosDataSet();

            if (platoRow.Id > 0)
            {
                foreach (var plato in datos.platos)
                {
                    if (plato.Id == platoRow.Id)
                    {
                        plato.Nombre = platoRow.Nombre;
                    }
                }
            }else
            {
                datos.platos.Rows.Add(platoRow.ItemArray);
            }
            

            platosTableAdapter adapter = new platosTableAdapter();
            adapter.Update(datos);
        }

        public void BorrarPlatosDataSet(RestauranteDataSet.platosRow platoRow)
        {
            RestauranteDataSet datos = ObtenerPlatosDataSet();
            if (platoRow.Id > 0)
            {
                foreach (var plato in datos.platos)
                {
                    if (plato.Id == platoRow.Id)
                    {
                        plato.Delete();
                    }
                }

             }
            platosTableAdapter adapter = new platosTableAdapter();
            adapter.Update(datos);
        }

    }
}
