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
            this.btnDetalle = new System.Windows.Forms.Button();
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
            this.dgvListadoCompras.Location = new System.Drawing.Point(12, 12);
            this.dgvListadoCompras.Name = "dgvListadoCompras";
            this.dgvListadoCompras.ReadOnly = true;
            this.dgvListadoCompras.Size = new System.Drawing.Size(645, 210);
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
            // btnDetalle
            // 
            this.btnDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalle.Location = new System.Drawing.Point(501, 228);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnDetalle.TabIndex = 2;
            this.btnDetalle.Text = "Ver detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            // 
            // frmListadoCompras
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(669, 263);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvListadoCompras);
            this.MinimumSize = new System.Drawing.Size(685, 302);
            this.Name = "frmListadoCompras";
            this.Text = "Listado Compras";
            this.Load += new System.EventHandler(this.frmListadoCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoCompras;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDetalle;
    }
}