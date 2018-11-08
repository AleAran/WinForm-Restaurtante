using Restaurante.BLL;
using Restaurante.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante.UI
{
    public partial class FrmAtencionDetalle : Form
    {
        public FrmAtencionDetalle()
        {
            InitializeComponent();
        }

        private void FrmAtencionDetalle_Load(object sender, EventArgs e)
        {
            EmpleadoBLL empleadoBLL = new EmpleadoBLL();
            List<Empleado> empleados = empleadoBLL.ObtenerEmpleados();
            MesaBLL mesaBLL = new MesaBLL();
            List<Mesa> mesas = mesaBLL.ObtenerMesas();

            cmbMesas.DisplayMember = "Nombre";
            cmbMesas.ValueMember = "Id";
            cmbMesas.DataSource = mesas;

            cmbEmpleados.DisplayMember = "Apellido";
            cmbEmpleados.ValueMember = "Id";
            cmbEmpleados.DataSource = empleados;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
