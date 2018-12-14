namespace TPC_GARCIAS
{
    partial class frmListadoStock
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
            this.dgvListadoVentas = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoVentas
            // 
            this.dgvListadoVentas.AllowUserToAddRows = false;
            this.dgvListadoVentas.AllowUserToDeleteRows = false;
            this.dgvListadoVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoVentas.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvListadoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoVentas.Location = new System.Drawing.Point(12, 12);
            this.dgvListadoVentas.Name = "dgvListadoVentas";
            this.dgvListadoVentas.ReadOnly = true;
            this.dgvListadoVentas.Size = new System.Drawing.Size(402, 158);
            this.dgvListadoVentas.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(339, 176);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmListadoStock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(426, 211);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvListadoVentas);
            this.MinimumSize = new System.Drawing.Size(442, 250);
            this.Name = "frmListadoStock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.frmListadoStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoVentas;
        private System.Windows.Forms.Button btnSalir;
    }
}