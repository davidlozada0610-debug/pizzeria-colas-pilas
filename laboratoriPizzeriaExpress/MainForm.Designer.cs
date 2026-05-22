namespace laboratoriPizzeriaCampusExpress
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Button btnEntregar;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox lstPedidos;
        private System.Windows.Forms.ListBox lstBitacora;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblContador;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
        	this.txtCliente = new System.Windows.Forms.TextBox();
        	this.btnNuevoPedido = new System.Windows.Forms.Button();
        	this.btnEntregar = new System.Windows.Forms.Button();
        	this.btnDeshacer = new System.Windows.Forms.Button();
        	this.btnLimpiar = new System.Windows.Forms.Button();
        	this.lstPedidos = new System.Windows.Forms.ListBox();
        	this.lstBitacora = new System.Windows.Forms.ListBox();
        	this.lblEstado = new System.Windows.Forms.Label();
        	this.lblContador = new System.Windows.Forms.Label();
        	this.btnAgregarVIP = new System.Windows.Forms.Button();
        	this.btnDeshacerVIP = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// txtCliente
        	// 
        	this.txtCliente.Location = new System.Drawing.Point(12, 12);
        	this.txtCliente.Name = "txtCliente";
        	this.txtCliente.Size = new System.Drawing.Size(200, 20);
        	this.txtCliente.TabIndex = 0;
        	// 
        	// btnNuevoPedido
        	// 
        	this.btnNuevoPedido.Location = new System.Drawing.Point(220, 12);
        	this.btnNuevoPedido.Name = "btnNuevoPedido";
        	this.btnNuevoPedido.Size = new System.Drawing.Size(100, 23);
        	this.btnNuevoPedido.TabIndex = 1;
        	this.btnNuevoPedido.Text = "Nuevo Pedido";
        	this.btnNuevoPedido.UseVisualStyleBackColor = true;
        	this.btnNuevoPedido.Click += new System.EventHandler(this.BtnNuevoPedido_Click);
        	// 
        	// btnEntregar
        	// 
        	this.btnEntregar.Location = new System.Drawing.Point(326, 12);
        	this.btnEntregar.Name = "btnEntregar";
        	this.btnEntregar.Size = new System.Drawing.Size(100, 23);
        	this.btnEntregar.TabIndex = 2;
        	this.btnEntregar.Text = "Entregar";
        	this.btnEntregar.UseVisualStyleBackColor = true;
        	this.btnEntregar.Click += new System.EventHandler(this.BtnEntregar_Click);
        	// 
        	// btnDeshacer
        	// 
        	this.btnDeshacer.Location = new System.Drawing.Point(432, 12);
        	this.btnDeshacer.Name = "btnDeshacer";
        	this.btnDeshacer.Size = new System.Drawing.Size(100, 23);
        	this.btnDeshacer.TabIndex = 3;
        	this.btnDeshacer.Text = "Deshacer";
        	this.btnDeshacer.UseVisualStyleBackColor = true;
        	this.btnDeshacer.Click += new System.EventHandler(this.BtnDeshacer_Click);
        	// 
        	// btnLimpiar
        	// 
        	this.btnLimpiar.Location = new System.Drawing.Point(538, 12);
        	this.btnLimpiar.Name = "btnLimpiar";
        	this.btnLimpiar.Size = new System.Drawing.Size(100, 23);
        	this.btnLimpiar.TabIndex = 4;
        	this.btnLimpiar.Text = "Limpiar todo";
        	this.btnLimpiar.UseVisualStyleBackColor = true;
        	this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
        	// 
        	// lstPedidos
        	// 
        	this.lstPedidos.FormattingEnabled = true;
        	this.lstPedidos.Location = new System.Drawing.Point(12, 50);
        	this.lstPedidos.Name = "lstPedidos";
        	this.lstPedidos.Size = new System.Drawing.Size(271, 238);
        	this.lstPedidos.TabIndex = 5;
        	// 
        	// lstBitacora
        	// 
        	this.lstBitacora.FormattingEnabled = true;
        	this.lstBitacora.Location = new System.Drawing.Point(312, 50);
        	this.lstBitacora.Name = "lstBitacora";
        	this.lstBitacora.Size = new System.Drawing.Size(288, 238);
        	this.lstBitacora.TabIndex = 6;
        	// 
        	// lblEstado
        	// 
        	this.lblEstado.AutoSize = true;
        	this.lblEstado.Location = new System.Drawing.Point(12, 315);
        	this.lblEstado.Name = "lblEstado";
        	this.lblEstado.Size = new System.Drawing.Size(91, 13);
        	this.lblEstado.TabIndex = 7;
        	this.lblEstado.Text = "Listo para trabajar";
        	// 
        	// lblContador
        	// 
        	this.lblContador.AutoSize = true;
        	this.lblContador.Location = new System.Drawing.Point(12, 340);
        	this.lblContador.Name = "lblContador";
        	this.lblContador.Size = new System.Drawing.Size(27, 13);
        	this.lblContador.TabIndex = 8;
        	this.lblContador.Text = "0 | 0";
        	// 
        	// btnAgregarVIP
        	// 
        	this.btnAgregarVIP.BackColor = System.Drawing.SystemColors.ButtonShadow;
        	this.btnAgregarVIP.ForeColor = System.Drawing.Color.Gold;
        	this.btnAgregarVIP.Location = new System.Drawing.Point(238, 305);
        	this.btnAgregarVIP.Name = "btnAgregarVIP";
        	this.btnAgregarVIP.Size = new System.Drawing.Size(118, 23);
        	this.btnAgregarVIP.TabIndex = 9;
        	this.btnAgregarVIP.Text = "Nuevo Pedido VIP";
        	this.btnAgregarVIP.UseVisualStyleBackColor = false;
        	this.btnAgregarVIP.Click += new System.EventHandler(this.BtnAgregarVIPClick);
        	// 
        	// btnDeshacerVIP
        	// 
        	this.btnDeshacerVIP.BackColor = System.Drawing.SystemColors.ButtonShadow;
        	this.btnDeshacerVIP.ForeColor = System.Drawing.Color.Gold;
        	this.btnDeshacerVIP.Location = new System.Drawing.Point(373, 305);
        	this.btnDeshacerVIP.Name = "btnDeshacerVIP";
        	this.btnDeshacerVIP.Size = new System.Drawing.Size(100, 23);
        	this.btnDeshacerVIP.TabIndex = 10;
        	this.btnDeshacerVIP.Text = "Deshacer VIP";
        	this.btnDeshacerVIP.UseVisualStyleBackColor = false;
        	this.btnDeshacerVIP.Click += new System.EventHandler(this.BtnDeshacerVIPClick);
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(654, 370);
        	this.Controls.Add(this.btnDeshacerVIP);
        	this.Controls.Add(this.btnAgregarVIP);
        	this.Controls.Add(this.lblContador);
        	this.Controls.Add(this.lblEstado);
        	this.Controls.Add(this.lstBitacora);
        	this.Controls.Add(this.lstPedidos);
        	this.Controls.Add(this.btnLimpiar);
        	this.Controls.Add(this.btnDeshacer);
        	this.Controls.Add(this.btnEntregar);
        	this.Controls.Add(this.btnNuevoPedido);
        	this.Controls.Add(this.txtCliente);
        	this.Name = "MainForm";
        	this.Text = "Pizzería Campus Express";
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Button btnDeshacerVIP;
        private System.Windows.Forms.Button btnAgregarVIP;
    }
}