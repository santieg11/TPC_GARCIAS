namespace TPC_GARCIAS
{
    partial class frmContactos
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.grbDatosContacto = new System.Windows.Forms.GroupBox();
            this.txbIDCont = new System.Windows.Forms.TextBox();
            this.lblIDCont = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txbNomContacto = new System.Windows.Forms.TextBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNomContacto = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grbDatosContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVolver.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(364, 255);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 40);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(193, 255);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 40);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // grbDatosContacto
            // 
            this.grbDatosContacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDatosContacto.Controls.Add(this.txbIDCont);
            this.grbDatosContacto.Controls.Add(this.lblIDCont);
            this.grbDatosContacto.Controls.Add(this.txbEmail);
            this.grbDatosContacto.Controls.Add(this.txbDireccion);
            this.grbDatosContacto.Controls.Add(this.txbNomContacto);
            this.grbDatosContacto.Controls.Add(this.mtbTelefono);
            this.grbDatosContacto.Controls.Add(this.lblDireccion);
            this.grbDatosContacto.Controls.Add(this.lblEmail);
            this.grbDatosContacto.Controls.Add(this.lblTelefono);
            this.grbDatosContacto.Controls.Add(this.lblNomContacto);
            this.grbDatosContacto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosContacto.Location = new System.Drawing.Point(12, 12);
            this.grbDatosContacto.MinimumSize = new System.Drawing.Size(317, 146);
            this.grbDatosContacto.Name = "grbDatosContacto";
            this.grbDatosContacto.Size = new System.Drawing.Size(433, 215);
            this.grbDatosContacto.TabIndex = 4;
            this.grbDatosContacto.TabStop = false;
            this.grbDatosContacto.Text = "Datos de Contacto";
            // 
            // txbIDCont
            // 
            this.txbIDCont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbIDCont.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDCont.Location = new System.Drawing.Point(92, 36);
            this.txbIDCont.Name = "txbIDCont";
            this.txbIDCont.Size = new System.Drawing.Size(335, 23);
            this.txbIDCont.TabIndex = 12;
            // 
            // lblIDCont
            // 
            this.lblIDCont.AutoSize = true;
            this.lblIDCont.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCont.Location = new System.Drawing.Point(6, 39);
            this.lblIDCont.Name = "lblIDCont";
            this.lblIDCont.Size = new System.Drawing.Size(78, 18);
            this.lblIDCont.TabIndex = 11;
            this.lblIDCont.Text = "ID Contacto";
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbEmail.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(92, 117);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(335, 23);
            this.txbEmail.TabIndex = 10;
            this.txbEmail.Validated += new System.EventHandler(this.txbEmail_Validated);
            // 
            // txbDireccion
            // 
            this.txbDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDireccion.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDireccion.Location = new System.Drawing.Point(92, 143);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(335, 23);
            this.txbDireccion.TabIndex = 9;
            // 
            // txbNomContacto
            // 
            this.txbNomContacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNomContacto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomContacto.Location = new System.Drawing.Point(92, 65);
            this.txbNomContacto.Name = "txbNomContacto";
            this.txbNomContacto.Size = new System.Drawing.Size(335, 23);
            this.txbNomContacto.TabIndex = 7;
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefono.Location = new System.Drawing.Point(92, 91);
            this.mtbTelefono.Mask = "99999999999";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(86, 23);
            this.mtbTelefono.TabIndex = 7;
            this.mtbTelefono.ValidatingType = typeof(int);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(6, 146);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(66, 18);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 18);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(6, 94);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(60, 18);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblNomContacto
            // 
            this.lblNomContacto.AutoSize = true;
            this.lblNomContacto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomContacto.Location = new System.Drawing.Point(6, 68);
            this.lblNomContacto.Name = "lblNomContacto";
            this.lblNomContacto.Size = new System.Drawing.Size(56, 18);
            this.lblNomContacto.TabIndex = 5;
            this.lblNomContacto.Text = "Nombre";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAceptar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(21, 255);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 40);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar Cambios";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(457, 316);
            this.ControlBox = false;
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grbDatosContacto);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnVolver);
            this.MinimumSize = new System.Drawing.Size(357, 324);
            this.Name = "frmContactos";
            this.Text = "Datos Contacto";
            this.grbDatosContacto.ResumeLayout(false);
            this.grbDatosContacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox grbDatosContacto;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNomContacto;
        private System.Windows.Forms.TextBox txbNomContacto;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.TextBox txbIDCont;
        private System.Windows.Forms.Label lblIDCont;
        private System.Windows.Forms.Button btnAceptar;
    }
}