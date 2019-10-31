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
    public partial class frmBusquedaPromociones : Form
    {
        private Service.promocion promoSeleccionada;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmBusquedaPromociones()
        {
            InitializeComponent();
            dgvPromociones.AutoGenerateColumns = false;
            dgvPromociones.DataSource = DBController.listarPromociones("%");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPromociones.DataSource = DBController.listarPromociones(txtNombre.Text);
        }
        public Service.promocion PromoSeleccionada { get => promoSeleccionada; set => promoSeleccionada = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            PromoSeleccionada = (Service.promocion)dgvPromociones.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvPromociones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.promocion promoFila = (Service.promocion)dgvPromociones.Rows[e.RowIndex].DataBoundItem;
            dgvPromociones.Rows[e.RowIndex].Cells["NombrePromo"].Value = promoFila.nombre;
            dgvPromociones.Rows[e.RowIndex].Cells["PrecioUnit"].Value = promoFila.precioUnitario;
        }
    }
}
