﻿
namespace EquiposFrontend
{
    partial class FrmListarPersonas
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
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.idPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piernaHabil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPierna = new System.Windows.Forms.ComboBox();
            this.cmbTipoDni = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimientoDesde = new System.Windows.Forms.DateTimePicker();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtPesoDesde = new System.Windows.Forms.TextBox();
            this.txtEstaturaDesde = new System.Windows.Forms.TextBox();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFechaNacimientoHasta = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEstaturaHasta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPesoHasta = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBajaPersona = new System.Windows.Forms.Button();
            this.btnEditarPersona = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbPierna = new System.Windows.Forms.CheckBox();
            this.chbTipoDoc = new System.Windows.Forms.CheckBox();
            this.chbBaja = new System.Windows.Forms.CheckBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrarNuevaPersona = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
=======
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AllowUserToDeleteRows = false;
            this.dgvPersonas.AllowUserToResizeRows = false;
            this.dgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersona,
            this.Apellido,
            this.Nombre,
            this.tipoDoc,
            this.nroDocumento,
            this.fechaNac,
            this.piernaHabil,
            this.peso,
            this.estatura,
            this.fechaAlta,
            this.fechaBaja});
<<<<<<< HEAD
            this.dgvPersonas.Location = new System.Drawing.Point(7, 16);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.RowTemplate.Height = 25;
            this.dgvPersonas.Size = new System.Drawing.Size(1571, 462);
=======
            this.dgvPersonas.Location = new System.Drawing.Point(9, 10);
            this.dgvPersonas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.RowTemplate.Height = 25;
            this.dgvPersonas.Size = new System.Drawing.Size(1068, 262);
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.dgvPersonas.TabIndex = 0;
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
            // tipoDoc
            // 
            this.tipoDoc.HeaderText = "Tipo Documento";
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.ReadOnly = true;
            // 
            // nroDocumento
            // 
            this.nroDocumento.HeaderText = "Número Documento";
            this.nroDocumento.Name = "nroDocumento";
            this.nroDocumento.ReadOnly = true;
            // 
            // fechaNac
            // 
            this.fechaNac.HeaderText = "Fecha Nacimiento";
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.ReadOnly = true;
            // 
            // piernaHabil
            // 
            this.piernaHabil.HeaderText = "Pierna Hábil";
            this.piernaHabil.Name = "piernaHabil";
            this.piernaHabil.ReadOnly = true;
            // 
            // peso
            // 
            this.peso.HeaderText = "Peso";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            // 
            // estatura
            // 
            this.estatura.HeaderText = "Estatura";
            this.estatura.Name = "estatura";
            this.estatura.ReadOnly = true;
            // 
            // fechaAlta
            // 
            this.fechaAlta.HeaderText = "FechaAlta";
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.ReadOnly = true;
            // 
            // fechaBaja
            // 
            this.fechaBaja.HeaderText = "Fecha Baja";
            this.fechaBaja.Name = "fechaBaja";
            this.fechaBaja.ReadOnly = true;
            // 
            // cmbPierna
            // 
            this.cmbPierna.FormattingEnabled = true;
<<<<<<< HEAD
            this.cmbPierna.Location = new System.Drawing.Point(724, 186);
            this.cmbPierna.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPierna.Name = "cmbPierna";
            this.cmbPierna.Size = new System.Drawing.Size(318, 28);
=======
            this.cmbPierna.Location = new System.Drawing.Point(670, 143);
            this.cmbPierna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPierna.Name = "cmbPierna";
            this.cmbPierna.Size = new System.Drawing.Size(128, 23);
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.cmbPierna.TabIndex = 18;
            // 
            // cmbTipoDni
            // 
            this.cmbTipoDni.FormattingEnabled = true;
<<<<<<< HEAD
            this.cmbTipoDni.Location = new System.Drawing.Point(194, 189);
            this.cmbTipoDni.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoDni.Name = "cmbTipoDni";
            this.cmbTipoDni.Size = new System.Drawing.Size(318, 28);
=======
            this.cmbTipoDni.Location = new System.Drawing.Point(278, 141);
            this.cmbTipoDni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTipoDni.Name = "cmbTipoDni";
            this.cmbTipoDni.Size = new System.Drawing.Size(146, 23);
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.cmbTipoDni.TabIndex = 19;
            // 
            // dtpFechaNacimientoDesde
            // 
