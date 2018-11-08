using Restaurante.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.BLL
{
    public class EmpresaBLL
    {
        public Empresa ObtenerEmpresa()
        {
            Empresa miEmpresa = new Empresa();
            miEmpresa.Nombre = "RestauranteEjemplo";
            return miEmpresa;
        }
    }
}
