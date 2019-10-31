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
    public partial class frmGestionarPromociones : Form
    {
        Service.alumno alumno = new Service.alumno();
        Service.ServicioClient DBController
                = new Service.ServicioClient();
        public frmGestionarPromociones()
        {
            InitializeComponent();
            estadoComponentes(Estado.Inicial);
        }

        public void limpiarComponentes()
        {
            txtIDPromocion.Text = "";
            txtNombrePromo.Text = "";
            txtPrecioPromo.Text = "";
            txtIDPP.Text = "";
            txtNombrePP.Text = "";
            txtPrecioUnitPP.Text = "";
            txtCantidadPP.Text = "";
        }

        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnAgregarPP.Enabled = false;
                    btnEliminarPP.Enabled = false;
                    btnBuscarPP.Enabled = false;
                    gbPromocion.Enabled = false;
                    gbDetallePromocion.Enabled = false;
                    dgvPP.Enabled = false;
                    break;
                case Estado.NuevoModificar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnAgregarPP.Enabled = true;
                    btnEliminarPP.Enabled = true;
                    btnBuscarPP.Enabled = true;
                    gbPromocion.Enabled = true;
                    gbDetallePromocion.Enabled = true;
                    dgvPP.Enabled = true;
                    break;
                case Estado.Actualizar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnAgregarPP.Enabled = false;
                    btnEliminarPP.Enabled = false;
                    btnBuscarPP.Enabled = false;
                    gbPromocion.Enabled = false;
                    gbDetallePromocion.Enabled = false;
                    dgvPP.Enabled = false;
                    break;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.NuevoModificar);
            limpiarComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Inicial);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaPromociones formBusquedaPromociones = new frmBusquedaPromociones();
            if (formBusquedaPromociones.ShowDialog() == DialogResult.OK)
            {
                estadoComponentes(Estado.Actualizar);
            }
        }

        private void btnAgregarPP_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.NuevoModificar);
        }

        private void btnBuscarPP_Click(object sender, EventArgs e)
        {
            frmBusquedaPP formBusquedaPP = new frmBusquedaPP();
            if(formBusquedaPP.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("¿Está seguro que desea eliminar esta promoción?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)){
                estadoComponentes(Estado.Inicial);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
