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
    public partial class frmBusquedaAlbumes : Form
    {
        private Service.albumMusical albumSeleccionado;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmBusquedaAlbumes()
        {
            InitializeComponent();
            dgvAlbumes.AutoGenerateColumns = false;
            dgvAlbumes.DataSource = DBController.listarAlbums("");
        }

        public Service.albumMusical AlbumSeleccionado { get => albumSeleccionado; set => albumSeleccionado = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            AlbumSeleccionado = (Service.albumMusical)dgvAlbumes.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvAlbumes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.albumMusical albumFila = (Service.albumMusical)dgvAlbumes.Rows[e.RowIndex].DataBoundItem;
            dgvAlbumes.Rows[e.RowIndex].Cells["Nombre"].Value = albumFila.nombreAlbum;
            dgvAlbumes.Rows[e.RowIndex].Cells["Artista"].Value = albumFila.artista.nombreArtista;
            dgvAlbumes.Rows[e.RowIndex].Cells["Fecha"].Value = albumFila.fechaLanzamiento;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvAlbumes.DataSource = DBController.listarAlbums(txtNombreAlbumArtista.Text);
        }
    }
}
