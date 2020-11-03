namespace DiasSemanaForm
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
            this.btnLunes = new System.Windows.Forms.Button();
            this.btnMartes = new System.Windows.Forms.Button();
            this.btnMiercoles = new System.Windows.Forms.Button();
            this.btnJueves = new System.Windows.Forms.Button();
            this.btnViernes = new System.Windows.Forms.Button();
            this.btnSabado = new System.Windows.Forms.Button();
            this.btnDomingo = new System.Windows.Forms.Button();
            this.lblDias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLunes
            // 
            this.btnLunes.Location = new System.Drawing.Point(19, 46);
            this.btnLunes.Name = "btnLunes";
            this.btnLunes.Size = new System.Drawing.Size(75, 23);
            this.btnLunes.TabIndex = 0;
            this.btnLunes.Text = "Lunes";
            this.btnLunes.UseVisualStyleBackColor = true;
            this.btnLunes.Click += new System.EventHandler(this.btnLunes_Click);
            // 
            // btnMartes
            // 
            this.btnMartes.Location = new System.Drawing.Point(112, 46);
            this.btnMartes.Name = "btnMartes";
            this.btnMartes.Size = new System.Drawing.Size(75, 23);
            this.btnMartes.TabIndex = 1;
            this.btnMartes.Text = "Martes";
            this.btnMartes.UseVisualStyleBackColor = true;
            this.btnMartes.Click += new System.EventHandler(this.btnMartes_Click);
            // 
            // btnMiercoles
            // 
            this.btnMiercoles.Location = new System.Drawing.Point(207, 46);
            this.btnMiercoles.Name = "btnMiercoles";
            this.btnMiercoles.Size = new System.Drawing.Size(75, 23);
            this.btnMiercoles.TabIndex = 2;
            this.btnMiercoles.Text = "Miercoles";
            this.btnMiercoles.UseVisualStyleBackColor = true;
            this.btnMiercoles.Click += new System.EventHandler(this.btnMiercoles_Click);
            // 
            // btnJueves
            // 
            this.btnJueves.Location = new System.Drawing.Point(300, 46);
            this.btnJueves.Name = "btnJueves";
            this.btnJueves.Size = new System.Drawing.Size(75, 23);
            this.btnJueves.TabIndex = 3;
            this.btnJueves.Text = "Jueves";
            this.btnJueves.UseVisualStyleBackColor = true;
            this.btnJueves.Click += new System.EventHandler(this.btnJueves_Click);
            // 
            // btnViernes
            // 
            this.btnViernes.Location = new System.Drawing.Point(390, 46);
            this.btnViernes.Name = "btnViernes";
            this.btnViernes.Size = new System.Drawing.Size(75, 23);
            this.btnViernes.TabIndex = 4;
            this.btnViernes.Text = "Viernes";
            this.btnViernes.UseVisualStyleBackColor = true;
            this.btnViernes.Click += new System.EventHandler(this.btnViernes_Click);
            // 
            // btnSabado
            // 
            this.btnSabado.Location = new System.Drawing.Point(484, 46);
            this.btnSabado.Name = "btnSabado";
            this.btnSabado.Size = new System.Drawing.Size(75, 23);
            this.btnSabado.TabIndex = 5;
            this.btnSabado.Text = "Sábado";
            this.btnSabado.UseVisualStyleBackColor = true;
            this.btnSabado.Click += new System.EventHandler(this.btnSabado_Click);
            // 
            // btnDomingo
            // 
            this.btnDomingo.Location = new System.Drawing.Point(579, 46);
            this.btnDomingo.Name = "btnDomingo";
            this.btnDomingo.Size = new System.Drawing.Size(75, 23);
            this.btnDomingo.TabIndex = 6;
            this.btnDomingo.Text = "Domingo";
            this.btnDomingo.UseVisualStyleBackColor = true;
            this.btnDomingo.Click += new System.EventHandler(this.btnDomingo_Click);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(16, 93);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(93, 13);
            this.lblDias.TabIndex = 7;
            this.lblDias.Text = "Presione un botón";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.btnDomingo);
            this.Controls.Add(this.btnSabado);
            this.Controls.Add(this.btnViernes);
            this.Controls.Add(this.btnJueves);
            this.Controls.Add(this.btnMiercoles);
            this.Controls.Add(this.btnMartes);
            this.Controls.Add(this.btnLunes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLunes;
        private System.Windows.Forms.Button btnMartes;
        private System.Windows.Forms.Button btnMiercoles;
        private System.Windows.Forms.Button btnJueves;
        private System.Windows.Forms.Button btnViernes;
        private System.Windows.Forms.Button btnSabado;
        private System.Windows.Forms.Button btnDomingo;
        private System.Windows.Forms.Label lblDias;
    }
}