<<<<<<< HEAD
            this.dtpFechaNacimientoDesde.Location = new System.Drawing.Point(198, 80);
            this.dtpFechaNacimientoDesde.Name = "dtpFechaNacimientoDesde";
            this.dtpFechaNacimientoDesde.Size = new System.Drawing.Size(249, 26);
=======
            this.dtpFechaNacimientoDesde.Location = new System.Drawing.Point(175, 78);
            this.dtpFechaNacimientoDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaNacimientoDesde.Name = "dtpFechaNacimientoDesde";
            this.dtpFechaNacimientoDesde.Size = new System.Drawing.Size(248, 23);
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.dtpFechaNacimientoDesde.TabIndex = 17;
            this.dtpFechaNacimientoDesde.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // txtApellido
            // 
<<<<<<< HEAD
            this.txtApellido.Location = new System.Drawing.Point(86, 68);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
=======
            this.txtApellido.Location = new System.Drawing.Point(174, 47);
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(249, 23);
            this.txtApellido.TabIndex = 12;
            // 
            // txtPesoDesde
            // 
<<<<<<< HEAD
            this.txtPesoDesde.Location = new System.Drawing.Point(612, 83);
            this.txtPesoDesde.Name = "txtPesoDesde";
            this.txtPesoDesde.Size = new System.Drawing.Size(249, 26);
=======
            this.txtPesoDesde.Location = new System.Drawing.Point(603, 76);
            this.txtPesoDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPesoDesde.Name = "txtPesoDesde";
            this.txtPesoDesde.Size = new System.Drawing.Size(195, 23);
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.txtPesoDesde.TabIndex = 13;
            // 
            // txtEstaturaDesde
            // 
<<<<<<< HEAD
            this.txtEstaturaDesde.Location = new System.Drawing.Point(611, 26);
            this.txtEstaturaDesde.Name = "txtEstaturaDesde";
            this.txtEstaturaDesde.Size = new System.Drawing.Size(249, 26);
=======
            this.txtEstaturaDesde.Location = new System.Drawing.Point(603, 21);
            this.txtEstaturaDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEstaturaDesde.Name = "txtEstaturaDesde";
            this.txtEstaturaDesde.Size = new System.Drawing.Size(195, 23);
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.txtEstaturaDesde.TabIndex = 14;
            // 
            // txtNroDoc
            // 
<<<<<<< HEAD
            this.txtNroDoc.Location = new System.Drawing.Point(150, 170);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(249, 26);
=======
            this.txtNroDoc.Location = new System.Drawing.Point(212, 184);
            this.txtNroDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(195, 23);
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.txtNroDoc.TabIndex = 15;
            // 
            // txtNombre
            // 
<<<<<<< HEAD
            this.txtNombre.Location = new System.Drawing.Point(86, 33);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
