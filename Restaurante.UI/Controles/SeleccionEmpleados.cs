using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurante.BLL;
using Restaurante.Entity;

namespace Restaurante.UI.Controles
{
    public partial class SeleccionEmpleados : UserControl
    {

        List<Empleado> listaCompleta;
        public SeleccionEmpleados()
        {
            InitializeComponent();
            updateData();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Empleado> listaFiltrada = new List<Empleado>();

            foreach (var empleado in listaCompleta)
            {
                if(empleado.Apellido.Contains(txtBusqueda.Text) ||
                    empleado.Nombre.Contains(txtBusqueda.Text))
                {
                    listaFiltrada.Add(empleado);
                }
            }

            listEmpleados.DataSource = null;
            listEmpleados.DataSource = listaFiltrada;
        }

        private void listEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateData();
        }

        private void updateData()
        {
            EmpleadoBLL empleadosBLL = new EmpleadoBLL();
            listaCompleta = empleadosBLL.ObtenerEmpleados();
            listEmpleados.DataSource = listaCompleta;
        }
    }
}
