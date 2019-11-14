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
    public partial class frmBusquedaArtistas : Form
    {
        private Service.artista artistaSeleccionado;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmBusquedaArtistas()
        {
            InitializeComponent();
            dgvArtistas.AutoGenerateColumns = false;
            dgvArtistas.DataSource = DBController.listarArtistas("");
        }

        public Service.artista ArtistaSeleccionado { get => artistaSeleccionado; set => artistaSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvArtistas.DataSource = DBController.listarArtistas(txtNombreArtista.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ArtistaSeleccionado = (Service.artista)dgvArtistas.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvArtistas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.artista artistaFila = (Service.artista)dgvArtistas.Rows[e.RowIndex].DataBoundItem;
            dgvArtistas.Rows[e.RowIndex].Cells["Nombre"].Value = artistaFila.nombreArtista;
            dgvArtistas.Rows[e.RowIndex].Cells["Nacionalidad"].Value = artistaFila.nacionalidad;
        }
    }
}
