using Restaurante.DAL;
using Restaurante.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BLL
{
    public class MesaBLL
    {
        public List<Mesa> ObtenerMesas()
        {
            MesaDAL mesaDAL = new MesaDAL();
            return mesaDAL.ObtenerMesas();
        }

        public void Guardar(Mesa mesa)
        {
            if (mesa.Nombre == "")
            {
                throw new Exception();
            }

            try
            {
                MesaDAL mesaDAL = new MesaDAL();
                mesaDAL.Guardar(mesa);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Editar(Mesa mesa)
        {
            MesaDAL mesaDAL = new MesaDAL();
            mesaDAL.Editar(mesa);
        }

        public void Borrar(Mesa mesa)
        {
            MesaDAL mesaDAL = new MesaDAL();
            mesaDAL.Borrar(mesa);
        }

        public int ObtenerCantidadMesas()
        {
            MesaDAL mesaDAL = new MesaDAL();
            return mesaDAL.ObtenerCantidadMesas();
        }
    }
}
