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
    public partial class FrmListaEmpleados : Form
    {
        public FrmListaEmpleados()
        {
            InitializeComponent();
        }

        private void FrmListaEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvListaEmpleados.SelectedRows.Count == 1)
            {
                DataGridViewRow o = dgvListaEmpleados.SelectedRows[0];
                Empleado empleado = (Empleado)o.DataBoundItem;

                FrmEmpleado frmEmpleado = new FrmEmpleado(empleado);
                frmEmpleado.ShowDialog();
                CargarEmpleados();
            }            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEmpleado frmEmpleado = new FrmEmpleado();
            frmEmpleado.ShowDialog();
            CargarEmpleados();            
        }

        private void CargarEmpleados()
        {
            //"Intento" hacer las operaciones que se encuentran dentro del bloque try
            try
            {
                EmpleadoBLL empleadosBLL = new EmpleadoBLL();
                List<Empleado> misEmpleados = empleadosBLL.ObtenerEmpleados();

                dgvListaEmpleados.DataSource = null;
                dgvListaEmpleados.DataSource = misEmpleados;

                this.Text = "Administración de Empleados - Total: " + empleadosBLL.ObtenerCantidadEmpleados();
            }
            catch(RestauranteDataException) //Esto se ejecuta si se produce algun error dentro del bloque try
            {
                MessageBox.Show("Ha ocurrido un error, por favor contactese con el administrador","Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                Application.Exit();
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvListaEmpleados.SelectedRows.Count == 1)
            {
                DataGridViewRow o = dgvListaEmpleados.SelectedRows[0];
                Empleado empleado = (Empleado)o.DataBoundItem;

                EmpleadoBLL empleadoBLL = new EmpleadoBLL();
                empleadoBLL.Borrar(empleado);
                CargarEmpleados();
            }
        }
    }
}
