﻿
namespace EquiposFrontend
{
    partial class RecoverPassword
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
            this.btnSendEmailRecover = new System.Windows.Forms.Button();
            this.textBoxUserRequest = new System.Windows.Forms.TextBox();
            this.btnExitLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendEmailRecover
            // 
            this.btnSendEmailRecover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnSendEmailRecover.FlatAppearance.BorderSize = 0;
            this.btnSendEmailRecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEmailRecover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSendEmailRecover.ForeColor = System.Drawing.Color.White;
            this.btnSendEmailRecover.Location = new System.Drawing.Point(513, 71);
            this.btnSendEmailRecover.Name = "btnSendEmailRecover";
            this.btnSendEmailRecover.Size = new System.Drawing.Size(155, 38);
            this.btnSendEmailRecover.TabIndex = 8;
            this.btnSendEmailRecover.Text = "SEND";
            this.btnSendEmailRecover.UseVisualStyleBackColor = false;
            this.btnSendEmailRecover.Click += new System.EventHandler(this.btnSendEmailRecover_Click);
            // 
            // textBoxUserRequest
            // 
            this.textBoxUserRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUserRequest.BackColor = System.Drawing.Color.White;
            this.textBoxUserRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserRequest.Location = new System.Drawing.Point(12, 71);
            this.textBoxUserRequest.Multiline = true;
            this.textBoxUserRequest.Name = "textBoxUserRequest";
            this.textBoxUserRequest.Size = new System.Drawing.Size(495, 38);
            this.textBoxUserRequest.TabIndex = 11;
            // 
            // btnExitLogin
            // 
            this.btnExitLogin.BackgroundImage = global::EquiposFrontend.Properties.Resources.close;
            this.btnExitLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExitLogin.FlatAppearance.BorderSize = 0;
            this.btnExitLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitLogin.Location = new System.Drawing.Point(1235, 2);
            this.btnExitLogin.Name = "btnExitLogin";
            this.btnExitLogin.Size = new System.Drawing.Size(26, 22);
            this.btnExitLogin.TabIndex = 0;
            this.btnExitLogin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnExitLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 28);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::EquiposFrontend.Properties.Resources.close;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(651, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 22);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "To recover your password enter your email:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(12, 122);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 20);
            this.lblResultado.TabIndex = 14;
            this.lblResultado.Text = "Resultado";
            // 
            // RecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(680, 222);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxUserRequest);
            this.Controls.Add(this.btnSendEmailRecover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecoverPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecoverPassword";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSendEmailRecover;
        private System.Windows.Forms.TextBox textBoxUserRequest;
        private System.Windows.Forms.Button btnExitLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
    }
}