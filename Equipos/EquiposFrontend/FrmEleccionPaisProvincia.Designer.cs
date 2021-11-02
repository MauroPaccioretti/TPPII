
namespace EquiposFrontend
{
    partial class FrmEleccionPaisProvincia
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPaises = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxProvincias = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(243, 141);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 33);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(137, 141);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 33);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elija a que país corresponde la localidad nueva:";
            // 
            // cbxPaises
            // 
            this.cbxPaises.FormattingEnabled = true;
            this.cbxPaises.Location = new System.Drawing.Point(27, 34);
            this.cbxPaises.Name = "cbxPaises";
            this.cbxPaises.Size = new System.Drawing.Size(255, 23);
            this.cbxPaises.TabIndex = 3;
            this.cbxPaises.SelectedIndexChanged += new System.EventHandler(this.cbxPaises_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Elija a que provincia corresponde la localidad nueva:";
            // 
            // cbxProvincias
            // 
            this.cbxProvincias.Enabled = false;
            this.cbxProvincias.FormattingEnabled = true;
            this.cbxProvincias.Location = new System.Drawing.Point(27, 90);
            this.cbxProvincias.Name = "cbxProvincias";
            this.cbxProvincias.Size = new System.Drawing.Size(255, 23);
            this.cbxProvincias.TabIndex = 5;
            // 
            // FrmEleccionPaisProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 186);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxProvincias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPaises);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.MaximumSize = new System.Drawing.Size(371, 225);
            this.MinimumSize = new System.Drawing.Size(371, 225);
            this.Name = "FrmEleccionPaisProvincia";
            this.Text = "FrmEleccionPaisProvincia";
            this.Load += new System.EventHandler(this.FrmEleccionPaisProvincia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPaises;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxProvincias;
    }
}