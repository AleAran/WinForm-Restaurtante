using Restaurante.BLL;
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
    public partial class FrmPlatoDetalle : Form
    {
        int id = 0;

        public FrmPlatoDetalle()
        {
            InitializeComponent();
        }

        public FrmPlatoDetalle(RestauranteDataSet.platosRow plato)
        {
            InitializeComponent();
            txtNombre.Text = plato.Nombre;
            id = plato.Id;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RestauranteDataSet dataSet = new RestauranteDataSet();
            RestauranteDataSet.platosRow plato = dataSet.platos.NewplatosRow();

            plato.Id = id;
            plato.Nombre = txtNombre.Text;

            dataSet.platos.AddplatosRow(plato);

            PlatosBLL platosBLL = new PlatosBLL();
            platosBLL.GuardarPlatosDataSet(plato);
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
