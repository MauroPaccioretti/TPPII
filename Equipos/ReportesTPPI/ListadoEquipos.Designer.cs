
namespace ReportesTPPI
{
    partial class ListadoEquipos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_equiposDataSet1 = new ReportesTPPI.db_equiposDataSet1();
            this.SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter = new ReportesTPPI.db_equiposDataSet1TableAdapters.SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.cboEquipos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.db_equiposDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetEquiposActivos";
            reportDataSource1.Value = this.SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportesTPPI.Reportes.ListadoEquipos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 160);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1202, 271);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // db_equiposDataSet1
            // 
            this.db_equiposDataSet1.DataSetName = "db_equiposDataSet1";
            this.db_equiposDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource
            // 
            this.SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource.DataMember = "SP_CONSULTAR_EQUIPOS_LOCALIDAD";
            this.SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource.DataSource = this.db_equiposDataSet1;
            // 
            // SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter
            // 
            this.SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter.ClearBeforeFill = true;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(35, 27);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(66, 25);
            this.lblFiltrar.TabIndex = 1;
            this.lblFiltrar.Text = "Filtrar:";
            // 
            // cboEquipos
            // 
            this.cboEquipos.FormattingEnabled = true;
            this.cboEquipos.Location = new System.Drawing.Point(162, 33);
            this.cboEquipos.Name = "cboEquipos";
            this.cboEquipos.Size = new System.Drawing.Size(194, 21);
            this.cboEquipos.TabIndex = 2;
            // 
            // ListadoEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 464);
            this.Controls.Add(this.cboEquipos);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ListadoEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Equipos";
            this.Load += new System.EventHandler(this.ListadoEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_equiposDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource;
        private db_equiposDataSet1 db_equiposDataSet1;
        private db_equiposDataSet1TableAdapters.SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cboEquipos;
    }
}

