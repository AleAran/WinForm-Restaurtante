using Restaurante.BLL;
using Restaurante.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante.UI
{
    public partial class FrmEmpleado : Form
    {
        private int id = 0;

        public FrmEmpleado(Empleado empleado)
        {
            InitializeComponent();
            txtApellidos.Text = empleado.Apellido;
            txtNombre.Text = empleado.Nombre;
            txtDNI.Text = empleado.DNI.ToString();
            id = empleado.Id;
        }
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Apellido = txtApellidos.Text;
            empleado.Nombre = txtNombre.Text;
            empleado.DNI = Convert.ToInt32(txtDNI.Text);

            EmpleadoBLL empleadosBLL = new EmpleadoBLL();

            if (id <= 0)
            {
                try
                {
                    empleadosBLL.Guardar(empleado);
                    this.Close();
                }
                catch(RestauranteDataException)
                {
                    MessageBox.Show("Ha ocurrido un error en la base de datos");
                }    
                catch(RestauranteValidacionException)
                {
                    MessageBox.Show("Verifique los datos ingresados");
                }            
            }
            else
            {
                empleado.Id = id;
                empleadosBLL.Editar(empleado);
                this.Close();
            }

        }
    }
}
