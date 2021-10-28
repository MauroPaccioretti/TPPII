
namespace EquiposFrontend
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitLogin = new System.Windows.Forms.Button();
            this.linklblOlvidoContra = new System.Windows.Forms.LinkLabel();
            this.checkBoxRemember = new System.Windows.Forms.CheckBox();
            this.lblRemember = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(804, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome back!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(868, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sign in to continue";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.ForeColor = System.Drawing.Color.DimGray;
            this.lbl1.Location = new System.Drawing.Point(804, 294);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(165, 19);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Please enter Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.Location = new System.Drawing.Point(804, 321);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(331, 38);
            this.textBoxUsername.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(804, 432);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(331, 38);
            this.textBoxPassword.TabIndex = 6;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2.ForeColor = System.Drawing.Color.DimGray;
            this.lbl2.Location = new System.Drawing.Point(804, 405);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(160, 19);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Please enter Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(868, 529);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(196, 48);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnExitLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 28);
            this.panel1.TabIndex = 8;
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
            this.btnExitLogin.Click += new System.EventHandler(this.btnExitLogin_Click);
            // 
            // linklblOlvidoContra
            // 
            this.linklblOlvidoContra.ActiveLinkColor = System.Drawing.Color.Black;
            this.linklblOlvidoContra.AutoSize = true;
            this.linklblOlvidoContra.BackColor = System.Drawing.Color.Transparent;
            this.linklblOlvidoContra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linklblOlvidoContra.ForeColor = System.Drawing.Color.DimGray;
            this.linklblOlvidoContra.LinkColor = System.Drawing.Color.DimGray;
            this.linklblOlvidoContra.Location = new System.Drawing.Point(985, 483);
            this.linklblOlvidoContra.Name = "linklblOlvidoContra";
            this.linklblOlvidoContra.Size = new System.Drawing.Size(150, 17);
            this.linklblOlvidoContra.TabIndex = 9;
            this.linklblOlvidoContra.TabStop = true;
            this.linklblOlvidoContra.Text = "Forgot your pasword?";
            // 
            // checkBoxRemember
            // 
            this.checkBoxRemember.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRemember.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.checkBoxRemember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRemember.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxRemember.Location = new System.Drawing.Point(804, 486);
            this.checkBoxRemember.Name = "checkBoxRemember";
            this.checkBoxRemember.Size = new System.Drawing.Size(12, 11);
            this.checkBoxRemember.TabIndex = 10;
            this.checkBoxRemember.UseVisualStyleBackColor = false;
            // 
            // lblRemember
            // 
            this.lblRemember.AutoSize = true;
            this.lblRemember.BackColor = System.Drawing.Color.Transparent;
            this.lblRemember.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRemember.ForeColor = System.Drawing.Color.DimGray;
            this.lblRemember.Location = new System.Drawing.Point(822, 483);
            this.lblRemember.Name = "lblRemember";
            this.lblRemember.Size = new System.Drawing.Size(104, 17);
            this.lblRemember.TabIndex = 11;
            this.lblRemember.Text = "Remember me";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EquiposFrontend.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.lblRemember);
            this.Controls.Add(this.checkBoxRemember);
            this.Controls.Add(this.linklblOlvidoContra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExitLogin;
        private System.Windows.Forms.LinkLabel linklblOlvidoContra;
        private System.Windows.Forms.CheckBox checkBoxRemember;
        private System.Windows.Forms.Label lblRemember;
    }
}