=======
            this.txtNombre.Location = new System.Drawing.Point(174, 18);
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 23);
            this.txtNombre.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Pierna Hábil:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Peso (Kg):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Estatura (cm):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Número de Documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(128, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Desde:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(128, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Hasta:";
            // 
            // dtpFechaNacimientoHasta
            // 
<<<<<<< HEAD
            this.dtpFechaNacimientoHasta.Location = new System.Drawing.Point(198, 109);
            this.dtpFechaNacimientoHasta.Name = "dtpFechaNacimientoHasta";
            this.dtpFechaNacimientoHasta.Size = new System.Drawing.Size(249, 26);
=======
            this.dtpFechaNacimientoHasta.Location = new System.Drawing.Point(175, 110);
            this.dtpFechaNacimientoHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaNacimientoHasta.Name = "dtpFechaNacimientoHasta";
            this.dtpFechaNacimientoHasta.Size = new System.Drawing.Size(248, 23);
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.dtpFechaNacimientoHasta.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(530, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Desde:";
            // 
            // txtEstaturaHasta
            // 
<<<<<<< HEAD
            this.txtEstaturaHasta.Location = new System.Drawing.Point(612, 54);
            this.txtEstaturaHasta.Name = "txtEstaturaHasta";
            this.txtEstaturaHasta.Size = new System.Drawing.Size(249, 26);
=======
            this.txtEstaturaHasta.Location = new System.Drawing.Point(603, 48);
            this.txtEstaturaHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEstaturaHasta.Name = "txtEstaturaHasta";
            this.txtEstaturaHasta.Size = new System.Drawing.Size(195, 23);
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.txtEstaturaHasta.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(530, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "Hasta:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(528, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "Desde:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(528, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 15);
            this.label14.TabIndex = 20;
            this.label14.Text = "Hasta:";
            // 
            // txtPesoHasta
            // 
<<<<<<< HEAD
            this.txtPesoHasta.Location = new System.Drawing.Point(612, 111);
            this.txtPesoHasta.Name = "txtPesoHasta";
            this.txtPesoHasta.Size = new System.Drawing.Size(249, 26);
=======
            this.txtPesoHasta.Location = new System.Drawing.Point(603, 103);
            this.txtPesoHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPesoHasta.Name = "txtPesoHasta";
            this.txtPesoHasta.Size = new System.Drawing.Size(195, 23);
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.txtPesoHasta.TabIndex = 14;
            // 
            // btnBuscar
            // 
<<<<<<< HEAD
            this.btnBuscar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBuscar.Location = new System.Drawing.Point(613, 231);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
=======
            this.btnBuscar.Location = new System.Drawing.Point(394, 215);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(261, 37);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
<<<<<<< HEAD
            this.btnBuscar.UseVisualStyleBackColor = false;
=======
            this.btnBuscar.UseVisualStyleBackColor = true;
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrarNuevaPersona);
            this.groupBox1.Controls.Add(this.btnBajaPersona);
            this.groupBox1.Controls.Add(this.btnEditarPersona);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGoldenrod;
<<<<<<< HEAD
            this.groupBox1.Location = new System.Drawing.Point(1175, 538);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(406, 196);
=======
            this.groupBox1.Location = new System.Drawing.Point(831, 315);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(246, 96);
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones sobre una Persona seleccionada";
            // 
            // btnBajaPersona
            // 
<<<<<<< HEAD
            this.btnBajaPersona.Location = new System.Drawing.Point(34, 77);
=======
            this.btnBajaPersona.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBajaPersona.Location = new System.Drawing.Point(26, 56);
            this.btnBajaPersona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.btnBajaPersona.Name = "btnBajaPersona";
            this.btnBajaPersona.Size = new System.Drawing.Size(203, 34);
            this.btnBajaPersona.TabIndex = 21;
            this.btnBajaPersona.Text = "Dar de Baja";
            this.btnBajaPersona.UseVisualStyleBackColor = true;
            this.btnBajaPersona.Click += new System.EventHandler(this.btnBajaPersona_Click);
            // 
            // btnEditarPersona
            // 
            this.btnEditarPersona.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEditarPersona.Location = new System.Drawing.Point(26, 16);
            this.btnEditarPersona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarPersona.Name = "btnEditarPersona";
            this.btnEditarPersona.Size = new System.Drawing.Size(203, 34);
            this.btnEditarPersona.TabIndex = 21;
            this.btnEditarPersona.Text = "Editar";
            this.btnEditarPersona.UseVisualStyleBackColor = true;
            this.btnEditarPersona.Click += new System.EventHandler(this.btnEditarPersona_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbPierna);
            this.groupBox2.Controls.Add(this.chbTipoDoc);
            this.groupBox2.Controls.Add(this.chbBaja);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmbPierna);
            this.groupBox2.Controls.Add(this.cmbTipoDni);
            this.groupBox2.Controls.Add(this.dtpFechaNacimientoHasta);
            this.groupBox2.Controls.Add(this.dtpFechaNacimientoDesde);
            this.groupBox2.Controls.Add(this.txtApellido);
            this.groupBox2.Controls.Add(this.txtPesoDesde);
            this.groupBox2.Controls.Add(this.txtPesoHasta);
            this.groupBox2.Controls.Add(this.txtEstaturaHasta);
            this.groupBox2.Controls.Add(this.txtEstaturaDesde);
            this.groupBox2.Controls.Add(this.txtNroDoc);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGoldenrod;
<<<<<<< HEAD
            this.groupBox2.Location = new System.Drawing.Point(13, 535);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1143, 295);
=======
            this.groupBox2.Location = new System.Drawing.Point(9, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(805, 261);
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Personas";
            // 
            // chbPierna
            // 
            this.chbPierna.AutoSize = true;
            this.chbPierna.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbPierna.Location = new System.Drawing.Point(528, 145);
            this.chbPierna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbPierna.Name = "chbPierna";
            this.chbPierna.Size = new System.Drawing.Size(176, 24);
            this.chbPierna.TabIndex = 23;
            this.chbPierna.Text = "Incluir en búsqueda?";
            this.chbPierna.UseVisualStyleBackColor = true;
            // 
            // chbTipoDoc
            // 
            this.chbTipoDoc.AutoSize = true;
            this.chbTipoDoc.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbTipoDoc.Location = new System.Drawing.Point(128, 143);
            this.chbTipoDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbTipoDoc.Name = "chbTipoDoc";
            this.chbTipoDoc.Size = new System.Drawing.Size(176, 24);
            this.chbTipoDoc.TabIndex = 23;
            this.chbTipoDoc.Text = "Incluir en búsqueda?";
            this.chbTipoDoc.UseVisualStyleBackColor = true;
            // 
            // chbBaja
            // 
            this.chbBaja.AutoSize = true;
            this.chbBaja.Location = new System.Drawing.Point(603, 188);
            this.chbBaja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbBaja.Name = "chbBaja";
            this.chbBaja.Size = new System.Drawing.Size(15, 14);
            this.chbBaja.TabIndex = 22;
            this.chbBaja.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
<<<<<<< HEAD
            this.btnLimpiar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnLimpiar.Location = new System.Drawing.Point(956, 231);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
=======
            this.btnLimpiar.Location = new System.Drawing.Point(659, 215);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(139, 37);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(467, 187);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Persona dada de baja?:";
            // 
            // btnSalir
            // 
<<<<<<< HEAD
            this.btnSalir.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSalir.Location = new System.Drawing.Point(1374, 766);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(196, 49);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
=======
            this.btnSalir.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSalir.Location = new System.Drawing.Point(857, 496);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(203, 34);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrarNuevaPersona
            // 
<<<<<<< HEAD
            this.btnRegistrarNuevaPersona.Location = new System.Drawing.Point(34, 135);
            this.btnRegistrarNuevaPersona.Name = "btnRegistrarNuevaPersona";
            this.btnRegistrarNuevaPersona.Size = new System.Drawing.Size(261, 46);
=======
            this.btnRegistrarNuevaPersona.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRegistrarNuevaPersona.Location = new System.Drawing.Point(857, 437);
            this.btnRegistrarNuevaPersona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrarNuevaPersona.Name = "btnRegistrarNuevaPersona";
            this.btnRegistrarNuevaPersona.Size = new System.Drawing.Size(203, 34);
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.btnRegistrarNuevaPersona.TabIndex = 24;
            this.btnRegistrarNuevaPersona.Text = "Registrar Nueva Persona";
            this.btnRegistrarNuevaPersona.UseVisualStyleBackColor = true;
            this.btnRegistrarNuevaPersona.Click += new System.EventHandler(this.btnRegistrarNuevaPersona_Click);
            // 
<<<<<<< HEAD
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Location = new System.Drawing.Point(1164, 766);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 49);
            this.button1.TabIndex = 24;
            this.button1.Text = "Registrar Nueva Persona";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPersonas);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(6, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1584, 484);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::EquiposFrontend.Properties.Resources.close;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(1576, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(26, 22);
            this.button6.TabIndex = 15;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1602, 30);
            this.panel1.TabIndex = 25;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(12, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(138, 17);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Listado de Personas";
            // 
=======
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            // FrmListarPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1602, 843);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
=======
            this.ClientSize = new System.Drawing.Size(1085, 549);
            this.Controls.Add(this.btnRegistrarNuevaPersona);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPersonas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
            this.Name = "FrmListarPersonas";
            this.Text = "Listado de Personas";
            this.Load += new System.EventHandler(this.FrmListarPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.ComboBox cmbPierna;
        private System.Windows.Forms.ComboBox cmbTipoDni;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimientoDesde;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtPesoDesde;
        private System.Windows.Forms.TextBox txtEstaturaDesde;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimientoHasta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEstaturaHasta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPesoHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBajaPersona;
        private System.Windows.Forms.Button btnEditarPersona;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
<<<<<<< HEAD

=======
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
        private System.Windows.Forms.Button btnRegistrarNuevaPersona;
        private System.Windows.Forms.CheckBox chbBaja;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chbPierna;
        private System.Windows.Forms.CheckBox chbTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn piernaHabil;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaBaja;
<<<<<<< HEAD

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;

=======
>>>>>>> 6f08aba79bf85f0285ee13a80876d6b374abde83
    }
}