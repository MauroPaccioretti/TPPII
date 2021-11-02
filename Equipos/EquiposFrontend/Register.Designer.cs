
namespace EquiposFrontend
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.lblErrorPass = new System.Windows.Forms.Label();
            this.lblErrorUsername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblErrorPass
            // 
            this.lblErrorPass.AutoSize = true;
            this.lblErrorPass.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorPass.Location = new System.Drawing.Point(313, 357);
            this.lblErrorPass.Name = "lblErrorPass";
            this.lblErrorPass.Size = new System.Drawing.Size(101, 16);
            this.lblErrorPass.TabIndex = 24;
            this.lblErrorPass.Text = "*Error Message";
            this.lblErrorPass.Visible = false;
            // 
            // lblErrorUsername
            // 
            this.lblErrorUsername.AutoSize = true;
            this.lblErrorUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorUsername.Location = new System.Drawing.Point(313, 264);
            this.lblErrorUsername.Name = "lblErrorUsername";
            this.lblErrorUsername.Size = new System.Drawing.Size(101, 16);
            this.lblErrorUsername.TabIndex = 23;
            this.lblErrorUsername.Text = "*Error Message";
            this.lblErrorUsername.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnExitLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 28);
            this.panel1.TabIndex = 21;
            // 
            // btnExitLogin
            // 
            this.btnExitLogin.BackgroundImage = global::EquiposFrontend.Properties.Resources.close;
            this.btnExitLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExitLogin.FlatAppearance.BorderSize = 0;
            this.btnExitLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitLogin.Location = new System.Drawing.Point(1235, 3);
            this.btnExitLogin.Name = "btnExitLogin";
            this.btnExitLogin.Size = new System.Drawing.Size(26, 22);
            this.btnExitLogin.TabIndex = 0;
            this.btnExitLogin.UseVisualStyleBackColor = true;
            this.btnExitLogin.Click += new System.EventHandler(this.btnExitLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(197, 551);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(196, 48);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "SIGN UP";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_ClickAsync);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2.ForeColor = System.Drawing.Color.DimGray;
            this.lbl2.Location = new System.Drawing.Point(132, 357);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(153, 17);
            this.lbl2.TabIndex = 18;
            this.lbl2.Text = "Please enter Password";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.ForeColor = System.Drawing.Color.DimGray;
            this.lbl1.Location = new System.Drawing.Point(132, 264);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(157, 17);
            this.lbl1.TabIndex = 17;
            this.lbl1.Text = "Please enter Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(196, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sign up to continue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(132, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "Create Account";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.Location = new System.Drawing.Point(132, 293);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(331, 38);
            this.textBoxUsername.TabIndex = 25;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPass.Location = new System.Drawing.Point(132, 387);
            this.textBoxPass.Multiline = true;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(331, 38);
            this.textBoxPass.TabIndex = 26;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.Location = new System.Drawing.Point(132, 480);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(331, 38);
            this.textBoxEmail.TabIndex = 29;
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorEmail.Location = new System.Drawing.Point(313, 450);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(101, 16);
            this.lblErrorEmail.TabIndex = 28;
            this.lblErrorEmail.Text = "*Error Message";
            this.lblErrorEmail.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(132, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Please enter Email";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.lblErrorPass);
            this.Controls.Add(this.lblErrorUsername);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorPass;
        private System.Windows.Forms.Label lblErrorUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExitLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label label4;
    }
}