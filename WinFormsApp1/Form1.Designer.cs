namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cboProducto = new ComboBox();
            txtCantidad = new TextBox();
            btnCalcular = new Button();
            tittle = new Label();
            lblProductoEtiqueta = new Label();
            lblCantidadEtiqueta = new Label();
            rbEfectivo = new RadioButton();
            rbTarjeta = new RadioButton();
            lblFormaPago = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // cboProducto
            // 
            cboProducto.BackColor = Color.Ivory;
            cboProducto.Cursor = Cursors.Cross;
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(140, 124);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(174, 28);
            cboProducto.TabIndex = 0;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(140, 191);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(174, 27);
            txtCantidad.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Brown;
            btnCalcular.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(254, 322);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(262, 38);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // tittle
            // 
            tittle.AutoSize = true;
            tittle.BackColor = SystemColors.ControlText;
            tittle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tittle.ForeColor = Color.White;
            tittle.Location = new Point(236, 33);
            tittle.Name = "tittle";
            tittle.Size = new Size(256, 28);
            tittle.TabIndex = 7;
            tittle.Text = "COLMADO MODO BRAZIL";
            // 
            // lblProductoEtiqueta
            // 
            lblProductoEtiqueta.AutoSize = true;
            lblProductoEtiqueta.BackColor = Color.Orange;
            lblProductoEtiqueta.Location = new Point(55, 127);
            lblProductoEtiqueta.Name = "lblProductoEtiqueta";
            lblProductoEtiqueta.Size = new Size(72, 20);
            lblProductoEtiqueta.TabIndex = 8;
            lblProductoEtiqueta.Text = "Producto:";
            // 
            // lblCantidadEtiqueta
            // 
            lblCantidadEtiqueta.AutoSize = true;
            lblCantidadEtiqueta.BackColor = Color.Green;
            lblCantidadEtiqueta.Location = new Point(55, 194);
            lblCantidadEtiqueta.Name = "lblCantidadEtiqueta";
            lblCantidadEtiqueta.Size = new Size(72, 20);
            lblCantidadEtiqueta.TabIndex = 9;
            lblCantidadEtiqueta.Text = "Cantidad:";
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Checked = true;
            rbEfectivo.Location = new Point(71, 305);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(83, 24);
            rbEfectivo.TabIndex = 10;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(71, 350);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(74, 24);
            rbTarjeta.TabIndex = 11;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.BackColor = Color.CornflowerBlue;
            lblFormaPago.Location = new Point(55, 262);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(114, 20);
            lblFormaPago.TabIndex = 12;
            lblFormaPago.Text = "Forma de pago:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotal.Location = new Point(311, 392);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(140, 25);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total: RD$0.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(726, 533);
            Controls.Add(lblTotal);
            Controls.Add(lblFormaPago);
            Controls.Add(rbTarjeta);
            Controls.Add(rbEfectivo);
            Controls.Add(lblCantidadEtiqueta);
            Controls.Add(lblProductoEtiqueta);
            Controls.Add(tittle);
            Controls.Add(btnCalcular);
            Controls.Add(txtCantidad);
            Controls.Add(cboProducto);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú del Colmado";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboProducto;
        private TextBox txtCantidad;
        private Button btnCalcular;
        private Label tittle;
        private Label lblProductoEtiqueta;
        private Label lblCantidadEtiqueta;
        private RadioButton rbEfectivo;
        private RadioButton rbTarjeta;
        private Label lblFormaPago;
        private Label lblTotal;
    }
}