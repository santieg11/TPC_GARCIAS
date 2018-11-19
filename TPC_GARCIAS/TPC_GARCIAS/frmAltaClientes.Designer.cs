namespace TPC_GARCIAS
{
    partial class frmAltaClientes
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.grbDatosContacto = new System.Windows.Forms.GroupBox();
            this.txbIDContacto = new System.Windows.Forms.TextBox();
            this.lblIDContacto = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txbNomContacto = new System.Windows.Forms.TextBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNomContacto = new System.Windows.Forms.Label();
            this.txbNomProv = new System.Windows.Forms.TextBox();
            this.mtbCUIT = new System.Windows.Forms.MaskedTextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.txbIDProv = new System.Windows.Forms.TextBox();
            this.lblIDProv = new System.Windows.Forms.Label();
            this.grbDatosContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancelar.Location = new System.Drawing.Point(138, 319);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 40);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAceptar.Location = new System.Drawing.Point(11, 319);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 40);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(18, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIT.Location = new System.Drawing.Point(18, 85);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(36, 13);
            this.lblCUIT.TabIndex = 3;
            this.lblCUIT.Text = "CUIT";
            // 
            // grbDatosContacto
            // 
            this.grbDatosContacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDatosContacto.Controls.Add(this.txbIDContacto);
            this.grbDatosContacto.Controls.Add(this.lblIDContacto);
            this.grbDatosContacto.Controls.Add(this.txbEmail);
            this.grbDatosContacto.Controls.Add(this.txbDireccion);
            this.grbDatosContacto.Controls.Add(this.txbNomContacto);
            this.grbDatosContacto.Controls.Add(this.mtbTelefono);
            this.grbDatosContacto.Controls.Add(this.lblDireccion);
            this.grbDatosContacto.Controls.Add(this.lblEmail);
            this.grbDatosContacto.Controls.Add(this.lblTelefono);
            this.grbDatosContacto.Controls.Add(this.lblNomContacto);
            this.grbDatosContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosContacto.Location = new System.Drawing.Point(12, 122);
            this.grbDatosContacto.MinimumSize = new System.Drawing.Size(317, 146);
            this.grbDatosContacto.Name = "grbDatosContacto";
            this.grbDatosContacto.Size = new System.Drawing.Size(317, 177);
            this.grbDatosContacto.TabIndex = 4;
            this.grbDatosContacto.TabStop = false;
            this.grbDatosContacto.Text = "Datos de Contacto";
            // 
            // txbIDContacto
            // 
            this.txbIDContacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbIDContacto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDContacto.Location = new System.Drawing.Point(92, 30);
            this.txbIDContacto.Name = "txbIDContacto";
            this.txbIDContacto.Size = new System.Drawing.Size(86, 23);
            this.txbIDContacto.TabIndex = 12;
            // 
            // lblIDContacto
            // 
            this.lblIDContacto.AutoSize = true;
            this.lblIDContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDContacto.Location = new System.Drawing.Point(6, 33);
            this.lblIDContacto.Name = "lblIDContacto";
            this.lblIDContacto.Size = new System.Drawing.Size(75, 13);
            this.lblIDContacto.TabIndex = 11;
            this.lblIDContacto.Text = "ID Contacto";
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbEmail.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(92, 143);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(219, 23);
            this.txbEmail.TabIndex = 10;
            this.txbEmail.Validated += new System.EventHandler(this.txbEmail_Validated);
            // 
            // txbDireccion
            // 
            this.txbDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDireccion.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDireccion.Location = new System.Drawing.Point(92, 114);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(219, 23);
            this.txbDireccion.TabIndex = 9;
            // 
            // txbNomContacto
            // 
            this.txbNomContacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNomContacto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomContacto.Location = new System.Drawing.Point(92, 59);
            this.txbNomContacto.Name = "txbNomContacto";
            this.txbNomContacto.Size = new System.Drawing.Size(219, 23);
            this.txbNomContacto.TabIndex = 7;
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefono.Location = new System.Drawing.Point(92, 85);
            this.mtbTelefono.Mask = "99999999999";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(86, 23);
            this.mtbTelefono.TabIndex = 7;
            this.mtbTelefono.ValidatingType = typeof(int);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(6, 117);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(61, 13);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 146);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(6, 88);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(57, 13);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblNomContacto
            // 
            this.lblNomContacto.AutoSize = true;
            this.lblNomContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomContacto.Location = new System.Drawing.Point(6, 62);
            this.lblNomContacto.Name = "lblNomContacto";
            this.lblNomContacto.Size = new System.Drawing.Size(50, 13);
            this.lblNomContacto.TabIndex = 5;
            this.lblNomContacto.Text = "Nombre";
            // 
            // txbNomProv
            // 
            this.txbNomProv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNomProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txbNomProv.Location = new System.Drawing.Point(105, 56);
            this.txbNomProv.Name = "txbNomProv";
            this.txbNomProv.Size = new System.Drawing.Size(224, 20);
            this.txbNomProv.TabIndex = 5;
            // 
            // mtbCUIT
            // 
            this.mtbCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mtbCUIT.Location = new System.Drawing.Point(105, 82);
            this.mtbCUIT.Mask = "00-00000000-0";
            this.mtbCUIT.Name = "mtbCUIT";
            this.mtbCUIT.Size = new System.Drawing.Size(98, 20);
            this.mtbCUIT.TabIndex = 6;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAtras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAtras.Location = new System.Drawing.Point(253, 319);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 40);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnMod
            // 
            this.btnMod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnMod.Location = new System.Drawing.Point(82, 319);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(91, 40);
            this.btnMod.TabIndex = 8;
            this.btnMod.Text = "Guardar Modificacion";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // txbIDProv
            // 
            this.txbIDProv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbIDProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txbIDProv.Location = new System.Drawing.Point(104, 27);
            this.txbIDProv.Name = "txbIDProv";
            this.txbIDProv.Size = new System.Drawing.Size(86, 20);
            this.txbIDProv.TabIndex = 10;
            // 
            // lblIDProv
            // 
            this.lblIDProv.AutoSize = true;
            this.lblIDProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProv.Location = new System.Drawing.Point(17, 30);
            this.lblIDProv.Name = "lblIDProv";
            this.lblIDProv.Size = new System.Drawing.Size(50, 13);
            this.lblIDProv.TabIndex = 9;
            this.lblIDProv.Text = "ID Prov";
            // 
            // frmAltaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(341, 371);
            this.ControlBox = false;
            this.Controls.Add(this.txbIDProv);
            this.Controls.Add(this.lblIDProv);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.mtbCUIT);
            this.Controls.Add(this.txbNomProv);
            this.Controls.Add(this.grbDatosContacto);
            this.Controls.Add(this.lblCUIT);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.MinimumSize = new System.Drawing.Size(357, 324);
            this.Name = "frmAltaClientes";
            this.Text = "Alta Proveedor";
            this.grbDatosContacto.ResumeLayout(false);
            this.grbDatosContacto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.GroupBox grbDatosContacto;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNomContacto;
        private System.Windows.Forms.TextBox txbNomProv;
        private System.Windows.Forms.MaskedTextBox mtbCUIT;
        private System.Windows.Forms.TextBox txbNomContacto;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.TextBox txbIDContacto;
        private System.Windows.Forms.Label lblIDContacto;
        private System.Windows.Forms.TextBox txbIDProv;
        private System.Windows.Forms.Label lblIDProv;
    }
}