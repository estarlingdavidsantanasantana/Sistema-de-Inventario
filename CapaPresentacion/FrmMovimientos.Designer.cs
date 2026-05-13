namespace CapaPresentacion
{
    partial class FrmMovimientos
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
            this.dgvMovis = new System.Windows.Forms.DataGridView();
            this.LTitulo = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMovis
            // 
            this.dgvMovis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovis.Location = new System.Drawing.Point(342, 105);
            this.dgvMovis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMovis.Name = "dgvMovis";
            this.dgvMovis.RowHeadersWidth = 62;
            this.dgvMovis.Size = new System.Drawing.Size(518, 471);
            this.dgvMovis.TabIndex = 0;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(511, 49);
            this.LTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(178, 37);
            this.LTitulo.TabIndex = 3;
            this.LTitulo.Text = "Movimientos";
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.Lime;
            this.btnVer.Location = new System.Drawing.Point(518, 597);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(140, 42);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "Ver Reporte";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // FrmMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.dgvMovis);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMovimientos";
            this.Text = "FrmMovimientos";
            this.Load += new System.EventHandler(this.FrmMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovis;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Button btnVer;
    }
}