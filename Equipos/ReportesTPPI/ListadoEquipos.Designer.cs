
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
            this.SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_equiposDataSet1 = new ReportesTPPI.db_equiposDataSet1();
            this.SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter = new ReportesTPPI.db_equiposDataSet1TableAdapters.SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.dgvRespuesta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblColumna = new System.Windows.Forms.Label();
            this.lblTituloEquiposActivos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_equiposDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespuesta)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource
            // 
            this.SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource.DataMember = "SP_CONSULTAR_EQUIPOS_LOCALIDAD";
            this.SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource.DataSource = this.db_equiposDataSet1;
            // 
            // db_equiposDataSet1
            // 
            this.db_equiposDataSet1.DataSetName = "db_equiposDataSet1";
            this.db_equiposDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter
            // 
            this.SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter.ClearBeforeFill = true;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblFiltrar.Location = new System.Drawing.Point(48, 78);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(61, 22);
            this.lblFiltrar.TabIndex = 1;
            this.lblFiltrar.Text = "Filtrar:";
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(185, 110);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(194, 21);
            this.cboBusqueda.TabIndex = 2;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.Location = new System.Drawing.Point(415, 149);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 3;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // dgvRespuesta
            // 
            this.dgvRespuesta.AllowUserToAddRows = false;
            this.dgvRespuesta.AllowUserToDeleteRows = false;
            this.dgvRespuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRespuesta.Location = new System.Drawing.Point(1, 204);
            this.dgvRespuesta.Name = "dgvRespuesta";
            this.dgvRespuesta.ReadOnly = true;
            this.dgvRespuesta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRespuesta.Size = new System.Drawing.Size(706, 188);
            this.dgvRespuesta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(123, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Equipo:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(185, 152);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(194, 20);
            this.txtFiltro.TabIndex = 6;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(496, 149);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblColumna
            // 
            this.lblColumna.AutoSize = true;
            this.lblColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumna.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblColumna.Location = new System.Drawing.Point(112, 111);
            this.lblColumna.Name = "lblColumna";
            this.lblColumna.Size = new System.Drawing.Size(67, 17);
            this.lblColumna.TabIndex = 8;
            this.lblColumna.Text = "Columna:";
            // 
            // lblTituloEquiposActivos
            // 
            this.lblTituloEquiposActivos.AutoSize = true;
            this.lblTituloEquiposActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEquiposActivos.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTituloEquiposActivos.Location = new System.Drawing.Point(12, 9);
            this.lblTituloEquiposActivos.Name = "lblTituloEquiposActivos";
            this.lblTituloEquiposActivos.Size = new System.Drawing.Size(294, 26);
            this.lblTituloEquiposActivos.TabIndex = 9;
            this.lblTituloEquiposActivos.Text = "Listado de equipos activos";
            // 
            // ListadoEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(707, 392);
            this.Controls.Add(this.lblTituloEquiposActivos);
            this.Controls.Add(this.lblColumna);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRespuesta);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.lblFiltrar);
            this.Name = "ListadoEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Equipos";
            this.Load += new System.EventHandler(this.ListadoEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_equiposDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespuesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource SP_CONSULTAR_EQUIPOS_LOCALIDADBindingSource;
        private db_equiposDataSet1 db_equiposDataSet1;
        private db_equiposDataSet1TableAdapters.SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.DataGridView dgvRespuesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblColumna;
        private System.Windows.Forms.Label lblTituloEquiposActivos;
    }
}

