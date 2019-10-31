using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteLab07
{
    public partial class frmBusquedaPP : Form
    {
        private Service.productoPresentacion ppSeleccionada;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmBusquedaPP()
        {
            InitializeComponent();
            dgvPP.AutoGenerateColumns = false;
            dgvPP.DataSource = DBController.listarProductos("%");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPP.DataSource = DBController.listarProductos(txtNombre.Text);
        }
        public Service.productoPresentacion PPSeleccionada { get => ppSeleccionada; set => ppSeleccionada = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            PPSeleccionada = (Service.productoPresentacion)dgvPP.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvPP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.productoPresentacion ppFila = (Service.productoPresentacion)dgvPP.Rows[e.RowIndex].DataBoundItem;
            dgvPP.Rows[e.RowIndex].Cells["NombrePP"].Value = ppFila.producto.nombre+" - "+ppFila.presentacion.unidadMedida;
            dgvPP.Rows[e.RowIndex].Cells["PrecioUnit"].Value = ppFila.precioUnitario;
        }
    }
}
