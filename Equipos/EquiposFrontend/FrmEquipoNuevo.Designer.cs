
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipoNuevo));
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
            this.grbPersonasEquipo = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.grbPersonasDisponibles = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCamiseta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarPersona = new System.Windows.Forms.Button();
            this.cmbTipoCompromiso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbCompromisosNvos = new System.Windows.Forms.GroupBox();
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
            this.grbCompromisosActuales = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvCompromisos = new System.Windows.Forms.DataGridView();
            this.idCompromiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCompromiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompromiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quitarComp = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnConfirmarAccion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarLocalidad = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonasDispo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonasEquipo)).BeginInit();
            this.grbPersonasEquipo.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.grbPersonasDisponibles.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grbCompromisosNvos.SuspendLayout();
            this.grbCompromisosActuales.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromisos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPosiciones
            // 
            this.cmbPosiciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosiciones.FormattingEnabled = true;
            this.cmbPosiciones.Location = new System.Drawing.Point(57, 342);
            this.cmbPosiciones.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPosiciones.Name = "cmbPosiciones";
            this.cmbPosiciones.Size = new System.Drawing.Size(306, 28);
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
            this.dgvPersonasDispo.Location = new System.Drawing.Point(6, 15);
            this.dgvPersonasDispo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPersonasDispo.MultiSelect = false;
            this.dgvPersonasDispo.Name = "dgvPersonasDispo";
            this.dgvPersonasDispo.ReadOnly = true;
            this.dgvPersonasDispo.RowTemplate.Height = 25;
            this.dgvPersonasDispo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonasDispo.Size = new System.Drawing.Size(823, 258);
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
            this.dgvPersonasEquipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonasEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonasEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idJugador,
            this.Apellido1,
            this.rol,
            this.Habilidad1,
            this.camiseta,
            this.fechaAlta,
            this.quitarJugador});
            this.dgvPersonasEquipo.Location = new System.Drawing.Point(6, 10);
            this.dgvPersonasEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPersonasEquipo.Name = "dgvPersonasEquipo";
            this.dgvPersonasEquipo.ReadOnly = true;
            this.dgvPersonasEquipo.RowTemplate.Height = 25;
            this.dgvPersonasEquipo.Size = new System.Drawing.Size(823, 231);
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
            this.camiseta.HeaderText = "Apodo";
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
            // grbPersonasEquipo
            // 
            this.grbPersonasEquipo.Controls.Add(this.groupBox7);
            this.grbPersonasEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbPersonasEquipo.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.grbPersonasEquipo.Location = new System.Drawing.Point(15, 591);
            this.grbPersonasEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.grbPersonasEquipo.Name = "grbPersonasEquipo";
            this.grbPersonasEquipo.Padding = new System.Windows.Forms.Padding(4);
            this.grbPersonasEquipo.Size = new System.Drawing.Size(851, 276);
            this.grbPersonasEquipo.TabIndex = 2;
            this.grbPersonasEquipo.TabStop = false;
            this.grbPersonasEquipo.Text = "Personas en el Equipo";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvPersonasEquipo);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox7.Location = new System.Drawing.Point(8, 26);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(836, 243);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            // 
            // grbPersonasDisponibles
            // 
            this.grbPersonasDisponibles.Controls.Add(this.groupBox5);
            this.grbPersonasDisponibles.Controls.Add(this.txtCamiseta);
            this.grbPersonasDisponibles.Controls.Add(this.label6);
            this.grbPersonasDisponibles.Controls.Add(this.label1);
            this.grbPersonasDisponibles.Controls.Add(this.btnAgregarPersona);
            this.grbPersonasDisponibles.Controls.Add(this.cmbPosiciones);
            this.grbPersonasDisponibles.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.grbPersonasDisponibles.Location = new System.Drawing.Point(15, 113);
            this.grbPersonasDisponibles.Margin = new System.Windows.Forms.Padding(4);
            this.grbPersonasDisponibles.Name = "grbPersonasDisponibles";
            this.grbPersonasDisponibles.Padding = new System.Windows.Forms.Padding(4);
            this.grbPersonasDisponibles.Size = new System.Drawing.Size(851, 470);
            this.grbPersonasDisponibles.TabIndex = 3;
            this.grbPersonasDisponibles.TabStop = false;
            this.grbPersonasDisponibles.Text = "Personas Disponibles";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvPersonasDispo);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(8, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(836, 280);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            // 
            // txtCamiseta
            // 
            this.txtCamiseta.Location = new System.Drawing.Point(476, 342);
            this.txtCamiseta.Margin = new System.Windows.Forms.Padding(4);
            this.txtCamiseta.Name = "txtCamiseta";
            this.txtCamiseta.Size = new System.Drawing.Size(306, 26);
            this.txtCamiseta.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 318);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Apodo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Posicion para participar en el Equipo:";
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarPersona.Location = new System.Drawing.Point(119, 404);
            this.btnAgregarPersona.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(601, 55);
            this.btnAgregarPersona.TabIndex = 10;
            this.btnAgregarPersona.Text = "Agregar Persona al Equipo";
            this.btnAgregarPersona.UseVisualStyleBackColor = false;
            this.btnAgregarPersona.Click += new System.EventHandler(this.btnAgregarPersona_Click);
            // 
            // cmbTipoCompromiso
            // 
            this.cmbTipoCompromiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCompromiso.FormattingEnabled = true;
            this.cmbTipoCompromiso.Location = new System.Drawing.Point(8, 49);
            this.cmbTipoCompromiso.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoCompromiso.Name = "cmbTipoCompromiso";
            this.cmbTipoCompromiso.Size = new System.Drawing.Size(409, 28);
            this.cmbTipoCompromiso.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de Compromiso:";
            // 
            // grbCompromisosNvos
            // 
            this.grbCompromisosNvos.Controls.Add(this.dtpCompromiso);
            this.grbCompromisosNvos.Controls.Add(this.btnNuevoCompromiso);
            this.grbCompromisosNvos.Controls.Add(this.btnAgregarCompromiso);
            this.grbCompromisosNvos.Controls.Add(this.txtCompromiso);
            this.grbCompromisosNvos.Controls.Add(this.label7);
            this.grbCompromisosNvos.Controls.Add(this.label3);
            this.grbCompromisosNvos.Controls.Add(this.label2);
            this.grbCompromisosNvos.Controls.Add(this.cmbTipoCompromiso);
            this.grbCompromisosNvos.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.grbCompromisosNvos.Location = new System.Drawing.Point(892, 112);
            this.grbCompromisosNvos.Margin = new System.Windows.Forms.Padding(4);
            this.grbCompromisosNvos.Name = "grbCompromisosNvos";
            this.grbCompromisosNvos.Padding = new System.Windows.Forms.Padding(4);
            this.grbCompromisosNvos.Size = new System.Drawing.Size(668, 339);
            this.grbCompromisosNvos.TabIndex = 5;
            this.grbCompromisosNvos.TabStop = false;
            this.grbCompromisosNvos.Text = "Compromisos del Equipo";
            // 
            // dtpCompromiso
            // 
            this.dtpCompromiso.Location = new System.Drawing.Point(192, 102);
            this.dtpCompromiso.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCompromiso.Name = "dtpCompromiso";
            this.dtpCompromiso.Size = new System.Drawing.Size(305, 26);
            this.dtpCompromiso.TabIndex = 12;
            // 
            // btnNuevoCompromiso
            // 
            this.btnNuevoCompromiso.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNuevoCompromiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCompromiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoCompromiso.Location = new System.Drawing.Point(424, 49);
            this.btnNuevoCompromiso.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoCompromiso.Name = "btnNuevoCompromiso";
            this.btnNuevoCompromiso.Size = new System.Drawing.Size(225, 28);
            this.btnNuevoCompromiso.TabIndex = 5;
            this.btnNuevoCompromiso.Text = "Nuevo Tipo de Compromiso";
            this.btnNuevoCompromiso.UseVisualStyleBackColor = false;
            this.btnNuevoCompromiso.Click += new System.EventHandler(this.btnNuevoCompromiso_Click);
            // 
            // btnAgregarCompromiso
            // 
            this.btnAgregarCompromiso.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarCompromiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCompromiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarCompromiso.Location = new System.Drawing.Point(9, 283);
            this.btnAgregarCompromiso.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarCompromiso.Name = "btnAgregarCompromiso";
            this.btnAgregarCompromiso.Size = new System.Drawing.Size(640, 47);
            this.btnAgregarCompromiso.TabIndex = 11;
            this.btnAgregarCompromiso.Text = "Agregar Compromiso al Equipo";
            this.btnAgregarCompromiso.UseVisualStyleBackColor = false;
            this.btnAgregarCompromiso.Click += new System.EventHandler(this.btnAgregarCompromiso_Click);
            // 
            // txtCompromiso
            // 
            this.txtCompromiso.Location = new System.Drawing.Point(9, 169);
            this.txtCompromiso.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompromiso.Multiline = true;
            this.txtCompromiso.Name = "txtCompromiso";
            this.txtCompromiso.Size = new System.Drawing.Size(639, 104);
            this.txtCompromiso.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fecha del Compromiso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Detalles del Compromiso:";
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(168, 58);
            this.txtNombreEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(365, 26);
            this.txtNombreEquipo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre del equipo:";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(1045, 54);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(322, 28);
            this.cmbLocalidad.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(883, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Localidad del equipo:";
            // 
            // grbCompromisosActuales
            // 
            this.grbCompromisosActuales.Controls.Add(this.groupBox6);
            this.grbCompromisosActuales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbCompromisosActuales.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.grbCompromisosActuales.Location = new System.Drawing.Point(892, 460);
            this.grbCompromisosActuales.Margin = new System.Windows.Forms.Padding(4);
            this.grbCompromisosActuales.Name = "grbCompromisosActuales";
            this.grbCompromisosActuales.Padding = new System.Windows.Forms.Padding(4);
            this.grbCompromisosActuales.Size = new System.Drawing.Size(668, 356);
            this.grbCompromisosActuales.TabIndex = 9;
            this.grbCompromisosActuales.TabStop = false;
            this.grbCompromisosActuales.Text = "Compromisos Actuales";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvCompromisos);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(9, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(652, 323);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
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
            this.dgvCompromisos.Location = new System.Drawing.Point(7, 20);
            this.dgvCompromisos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCompromisos.Name = "dgvCompromisos";
            this.dgvCompromisos.ReadOnly = true;
            this.dgvCompromisos.RowTemplate.Height = 25;
            this.dgvCompromisos.Size = new System.Drawing.Size(640, 296);
            this.dgvCompromisos.TabIndex = 0;
            this.dgvCompromisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompromisos_CellContentClick);
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
            // btnConfirmarAccion
            // 
            this.btnConfirmarAccion.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConfirmarAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmarAccion.Location = new System.Drawing.Point(944, 824);
            this.btnConfirmarAccion.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmarAccion.Name = "btnConfirmarAccion";
            this.btnConfirmarAccion.Size = new System.Drawing.Size(247, 43);
            this.btnConfirmarAccion.TabIndex = 12;
            this.btnConfirmarAccion.Text = "Registrar Equipo";
            this.btnConfirmarAccion.UseVisualStyleBackColor = false;
            this.btnConfirmarAccion.Click += new System.EventHandler(this.btnConfirmarAccion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(1209, 824);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(247, 43);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregarLocalidad
            // 
            this.btnAgregarLocalidad.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarLocalidad.Location = new System.Drawing.Point(1379, 54);
            this.btnAgregarLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarLocalidad.Name = "btnAgregarLocalidad";
            this.btnAgregarLocalidad.Size = new System.Drawing.Size(177, 28);
            this.btnAgregarLocalidad.TabIndex = 2;
            this.btnAgregarLocalidad.Text = "Nueva Localidad";
            this.btnAgregarLocalidad.UseVisualStyleBackColor = false;
            this.btnAgregarLocalidad.Click += new System.EventHandler(this.btnAgregarLocalidad_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(1534, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 27);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitulo.Location = new System.Drawing.Point(714, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 17);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Agregar Nuevo Equipo";
            // 
            // FrmEquipoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1573, 880);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregarLocalidad);
            this.Controls.Add(this.grbCompromisosActuales);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.txtNombreEquipo);
            this.Controls.Add(this.grbCompromisosNvos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarAccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grbPersonasDisponibles);
            this.Controls.Add(this.grbPersonasEquipo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEquipoNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Equipo";
            this.Load += new System.EventHandler(this.FrmEquipoNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonasDispo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonasEquipo)).EndInit();
            this.grbPersonasEquipo.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.grbPersonasDisponibles.ResumeLayout(false);
            this.grbPersonasDisponibles.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.grbCompromisosNvos.ResumeLayout(false);
            this.grbCompromisosNvos.PerformLayout();
            this.grbCompromisosActuales.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPosiciones;
        private System.Windows.Forms.DataGridView dgvPersonasDispo;
        private System.Windows.Forms.DataGridView dgvPersonasEquipo;
        private System.Windows.Forms.GroupBox grbPersonasEquipo;
        private System.Windows.Forms.GroupBox grbPersonasDisponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoCompromiso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbCompromisosNvos;
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
        private System.Windows.Forms.GroupBox grbCompromisosActuales;
        private System.Windows.Forms.DataGridView dgvCompromisos;
        private System.Windows.Forms.Button btnConfirmarAccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevoCompromiso;
        private System.Windows.Forms.Button btnAgregarLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEquipo;
        private System.Windows.Forms.DateTimePicker dtpCompromiso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompromiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCompromiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompromiso;
        private System.Windows.Forms.DataGridViewButtonColumn quitarComp;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habilidad1;
        private System.Windows.Forms.DataGridViewTextBoxColumn camiseta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlta;
        private System.Windows.Forms.DataGridViewButtonColumn quitarJugador;
        private System.Windows.Forms.Button button2;
    }
}