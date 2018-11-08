using Restaurante.BLL;
using Restaurante.Entity;
using Restaurante.Entity.DataSets;
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
    public partial class FrmPlatos : Form
    {
        public FrmPlatos()
        {
            InitializeComponent();
        }

        private void FrmPlatos_Load(object sender, EventArgs e)
        {
            CargarPlatos();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvListaMesas.SelectedRows.Count == 1)
            {
                DataGridViewRow o = dgvListaMesas.SelectedRows[0];

                DataRowView rowView = (DataRowView)o.DataBoundItem;

               RestauranteDataSet.platosRow plato = (RestauranteDataSet.platosRow)rowView.Row;

                FrmPlatoDetalle frmPlatoDetalle = new FrmPlatoDetalle(plato);
                frmPlatoDetalle.ShowDialog();
               // CargarListaMesas();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmPlatoDetalle frmPlatoDet = new FrmPlatoDetalle();
            frmPlatoDet.ShowDialog();
            CargarPlatos();
        }

        private void CargarPlatos()
        {
            PlatosBLL platosBLL = new PlatosBLL();

            RestauranteDataSet datos = platosBLL.ObtenerPlatosDataSet();

            dgvListaMesas.DataSource = datos.platos;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvListaMesas.SelectedRows.Count == 1)
            {

                DataGridViewRow o = dgvListaMesas.SelectedRows[0];

                DataRowView rowView = (DataRowView)o.DataBoundItem;

                RestauranteDataSet.platosRow plato = (RestauranteDataSet.platosRow)rowView.Row;

                PlatosBLL platosBLL = new PlatosBLL();
                platosBLL.Borrar(plato);

                CargarPlatos();
            }
        }
    }
}
