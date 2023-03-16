namespace wLineas
{
    partial class frmDibujarLinea
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblXinicial = new System.Windows.Forms.Label();
            this.lblXFinal = new System.Windows.Forms.Label();
            this.lblYInicial = new System.Windows.Forms.Label();
            this.lblYFinal = new System.Windows.Forms.Label();
            this.txtXInicial = new System.Windows.Forms.TextBox();
            this.txtXFinal = new System.Windows.Forms.TextBox();
            this.txtYInicial = new System.Windows.Forms.TextBox();
            this.txtYFinal = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnDibujarLinea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblXinicial
            // 
            this.lblXinicial.AutoSize = true;
            this.lblXinicial.Location = new System.Drawing.Point(74, 50);
            this.lblXinicial.Name = "lblXinicial";
            this.lblXinicial.Size = new System.Drawing.Size(40, 13);
            this.lblXinicial.TabIndex = 0;
            this.lblXinicial.Text = "Xinicial";
            this.lblXinicial.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblXFinal
            // 
            this.lblXFinal.AutoSize = true;
            this.lblXFinal.Location = new System.Drawing.Point(74, 81);
            this.lblXFinal.Name = "lblXFinal";
            this.lblXFinal.Size = new System.Drawing.Size(33, 13);
            this.lblXFinal.TabIndex = 1;
            this.lblXFinal.Text = "Xfinal";
            // 
            // lblYInicial
            // 
            this.lblYInicial.AutoSize = true;
            this.lblYInicial.Location = new System.Drawing.Point(331, 50);
            this.lblYInicial.Name = "lblYInicial";
            this.lblYInicial.Size = new System.Drawing.Size(40, 13);
            this.lblYInicial.TabIndex = 2;
            this.lblYInicial.Text = "Yinicial";
            // 
            // lblYFinal
            // 
            this.lblYFinal.AutoSize = true;
            this.lblYFinal.Location = new System.Drawing.Point(334, 83);
            this.lblYFinal.Name = "lblYFinal";
            this.lblYFinal.Size = new System.Drawing.Size(33, 13);
            this.lblYFinal.TabIndex = 3;
            this.lblYFinal.Text = "Yfinal";
            // 
            // txtXInicial
            // 
            this.txtXInicial.Location = new System.Drawing.Point(129, 49);
            this.txtXInicial.Name = "txtXInicial";
            this.txtXInicial.Size = new System.Drawing.Size(150, 20);
            this.txtXInicial.TabIndex = 4;
            // 
            // txtXFinal
            // 
            this.txtXFinal.Location = new System.Drawing.Point(129, 81);
            this.txtXFinal.Name = "txtXFinal";
            this.txtXFinal.Size = new System.Drawing.Size(150, 20);
            this.txtXFinal.TabIndex = 5;
            // 
            // txtYInicial
            // 
            this.txtYInicial.Location = new System.Drawing.Point(386, 47);
            this.txtYInicial.Name = "txtYInicial";
            this.txtYInicial.Size = new System.Drawing.Size(150, 20);
            this.txtYInicial.TabIndex = 6;
            // 
            // txtYFinal
            // 
            this.txtYFinal.Location = new System.Drawing.Point(386, 81);
            this.txtYFinal.Name = "txtYFinal";
            this.txtYFinal.Size = new System.Drawing.Size(150, 20);
            this.txtYFinal.TabIndex = 7;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(79, 162);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(94, 13);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad de lineas";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(77, 187);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(107, 20);
            this.txtResultado.TabIndex = 9;
            // 
            // btnDibujarLinea
            // 
            this.btnDibujarLinea.Location = new System.Drawing.Point(337, 162);
            this.btnDibujarLinea.Name = "btnDibujarLinea";
            this.btnDibujarLinea.Size = new System.Drawing.Size(183, 45);
            this.btnDibujarLinea.TabIndex = 10;
            this.btnDibujarLinea.Text = "Dibujar lineas";
            this.btnDibujarLinea.UseVisualStyleBackColor = true;
            this.btnDibujarLinea.Click += new System.EventHandler(this.btnDibujarLinea_Click);
            // 
            // frmDibujarLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDibujarLinea);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtYFinal);
            this.Controls.Add(this.txtYInicial);
            this.Controls.Add(this.txtXFinal);
            this.Controls.Add(this.txtXInicial);
            this.Controls.Add(this.lblYFinal);
            this.Controls.Add(this.lblYInicial);
            this.Controls.Add(this.lblXFinal);
            this.Controls.Add(this.lblXinicial);
            this.Name = "frmDibujarLinea";
            this.Text = "Dibujar Linea";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXinicial;
        private System.Windows.Forms.Label lblXFinal;
        private System.Windows.Forms.Label lblYInicial;
        private System.Windows.Forms.Label lblYFinal;
        private System.Windows.Forms.TextBox txtXInicial;
        private System.Windows.Forms.TextBox txtXFinal;
        private System.Windows.Forms.TextBox txtYInicial;
        private System.Windows.Forms.TextBox txtYFinal;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnDibujarLinea;
    }
}

