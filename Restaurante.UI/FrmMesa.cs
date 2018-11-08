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
    public partial class FrmMesa : Form
    {
        int id = 0;
        public FrmMesa(Mesa mesa)
        {
            InitializeComponent();
            this.txtNombre.Text = mesa.Nombre;
            id = mesa.Id;
        }

        public FrmMesa()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Mesa mesa = new Mesa();
            mesa.Nombre = txtNombre.Text;

            MesaBLL mesaBLL = new MesaBLL();

            if (id <= 0)
            {
                try
                {
                    mesaBLL.Guardar(mesa);
                }
                catch(SqlException)
                {
                    MessageBox.Show("Ha ocurrido un error en la base de datos");
                }
                catch(Exception)
                {
                    MessageBox.Show("Verifique los datos ingresados");
                }
                
            }
            else
            {
                mesa.Id = id;
                mesaBLL.Editar(mesa);
            }

            this.Close();
        }
    }
}
