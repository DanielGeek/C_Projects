namespace hardyApp
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
            this.btnPesar = new System.Windows.Forms.Button();
            this.lblPesoHardy = new System.Windows.Forms.Label();
            this.btnCalibrar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblContadorPez = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPesar
            // 
            this.btnPesar.Location = new System.Drawing.Point(221, 53);
            this.btnPesar.Name = "btnPesar";
            this.btnPesar.Size = new System.Drawing.Size(97, 38);
            this.btnPesar.TabIndex = 0;
            this.btnPesar.Text = "Iniciar Pesaje";
            this.btnPesar.UseVisualStyleBackColor = true;
            this.btnPesar.Click += new System.EventHandler(this.btnPesar_Click);
            // 
            // lblPesoHardy
            // 
            this.lblPesoHardy.AutoSize = true;
            this.lblPesoHardy.Location = new System.Drawing.Point(224, 111);
            this.lblPesoHardy.Name = "lblPesoHardy";
            this.lblPesoHardy.Size = new System.Drawing.Size(0, 13);
            this.lblPesoHardy.TabIndex = 1;
            // 
            // btnCalibrar
            // 
            this.btnCalibrar.Location = new System.Drawing.Point(43, 53);
            this.btnCalibrar.Name = "btnCalibrar";
            this.btnCalibrar.Size = new System.Drawing.Size(102, 38);
            this.btnCalibrar.TabIndex = 2;
            this.btnCalibrar.Text = "Calibrar";
            this.btnCalibrar.UseVisualStyleBackColor = true;
            this.btnCalibrar.Click += new System.EventHandler(this.btnCalibrar_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // lblContadorPez
            // 
            this.lblContadorPez.AutoSize = true;
            this.lblContadorPez.Location = new System.Drawing.Point(349, 111);
            this.lblContadorPez.Name = "lblContadorPez";
            this.lblContadorPez.Size = new System.Drawing.Size(0, 13);
            this.lblContadorPez.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 453);
            this.Controls.Add(this.lblContadorPez);
            this.Controls.Add(this.btnCalibrar);
            this.Controls.Add(this.lblPesoHardy);
            this.Controls.Add(this.btnPesar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesar;
        private System.Windows.Forms.Label lblPesoHardy;
        private System.Windows.Forms.Button btnCalibrar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblContadorPez;
    }
}

