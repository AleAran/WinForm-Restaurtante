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
    public partial class ListaEmpleados : UserControl
    {
        public ListaEmpleados()
        {
            InitializeComponent();
            EmpleadoBLL empleadoBLL = new EmpleadoBLL();
            cmbEmpleados.DataSource = empleadoBLL.ObtenerEmpleados();
            cmbEmpleados.DisplayMember = "Nombre";
        }

        private void ListaEmpleados_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtNombreEmpleado.Text = ((Empleado)cmbEmpleados.SelectedValue).Nombre;
        }
    }
}
