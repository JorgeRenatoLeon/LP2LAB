using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioNro09
{
    public partial class frmBusquedaDisquera : Form
    {
        private Service.empresaDiscografica empresaSeleccionada;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmBusquedaDisquera()
        {
            InitializeComponent();
            dgvDisqueras.AutoGenerateColumns = false;
            dgvDisqueras.DataSource = DBController.listarEmpresas("");
        }

        public Service.empresaDiscografica EmpresaSeleccionada { get => empresaSeleccionada; set => empresaSeleccionada = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvDisqueras.DataSource = DBController.listarEmpresas(txtNombre.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            EmpresaSeleccionada = (Service.empresaDiscografica)dgvDisqueras.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvDisqueras_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.empresaDiscografica empresaFila = (Service.empresaDiscografica)dgvDisqueras.Rows[e.RowIndex].DataBoundItem;
            dgvDisqueras.Rows[e.RowIndex].Cells["Nombre"].Value = empresaFila.nombreEmpresa;
        }
    }
}
