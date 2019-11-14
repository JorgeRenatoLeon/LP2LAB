namespace LaboratorioNro09
{
    partial class frmGestionAlbumMusical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionAlbumMusical));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.gbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.lblDisquera = new System.Windows.Forms.Label();
            this.btnBuscarDisquera = new System.Windows.Forms.Button();
            this.txtDisquera = new System.Windows.Forms.TextBox();
            this.btnBuscarArtista = new System.Windows.Forms.Button();
            this.lblPortada = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombreAlbum = new System.Windows.Forms.TextBox();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDAlbum = new System.Windows.Forms.TextBox();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.gbTracks = new System.Windows.Forms.GroupBox();
            this.txtDuracionTrack = new System.Windows.Forms.TextBox();
            this.lblDuracionTrack = new System.Windows.Forms.Label();
            this.lblNombreTrack = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombreTrack = new System.Windows.Forms.TextBox();
            this.dgvTracks = new System.Windows.Forms.DataGridView();
            this.Pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofdPortada = new System.Windows.Forms.OpenFileDialog();
            this.tsMenu.SuspendLayout();
            this.gbDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.gbTracks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnBuscar,
            this.btnCancelar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(986, 25);
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 22);
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbDatosGenerales
            // 
            this.gbDatosGenerales.Controls.Add(this.btnSubirFoto);
            this.gbDatosGenerales.Controls.Add(this.lblDisquera);
            this.gbDatosGenerales.Controls.Add(this.btnBuscarDisquera);
            this.gbDatosGenerales.Controls.Add(this.txtDisquera);
            this.gbDatosGenerales.Controls.Add(this.btnBuscarArtista);
            this.gbDatosGenerales.Controls.Add(this.lblPortada);
            this.gbDatosGenerales.Controls.Add(this.txtDescripcion);
            this.gbDatosGenerales.Controls.Add(this.lblFecha);
            this.gbDatosGenerales.Controls.Add(this.lblDescripcion);
            this.gbDatosGenerales.Controls.Add(this.lblTitulo);
            this.gbDatosGenerales.Controls.Add(this.txtNombreAlbum);
            this.gbDatosGenerales.Controls.Add(this.txtArtista);
            this.gbDatosGenerales.Controls.Add(this.label7);
            this.gbDatosGenerales.Controls.Add(this.cboGenero);
            this.gbDatosGenerales.Controls.Add(this.lblGenero);
            this.gbDatosGenerales.Controls.Add(this.dtpFechaLanzamiento);
            this.gbDatosGenerales.Controls.Add(this.label1);
            this.gbDatosGenerales.Controls.Add(this.txtIDAlbum);
            this.gbDatosGenerales.Controls.Add(this.pbPortada);
            this.gbDatosGenerales.Location = new System.Drawing.Point(12, 28);
            this.gbDatosGenerales.Name = "gbDatosGenerales";
            this.gbDatosGenerales.Size = new System.Drawing.Size(378, 311);
            this.gbDatosGenerales.TabIndex = 1;
            this.gbDatosGenerales.TabStop = false;
            this.gbDatosGenerales.Text = "Datos Generales del Álbum";
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirFoto.Location = new System.Drawing.Point(97, 275);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(39, 23);
            this.btnSubirFoto.TabIndex = 8;
            this.btnSubirFoto.Text = "...";
            this.btnSubirFoto.UseVisualStyleBackColor = true;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // lblDisquera
            // 
            this.lblDisquera.AutoSize = true;
            this.lblDisquera.Location = new System.Drawing.Point(9, 113);
            this.lblDisquera.Name = "lblDisquera";
            this.lblDisquera.Size = new System.Drawing.Size(52, 13);
            this.lblDisquera.TabIndex = 15;
            this.lblDisquera.Text = "Disquera:";
            // 
            // btnBuscarDisquera
            // 
            this.btnBuscarDisquera.Location = new System.Drawing.Point(325, 108);
            this.btnBuscarDisquera.Name = "btnBuscarDisquera";
            this.btnBuscarDisquera.Size = new System.Drawing.Size(39, 23);
            this.btnBuscarDisquera.TabIndex = 7;
            this.btnBuscarDisquera.Text = "...";
            this.btnBuscarDisquera.UseVisualStyleBackColor = true;
            this.btnBuscarDisquera.Click += new System.EventHandler(this.btnBuscarDisquera_Click);
            // 
            // txtDisquera
            // 
            this.txtDisquera.Location = new System.Drawing.Point(67, 110);
            this.txtDisquera.Name = "txtDisquera";
            this.txtDisquera.ReadOnly = true;
            this.txtDisquera.Size = new System.Drawing.Size(252, 20);
            this.txtDisquera.TabIndex = 6;
            // 
            // btnBuscarArtista
            // 
            this.btnBuscarArtista.Location = new System.Drawing.Point(325, 86);
            this.btnBuscarArtista.Name = "btnBuscarArtista";
            this.btnBuscarArtista.Size = new System.Drawing.Size(39, 23);
            this.btnBuscarArtista.TabIndex = 5;
            this.btnBuscarArtista.Text = "...";
            this.btnBuscarArtista.UseVisualStyleBackColor = true;
            this.btnBuscarArtista.Click += new System.EventHandler(this.btnBuscarArtista_Click);
            // 
            // lblPortada
            // 
            this.lblPortada.AutoSize = true;
            this.lblPortada.Location = new System.Drawing.Point(6, 157);
            this.lblPortada.Name = "lblPortada";
            this.lblPortada.Size = new System.Drawing.Size(47, 13);
            this.lblPortada.TabIndex = 12;
            this.lblPortada.Text = "Portada:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(152, 190);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(211, 108);
            this.txtDescripcion.TabIndex = 9;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(11, 136);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(103, 13);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha Lanzamiento:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(149, 173);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(3, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 13);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Nombre:";
            // 
            // txtNombreAlbum
            // 
            this.txtNombreAlbum.Location = new System.Drawing.Point(50, 40);
            this.txtNombreAlbum.Name = "txtNombreAlbum";
            this.txtNombreAlbum.Size = new System.Drawing.Size(313, 20);
            this.txtNombreAlbum.TabIndex = 2;
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(50, 87);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.ReadOnly = true;
            this.txtArtista.Size = new System.Drawing.Size(269, 20);
            this.txtArtista.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Artista:";
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(50, 63);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(314, 21);
            this.cboGenero.TabIndex = 3;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(6, 66);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 5;
            this.lblGenero.Text = "Género:";
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(119, 132);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(244, 20);
            this.dtpFechaLanzamiento.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // txtIDAlbum
            // 
            this.txtIDAlbum.Location = new System.Drawing.Point(50, 19);
            this.txtIDAlbum.Name = "txtIDAlbum";
            this.txtIDAlbum.ReadOnly = true;
            this.txtIDAlbum.Size = new System.Drawing.Size(72, 20);
            this.txtIDAlbum.TabIndex = 1;
            this.txtIDAlbum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbPortada
            // 
            this.pbPortada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPortada.Location = new System.Drawing.Point(9, 173);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(127, 125);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortada.TabIndex = 0;
            this.pbPortada.TabStop = false;
            // 
            // gbTracks
            // 
            this.gbTracks.Controls.Add(this.txtDuracionTrack);
            this.gbTracks.Controls.Add(this.lblDuracionTrack);
            this.gbTracks.Controls.Add(this.lblNombreTrack);
            this.gbTracks.Controls.Add(this.lblPosicion);
            this.gbTracks.Controls.Add(this.label3);
            this.gbTracks.Controls.Add(this.txtPosicion);
            this.gbTracks.Controls.Add(this.btnEliminar);
            this.gbTracks.Controls.Add(this.btnAgregar);
            this.gbTracks.Controls.Add(this.txtNombreTrack);
            this.gbTracks.Controls.Add(this.dgvTracks);
            this.gbTracks.Location = new System.Drawing.Point(409, 28);
            this.gbTracks.Name = "gbTracks";
            this.gbTracks.Size = new System.Drawing.Size(565, 311);
            this.gbTracks.TabIndex = 2;
            this.gbTracks.TabStop = false;
            this.gbTracks.Text = "Pistas Musicales del Álbum";
            // 
            // txtDuracionTrack
            // 
            this.txtDuracionTrack.Location = new System.Drawing.Point(115, 64);
            this.txtDuracionTrack.Name = "txtDuracionTrack";
            this.txtDuracionTrack.Size = new System.Drawing.Size(79, 20);
            this.txtDuracionTrack.TabIndex = 12;
            // 
            // lblDuracionTrack
            // 
            this.lblDuracionTrack.AutoSize = true;
            this.lblDuracionTrack.Location = new System.Drawing.Point(13, 67);
            this.lblDuracionTrack.Name = "lblDuracionTrack";
            this.lblDuracionTrack.Size = new System.Drawing.Size(101, 13);
            this.lblDuracionTrack.TabIndex = 8;
            this.lblDuracionTrack.Text = "Duración del Track:";
            // 
            // lblNombreTrack
            // 
            this.lblNombreTrack.AutoSize = true;
            this.lblNombreTrack.Location = new System.Drawing.Point(19, 44);
            this.lblNombreTrack.Name = "lblNombreTrack";
            this.lblNombreTrack.Size = new System.Drawing.Size(95, 13);
            this.lblNombreTrack.TabIndex = 7;
            this.lblNombreTrack.Text = "Nombre del Track:";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(58, 22);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(50, 13);
            this.lblPosicion.TabIndex = 6;
            this.lblPosicion.Text = "Posición:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(115, 19);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(53, 20);
            this.txtPosicion.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(520, 74);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(39, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "-";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(480, 74);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(39, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombreTrack
            // 
            this.txtNombreTrack.Location = new System.Drawing.Point(115, 42);
            this.txtNombreTrack.Name = "txtNombreTrack";
            this.txtNombreTrack.Size = new System.Drawing.Size(428, 20);
            this.txtNombreTrack.TabIndex = 11;
            // 
            // dgvTracks
            // 
            this.dgvTracks.AllowUserToAddRows = false;
            this.dgvTracks.AllowUserToDeleteRows = false;
            this.dgvTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTracks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pos,
            this.Nombre,
            this.Duracion});
            this.dgvTracks.Location = new System.Drawing.Point(15, 99);
            this.dgvTracks.Name = "dgvTracks";
            this.dgvTracks.ReadOnly = true;
            this.dgvTracks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTracks.Size = new System.Drawing.Size(544, 206);
            this.dgvTracks.TabIndex = 0;
            // 
            // Pos
            // 
            this.Pos.DataPropertyName = "Pos";
            this.Pos.HeaderText = "Pos";
            this.Pos.Name = "Pos";
            this.Pos.ReadOnly = true;
            this.Pos.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre del Track";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 370;
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duración";
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            this.Duracion.Width = 75;
            // 
            // ofdPortada
            // 
            this.ofdPortada.FileName = "ofdPortada";
            // 
            // frmGestionAlbumMusical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 351);
            this.Controls.Add(this.gbTracks);
            this.Controls.Add(this.gbDatosGenerales);
            this.Controls.Add(this.tsMenu);
            this.Name = "frmGestionAlbumMusical";
            this.Text = "Formulario de Gestión de Álbumes Musicales";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.gbDatosGenerales.ResumeLayout(false);
            this.gbDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.gbTracks.ResumeLayout(false);
            this.gbTracks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.GroupBox gbTracks;
        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.TextBox txtNombreTrack;
        private System.Windows.Forms.DataGridView dgvTracks;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDAlbum;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreTrack;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblPortada;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombreAlbum;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.TextBox txtDuracionTrack;
        private System.Windows.Forms.Label lblDuracionTrack;
        private System.Windows.Forms.Button btnBuscarArtista;
        private System.Windows.Forms.Button btnSubirFoto;
        private System.Windows.Forms.Label lblDisquera;
        private System.Windows.Forms.Button btnBuscarDisquera;
        private System.Windows.Forms.TextBox txtDisquera;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.OpenFileDialog ofdPortada;
    }
}

