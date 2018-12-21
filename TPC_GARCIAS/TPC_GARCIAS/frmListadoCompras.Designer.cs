namespace TPC_GARCIAS
{
    partial class frmListadoCompras
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
            this.dgvListadoCompras = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoCompras
            // 
            this.dgvListadoCompras.AllowUserToAddRows = false;
            this.dgvListadoCompras.AllowUserToDeleteRows = false;
            this.dgvListadoCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoCompras.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvListadoCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoCompras.Location = new System.Drawing.Point(12, 39);
            this.dgvListadoCompras.Name = "dgvListadoCompras";
            this.dgvListadoCompras.ReadOnly = true;
            this.dgvListadoCompras.Size = new System.Drawing.Size(645, 183);
            this.dgvListadoCompras.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(582, 228);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(108, 10);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(150, 20);
            this.txbBuscar.TabIndex = 3;
            this.txbBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar nro remito";
            // 
            // frmListadoCompras
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(669, 263);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvListadoCompras);
            this.MinimumSize = new System.Drawing.Size(685, 302);
            this.Name = "frmListadoCompras";
            this.Text = "Listado Compras";
            this.Load += new System.EventHandler(this.frmListadoCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoCompras;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.Label label1;
    }
}