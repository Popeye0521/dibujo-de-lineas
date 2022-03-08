
namespace Rectangulo1
{
    partial class DibujarLinea
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
            this.btnDibujar = new System.Windows.Forms.Button();
            this.lblXfinal = new System.Windows.Forms.Label();
            this.txtXfinal = new System.Windows.Forms.TextBox();
            this.txtYfinal = new System.Windows.Forms.TextBox();
            this.lblYfinal = new System.Windows.Forms.Label();
            this.lblXinicial = new System.Windows.Forms.Label();
            this.lblYinicial = new System.Windows.Forms.Label();
            this.txtXinicial = new System.Windows.Forms.TextBox();
            this.txtYinicial = new System.Windows.Forms.TextBox();
            this.lblCantidadLineas = new System.Windows.Forms.Label();
            this.txtCantidadLineas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDibujar
            // 
            this.btnDibujar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDibujar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujar.Location = new System.Drawing.Point(195, 232);
            this.btnDibujar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(185, 42);
            this.btnDibujar.TabIndex = 0;
            this.btnDibujar.Text = "Dibujar linea";
            this.btnDibujar.UseVisualStyleBackColor = false;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // lblXfinal
            // 
            this.lblXfinal.AutoSize = true;
            this.lblXfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXfinal.Location = new System.Drawing.Point(159, 150);
            this.lblXfinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblXfinal.Name = "lblXfinal";
            this.lblXfinal.Size = new System.Drawing.Size(50, 16);
            this.lblXfinal.TabIndex = 1;
            this.lblXfinal.Text = "X final";
            this.lblXfinal.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtXfinal
            // 
            this.txtXfinal.Location = new System.Drawing.Point(223, 150);
            this.txtXfinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtXfinal.Name = "txtXfinal";
            this.txtXfinal.Size = new System.Drawing.Size(76, 20);
            this.txtXfinal.TabIndex = 2;
            this.txtXfinal.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            // 
            // txtYfinal
            // 
            this.txtYfinal.Location = new System.Drawing.Point(418, 150);
            this.txtYfinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtYfinal.Name = "txtYfinal";
            this.txtYfinal.Size = new System.Drawing.Size(76, 20);
            this.txtYfinal.TabIndex = 3;
            this.txtYfinal.TextChanged += new System.EventHandler(this.txtY_TextChanged);
            // 
            // lblYfinal
            // 
            this.lblYfinal.AutoSize = true;
            this.lblYfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYfinal.Location = new System.Drawing.Point(352, 150);
            this.lblYfinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYfinal.Name = "lblYfinal";
            this.lblYfinal.Size = new System.Drawing.Size(51, 16);
            this.lblYfinal.TabIndex = 4;
            this.lblYfinal.Text = "Y final";
            // 
            // lblXinicial
            // 
            this.lblXinicial.AutoSize = true;
            this.lblXinicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinicial.Location = new System.Drawing.Point(159, 116);
            this.lblXinicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblXinicial.Name = "lblXinicial";
            this.lblXinicial.Size = new System.Drawing.Size(62, 16);
            this.lblXinicial.TabIndex = 5;
            this.lblXinicial.Text = "X inicial";
            // 
            // lblYinicial
            // 
            this.lblYinicial.AutoSize = true;
            this.lblYinicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYinicial.Location = new System.Drawing.Point(352, 116);
            this.lblYinicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYinicial.Name = "lblYinicial";
            this.lblYinicial.Size = new System.Drawing.Size(63, 16);
            this.lblYinicial.TabIndex = 6;
            this.lblYinicial.Text = "Y inicial";
            // 
            // txtXinicial
            // 
            this.txtXinicial.Location = new System.Drawing.Point(223, 114);
            this.txtXinicial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtXinicial.Name = "txtXinicial";
            this.txtXinicial.Size = new System.Drawing.Size(76, 20);
            this.txtXinicial.TabIndex = 7;
            // 
            // txtYinicial
            // 
            this.txtYinicial.Location = new System.Drawing.Point(418, 114);
            this.txtYinicial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtYinicial.Name = "txtYinicial";
            this.txtYinicial.Size = new System.Drawing.Size(76, 20);
            this.txtYinicial.TabIndex = 8;
            // 
            // lblCantidadLineas
            // 
            this.lblCantidadLineas.AutoSize = true;
            this.lblCantidadLineas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadLineas.Location = new System.Drawing.Point(493, 232);
            this.lblCantidadLineas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadLineas.Name = "lblCantidadLineas";
            this.lblCantidadLineas.Size = new System.Drawing.Size(138, 16);
            this.lblCantidadLineas.TabIndex = 9;
            this.lblCantidadLineas.Text = "Cantidad de lineas";
            this.lblCantidadLineas.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCantidadLineas
            // 
            this.txtCantidadLineas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCantidadLineas.Location = new System.Drawing.Point(495, 257);
            this.txtCantidadLineas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidadLineas.Name = "txtCantidadLineas";
            this.txtCantidadLineas.Size = new System.Drawing.Size(76, 20);
            this.txtCantidadLineas.TabIndex = 10;
            // 
            // DibujarLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1012, 510);
            this.Controls.Add(this.txtCantidadLineas);
            this.Controls.Add(this.lblCantidadLineas);
            this.Controls.Add(this.txtYinicial);
            this.Controls.Add(this.txtXinicial);
            this.Controls.Add(this.lblYinicial);
            this.Controls.Add(this.lblXinicial);
            this.Controls.Add(this.lblYfinal);
            this.Controls.Add(this.txtYfinal);
            this.Controls.Add(this.txtXfinal);
            this.Controls.Add(this.lblXfinal);
            this.Controls.Add(this.btnDibujar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DibujarLinea";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Label lblXfinal;
        private System.Windows.Forms.TextBox txtXfinal;
        private System.Windows.Forms.TextBox txtYfinal;
        private System.Windows.Forms.Label lblYfinal;
        private System.Windows.Forms.Label lblXinicial;
        private System.Windows.Forms.Label lblYinicial;
        private System.Windows.Forms.TextBox txtXinicial;
        private System.Windows.Forms.TextBox txtYinicial;
        private System.Windows.Forms.Label lblCantidadLineas;
        private System.Windows.Forms.TextBox txtCantidadLineas;
    }
}

