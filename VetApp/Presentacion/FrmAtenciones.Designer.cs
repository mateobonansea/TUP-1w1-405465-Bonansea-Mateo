namespace VetApp.Vistas
{
    partial class FrmAtenciones
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
            this.LblNroAtencion = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.TxtTratamiento = new System.Windows.Forms.TextBox();
            this.DgvMascotas = new System.Windows.Forms.DataGridView();
            this.ColNroMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LblTratamiento = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblEdad = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LblCliente = new System.Windows.Forms.Label();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNroAtencion
            // 
            this.LblNroAtencion.AutoSize = true;
            this.LblNroAtencion.Location = new System.Drawing.Point(39, 41);
            this.LblNroAtencion.Name = "LblNroAtencion";
            this.LblNroAtencion.Size = new System.Drawing.Size(84, 13);
            this.LblNroAtencion.TabIndex = 0;
            this.LblNroAtencion.Text = "Nro de Atencion";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(77, 87);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(37, 13);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Fecha";
            // 
            // TxtTratamiento
            // 
            this.TxtTratamiento.Location = new System.Drawing.Point(159, 153);
            this.TxtTratamiento.Name = "TxtTratamiento";
            this.TxtTratamiento.Size = new System.Drawing.Size(287, 20);
            this.TxtTratamiento.TabIndex = 4;
            // 
            // DgvMascotas
            // 
            this.DgvMascotas.AllowUserToAddRows = false;
            this.DgvMascotas.AllowUserToDeleteRows = false;
            this.DgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNroMascota,
            this.ColNombreMascota,
            this.ColEdad,
            this.ColTipo,
            this.ColAcciones});
            this.DgvMascotas.Location = new System.Drawing.Point(29, 268);
            this.DgvMascotas.Name = "DgvMascotas";
            this.DgvMascotas.ReadOnly = true;
            this.DgvMascotas.Size = new System.Drawing.Size(544, 150);
            this.DgvMascotas.TabIndex = 11;
            // 
            // ColNroMascota
            // 
            this.ColNroMascota.HeaderText = "Nro Mascota";
            this.ColNroMascota.Name = "ColNroMascota";
            this.ColNroMascota.ReadOnly = true;
            // 
            // ColNombreMascota
            // 
            this.ColNombreMascota.HeaderText = "Nombre ";
            this.ColNombreMascota.Name = "ColNombreMascota";
            this.ColNombreMascota.ReadOnly = true;
            // 
            // ColEdad
            // 
            this.ColEdad.HeaderText = "Edad";
            this.ColEdad.Name = "ColEdad";
            this.ColEdad.ReadOnly = true;
            // 
            // ColTipo
            // 
            this.ColTipo.HeaderText = "Tipo";
            this.ColTipo.Name = "ColTipo";
            this.ColTipo.ReadOnly = true;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            // 
            // LblTratamiento
            // 
            this.LblTratamiento.AutoSize = true;
            this.LblTratamiento.Location = new System.Drawing.Point(51, 153);
            this.LblTratamiento.Name = "LblTratamiento";
            this.LblTratamiento.Size = new System.Drawing.Size(63, 13);
            this.LblTratamiento.TabIndex = 3;
            this.LblTratamiento.Text = "Tratamiento";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(30, 183);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(88, 13);
            this.LblNombre.TabIndex = 5;
            this.LblNombre.Text = "Nombre Mascota";
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Location = new System.Drawing.Point(86, 209);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(32, 13);
            this.LblEdad.TabIndex = 7;
            this.LblEdad.Text = "Edad";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Location = new System.Drawing.Point(86, 235);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(28, 13);
            this.LblTipo.TabIndex = 9;
            this.LblTipo.Text = "Tipo";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(159, 183);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(287, 20);
            this.TxtNombre.TabIndex = 6;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(159, 209);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(109, 20);
            this.TxtEdad.TabIndex = 8;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(159, 235);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(209, 21);
            this.cboTipo.TabIndex = 10;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(134, 441);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(109, 27);
            this.BtnAceptar.TabIndex = 12;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(403, 441);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(115, 27);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(159, 87);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(109, 20);
            this.TxtFecha.TabIndex = 14;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(464, 235);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(109, 27);
            this.BtnAgregar.TabIndex = 15;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(75, 122);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(39, 13);
            this.LblCliente.TabIndex = 16;
            this.LblCliente.Text = "Cliente";
            // 
            // CboCliente
            // 
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Location = new System.Drawing.Point(159, 122);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(209, 21);
            this.CboCliente.TabIndex = 17;
            // 
            // FrmAtenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 497);
            this.Controls.Add(this.CboCliente);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.LblEdad);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.DgvMascotas);
            this.Controls.Add(this.TxtTratamiento);
            this.Controls.Add(this.LblTratamiento);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblNroAtencion);
            this.Name = "FrmAtenciones";
            this.Text = "FrmAtenciones";
            this.Load += new System.EventHandler(this.FrmAtenciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNroAtencion;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.TextBox TxtTratamiento;
        private System.Windows.Forms.DataGridView DgvMascotas;
        private System.Windows.Forms.Label LblTratamiento;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNroMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipo;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.ComboBox CboCliente;
    }
}