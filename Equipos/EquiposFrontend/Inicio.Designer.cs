
namespace EquiposFrontend
{
    partial class Inicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPaísToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provinciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarNombreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeDocumentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarNombreToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeCompromisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTipoDeCompromisoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarElNombreDeUnTipoDeCompromisoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaDePosicionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCompromisos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCompromiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompromiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBajaEquipo = new System.Windows.Forms.Button();
            this.btnEditarEquipo = new System.Windows.Forms.Button();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.idEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEntrenador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadJugadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNvoEquipo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBajaPersona = new System.Windows.Forms.Button();
            this.btnEditarPersona = new System.Windows.Forms.Button();
            this.btnNvaPersona = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromisos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.soporteToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1201, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.aToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.salirToolStripMenuItem.Text = "LogOut";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPaísToolStripMenuItem,
            this.provinciasToolStripMenuItem,
            this.localidadesToolStripMenuItem,
            this.tiposDeDocumentosToolStripMenuItem,
            this.tiposDeCompromisosToolStripMenuItem});
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // agregarPaísToolStripMenuItem
            // 
            this.agregarPaísToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoToolStripMenuItem,
            this.editarNombreToolStripMenuItem});
            this.agregarPaísToolStripMenuItem.Name = "agregarPaísToolStripMenuItem";
            this.agregarPaísToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.agregarPaísToolStripMenuItem.Text = "Países";
            // 
            // agregarNuevoToolStripMenuItem
            // 
            this.agregarNuevoToolStripMenuItem.Name = "agregarNuevoToolStripMenuItem";
            this.agregarNuevoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.agregarNuevoToolStripMenuItem.Text = "Agregar Nuevo Pais";
            this.agregarNuevoToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoToolStripMenuItem_Click);
            // 
            // editarNombreToolStripMenuItem
            // 
            this.editarNombreToolStripMenuItem.Name = "editarNombreToolStripMenuItem";
            this.editarNombreToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.editarNombreToolStripMenuItem.Text = "Editar Nombre";
            this.editarNombreToolStripMenuItem.Click += new System.EventHandler(this.editarNombreToolStripMenuItem_Click);
            // 
            // provinciasToolStripMenuItem
            // 
            this.provinciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevaToolStripMenuItem,
            this.cambiarNombreToolStripMenuItem});
            this.provinciasToolStripMenuItem.Name = "provinciasToolStripMenuItem";
            this.provinciasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.provinciasToolStripMenuItem.Text = "Provincias";
            // 
            // agregarNuevaToolStripMenuItem
            // 
            this.agregarNuevaToolStripMenuItem.Name = "agregarNuevaToolStripMenuItem";
            this.agregarNuevaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.agregarNuevaToolStripMenuItem.Text = "Agregar Nueva Provincia";
            this.agregarNuevaToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevaToolStripMenuItem_Click);
            // 
            // cambiarNombreToolStripMenuItem
            // 
            this.cambiarNombreToolStripMenuItem.Name = "cambiarNombreToolStripMenuItem";
            this.cambiarNombreToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.cambiarNombreToolStripMenuItem.Text = "Editar Nombre";
            this.cambiarNombreToolStripMenuItem.Click += new System.EventHandler(this.cambiarNombreToolStripMenuItem_Click);
            // 
            // localidadesToolStripMenuItem
            // 
            this.localidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevaToolStripMenuItem1,
            this.cambiarNombreToolStripMenuItem1});
            this.localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            this.localidadesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.localidadesToolStripMenuItem.Text = "Localidades";
            // 
            // agregarNuevaToolStripMenuItem1
            // 
            this.agregarNuevaToolStripMenuItem1.Name = "agregarNuevaToolStripMenuItem1";
            this.agregarNuevaToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.agregarNuevaToolStripMenuItem1.Text = "Agregar Nueva Localidad";
            this.agregarNuevaToolStripMenuItem1.Click += new System.EventHandler(this.agregarNuevaToolStripMenuItem1_Click);
            // 
            // cambiarNombreToolStripMenuItem1
            // 
            this.cambiarNombreToolStripMenuItem1.Name = "cambiarNombreToolStripMenuItem1";
            this.cambiarNombreToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.cambiarNombreToolStripMenuItem1.Text = "Editar Nombre";
            this.cambiarNombreToolStripMenuItem1.Click += new System.EventHandler(this.cambiarNombreToolStripMenuItem1_Click);
            // 
            // tiposDeDocumentosToolStripMenuItem
            // 
            this.tiposDeDocumentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoTipoToolStripMenuItem,
            this.cambiarNombreToolStripMenuItem2});
            this.tiposDeDocumentosToolStripMenuItem.Name = "tiposDeDocumentosToolStripMenuItem";
            this.tiposDeDocumentosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.tiposDeDocumentosToolStripMenuItem.Text = "Tipos de Documentos";
            // 
            // agregarNuevoTipoToolStripMenuItem
            // 
            this.agregarNuevoTipoToolStripMenuItem.Name = "agregarNuevoTipoToolStripMenuItem";
            this.agregarNuevoTipoToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.agregarNuevoTipoToolStripMenuItem.Text = "Agregar Nuevo Tipo de Documento";
            this.agregarNuevoTipoToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoTipoToolStripMenuItem_Click);
            // 
            // cambiarNombreToolStripMenuItem2
            // 
            this.cambiarNombreToolStripMenuItem2.Name = "cambiarNombreToolStripMenuItem2";
            this.cambiarNombreToolStripMenuItem2.Size = new System.Drawing.Size(275, 22);
            this.cambiarNombreToolStripMenuItem2.Text = "Editar Nombre de Tipo de Documento";
            this.cambiarNombreToolStripMenuItem2.Click += new System.EventHandler(this.cambiarNombreToolStripMenuItem2_Click);
            // 
            // tiposDeCompromisosToolStripMenuItem
            // 
            this.tiposDeCompromisosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarTipoDeCompromisoToolStripMenuItem,
            this.modificarElNombreDeUnTipoDeCompromisoToolStripMenuItem});
            this.tiposDeCompromisosToolStripMenuItem.Name = "tiposDeCompromisosToolStripMenuItem";
            this.tiposDeCompromisosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.tiposDeCompromisosToolStripMenuItem.Text = "Tipos de Compromisos";
            // 
            // agregarTipoDeCompromisoToolStripMenuItem
            // 
            this.agregarTipoDeCompromisoToolStripMenuItem.Name = "agregarTipoDeCompromisoToolStripMenuItem";
            this.agregarTipoDeCompromisoToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.agregarTipoDeCompromisoToolStripMenuItem.Text = "Agregar Nuevo Tipo de Compromiso";
            this.agregarTipoDeCompromisoToolStripMenuItem.Click += new System.EventHandler(this.agregarTipoDeCompromisoToolStripMenuItem_Click);
            // 
            // modificarElNombreDeUnTipoDeCompromisoToolStripMenuItem
            // 
            this.modificarElNombreDeUnTipoDeCompromisoToolStripMenuItem.Name = "modificarElNombreDeUnTipoDeCompromisoToolStripMenuItem";
            this.modificarElNombreDeUnTipoDeCompromisoToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.modificarElNombreDeUnTipoDeCompromisoToolStripMenuItem.Text = "Editar el Nombre de un Tipo de Compromiso";
            this.modificarElNombreDeUnTipoDeCompromisoToolStripMenuItem.Click += new System.EventHandler(this.modificarElNombreDeUnTipoDeCompromisoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaDePosicionesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // tablaDePosicionesToolStripMenuItem
            // 
            this.tablaDePosicionesToolStripMenuItem.Name = "tablaDePosicionesToolStripMenuItem";
            this.tablaDePosicionesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.tablaDePosicionesToolStripMenuItem.Text = "Tabla de posiciones";
            this.tablaDePosicionesToolStripMenuItem.Click += new System.EventHandler(this.tablaDePosicionesToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónGeneralToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // informaciónGeneralToolStripMenuItem
            // 
            this.informaciónGeneralToolStripMenuItem.Name = "informaciónGeneralToolStripMenuItem";
            this.informaciónGeneralToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.informaciónGeneralToolStripMenuItem.Text = "Información general";
            // 
            // dgvCompromisos
            // 
            this.dgvCompromisos.AllowUserToAddRows = false;
            this.dgvCompromisos.AllowUserToDeleteRows = false;
            this.dgvCompromisos.AllowUserToResizeRows = false;
            this.dgvCompromisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompromisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompromisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.tipoCompromiso,
            this.fechaCompromiso});
            this.dgvCompromisos.Location = new System.Drawing.Point(6, 22);
            this.dgvCompromisos.Name = "dgvCompromisos";
            this.dgvCompromisos.ReadOnly = true;
            this.dgvCompromisos.RowTemplate.Height = 25;
            this.dgvCompromisos.Size = new System.Drawing.Size(441, 382);
            this.dgvCompromisos.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "idEquipo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre del Equipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tipoCompromiso
            // 
            this.tipoCompromiso.HeaderText = "Compromiso";
            this.tipoCompromiso.Name = "tipoCompromiso";
            this.tipoCompromiso.ReadOnly = true;
            // 
            // fechaCompromiso
            // 
            this.fechaCompromiso.HeaderText = "Fecha del Compromiso";
            this.fechaCompromiso.Name = "fechaCompromiso";
            this.fechaCompromiso.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCompromisos);
            this.groupBox1.Location = new System.Drawing.Point(736, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 410);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Próximos Compromisos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBajaEquipo);
            this.groupBox2.Controls.Add(this.btnEditarEquipo);
            this.groupBox2.Controls.Add(this.dgvEquipos);
            this.groupBox2.Controls.Add(this.btnNvoEquipo);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 313);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipos Inscriptos";
            // 
            // btnBajaEquipo
            // 
            this.btnBajaEquipo.Location = new System.Drawing.Point(470, 269);
            this.btnBajaEquipo.Name = "btnBajaEquipo";
            this.btnBajaEquipo.Size = new System.Drawing.Size(217, 38);
            this.btnBajaEquipo.TabIndex = 1;
            this.btnBajaEquipo.Text = "Baja de un Equipo Inscripto";
            this.btnBajaEquipo.UseVisualStyleBackColor = true;
            this.btnBajaEquipo.Click += new System.EventHandler(this.btnBajaEquipo_Click);
            // 
            // btnEditarEquipo
            // 
            this.btnEditarEquipo.Location = new System.Drawing.Point(247, 269);
            this.btnEditarEquipo.Name = "btnEditarEquipo";
            this.btnEditarEquipo.Size = new System.Drawing.Size(217, 38);
            this.btnEditarEquipo.TabIndex = 1;
            this.btnEditarEquipo.Text = "Editar Datos de un Equipo";
            this.btnEditarEquipo.UseVisualStyleBackColor = true;
            this.btnEditarEquipo.Click += new System.EventHandler(this.btnEditarEquipo_Click);
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.AllowUserToAddRows = false;
            this.dgvEquipos.AllowUserToDeleteRows = false;
            this.dgvEquipos.AllowUserToResizeRows = false;
            this.dgvEquipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEquipo,
            this.nombreEquipo,
            this.nombreEntrenador,
            this.cantidadJugadores,
            this.fechaAlta});
            this.dgvEquipos.Location = new System.Drawing.Point(6, 22);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.ReadOnly = true;
            this.dgvEquipos.RowTemplate.Height = 25;
            this.dgvEquipos.Size = new System.Drawing.Size(706, 230);
            this.dgvEquipos.TabIndex = 0;
            // 
            // idEquipo
            // 
            this.idEquipo.HeaderText = "idEquipo";
            this.idEquipo.Name = "idEquipo";
            this.idEquipo.ReadOnly = true;
            this.idEquipo.Visible = false;
            // 
            // nombreEquipo
            // 
            this.nombreEquipo.HeaderText = "Nombre del Equipo";
            this.nombreEquipo.Name = "nombreEquipo";
            this.nombreEquipo.ReadOnly = true;
            // 
            // nombreEntrenador
            // 
            this.nombreEntrenador.HeaderText = "Nombre del Entrenador";
            this.nombreEntrenador.Name = "nombreEntrenador";
            this.nombreEntrenador.ReadOnly = true;
            // 
            // cantidadJugadores
            // 
            this.cantidadJugadores.HeaderText = "Cantidad de Jugadores";
            this.cantidadJugadores.Name = "cantidadJugadores";
            this.cantidadJugadores.ReadOnly = true;
            // 
            // fechaAlta
            // 
            this.fechaAlta.HeaderText = "Fecha de Alta";
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.ReadOnly = true;
            // 
            // btnNvoEquipo
            // 
            this.btnNvoEquipo.Location = new System.Drawing.Point(24, 269);
            this.btnNvoEquipo.Name = "btnNvoEquipo";
            this.btnNvoEquipo.Size = new System.Drawing.Size(217, 38);
            this.btnNvoEquipo.TabIndex = 1;
            this.btnNvoEquipo.Text = "Inscribir Nuevo Equipo";
            this.btnNvoEquipo.UseVisualStyleBackColor = true;
            this.btnNvoEquipo.Click += new System.EventHandler(this.btnNvoEquipo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBajaPersona);
            this.groupBox3.Controls.Add(this.btnEditarPersona);
            this.groupBox3.Controls.Add(this.btnNvaPersona);
            this.groupBox3.Location = new System.Drawing.Point(12, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(718, 91);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gestion de Personas";
            // 
            // btnBajaPersona
            // 
            this.btnBajaPersona.Location = new System.Drawing.Point(470, 31);
            this.btnBajaPersona.Name = "btnBajaPersona";
            this.btnBajaPersona.Size = new System.Drawing.Size(217, 38);
            this.btnBajaPersona.TabIndex = 1;
            this.btnBajaPersona.Text = "Baja de una Persona Inscripta";
            this.btnBajaPersona.UseVisualStyleBackColor = true;
            this.btnBajaPersona.Click += new System.EventHandler(this.btnBajaPersona_Click);
            // 
            // btnEditarPersona
            // 
            this.btnEditarPersona.Location = new System.Drawing.Point(247, 31);
            this.btnEditarPersona.Name = "btnEditarPersona";
            this.btnEditarPersona.Size = new System.Drawing.Size(217, 38);
            this.btnEditarPersona.TabIndex = 1;
            this.btnEditarPersona.Text = "Editar Datos de una Persona";
            this.btnEditarPersona.UseVisualStyleBackColor = true;
            this.btnEditarPersona.Click += new System.EventHandler(this.btnEditarPersona_Click);
            // 
            // btnNvaPersona
            // 
            this.btnNvaPersona.Location = new System.Drawing.Point(24, 31);
            this.btnNvaPersona.Name = "btnNvaPersona";
            this.btnNvaPersona.Size = new System.Drawing.Size(217, 38);
            this.btnNvaPersona.TabIndex = 1;
            this.btnNvaPersona.Text = "Inscribir Nueva Persona";
            this.btnNvaPersona.UseVisualStyleBackColor = true;
            this.btnNvaPersona.Click += new System.EventHandler(this.btnNvaPersona_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 464);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(220, 35);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromisos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPaísToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provinciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cambiarNombreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tiposDeDocumentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarNombreToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tiposDeCompromisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTipoDeCompromisoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarElNombreDeUnTipoDeCompromisoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvCompromisos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCompromiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompromiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEntrenador;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadJugadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlta;
        private System.Windows.Forms.Button btnBajaEquipo;
        private System.Windows.Forms.Button btnEditarEquipo;
        private System.Windows.Forms.Button btnNvoEquipo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBajaPersona;
        private System.Windows.Forms.Button btnEditarPersona;
        private System.Windows.Forms.Button btnNvaPersona;

        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaDePosicionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónGeneralToolStripMenuItem;

    }
}