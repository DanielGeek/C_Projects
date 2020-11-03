namespace Checkbox_Form_App
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
            this.cBIngles = new System.Windows.Forms.CheckBox();
            this.cBFrances = new System.Windows.Forms.CheckBox();
            this.cBAleman = new System.Windows.Forms.CheckBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.cBAcepto = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cBIngles
            // 
            this.cBIngles.AutoSize = true;
            this.cBIngles.Location = new System.Drawing.Point(52, 35);
            this.cBIngles.Name = "cBIngles";
            this.cBIngles.Size = new System.Drawing.Size(54, 17);
            this.cBIngles.TabIndex = 0;
            this.cBIngles.Text = "Ingles";
            this.cBIngles.UseVisualStyleBackColor = true;
            // 
            // cBFrances
            // 
            this.cBFrances.AutoSize = true;
            this.cBFrances.Location = new System.Drawing.Point(52, 76);
            this.cBFrances.Name = "cBFrances";
            this.cBFrances.Size = new System.Drawing.Size(64, 17);
            this.cBFrances.TabIndex = 1;
            this.cBFrances.Text = "Francés";
            this.cBFrances.UseVisualStyleBackColor = true;
            // 
            // cBAleman
            // 
            this.cBAleman.AutoSize = true;
            this.cBAleman.Location = new System.Drawing.Point(52, 116);
            this.cBAleman.Name = "cBAleman";
            this.cBAleman.Size = new System.Drawing.Size(61, 17);
            this.cBAleman.TabIndex = 2;
            this.cBAleman.Text = "Alemán";
            this.cBAleman.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Enabled = false;
            this.btnMostrar.Location = new System.Drawing.Point(165, 185);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(92, 44);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar Seleccionados";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // cBAcepto
            // 
            this.cBAcepto.AutoSize = true;
            this.cBAcepto.Location = new System.Drawing.Point(52, 185);
            this.cBAcepto.Name = "cBAcepto";
            this.cBAcepto.Size = new System.Drawing.Size(60, 17);
            this.cBAcepto.TabIndex = 4;
            this.cBAcepto.Text = "Acepto";
            this.cBAcepto.UseVisualStyleBackColor = true;
            this.cBAcepto.CheckedChanged += new System.EventHandler(this.cBAcepto_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Esta de acuerdo con las normas del servicio?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBAcepto);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cBAleman);
            this.Controls.Add(this.cBFrances);
            this.Controls.Add(this.cBIngles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cBIngles;
        private System.Windows.Forms.CheckBox cBFrances;
        private System.Windows.Forms.CheckBox cBAleman;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.CheckBox cBAcepto;
        private System.Windows.Forms.Label label1;
    }
}

