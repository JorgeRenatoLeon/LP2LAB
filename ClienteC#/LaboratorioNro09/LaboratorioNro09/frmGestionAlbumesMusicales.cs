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
    public partial class frmGestionAlbumMusical : Form
    {
        private String ruta = "";
        public frmGestionAlbumMusical()
        {
            InitializeComponent();
            dgvTracks.AutoGenerateColumns = false;
            estadoComponentes(Estado.Inicial);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaAlbumes formBusquedaAlbumes = new frmBusquedaAlbumes();
            if (formBusquedaAlbumes.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnBuscarArtista_Click(object sender, EventArgs e)
        {
            frmBusquedaArtistas formBusquedaArtistas = new frmBusquedaArtistas();
            if (formBusquedaArtistas.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnBuscarDisquera_Click(object sender, EventArgs e)
        {
            frmBusquedaDisquera formBusquedaDisquera = new frmBusquedaDisquera();
            if (formBusquedaDisquera.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdPortada.ShowDialog() == DialogResult.OK)
                {
                    ruta = ofdPortada.FileName;
                    pbPortada.Image = Image.FromFile(ruta);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGuardar.Enabled = false;
                    gbDatosGenerales.Enabled = false;
                    gbTracks.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnGuardar.Enabled = true;
                    gbDatosGenerales.Enabled = true;
                    gbTracks.Enabled = true;
                    break;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoComponentes(Estado.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Inicial);
        }
        public void limpiarComponentes()
        {
            txtIDAlbum.Text = "";
            txtNombreAlbum.Text = "";
            cboGenero.SelectedIndex = -1;
            txtArtista.Text = "";
            txtDisquera.Text = "";
            dtpFechaLanzamiento.Value = DateTime.Today;
            txtDescripcion.Text = "";
            pbPortada.Image = null;
            txtPosicion.Text = "";
            txtNombreTrack.Text = "";
            txtDuracionTrack.Text = "";
            ruta = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
