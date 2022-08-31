namespace Win_Banco
{
    partial class frmCuentas
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gpCliente = new System.Windows.Forms.GroupBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.gpCuentas = new System.Windows.Forms.GroupBox();
            this.cmbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblCbu = new System.Windows.Forms.Label();
            this.txtCbu = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblcmbcliente = new System.Windows.Forms.Label();
            this.lblDetallesCuentas = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnNuevaCuenta = new System.Windows.Forms.Button();
            this.btnEditarCuenta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gpCliente.SuspendLayout();
            this.gpCuentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(67, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // gpCliente
            // 
            this.gpCliente.Controls.Add(this.lblDni);
            this.gpCliente.Controls.Add(this.txtDni);
            this.gpCliente.Controls.Add(this.lblApellido);
            this.gpCliente.Controls.Add(this.txtApellido);
            this.gpCliente.Controls.Add(this.lblNombre);
            this.gpCliente.Controls.Add(this.txtNombre);
            this.gpCliente.Location = new System.Drawing.Point(12, 12);
            this.gpCliente.Name = "gpCliente";
            this.gpCliente.Size = new System.Drawing.Size(265, 116);
            this.gpCliente.TabIndex = 2;
            this.gpCliente.TabStop = false;
            this.gpCliente.Text = "Clientes";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(6, 80);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(67, 77);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 54);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(67, 51);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(183, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // gpCuentas
            // 
            this.gpCuentas.Controls.Add(this.cmbCliente);
            this.gpCuentas.Controls.Add(this.lblcmbcliente);
            this.gpCuentas.Controls.Add(this.cmbTipoCuenta);
            this.gpCuentas.Controls.Add(this.lblTipoCuenta);
            this.gpCuentas.Controls.Add(this.lblSaldo);
            this.gpCuentas.Controls.Add(this.txtSaldo);
            this.gpCuentas.Controls.Add(this.lblCbu);
            this.gpCuentas.Controls.Add(this.txtCbu);
            this.gpCuentas.Location = new System.Drawing.Point(283, 12);
            this.gpCuentas.Name = "gpCuentas";
            this.gpCuentas.Size = new System.Drawing.Size(348, 142);
            this.gpCuentas.TabIndex = 6;
            this.gpCuentas.TabStop = false;
            this.gpCuentas.Text = "Cuentas";
            // 
            // cmbTipoCuenta
            // 
            this.cmbTipoCuenta.FormattingEnabled = true;
            this.cmbTipoCuenta.Location = new System.Drawing.Point(77, 77);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Size = new System.Drawing.Size(265, 21);
            this.cmbTipoCuenta.TabIndex = 7;
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(6, 80);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(68, 13);
            this.lblTipoCuenta.TabIndex = 4;
            this.lblTipoCuenta.Text = "Tipo Cuenta:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(6, 54);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(67, 51);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(137, 20);
            this.txtSaldo.TabIndex = 3;
            // 
            // lblCbu
            // 
            this.lblCbu.AutoSize = true;
            this.lblCbu.Location = new System.Drawing.Point(6, 28);
            this.lblCbu.Name = "lblCbu";
            this.lblCbu.Size = new System.Drawing.Size(32, 13);
            this.lblCbu.TabIndex = 0;
            this.lblCbu.Text = "CBU:";
            // 
            // txtCbu
            // 
            this.txtCbu.Location = new System.Drawing.Point(67, 25);
            this.txtCbu.Name = "txtCbu";
            this.txtCbu.Size = new System.Drawing.Size(275, 20);
            this.txtCbu.TabIndex = 1;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(77, 104);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(265, 21);
            this.cmbCliente.TabIndex = 9;
            // 
            // lblcmbcliente
            // 
            this.lblcmbcliente.AutoSize = true;
            this.lblcmbcliente.Location = new System.Drawing.Point(6, 107);
            this.lblcmbcliente.Name = "lblcmbcliente";
            this.lblcmbcliente.Size = new System.Drawing.Size(42, 13);
            this.lblcmbcliente.TabIndex = 8;
            this.lblcmbcliente.Text = "Cliente:";
            // 
            // lblDetallesCuentas
            // 
            this.lblDetallesCuentas.AutoSize = true;
            this.lblDetallesCuentas.Location = new System.Drawing.Point(18, 141);
            this.lblDetallesCuentas.Name = "lblDetallesCuentas";
            this.lblDetallesCuentas.Size = new System.Drawing.Size(109, 13);
            this.lblDetallesCuentas.TabIndex = 6;
            this.lblDetallesCuentas.Text = "DETALLE CUENTAS";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(12, 167);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.Size = new System.Drawing.Size(619, 164);
            this.dgvDetalles.TabIndex = 7;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(648, 17);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(140, 23);
            this.btnNuevoCliente.TabIndex = 8;
            this.btnNuevoCliente.Text = "NUEVO CLIENTE";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // btnNuevaCuenta
            // 
            this.btnNuevaCuenta.Location = new System.Drawing.Point(648, 89);
            this.btnNuevaCuenta.Name = "btnNuevaCuenta";
            this.btnNuevaCuenta.Size = new System.Drawing.Size(140, 23);
            this.btnNuevaCuenta.TabIndex = 9;
            this.btnNuevaCuenta.Text = "NUEVO CUENTA";
            this.btnNuevaCuenta.UseVisualStyleBackColor = true;
            // 
            // btnEditarCuenta
            // 
            this.btnEditarCuenta.Location = new System.Drawing.Point(648, 119);
            this.btnEditarCuenta.Name = "btnEditarCuenta";
            this.btnEditarCuenta.Size = new System.Drawing.Size(140, 23);
            this.btnEditarCuenta.TabIndex = 10;
            this.btnEditarCuenta.Text = "EDITAR CUENTA";
            this.btnEditarCuenta.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(648, 167);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(648, 308);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditarCuenta);
            this.Controls.Add(this.btnNuevaCuenta);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.lblDetallesCuentas);
            this.Controls.Add(this.gpCuentas);
            this.Controls.Add(this.gpCliente);
            this.Name = "frmCuentas";
            this.Text = "CUENTAS";
            this.gpCliente.ResumeLayout(false);
            this.gpCliente.PerformLayout();
            this.gpCuentas.ResumeLayout(false);
            this.gpCuentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gpCliente;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox gpCuentas;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblCbu;
        private System.Windows.Forms.TextBox txtCbu;
        private System.Windows.Forms.ComboBox cmbTipoCuenta;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblcmbcliente;
        private System.Windows.Forms.Label lblDetallesCuentas;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnNuevaCuenta;
        private System.Windows.Forms.Button btnEditarCuenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
    }
}

