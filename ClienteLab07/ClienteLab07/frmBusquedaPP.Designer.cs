namespace ClienteLab07
{
    partial class frmBusquedaPP
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvPP = new System.Windows.Forms.DataGridView();
            this.NombrePP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(96, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Ingrese el Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(321, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(439, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(634, 7);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(118, 23);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // dgvPP
            // 
            this.dgvPP.AllowUserToAddRows = false;
            this.dgvPP.AllowUserToDeleteRows = false;
            this.dgvPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePP,
            this.PrecioUnit});
            this.dgvPP.Location = new System.Drawing.Point(15, 36);
            this.dgvPP.Name = "dgvPP";
            this.dgvPP.ReadOnly = true;
            this.dgvPP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPP.Size = new System.Drawing.Size(737, 256);
            this.dgvPP.TabIndex = 4;
            // 
            // NombrePP
            // 
            this.NombrePP.DataPropertyName = "Nombre";
            this.NombrePP.HeaderText = "Nombre del Producto Presentación";
            this.NombrePP.Name = "NombrePP";
            this.NombrePP.ReadOnly = true;
            this.NombrePP.Width = 550;
            // 
            // PrecioUnit
            // 
            this.PrecioUnit.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Format = "N2";
            this.PrecioUnit.DefaultCellStyle = dataGridViewCellStyle1;
            this.PrecioUnit.HeaderText = "Precio Unitario";
            this.PrecioUnit.Name = "PrecioUnit";
            this.PrecioUnit.ReadOnly = true;
            // 
            // frmBusquedaPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 304);
            this.Controls.Add(this.dgvPP);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmBusquedaPP";
            this.Text = "Formulario Búsqueda de Productos Presentación";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnit;
    }
}