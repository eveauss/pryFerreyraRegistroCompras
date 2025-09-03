namespace pryFerreyraRegistroCompras
{
    partial class frmLogin
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
            gbLogin = new GroupBox();
            lblContra = new Label();
            lblUsuario = new Label();
            lblLogin = new Label();
            btnIniciar = new Button();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // gbLogin
            // 
            gbLogin.BackColor = Color.White;
            gbLogin.Controls.Add(lblContra);
            gbLogin.Controls.Add(lblUsuario);
            gbLogin.Controls.Add(lblLogin);
            gbLogin.Controls.Add(btnIniciar);
            gbLogin.Controls.Add(txtContraseña);
            gbLogin.Controls.Add(txtUsuario);
            gbLogin.Location = new Point(28, 31);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(304, 391);
            gbLogin.TabIndex = 6;
            gbLogin.TabStop = false;
            // 
            // lblContra
            // 
            lblContra.AutoSize = true;
            lblContra.ForeColor = SystemColors.ControlText;
            lblContra.Location = new Point(60, 213);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(67, 15);
            lblContra.TabIndex = 17;
            lblContra.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.ForeColor = SystemColors.ControlText;
            lblUsuario.Location = new Point(60, 151);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(52, 15);
            lblUsuario.TabIndex = 16;
            lblUsuario.Text = "Ususario";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = SystemColors.ControlText;
            lblLogin.Location = new Point(26, 104);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(253, 21);
            lblLogin.TabIndex = 15;
            lblLogin.Text = "Ingrese su Usuario y Contraseña";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.SteelBlue;
            btnIniciar.ForeColor = SystemColors.ControlLightLight;
            btnIniciar.Location = new Point(147, 259);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(81, 28);
            btnIniciar.TabIndex = 14;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(128, 205);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 13;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(129, 143);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 12;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(359, 450);
            Controls.Add(gbLogin);
            Name = "frmLogin";
            Text = "frmLogin";
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbLogin;
        private Label lblContra;
        private Label lblUsuario;
        private Label lblLogin;
        private Button btnIniciar;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
    }
}