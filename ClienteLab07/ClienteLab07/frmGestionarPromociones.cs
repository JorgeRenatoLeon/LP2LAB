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
        Estado estadoObjPromocion;
        Service.promocion promocion = new Service.promocion();
            Service.lineaDetallePromocion lineaDetallePromocion = new Service.lineaDetallePromocion();
        Service.ServicioClient DBController = new Service.ServicioClient();
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
            estadoObjPromocion = Estado.NuevoModificar;
            estadoComponentes(estadoObjPromocion);
            limpiarComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoObjPromocion = Estado.Inicial;
            estadoComponentes(estadoObjPromocion);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaPromociones formBusquedaPromociones = new frmBusquedaPromociones();
            if (formBusquedaPromociones.ShowDialog() == DialogResult.OK)
            {
                promocion = formBusquedaPromociones.PromoSeleccionada;
                txtIDPromocion.Text = promocion.idItemVenta.ToString();
                txtNombrePromo.Text = promocion.nombre;
                txtPrecioPromo.Text = promocion.precioUnitario.ToString();
                estadoObjPromocion = Estado.Actualizar;
                estadoComponentes(estadoObjPromocion);
            }
        }

        private void btnAgregarPP_Click(object sender, EventArgs e)
        {

            lineaDetallePromocion.idLineaDetallePromocion = Int32.Parse(txtIDPP.Text);
            lineaDetallePromocion.productoPresentacion.producto.nombre = txtNombrePP.Text;
            lineaDetallePromocion.productoPresentacion.precioUnitario = Int32.Parse(txtPrecioUnitPP.Text);
            lineaDetallePromocion.cantidad = Int32.Parse(txtCantidadPP.Text);

            //promocion.lineasDetallePromocion(lineaDetallePromocion);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoObjPromocion = Estado.NuevoModificar;
            estadoComponentes(estadoObjPromocion);
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
            if(DialogResult.Yes == MessageBox.Show("¿Está seguro que desea eliminar esta promoción?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                estadoObjPromocion = Estado.Inicial;
                estadoComponentes(estadoObjPromocion);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Completamos los datos del objeto con lo ingresado a nivel de vista
            promocion.idItemVenta = Int32.Parse(txtIDPromocion.Text);
            promocion.tipoItem.tipo = "PROMOCION";
            promocion.precioUnitario = Int32.Parse(txtPrecioPromo.Text);

            if (estadoObjPromocion == Estado.Inicial)
            {
                DBController.insertarPromociones(promocion);
                //Mostramos un mensaje de exito
                MessageBox.Show("Promoción Registrada exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (estadoObjPromocion == Estado.NuevoModificar)
            {
                DBController.actualizarPromociones(promocion);
                MessageBox.Show("Se han actualizado los datos", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            estadoComponentes(Estado.Inicial);
        }
    }
}
