
namespace EquiposFrontend
{
    partial class FrmEquipoNuevo
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
            this.cmbPosiciones = new System.Windows.Forms.ComboBox();
            this.dgvPersonasDispo = new System.Windows.Forms.DataGridView();
            this.idPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPersonasEquipo = new System.Windows.Forms.DataGridView();
            this.idJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habilidad1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camiseta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quitarJugador = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNuevaPosicion = new System.Windows.Forms.Button();
            this.txtCamiseta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarPersona = new System.Windows.Forms.Button();
            this.cmbTipoCompromiso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpCompromiso = new System.Windows.Forms.DateTimePicker();
            this.btnNuevoCompromiso = new System.Windows.Forms.Button();
            this.btnAgregarCompromiso = new System.Windows.Forms.Button();
            this.txtCompromiso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCompromisos = new System.Windows.Forms.DataGridView();
            this.btnConfirmarAccion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarLocalidad = new System.Windows.Forms.Button();
            this.idCompromiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCompromiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompromiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quitarComp = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonasDispo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonasEquipo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromisos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPosiciones
            // 
            this.cmbPosiciones.FormattingEnabled = true;
            this.cmbPosiciones.Location = new System.Drawing.Point(88, 210);
            this.cmbPosiciones.Name = "cmbPosiciones";
            this.cmbPosiciones.Size = new System.Drawing.Size(239, 23);
            this.cmbPosiciones.TabIndex = 7;
            // 
            // dgvPersonasDispo
            // 
            this.dgvPersonasDispo.AllowUserToAddRows = false;
            this.dgvPersonasDispo.AllowUserToDeleteRows = false;
            this.dgvPersonasDispo.AllowUserToResizeRows = false;
            this.dgvPersonasDispo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonasDispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonasDispo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersona,
            this.Apellido,
            this.Nombre,
            this.Habilidad,
            this.Peso,
            this.Estatura,
            this.fechaNacimiento});
            this.dgvPersonasDispo.Location = new System.Drawing.Point(6, 22);
            this.dgvPersonasDispo.Name = "dgvPersonasDispo";
            this.dgvPersonasDispo.ReadOnly = true;
            this.dgvPersonasDispo.RowTemplate.Height = 25;
            this.dgvPersonasDispo.Size = new System.Drawing.Size(640, 163);
            this.dgvPersonasDispo.TabIndex = 3;
            // 
            // idPersona
            // 
            this.idPersona.HeaderText = "idPersona";
            this.idPersona.Name = "idPersona";
            this.idPersona.ReadOnly = true;
            this.idPersona.Visible = false;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Habilidad
            // 
            this.Habilidad.HeaderText = "Habilidad";
            this.Habilidad.Name = "Habilidad";
            this.Habilidad.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // Estatura
            // 
            this.Estatura.HeaderText = "Estatura";
            this.Estatura.Name = "Estatura";
            this.Estatura.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            // 
            // dgvPersonasEquipo
            // 
            this.dgvPersonasEquipo.AllowUserToAddRows = false;
            this.dgvPersonasEquipo.AllowUserToDeleteRows = false;
            this.dgvPersonasEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonasEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idJugador,
            this.Apellido1,
            this.rol,
            this.Habilidad1,
            this.camiseta,
            this.fechaAlta,
            this.quitarJugador});
            this.dgvPersonasEquipo.Location = new System.Drawing.Point(6, 22);
            this.dgvPersonasEquipo.Name = "dgvPersonasEquipo";
            this.dgvPersonasEquipo.ReadOnly = true;
            this.dgvPersonasEquipo.RowTemplate.Height = 25;
            this.dgvPersonasEquipo.Size = new System.Drawing.Size(634, 169);
            this.dgvPersonasEquipo.TabIndex = 1;
            this.dgvPersonasEquipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonasEquipo_CellContentClick);
            // 
            // idJugador
            // 
            this.idJugador.HeaderText = "idJugador";
            this.idJugador.Name = "idJugador";
            this.idJugador.ReadOnly = true;
            this.idJugador.Visible = false;
            // 
            // Apellido1
            // 
            this.Apellido1.HeaderText = "Apellido";
            this.Apellido1.Name = "Apellido1";
            this.Apellido1.ReadOnly = true;
            // 
            // rol
            // 
            this.rol.HeaderText = "Rol en el Equipo";
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            // 
            // Habilidad1
            // 
            this.Habilidad1.HeaderText = "Habilidad";
            this.Habilidad1.Name = "Habilidad1";
            this.Habilidad1.ReadOnly = true;
            this.Habilidad1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Habilidad1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // camiseta
            // 
            this.camiseta.HeaderText = "Camiseta";
            this.camiseta.Name = "camiseta";
            this.camiseta.ReadOnly = true;
            this.camiseta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.camiseta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fechaAlta
            // 
            this.fechaAlta.HeaderText = "Fecha Incorporación";
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.ReadOnly = true;
            this.fechaAlta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fechaAlta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // quitarJugador
            // 
            this.quitarJugador.HeaderText = "Quitar";
            this.quitarJugador.Name = "quitarJugador";
            this.quitarJugador.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPersonasEquipo);
            this.groupBox1.Location = new System.Drawing.Point(18, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 207);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personas en el Equipo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNuevaPosicion);
            this.groupBox2.Controls.Add(this.txtCamiseta);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dgvPersonasDispo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnAgregarPersona);
            this.groupBox2.Controls.Add(this.cmbPosiciones);
            this.groupBox2.Location = new System.Drawing.Point(12, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(652, 335);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personas Disponibles";
            // 
            // btnNuevaPosicion
            // 
            this.btnNuevaPosicion.Location = new System.Drawing.Point(364, 209);
            this.btnNuevaPosicion.Name = "btnNuevaPosicion";
            this.btnNuevaPosicion.Size = new System.Drawing.Size(153, 23);
            this.btnNuevaPosicion.TabIndex = 8;
            this.btnNuevaPosicion.Text = "Agregar Nueva Posicion";
            this.btnNuevaPosicion.UseVisualStyleBackColor = true;
            // 
            // txtCamiseta
            // 
            this.txtCamiseta.Location = new System.Drawing.Point(88, 259);
            this.txtCamiseta.Name = "txtCamiseta";
            this.txtCamiseta.Size = new System.Drawing.Size(468, 23);
            this.txtCamiseta.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Camiseta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Posicion para participar en el Equipo:";
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.Location = new System.Drawing.Point(6, 288);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(640, 41);
            this.btnAgregarPersona.TabIndex = 10;
            this.btnAgregarPersona.Text = "Agregar Persona al Equipo";
            this.btnAgregarPersona.UseVisualStyleBackColor = true;
            this.btnAgregarPersona.Click += new System.EventHandler(this.btnAgregarPersona_Click);
            // 
            // cmbTipoCompromiso
            // 
            this.cmbTipoCompromiso.FormattingEnabled = true;
            this.cmbTipoCompromiso.Location = new System.Drawing.Point(6, 37);
            this.cmbTipoCompromiso.Name = "cmbTipoCompromiso";
            this.cmbTipoCompromiso.Size = new System.Drawing.Size(319, 23);
            this.cmbTipoCompromiso.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de Compromiso:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpCompromiso);
            this.groupBox3.Controls.Add(this.btnNuevoCompromiso);
            this.groupBox3.Controls.Add(this.btnAgregarCompromiso);
            this.groupBox3.Controls.Add(this.txtCompromiso);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbTipoCompromiso);
            this.groupBox3.Location = new System.Drawing.Point(670, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 254);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compromisos del Equipo";
            // 
            // dtpCompromiso
            // 
            this.dtpCompromiso.Location = new System.Drawing.Point(145, 74);
            this.dtpCompromiso.Name = "dtpCompromiso";
            this.dtpCompromiso.Size = new System.Drawing.Size(238, 23);
            this.dtpCompromiso.TabIndex = 12;
            // 
            // btnNuevoCompromiso
            // 
            this.btnNuevoCompromiso.Location = new System.Drawing.Point(330, 37);
            this.btnNuevoCompromiso.Name = "btnNuevoCompromiso";
            this.btnNuevoCompromiso.Size = new System.Drawing.Size(175, 23);
            this.btnNuevoCompromiso.TabIndex = 5;
            this.btnNuevoCompromiso.Text = "Nuevo Tipo de Compromiso";
            this.btnNuevoCompromiso.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCompromiso
            // 
            this.btnAgregarCompromiso.Location = new System.Drawing.Point(7, 212);
            this.btnAgregarCompromiso.Name = "btnAgregarCompromiso";
            this.btnAgregarCompromiso.Size = new System.Drawing.Size(498, 35);
            this.btnAgregarCompromiso.TabIndex = 11;
            this.btnAgregarCompromiso.Text = "Agregar Compromiso al Equipo";
            this.btnAgregarCompromiso.UseVisualStyleBackColor = true;
            this.btnAgregarCompromiso.Click += new System.EventHandler(this.btnAgregarCompromiso_Click);
            // 
            // txtCompromiso
            // 
            this.txtCompromiso.Location = new System.Drawing.Point(7, 127);
            this.txtCompromiso.Multiline = true;
            this.txtCompromiso.Name = "txtCompromiso";
            this.txtCompromiso.Size = new System.Drawing.Size(498, 79);
            this.txtCompromiso.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fecha del Compromiso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Detalles del Compromiso:";
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(131, 18);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(285, 23);
            this.txtNombreEquipo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre del equipo:";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(728, 15);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(251, 23);
            this.cmbLocalidad.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(602, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Localidad del equipo:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCompromisos);
            this.groupBox4.Location = new System.Drawing.Point(670, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(511, 250);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Compromisos Actuales";
            // 
            // dgvCompromisos
            // 
            this.dgvCompromisos.AllowUserToAddRows = false;
            this.dgvCompromisos.AllowUserToDeleteRows = false;
            this.dgvCompromisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompromisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompromisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompromiso,
            this.colCodEquipo,
            this.TipoCompromiso,
            this.comentarios,
            this.fechaCompromiso,
            this.quitarComp});
            this.dgvCompromisos.Location = new System.Drawing.Point(7, 22);
            this.dgvCompromisos.Name = "dgvCompromisos";
            this.dgvCompromisos.ReadOnly = true;
            this.dgvCompromisos.RowTemplate.Height = 25;
            this.dgvCompromisos.Size = new System.Drawing.Size(498, 222);
            this.dgvCompromisos.TabIndex = 0;
            this.dgvCompromisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompromisos_CellContentClick);
            // 
            // btnConfirmarAccion
            // 
            this.btnConfirmarAccion.Location = new System.Drawing.Point(728, 566);
            this.btnConfirmarAccion.Name = "btnConfirmarAccion";
            this.btnConfirmarAccion.Size = new System.Drawing.Size(192, 32);
            this.btnConfirmarAccion.TabIndex = 12;
            this.btnConfirmarAccion.Text = "Registrar Equipo";
            this.btnConfirmarAccion.UseVisualStyleBackColor = true;
            this.btnConfirmarAccion.Click += new System.EventHandler(this.btnConfirmarAccion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(934, 566);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(192, 32);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregarLocalidad
            // 
            this.btnAgregarLocalidad.Location = new System.Drawing.Point(988, 15);
            this.btnAgregarLocalidad.Name = "btnAgregarLocalidad";
            this.btnAgregarLocalidad.Size = new System.Drawing.Size(138, 23);
            this.btnAgregarLocalidad.TabIndex = 2;
            this.btnAgregarLocalidad.Text = "Nueva Localidad";
            this.btnAgregarLocalidad.UseVisualStyleBackColor = true;
            // 
            // idCompromiso
            // 
            this.idCompromiso.HeaderText = "idCompromiso";
            this.idCompromiso.Name = "idCompromiso";
            this.idCompromiso.ReadOnly = true;
            this.idCompromiso.Visible = false;
            // 
            // colCodEquipo
            // 
            this.colCodEquipo.HeaderText = "colCodEquipo";
            this.colCodEquipo.Name = "colCodEquipo";
            this.colCodEquipo.ReadOnly = true;
            this.colCodEquipo.Visible = false;
            // 
            // TipoCompromiso
            // 
            this.TipoCompromiso.HeaderText = "Tipo Compromiso";
            this.TipoCompromiso.Name = "TipoCompromiso";
            this.TipoCompromiso.ReadOnly = true;
            // 
            // comentarios
            // 
            this.comentarios.HeaderText = "Comentarios";
            this.comentarios.Name = "comentarios";
            this.comentarios.ReadOnly = true;
            // 
            // fechaCompromiso
            // 
            this.fechaCompromiso.HeaderText = "Fecha del Compromiso";
            this.fechaCompromiso.Name = "fechaCompromiso";
            this.fechaCompromiso.ReadOnly = true;
            // 
            // quitarComp
            // 
            this.quitarComp.HeaderText = "Quitar";
            this.quitarComp.Name = "quitarComp";
            this.quitarComp.ReadOnly = true;
            this.quitarComp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.quitarComp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmEquipoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 620);
            this.Controls.Add(this.btnAgregarLocalidad);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.txtNombreEquipo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarAccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEquipoNuevo";
            this.Text = "Nuevo Equipo";
            this.Load += new System.EventHandler(this.FrmEquipoNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonasDispo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonasEquipo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPosiciones;
        private System.Windows.Forms.DataGridView dgvPersonasDispo;
        private System.Windows.Forms.DataGridView dgvPersonasEquipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoCompromiso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAgregarCompromiso;
        private System.Windows.Forms.TextBox txtCompromiso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarPersona;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCamiseta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvCompromisos;
        private System.Windows.Forms.Button btnConfirmarAccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevaPosicion;
        private System.Windows.Forms.Button btnNuevoCompromiso;
        private System.Windows.Forms.Button btnAgregarLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habilidad1;
        private System.Windows.Forms.DataGridViewTextBoxColumn camiseta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlta;
        private System.Windows.Forms.DataGridViewButtonColumn quitarJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEquipo;
        private System.Windows.Forms.DateTimePicker dtpCompromiso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompromiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCompromiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompromiso;
        private System.Windows.Forms.DataGridViewButtonColumn quitarComp;
    }
}