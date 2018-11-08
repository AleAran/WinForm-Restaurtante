using Restaurante.BLL;
using Restaurante.Entity;
using Restaurante.UI;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            EmpresaBLL empresaBLL = new EmpresaBLL();
            Empresa miEmpresa = empresaBLL.ObtenerEmpresa();
            this.Text = miEmpresa.Nombre;
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmListaEmpleados frmListaEmpleados = new FrmListaEmpleados();
            frmListaEmpleados.ShowDialog(this);
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaMesas frmListaMesas = new FrmListaMesas();
            frmListaMesas.ShowDialog(this);
        }

        private void atenciònToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtencion frmAtencion = new FrmAtencion();
            frmAtencion.ShowDialog(this);
        }

        private void platosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlatos frmPlatos = new FrmPlatos();
            frmPlatos.ShowDialog(this);
        }
        private void seleccionEmpleados1_Load(object sender, EventArgs e)
        {
        }

    }
}
