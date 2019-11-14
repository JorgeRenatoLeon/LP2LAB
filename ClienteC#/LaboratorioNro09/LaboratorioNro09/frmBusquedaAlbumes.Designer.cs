namespace LaboratorioNro09
{
    partial class frmBusquedaAlbumes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAlbumes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtNombreAlbumArtista = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNombreAlbum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlbumes
            // 
            this.dgvAlbumes.AllowUserToAddRows = false;
            this.dgvAlbumes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlbumes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlbumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbumes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Artista,
            this.Fecha});
            this.dgvAlbumes.Location = new System.Drawing.Point(12, 41);
            this.dgvAlbumes.Name = "dgvAlbumes";
            this.dgvAlbumes.ReadOnly = true;
            this.dgvAlbumes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlbumes.Size = new System.Drawing.Size(846, 313);
            this.dgvAlbumes.TabIndex = 0;
            this.dgvAlbumes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAlbumes_CellFormatting);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del Álbum";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 300;
            // 
            // Artista
            // 
            this.Artista.HeaderText = "Artista";
            this.Artista.Name = "Artista";
            this.Artista.ReadOnly = true;
            this.Artista.Width = 300;
            // 
            // Fecha
            // 
            dataGridViewCellStyle2.Format = "dd-MM-yyyy";
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha.HeaderText = "Fecha de Lanzamiento";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 200;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(713, 11);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(97, 23);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtNombreAlbumArtista
            // 
            this.txtNombreAlbumArtista.Location = new System.Drawing.Point(150, 13);
            this.txtNombreAlbumArtista.Name = "txtNombreAlbumArtista";
            this.txtNombreAlbumArtista.Size = new System.Drawing.Size(366, 20);
            this.txtNombreAlbumArtista.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(519, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNombreAlbum
            // 
            this.lblNombreAlbum.AutoSize = true;
            this.lblNombreAlbum.Location = new System.Drawing.Point(12, 16);
            this.lblNombreAlbum.Name = "lblNombreAlbum";
            this.lblNombreAlbum.Size = new System.Drawing.Size(136, 13);
            this.lblNombreAlbum.TabIndex = 4;
            this.lblNombreAlbum.Text = "Nombre del Álbum / Artista:";
            // 
            // frmBusquedaAlbumes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 364);
            this.Controls.Add(this.lblNombreAlbum);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombreAlbumArtista);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvAlbumes);
            this.Name = "frmBusquedaAlbumes";
            this.Text = "Formulario de Búsqueda de Álbumes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlbumes;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtNombreAlbumArtista;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNombreAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}