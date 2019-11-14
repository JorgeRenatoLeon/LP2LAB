using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioNro09
{
    public partial class frmGestionAlbumMusical : Form
    {
        private String ruta = "";
        private Service.albumMusical albumMusical;
        private Service.track track;
        BindingList<Service.track> tracks;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmGestionAlbumMusical()
        {
            tracks = new BindingList<Service.track>();
            albumMusical = new Service.albumMusical();
            InitializeComponent();
            cboGenero.DataSource = DBController.listarGeneros();
            cboGenero.DisplayMember = "nombreGenero";
            dgvTracks.AutoGenerateColumns = false;
            estadoComponentes(Estado.Inicial);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaAlbumes formBusquedaAlbumes = new frmBusquedaAlbumes();
            if (formBusquedaAlbumes.ShowDialog() == DialogResult.OK)
            {
                albumMusical = formBusquedaAlbumes.AlbumSeleccionado;
                txtIDAlbum.Text = albumMusical.idAlbum.ToString();
                txtNombreAlbum.Text = albumMusical.nombreAlbum;
                txtDescripcion.Text = albumMusical.descripcion;
                dgvTracks.DataSource = albumMusical.tracks;
                MemoryStream ms1 = new MemoryStream(albumMusical.portada);
                pbPortada.Image = new Bitmap(ms1);
                cboGenero.SelectedIndex = cboGenero.FindStringExact(albumMusical.generoMusical.nombreGenero);
                txtArtista.Text = albumMusical.artista.nombreArtista;
                txtDisquera.Text = albumMusical.empresaDiscografica.nombreEmpresa;
                dtpFechaLanzamiento.Value = albumMusical.fechaLanzamiento;
            }
        }

        private void btnBuscarArtista_Click(object sender, EventArgs e)
        {
            frmBusquedaArtistas formBusquedaArtistas = new frmBusquedaArtistas();
            if (formBusquedaArtistas.ShowDialog() == DialogResult.OK)
            {
                albumMusical.artista = formBusquedaArtistas.ArtistaSeleccionado;
                txtArtista.Text = albumMusical.artista.nombreArtista;
            }
        }

        private void btnBuscarDisquera_Click(object sender, EventArgs e)
        {
            frmBusquedaDisquera formBusquedaDisquera = new frmBusquedaDisquera();
            if (formBusquedaDisquera.ShowDialog() == DialogResult.OK)
            {
                albumMusical.empresaDiscografica = formBusquedaDisquera.EmpresaSeleccionada;
                txtDisquera.Text = albumMusical.empresaDiscografica.nombreEmpresa;
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
            FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            albumMusical.portada = br.ReadBytes((int)fs.Length);
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
            albumMusical.nombreAlbum = txtNombreAlbum.Text;
            albumMusical.descripcion = txtDescripcion.Text;
            albumMusical.fechaLanzamiento = dtpFechaLanzamiento.Value;
            albumMusical.fechaLanzamientoSpecified = true;
            albumMusical.generoMusical = (Service.generoMusical)cboGenero.SelectedValue;
            albumMusical.tracks = tracks.ToArray();
            albumMusical.idAlbum = DBController.insertarAlbum(albumMusical);
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }
        public void limpiarComponentes()
        {
            albumMusical = new Service.albumMusical();
            tracks = new BindingList<Service.track>();
            dgvTracks.DataSource = null;
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
            track = new Service.track();
            track.nombreTrack = txtNombreTrack.Text;
            track.posicionAlbum = int.Parse(txtPosicion.Text);
            track.duracion = txtDuracionTrack.Text;
            tracks.Add(track);
            dgvTracks.DataSource = tracks;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string str = dgvTracks.Rows[dgvTracks.SelectedRows[0].Index].Cells[1].Value.ToString();

            BindingList<Service.track> lineasElim = new BindingList<Service.track>();
            foreach (Service.track item in tracks)
            {
                if (item.nombreTrack != str) lineasElim.Add(item);
            }
            tracks = lineasElim;
            dgvTracks.DataSource = tracks;
        }

        private void dgvTracks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.track trackFila = (Service.track)dgvTracks.Rows[e.RowIndex].DataBoundItem;
            dgvTracks.Rows[e.RowIndex].Cells["Pos"].Value = trackFila.posicionAlbum;
            dgvTracks.Rows[e.RowIndex].Cells["Nombre"].Value = trackFila.nombreTrack;
            dgvTracks.Rows[e.RowIndex].Cells["Duracion"].Value = trackFila.duracion;
        }
    }
}
