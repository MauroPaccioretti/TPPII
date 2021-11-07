
namespace ReportesTPPI
{
    partial class CantidadXHabilidad
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_equiposDataSet = new ReportesTPPI.db_equiposDataSet();
            this.SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter = new ReportesTPPI.db_equiposDataSetTableAdapters.SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter();
            this.SP_HABILIDADES_PERSONASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_HABILIDADES_PERSONASTableAdapter = new ReportesTPPI.db_equiposDataSetTableAdapters.SP_HABILIDADES_PERSONASTableAdapter();
            this.lblTituloEquiposActivos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_equiposDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_HABILIDADES_PERSONASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.DarkGray;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.SP_HABILIDADES_PERSONASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportesTPPI.Reportes.ReporteCantidadXHabilidad.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(683, 296);
            this.reportViewer1.TabIndex = 0;
            // 
            // db_equiposDataSet
            // 
            this.db_equiposDataSet.DataSetName = "db_equiposDataSet";
            this.db_equiposDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource
            // 
            this.SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource.DataMember = "SP_CONSULTAR_EQUIPOS_LOCALIDAD";
            this.SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource.DataSource = this.db_equiposDataSet;
            // 
            // SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter
            // 
            this.SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter.ClearBeforeFill = true;
            // 
            // SP_HABILIDADES_PERSONASBindingSource
            // 
            this.SP_HABILIDADES_PERSONASBindingSource.DataMember = "SP_HABILIDADES_PERSONAS";
            this.SP_HABILIDADES_PERSONASBindingSource.DataSource = this.db_equiposDataSet;
            // 
            // SP_HABILIDADES_PERSONASTableAdapter
            // 
            this.SP_HABILIDADES_PERSONASTableAdapter.ClearBeforeFill = true;
            // 
            // lblTituloEquiposActivos
            // 
            this.lblTituloEquiposActivos.AutoSize = true;
            this.lblTituloEquiposActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEquiposActivos.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTituloEquiposActivos.Location = new System.Drawing.Point(12, 9);
            this.lblTituloEquiposActivos.Name = "lblTituloEquiposActivos";
            this.lblTituloEquiposActivos.Size = new System.Drawing.Size(388, 26);
            this.lblTituloEquiposActivos.TabIndex = 10;
            this.lblTituloEquiposActivos.Text = "Cantidad de personas por habilidad";
            // 
            // CantidadXHabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(707, 392);
            this.Controls.Add(this.lblTituloEquiposActivos);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CantidadXHabilidad";
            this.Text = "HabilidadesXPersonas";
            this.Load += new System.EventHandler(this.CantidadXHabilidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_equiposDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_HABILIDADES_PERSONASBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource;
        private db_equiposDataSet db_equiposDataSet;
        private System.Windows.Forms.BindingSource SP_HABILIDADES_PERSONASBindingSource;
        private db_equiposDataSetTableAdapters.SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter;
        private db_equiposDataSetTableAdapters.SP_HABILIDADES_PERSONASTableAdapter SP_HABILIDADES_PERSONASTableAdapter;
        private System.Windows.Forms.Label lblTituloEquiposActivos;
    }
}