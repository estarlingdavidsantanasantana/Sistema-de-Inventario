namespace CapaPresentacion
{
    partial class FrmAdmin
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
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnMovimiento = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LRol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPanel = new System.Windows.Forms.GroupBox();
            this.btnMovis = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.PContenedor = new System.Windows.Forms.Panel();
            this.gbPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(11, 414);
            this.btnCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(261, 58);
            this.btnCategoria.TabIndex = 1;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnMovimiento
            // 
            this.btnMovimiento.Location = new System.Drawing.Point(11, 478);
            this.btnMovimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMovimiento.Name = "btnMovimiento";
            this.btnMovimiento.Size = new System.Drawing.Size(261, 57);
            this.btnMovimiento.TabIndex = 2;
            this.btnMovimiento.Text = "Movimiento";
            this.btnMovimiento.UseVisualStyleBackColor = true;
            this.btnMovimiento.Click += new System.EventHandler(this.btnMovimiento_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(8, 351);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(261, 55);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(13, 148);
            this.btnProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(261, 55);
            this.btnProveedor.TabIndex = 4;
            this.btnProveedor.Text = "Proveedor";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(13, 287);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(261, 54);
            this.btnUsuario.TabIndex = 5;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(48, 622);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 38);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Cerrar Seccion";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Location = new System.Drawing.Point(106, 40);
            this.LUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(51, 20);
            this.LUsuario.TabIndex = 7;
            this.LUsuario.Text = "label1";
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.Location = new System.Drawing.Point(106, 75);
            this.LRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(51, 20);
            this.LRol.TabIndex = 8;
            this.LRol.Text = "label2";
            this.LRol.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rol:";
            // 
            // gbPanel
            // 
            this.gbPanel.Controls.Add(this.btnMovis);
            this.gbPanel.Controls.Add(this.btnCliente);
            this.gbPanel.Controls.Add(this.btnCategoria);
            this.gbPanel.Controls.Add(this.btnLogin);
            this.gbPanel.Controls.Add(this.label2);
            this.gbPanel.Controls.Add(this.btnUsuario);
            this.gbPanel.Controls.Add(this.label1);
            this.gbPanel.Controls.Add(this.btnProductos);
            this.gbPanel.Controls.Add(this.btnProveedor);
            this.gbPanel.Controls.Add(this.btnMovimiento);
            this.gbPanel.Controls.Add(this.LUsuario);
            this.gbPanel.Controls.Add(this.LRol);
            this.gbPanel.Location = new System.Drawing.Point(2, 14);
            this.gbPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPanel.Name = "gbPanel";
            this.gbPanel.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPanel.Size = new System.Drawing.Size(282, 680);
            this.gbPanel.TabIndex = 11;
            this.gbPanel.TabStop = false;
            this.gbPanel.Text = "Panel Admin";
            // 
            // btnMovis
            // 
            this.btnMovis.Location = new System.Drawing.Point(13, 545);
            this.btnMovis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMovis.Name = "btnMovis";
            this.btnMovis.Size = new System.Drawing.Size(261, 54);
            this.btnMovis.TabIndex = 12;
            this.btnMovis.Text = "Movimientos";
            this.btnMovis.UseVisualStyleBackColor = true;
            this.btnMovis.Click += new System.EventHandler(this.btnMovis_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(13, 223);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(261, 54);
            this.btnCliente.TabIndex = 11;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // PContenedor
            // 
            this.PContenedor.Location = new System.Drawing.Point(292, 14);
            this.PContenedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(1028, 660);
            this.PContenedor.TabIndex = 12;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 692);
            this.Controls.Add(this.PContenedor);
            this.Controls.Add(this.gbPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.gbPanel.ResumeLayout(false);
            this.gbPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnMovimiento;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPanel;
        private System.Windows.Forms.Panel PContenedor;
        private System.Windows.Forms.Button btnMovis;
        private System.Windows.Forms.Button btnCliente;
    }
}