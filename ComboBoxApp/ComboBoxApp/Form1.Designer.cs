namespace ComboBoxApp
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
            this.cBRojo = new System.Windows.Forms.ComboBox();
            this.cBVerde = new System.Windows.Forms.ComboBox();
            this.cBAzul = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBRojo
            // 
            this.cBRojo.FormattingEnabled = true;
            this.cBRojo.Location = new System.Drawing.Point(95, 49);
            this.cBRojo.Name = "cBRojo";
            this.cBRojo.Size = new System.Drawing.Size(121, 21);
            this.cBRojo.TabIndex = 0;
            // 
            // cBVerde
            // 
            this.cBVerde.FormattingEnabled = true;
            this.cBVerde.Location = new System.Drawing.Point(95, 109);
            this.cBVerde.Name = "cBVerde";
            this.cBVerde.Size = new System.Drawing.Size(121, 21);
            this.cBVerde.TabIndex = 1;
            // 
            // cBAzul
            // 
            this.cBAzul.FormattingEnabled = true;
            this.cBAzul.Location = new System.Drawing.Point(95, 179);
            this.cBAzul.Name = "cBAzul";
            this.cBAzul.Size = new System.Drawing.Size(121, 21);
            this.cBAzul.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rojo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Verde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Azul";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(95, 238);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBAzul);
            this.Controls.Add(this.cBVerde);
            this.Controls.Add(this.cBRojo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBRojo;
        private System.Windows.Forms.ComboBox cBVerde;
        private System.Windows.Forms.ComboBox cBAzul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnActualizar;
    }
}

