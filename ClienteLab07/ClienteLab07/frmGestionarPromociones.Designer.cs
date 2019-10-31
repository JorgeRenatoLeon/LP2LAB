namespace ClienteLab07
{
    partial class frmGestionarPromociones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarPromociones));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.txtIDPromocion = new System.Windows.Forms.TextBox();
            this.gbPromocion = new System.Windows.Forms.GroupBox();
            this.txtNombrePromo = new System.Windows.Forms.TextBox();
            this.lblNombrePromocion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDetallePromocion = new System.Windows.Forms.GroupBox();
            this.txtPrecioPromo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPP = new System.Windows.Forms.DataGridView();
            this.NombrePP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarPP = new System.Windows.Forms.Button();
            this.btnAgregarPP = new System.Windows.Forms.Button();
            this.btnBuscarPP = new System.Windows.Forms.Button();
            this.txtCantidadPP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioUnitPP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombrePP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDPP = new System.Windows.Forms.TextBox();
            this.tsMenu.SuspendLayout();
            this.gbPromocion.SuspendLayout();
            this.gbDetallePromocion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnModificar,
            this.btnEliminar,
            this.btnBuscar,
            this.btnCancelar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(626, 25);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "&Guardar";
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtIDPromocion
            // 
            this.txtIDPromocion.Location = new System.Drawing.Point(112, 20);
            this.txtIDPromocion.Name = "txtIDPromocion";
            this.txtIDPromocion.ReadOnly = true;
            this.txtIDPromocion.Size = new System.Drawing.Size(56, 20);
            this.txtIDPromocion.TabIndex = 1;
            // 
            // gbPromocion
            // 
            this.gbPromocion.Controls.Add(this.txtNombrePromo);
            this.gbPromocion.Controls.Add(this.lblNombrePromocion);
            this.gbPromocion.Controls.Add(this.label1);
            this.gbPromocion.Controls.Add(this.txtIDPromocion);
            this.gbPromocion.Location = new System.Drawing.Point(12, 28);
            this.gbPromocion.Name = "gbPromocion";
            this.gbPromocion.Size = new System.Drawing.Size(605, 51);
            this.gbPromocion.TabIndex = 2;
            this.gbPromocion.TabStop = false;
            this.gbPromocion.Text = "Datos de la Promoción";
            // 
            // txtNombrePromo
            // 
            this.txtNombrePromo.Location = new System.Drawing.Point(227, 20);
            this.txtNombrePromo.Name = "txtNombrePromo";
            this.txtNombrePromo.Size = new System.Drawing.Size(360, 20);
            this.txtNombrePromo.TabIndex = 1;
            // 
            // lblNombrePromocion
            // 
            this.lblNombrePromocion.AutoSize = true;
            this.lblNombrePromocion.Location = new System.Drawing.Point(174, 23);
            this.lblNombrePromocion.Name = "lblNombrePromocion";
            this.lblNombrePromocion.Size = new System.Drawing.Size(47, 13);
            this.lblNombrePromocion.TabIndex = 3;
            this.lblNombrePromocion.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID de la Promoción:";
            // 
            // gbDetallePromocion
            // 
            this.gbDetallePromocion.Controls.Add(this.txtPrecioPromo);
            this.gbDetallePromocion.Controls.Add(this.label6);
            this.gbDetallePromocion.Controls.Add(this.dgvPP);
            this.gbDetallePromocion.Controls.Add(this.groupBox1);
            this.gbDetallePromocion.Location = new System.Drawing.Point(12, 85);
            this.gbDetallePromocion.Name = "gbDetallePromocion";
            this.gbDetallePromocion.Size = new System.Drawing.Size(605, 315);
            this.gbDetallePromocion.TabIndex = 3;
            this.gbDetallePromocion.TabStop = false;
            this.gbDetallePromocion.Text = "Detalle de la Promoción";
            // 
            // txtPrecioPromo
            // 
            this.txtPrecioPromo.Location = new System.Drawing.Point(138, 20);
            this.txtPrecioPromo.Name = "txtPrecioPromo";
            this.txtPrecioPromo.Size = new System.Drawing.Size(80, 20);
            this.txtPrecioPromo.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio Total de la Promo:";
            // 
            // dgvPP
            // 
            this.dgvPP.AllowUserToAddRows = false;
            this.dgvPP.AllowUserToDeleteRows = false;
            this.dgvPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePP,
            this.Cant,
            this.PrecioUnit});
            this.dgvPP.Location = new System.Drawing.Point(9, 149);
            this.dgvPP.Name = "dgvPP";
            this.dgvPP.ReadOnly = true;
            this.dgvPP.Size = new System.Drawing.Size(590, 160);
            this.dgvPP.TabIndex = 7;
            // 
            // NombrePP
            // 
            this.NombrePP.HeaderText = "Nombre del PP";
            this.NombrePP.Name = "NombrePP";
            this.NombrePP.ReadOnly = true;
            this.NombrePP.Width = 340;
            // 
            // Cant
            // 
            this.Cant.HeaderText = "Cant";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            // 
            // PrecioUnit
            // 
            this.PrecioUnit.HeaderText = "Precio Unit";
            this.PrecioUnit.Name = "PrecioUnit";
            this.PrecioUnit.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarPP);
            this.groupBox1.Controls.Add(this.btnAgregarPP);
            this.groupBox1.Controls.Add(this.btnBuscarPP);
            this.groupBox1.Controls.Add(this.txtCantidadPP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrecioUnitPP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombrePP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIDPP);
            this.groupBox1.Location = new System.Drawing.Point(9, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 97);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda de Producto Presentación";
            // 
            // btnEliminarPP
            // 
            this.btnEliminarPP.Location = new System.Drawing.Point(544, 69);
            this.btnEliminarPP.Name = "btnEliminarPP";
            this.btnEliminarPP.Size = new System.Drawing.Size(34, 23);
            this.btnEliminarPP.TabIndex = 13;
            this.btnEliminarPP.Text = "-";
            this.btnEliminarPP.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPP
            // 
            this.btnAgregarPP.Location = new System.Drawing.Point(508, 69);
            this.btnAgregarPP.Name = "btnAgregarPP";
            this.btnAgregarPP.Size = new System.Drawing.Size(34, 23);
            this.btnAgregarPP.TabIndex = 12;
            this.btnAgregarPP.Text = "+";
            this.btnAgregarPP.UseVisualStyleBackColor = true;
            this.btnAgregarPP.Click += new System.EventHandler(this.btnAgregarPP_Click);
            // 
            // btnBuscarPP
            // 
            this.btnBuscarPP.Location = new System.Drawing.Point(163, 21);
            this.btnBuscarPP.Name = "btnBuscarPP";
            this.btnBuscarPP.Size = new System.Drawing.Size(34, 23);
            this.btnBuscarPP.TabIndex = 3;
            this.btnBuscarPP.Text = "...";
            this.btnBuscarPP.UseVisualStyleBackColor = true;
            this.btnBuscarPP.Click += new System.EventHandler(this.btnBuscarPP_Click);
            // 
            // txtCantidadPP
            // 
            this.txtCantidadPP.Location = new System.Drawing.Point(287, 71);
            this.txtCantidadPP.Name = "txtCantidadPP";
            this.txtCantidadPP.Size = new System.Drawing.Size(80, 20);
            this.txtCantidadPP.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad:";
            // 
            // txtPrecioUnitPP
            // 
            this.txtPrecioUnitPP.Location = new System.Drawing.Point(103, 71);
            this.txtPrecioUnitPP.Name = "txtPrecioUnitPP";
            this.txtPrecioUnitPP.ReadOnly = true;
            this.txtPrecioUnitPP.Size = new System.Drawing.Size(80, 20);
            this.txtPrecioUnitPP.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio Unit:";
            // 
            // txtNombrePP
            // 
            this.txtNombrePP.Location = new System.Drawing.Point(103, 46);
            this.txtNombrePP.Name = "txtNombrePP";
            this.txtNombrePP.ReadOnly = true;
            this.txtNombrePP.Size = new System.Drawing.Size(475, 20);
            this.txtNombrePP.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre del PP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID del PP:";
            // 
            // txtIDPP
            // 
            this.txtIDPP.Location = new System.Drawing.Point(103, 22);
            this.txtIDPP.Name = "txtIDPP";
            this.txtIDPP.ReadOnly = true;
            this.txtIDPP.Size = new System.Drawing.Size(56, 20);
            this.txtIDPP.TabIndex = 5;
            // 
            // frmGestionarPromociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 407);
            this.Controls.Add(this.gbDetallePromocion);
            this.Controls.Add(this.gbPromocion);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGestionarPromociones";
            this.Text = "Formulario Gestión de Promociones";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.gbPromocion.ResumeLayout(false);
            this.gbPromocion.PerformLayout();
            this.gbDetallePromocion.ResumeLayout(false);
            this.gbDetallePromocion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.TextBox txtIDPromocion;
        private System.Windows.Forms.GroupBox gbPromocion;
        private System.Windows.Forms.TextBox txtNombrePromo;
        private System.Windows.Forms.Label lblNombrePromocion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDetallePromocion;
        private System.Windows.Forms.DataGridView dgvPP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDPP;
        private System.Windows.Forms.TextBox txtNombrePP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminarPP;
        private System.Windows.Forms.Button btnAgregarPP;
        private System.Windows.Forms.Button btnBuscarPP;
        private System.Windows.Forms.TextBox txtCantidadPP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioUnitPP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioPromo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnit;
    }
}

