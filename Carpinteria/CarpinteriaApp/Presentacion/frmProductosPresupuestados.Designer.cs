namespace CarpinteriaApp.Presentacion
{
    partial class frmProductosPresupuestados
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dSProductosPrersupuestados = new CarpinteriaApp.Reportes.DSProductosPrersupuestados();
            this.sPREPORTEPRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_REPORTE_PRODUCTOSTableAdapter = new CarpinteriaApp.Reportes.DSProductosPrersupuestadosTableAdapters.SP_REPORTE_PRODUCTOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSProductosPrersupuestados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTEPRODUCTOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPREPORTEPRODUCTOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CarpinteriaApp.Reportes.rpProductosPresupuestados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(27, 79);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(636, 368);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha Hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(356, 5);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaHasta.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha Desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(104, 5);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaDesde.TabIndex = 8;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(509, 24);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(117, 30);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dSProductosPrersupuestados
            // 
            this.dSProductosPrersupuestados.DataSetName = "DSProductosPrersupuestados";
            this.dSProductosPrersupuestados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPREPORTEPRODUCTOSBindingSource
            // 
            this.sPREPORTEPRODUCTOSBindingSource.DataMember = "SP_REPORTE_PRODUCTOS";
            this.sPREPORTEPRODUCTOSBindingSource.DataSource = this.dSProductosPrersupuestados;
            // 
            // sP_REPORTE_PRODUCTOSTableAdapter
            // 
            this.sP_REPORTE_PRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // frmProductosPresupuestados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmProductosPresupuestados";
            this.Text = "frmProductosPresupuestados";
            this.Load += new System.EventHandler(this.frmProductosPresupuestados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSProductosPrersupuestados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTEPRODUCTOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.BindingSource sPREPORTEPRODUCTOSBindingSource;
        private Reportes.DSProductosPrersupuestados dSProductosPrersupuestados;
        private Reportes.DSProductosPrersupuestadosTableAdapters.SP_REPORTE_PRODUCTOSTableAdapter sP_REPORTE_PRODUCTOSTableAdapter;
    }
}