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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblNroAtencion = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.DgvAtenciones = new System.Windows.Forms.DataGridView();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblEdad = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LblCliente = new System.Windows.Forms.Label();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.LblTratamiento = new System.Windows.Forms.Label();
            this.txtTratatamiento = new System.Windows.Forms.TextBox();
            this.LblImporte = new System.Windows.Forms.Label();
            this.TxtImporte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAtenciones)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNroAtencion
            // 
            this.LblNroAtencion.AutoSize = true;
            this.LblNroAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroAtencion.Location = new System.Drawing.Point(12, 9);
            this.LblNroAtencion.Name = "LblNroAtencion";
            this.LblNroAtencion.Size = new System.Drawing.Size(138, 20);
            this.LblNroAtencion.TabIndex = 0;
            this.LblNroAtencion.Text = "Nro de Atencion";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(159, 114);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(317, 20);
            this.TxtNombre.TabIndex = 4;
            // 
            // DgvAtenciones
            // 
            this.DgvAtenciones.AllowUserToAddRows = false;
            this.DgvAtenciones.AllowUserToDeleteRows = false;
            this.DgvAtenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAtenciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFecha,
            this.ColDescripcion,
            this.ColImporte,
            this.ColAcciones});
            this.DgvAtenciones.Location = new System.Drawing.Point(71, 263);
            this.DgvAtenciones.Name = "DgvAtenciones";
            this.DgvAtenciones.ReadOnly = true;
            this.DgvAtenciones.Size = new System.Drawing.Size(443, 138);
            this.DgvAtenciones.TabIndex = 11;
            this.DgvAtenciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAtenciones_CellContentClick);
            // 
            // ColFecha
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.ColFecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Tratamiento";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            // 
            // ColImporte
            // 
            this.ColImporte.HeaderText = "Importe";
            this.ColImporte.Name = "ColImporte";
            this.ColImporte.ReadOnly = true;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(30, 114);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(88, 13);
            this.LblNombre.TabIndex = 5;
            this.LblNombre.Text = "Nombre Mascota";
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Location = new System.Drawing.Point(86, 174);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(32, 13);
            this.LblEdad.TabIndex = 7;
            this.LblEdad.Text = "Edad";
            this.LblEdad.Click += new System.EventHandler(this.LblEdad_Click);
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Location = new System.Drawing.Point(90, 140);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(28, 13);
            this.LblTipo.TabIndex = 9;
            this.LblTipo.Text = "Tipo";
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(159, 167);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(45, 20);
            this.TxtEdad.TabIndex = 8;
            this.TxtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(159, 140);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(209, 21);
            this.cboTipo.TabIndex = 10;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(71, 407);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(109, 27);
            this.BtnAceptar.TabIndex = 12;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(399, 407);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(115, 27);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(405, 234);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(109, 23);
            this.BtnAgregar.TabIndex = 15;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(79, 90);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(39, 13);
            this.LblCliente.TabIndex = 16;
            this.LblCliente.Text = "Cliente";
            // 
            // CboCliente
            // 
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Location = new System.Drawing.Point(159, 87);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(317, 21);
            this.CboCliente.TabIndex = 17;
            this.CboCliente.SelectedIndexChanged += new System.EventHandler(this.CboCliente_SelectedIndexChanged);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(79, 58);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(37, 13);
            this.LblFecha.TabIndex = 18;
            this.LblFecha.Text = "Fecha";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(159, 55);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(161, 20);
            this.TxtFecha.TabIndex = 19;
            // 
            // LblTratamiento
            // 
            this.LblTratamiento.AutoSize = true;
            this.LblTratamiento.Location = new System.Drawing.Point(55, 202);
            this.LblTratamiento.Name = "LblTratamiento";
            this.LblTratamiento.Size = new System.Drawing.Size(63, 13);
            this.LblTratamiento.TabIndex = 20;
            this.LblTratamiento.Text = "Tratamiento";
            // 
            // txtTratatamiento
            // 
            this.txtTratatamiento.Location = new System.Drawing.Point(159, 199);
            this.txtTratatamiento.Name = "txtTratatamiento";
            this.txtTratatamiento.Size = new System.Drawing.Size(161, 20);
            this.txtTratatamiento.TabIndex = 21;
            // 
            // LblImporte
            // 
            this.LblImporte.AutoSize = true;
            this.LblImporte.Location = new System.Drawing.Point(338, 202);
            this.LblImporte.Name = "LblImporte";
            this.LblImporte.Size = new System.Drawing.Size(42, 13);
            this.LblImporte.TabIndex = 22;
            this.LblImporte.Text = "Importe";
            // 
            // TxtImporte
            // 
            this.TxtImporte.Location = new System.Drawing.Point(386, 199);
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.Size = new System.Drawing.Size(128, 20);
            this.TxtImporte.TabIndex = 23;
            // 
            // FrmAtenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 458);
            this.Controls.Add(this.TxtImporte);
            this.Controls.Add(this.LblImporte);
            this.Controls.Add(this.txtTratatamiento);
            this.Controls.Add(this.LblTratamiento);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.CboCliente);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.LblEdad);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.DgvAtenciones);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNroAtencion);
            this.Name = "FrmAtenciones";
            this.Text = "FrmAtenciones";
            this.Load += new System.EventHandler(this.FrmAtenciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAtenciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNroAtencion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.DataGridView DgvAtenciones;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.ComboBox CboCliente;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label LblTratamiento;
        private System.Windows.Forms.TextBox txtTratatamiento;
        private System.Windows.Forms.Label LblImporte;
        private System.Windows.Forms.TextBox TxtImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImporte;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
    }
}