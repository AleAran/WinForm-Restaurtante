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
    public partial class FrmListaMesas : Form
    {
        public FrmListaMesas()
        {
            InitializeComponent();
        }

        private void CargarListaMesas()
        {
            MesaBLL mesaBLL = new MesaBLL();
            List<Mesa> listaMesas = mesaBLL.ObtenerMesas();

            dgvListaMesas.DataSource = null;
            dgvListaMesas.DataSource = listaMesas;


            this.Text = "Administración de Mesas - Total: " + mesaBLL.ObtenerCantidadMesas();
        }

        private void dgvListaMesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarListaMesas();
        }

        private void FrmListaMesas_Load(object sender, EventArgs e)
        {
            CargarListaMesas();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvListaMesas.SelectedRows.Count == 1)
            {
                DataGridViewRow o = dgvListaMesas.SelectedRows[0];
                Mesa mesa = (Mesa)o.DataBoundItem;

                FrmMesa frmMesa = new FrmMesa(mesa);
                frmMesa.ShowDialog();
                CargarListaMesas();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMesa frmMesa = new FrmMesa();
            frmMesa.ShowDialog();
            CargarListaMesas();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvListaMesas.SelectedRows.Count == 1)
            {
                DataGridViewRow o = dgvListaMesas.SelectedRows[0];
                Mesa mesa = (Mesa)o.DataBoundItem;

                MesaBLL mesaBLL = new MesaBLL();
                mesaBLL.Borrar(mesa);

                CargarListaMesas();
            }
        }
    }
}
