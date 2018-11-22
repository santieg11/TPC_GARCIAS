namespace TPC_GARCIAS
{
    partial class frmProductos
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
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.lblIDProd = new System.Windows.Forms.Label();
            this.mtbIDProd = new System.Windows.Forms.MaskedTextBox();
            this.mtbGanancia = new System.Windows.Forms.MaskedTextBox();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.lblporcentaje = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(146, 123);
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
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(19, 123);
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
            this.lblNombre.Location = new System.Drawing.Point(9, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(74, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Descripcion";
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txbDescripcion.Location = new System.Drawing.Point(91, 52);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(223, 20);
            this.txbDescripcion.TabIndex = 5;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAtras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(261, 123);
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
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(90, 123);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(91, 40);
            this.btnMod.TabIndex = 8;
            this.btnMod.Text = "Guardar Modificacion";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // lblIDProd
            // 
            this.lblIDProd.AutoSize = true;
            this.lblIDProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProd.Location = new System.Drawing.Point(8, 29);
            this.lblIDProd.Name = "lblIDProd";
            this.lblIDProd.Size = new System.Drawing.Size(75, 13);
            this.lblIDProd.TabIndex = 9;
            this.lblIDProd.Text = "ID Producto";
            // 
            // mtbIDProd
            // 
            this.mtbIDProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mtbIDProd.Location = new System.Drawing.Point(91, 26);
            this.mtbIDProd.Mask = "999999999999";
            this.mtbIDProd.Name = "mtbIDProd";
            this.mtbIDProd.Size = new System.Drawing.Size(79, 20);
            this.mtbIDProd.TabIndex = 11;
            this.mtbIDProd.ValidatingType = typeof(int);
            // 
            // mtbGanancia
            // 
            this.mtbGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mtbGanancia.Location = new System.Drawing.Point(286, 78);
            this.mtbGanancia.Mask = "999";
            this.mtbGanancia.Name = "mtbGanancia";
            this.mtbGanancia.Size = new System.Drawing.Size(28, 20);
            this.mtbGanancia.TabIndex = 13;
            this.mtbGanancia.ValidatingType = typeof(int);
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanancia.Location = new System.Drawing.Point(219, 81);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(61, 13);
            this.lblGanancia.TabIndex = 12;
            this.lblGanancia.Text = "Ganancia";
            // 
            // lblporcentaje
            // 
            this.lblporcentaje.AutoSize = true;
            this.lblporcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblporcentaje.Location = new System.Drawing.Point(320, 81);
            this.lblporcentaje.Name = "lblporcentaje";
            this.lblporcentaje.Size = new System.Drawing.Size(16, 13);
            this.lblporcentaje.TabIndex = 14;
            this.lblporcentaje.Text = "%";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(10, 81);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(73, 13);
            this.lblValor.TabIndex = 15;
            this.lblValor.Text = "Valor Venta";
            // 
            // txbValor
            // 
            this.txbValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txbValor.Location = new System.Drawing.Point(89, 78);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(81, 20);
            this.txbValor.TabIndex = 16;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(356, 198);
            this.ControlBox = false;
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblporcentaje);
            this.Controls.Add(this.mtbGanancia);
            this.Controls.Add(this.lblGanancia);
            this.Controls.Add(this.mtbIDProd);
            this.Controls.Add(this.lblIDProd);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.MinimumSize = new System.Drawing.Size(350, 188);
            this.Name = "frmProductos";
            this.Text = "Alta Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label lblIDProd;
        private System.Windows.Forms.MaskedTextBox mtbIDProd;
        private System.Windows.Forms.MaskedTextBox mtbGanancia;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.Label lblporcentaje;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txbValor;
    }
}