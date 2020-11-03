namespace SumaAppForm
{
    partial class Form1
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
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.txtBValor1 = new System.Windows.Forms.TextBox();
            this.txtBValor2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(26, 79);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(112, 13);
            this.lblValor2.TabIndex = 1;
            this.lblValor2.Text = "Ingrese segundo valor";
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(26, 37);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(99, 13);
            this.lblValor1.TabIndex = 2;
            this.lblValor1.Text = "Ingrese primer valor";
            // 
            // txtBValor1
            // 
            this.txtBValor1.Location = new System.Drawing.Point(188, 34);
            this.txtBValor1.Name = "txtBValor1";
            this.txtBValor1.Size = new System.Drawing.Size(100, 20);
            this.txtBValor1.TabIndex = 5;
            // 
            // txtBValor2
            // 
            this.txtBValor2.Location = new System.Drawing.Point(188, 76);
            this.txtBValor2.Name = "txtBValor2";
            this.txtBValor2.Size = new System.Drawing.Size(100, 20);
            this.txtBValor2.TabIndex = 6;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(313, 125);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(67, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "La sema es: ";
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(188, 115);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(100, 23);
            this.btnSumar.TabIndex = 8;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 239);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtBValor2);
            this.Controls.Add(this.txtBValor1);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.lblValor2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.TextBox txtBValor1;
        private System.Windows.Forms.TextBox txtBValor2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSumar;
    }
}

