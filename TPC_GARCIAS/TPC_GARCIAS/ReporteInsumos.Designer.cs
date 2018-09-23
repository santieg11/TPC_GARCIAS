namespace TPC_GARCIAS
{
    partial class frmReporteInsumos
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
            this.btnSalir = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvListadoInsumos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(738, 400);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = false;
            this.btnSalir.Size = new System.Drawing.Size(49, 36);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvListadoInsumos
            // 
            this.dgvListadoInsumos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListadoInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoInsumos.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListadoInsumos.Location = new System.Drawing.Point(12, 80);
            this.dgvListadoInsumos.Name = "dgvListadoInsumos";
            this.dgvListadoInsumos.Size = new System.Drawing.Size(776, 311);
            this.dgvListadoInsumos.TabIndex = 1;
            // 
            // frmReporteInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.dgvListadoInsumos);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmReporteInsumos";
            this.Text = "Reporte Insumos";
            this.Load += new System.EventHandler(this.frmReporteInsumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoInsumos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnSalir;
        private System.Windows.Forms.DataGridView dgvListadoInsumos;
    }
}