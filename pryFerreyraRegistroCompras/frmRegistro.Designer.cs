namespace pryFerreyraRegistroCompras
{
    partial class frmRegistro
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
            gbAgregar = new GroupBox();
            lstProducto = new ComboBox();
            lblProducto = new Label();
            btnCancelar = new Button();
            txtPrecio = new MaskedTextBox();
            numCantidad = new NumericUpDown();
            lblCantidad = new Label();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            lblPrecio = new Label();
            btnAgregar = new Button();
            lblResultado = new Label();
            gbAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // gbAgregar
            // 
            gbAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbAgregar.BackColor = Color.White;
            gbAgregar.Controls.Add(lstProducto);
            gbAgregar.Controls.Add(lblProducto);
            gbAgregar.Controls.Add(btnCancelar);
            gbAgregar.Controls.Add(txtPrecio);
            gbAgregar.Controls.Add(numCantidad);
            gbAgregar.Controls.Add(lblCantidad);
            gbAgregar.Controls.Add(dtpFecha);
            gbAgregar.Controls.Add(lblFecha);
            gbAgregar.Controls.Add(lblPrecio);
            gbAgregar.Controls.Add(btnAgregar);
            gbAgregar.Location = new Point(12, 29);
            gbAgregar.Name = "gbAgregar";
            gbAgregar.Size = new Size(505, 216);
            gbAgregar.TabIndex = 9;
            gbAgregar.TabStop = false;
            gbAgregar.Text = "Registrar Producto";
            gbAgregar.Enter += gbAgregar_Enter;
            // 
            // lstProducto
            // 
            lstProducto.FormattingEnabled = true;
            lstProducto.Location = new Point(98, 45);
            lstProducto.Name = "lstProducto";
            lstProducto.Size = new Size(144, 23);
            lstProducto.TabIndex = 48;
            lstProducto.TextChanged += lstprod_text;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(39, 49);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 47;
            lblProducto.Text = "Producto";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.SteelBlue;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(286, 149);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(71, 24);
            btnCancelar.TabIndex = 44;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(332, 95);
            txtPrecio.Mask = "99999";
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(102, 23);
            txtPrecio.TabIndex = 43;
            txtPrecio.ValidatingType = typeof(int);
            // 
            // numCantidad
            // 
            numCantidad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            numCantidad.Location = new Point(98, 93);
            numCantidad.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(107, 23);
            numCantidad.TabIndex = 42;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(35, 96);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 41;
            lblCantidad.Text = "Cantidad";
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(332, 45);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(102, 23);
            dtpFecha.TabIndex = 40;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(275, 50);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 39;
            lblFecha.Text = "Fecha";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(273, 100);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(54, 15);
            lblPrecio.TabIndex = 38;
            lblPrecio.Text = "Precio U.";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SteelBlue;
            btnAgregar.Enabled = false;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(363, 149);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(71, 24);
            btnAgregar.TabIndex = 37;
            btnAgregar.Text = "Registrar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += Agregar_Click;
            // 
            // lblResultado
            // 
            lblResultado.BackColor = Color.White;
            lblResultado.Location = new Point(12, 248);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(505, 44);
            lblResultado.TabIndex = 49;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(529, 319);
            Controls.Add(lblResultado);
            Controls.Add(gbAgregar);
            Name = "frmRegistro";
            Text = "Registro";
            gbAgregar.ResumeLayout(false);
            gbAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbAgregar;
        private Button btnCancelar;
        private NumericUpDown numCantidad;
        private Label lblCantidad;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private Label lblPrecio;
        private Button btnAgregar;
        private ComboBox lstProducto;
        private Label lblProducto;
        private MaskedTextBox txtPrecio;
        private Label lblResultado;
    }
}