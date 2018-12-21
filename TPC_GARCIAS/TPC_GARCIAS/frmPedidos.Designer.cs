namespace TPC_GARCIAS
{
    partial class frmPedidos
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
            this.txbPedido = new System.Windows.Forms.TextBox();
            this.txbVenta = new System.Windows.Forms.TextBox();
            this.dtpPedido = new System.Windows.Forms.DateTimePicker();
            this.dtpEAcord = new System.Windows.Forms.DateTimePicker();
            this.dtpEReal = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnInsumos = new System.Windows.Forms.Button();
            this.lblIDPed = new System.Windows.Forms.Label();
            this.lblIDVta = new System.Windows.Forms.Label();
            this.lblFPed = new System.Windows.Forms.Label();
            this.lblFAcordad = new System.Windows.Forms.Label();
            this.lblEReal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbPedido
            // 
            this.txbPedido.Location = new System.Drawing.Point(15, 25);
            this.txbPedido.Name = "txbPedido";
            this.txbPedido.Size = new System.Drawing.Size(51, 20);
            this.txbPedido.TabIndex = 0;
            // 
            // txbVenta
            // 
            this.txbVenta.Location = new System.Drawing.Point(72, 25);
            this.txbVenta.Name = "txbVenta";
            this.txbVenta.Size = new System.Drawing.Size(46, 20);
            this.txbVenta.TabIndex = 1;
            // 
            // dtpPedido
            // 
            this.dtpPedido.Location = new System.Drawing.Point(130, 25);
            this.dtpPedido.Name = "dtpPedido";
            this.dtpPedido.Size = new System.Drawing.Size(200, 20);
            this.dtpPedido.TabIndex = 2;
            // 
            // dtpEAcord
            // 
            this.dtpEAcord.Location = new System.Drawing.Point(130, 56);
            this.dtpEAcord.Name = "dtpEAcord";
            this.dtpEAcord.Size = new System.Drawing.Size(200, 20);
            this.dtpEAcord.TabIndex = 3;
            // 
            // dtpEReal
            // 
            this.dtpEReal.Location = new System.Drawing.Point(130, 82);
            this.dtpEReal.Name = "dtpEReal";
            this.dtpEReal.Size = new System.Drawing.Size(200, 20);
            this.dtpEReal.TabIndex = 4;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(130, 108);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 5;
            this.cmbStatus.TextChanged += new System.EventHandler(this.cmbStatus_TextChanged);
            // 
            // btnInsumos
            // 
            this.btnInsumos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsumos.Location = new System.Drawing.Point(12, 141);
            this.btnInsumos.Name = "btnInsumos";
            this.btnInsumos.Size = new System.Drawing.Size(103, 46);
            this.btnInsumos.TabIndex = 6;
            this.btnInsumos.Text = "Ver Insumos";
            this.btnInsumos.UseVisualStyleBackColor = true;
            this.btnInsumos.Click += new System.EventHandler(this.btnInsumos_Click);
            // 
            // lblIDPed
            // 
            this.lblIDPed.AutoSize = true;
            this.lblIDPed.Location = new System.Drawing.Point(12, 9);
            this.lblIDPed.Name = "lblIDPed";
            this.lblIDPed.Size = new System.Drawing.Size(54, 13);
            this.lblIDPed.TabIndex = 7;
            this.lblIDPed.Text = "ID Pedido";
            // 
            // lblIDVta
            // 
            this.lblIDVta.AutoSize = true;
            this.lblIDVta.Location = new System.Drawing.Point(72, 9);
            this.lblIDVta.Name = "lblIDVta";
            this.lblIDVta.Size = new System.Drawing.Size(49, 13);
            this.lblIDVta.TabIndex = 8;
            this.lblIDVta.Text = "ID Venta";
            // 
            // lblFPed
            // 
            this.lblFPed.AutoSize = true;
            this.lblFPed.Location = new System.Drawing.Point(197, 9);
            this.lblFPed.Name = "lblFPed";
            this.lblFPed.Size = new System.Drawing.Size(73, 13);
            this.lblFPed.TabIndex = 9;
            this.lblFPed.Text = "Fecha Pedido";
            // 
            // lblFAcordad
            // 
            this.lblFAcordad.AutoSize = true;
            this.lblFAcordad.Location = new System.Drawing.Point(31, 62);
            this.lblFAcordad.Name = "lblFAcordad";
            this.lblFAcordad.Size = new System.Drawing.Size(93, 13);
            this.lblFAcordad.TabIndex = 10;
            this.lblFAcordad.Text = "Entrega Acordada";
            // 
            // lblEReal
            // 
            this.lblEReal.AutoSize = true;
            this.lblEReal.Location = new System.Drawing.Point(55, 88);
            this.lblEReal.Name = "lblEReal";
            this.lblEReal.Size = new System.Drawing.Size(69, 13);
            this.lblEReal.TabIndex = 11;
            this.lblEReal.Text = "Entrega Real";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(84, 111);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(224, 141);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 46);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 196);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEReal);
            this.Controls.Add(this.lblFAcordad);
            this.Controls.Add(this.lblFPed);
            this.Controls.Add(this.lblIDVta);
            this.Controls.Add(this.lblIDPed);
            this.Controls.Add(this.btnInsumos);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dtpEReal);
            this.Controls.Add(this.dtpEAcord);
            this.Controls.Add(this.dtpPedido);
            this.Controls.Add(this.txbVenta);
            this.Controls.Add(this.txbPedido);
            this.MinimumSize = new System.Drawing.Size(360, 235);
            this.Name = "frmPedidos";
            this.Text = "Detalle Pedido";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPedido;
        private System.Windows.Forms.TextBox txbVenta;
        private System.Windows.Forms.DateTimePicker dtpPedido;
        private System.Windows.Forms.DateTimePicker dtpEAcord;
        private System.Windows.Forms.DateTimePicker dtpEReal;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnInsumos;
        private System.Windows.Forms.Label lblIDPed;
        private System.Windows.Forms.Label lblIDVta;
        private System.Windows.Forms.Label lblFPed;
        private System.Windows.Forms.Label lblFAcordad;
        private System.Windows.Forms.Label lblEReal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSalir;
    }
}