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
            this.btnSensor2 = new System.Windows.Forms.Button();
            this.btnSensor3 = new System.Windows.Forms.Button();
            this.lblSensor2 = new System.Windows.Forms.Label();
            this.lblSensor3 = new System.Windows.Forms.Label();
            this.lblEstadoSenor = new System.Windows.Forms.Label();
            this.lblPesoMaximo = new System.Windows.Forms.Label();
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
            // btnSensor2
            // 
            this.btnSensor2.Enabled = false;
            this.btnSensor2.Image = global::hardyApp.Properties.Resources.On;
            this.btnSensor2.Location = new System.Drawing.Point(221, 230);
            this.btnSensor2.Name = "btnSensor2";
            this.btnSensor2.Size = new System.Drawing.Size(54, 46);
            this.btnSensor2.TabIndex = 4;
            this.btnSensor2.UseVisualStyleBackColor = true;
            // 
            // btnSensor3
            // 
            this.btnSensor3.Enabled = false;
            this.btnSensor3.Image = global::hardyApp.Properties.Resources.On;
            this.btnSensor3.Location = new System.Drawing.Point(91, 230);
            this.btnSensor3.Name = "btnSensor3";
            this.btnSensor3.Size = new System.Drawing.Size(54, 46);
            this.btnSensor3.TabIndex = 5;
            this.btnSensor3.UseVisualStyleBackColor = true;
            // 
            // lblSensor2
            // 
            this.lblSensor2.AutoSize = true;
            this.lblSensor2.Location = new System.Drawing.Point(218, 201);
            this.lblSensor2.Name = "lblSensor2";
            this.lblSensor2.Size = new System.Drawing.Size(49, 13);
            this.lblSensor2.TabIndex = 6;
            this.lblSensor2.Text = "Sensor 2";
            // 
            // lblSensor3
            // 
            this.lblSensor3.AutoSize = true;
            this.lblSensor3.Location = new System.Drawing.Point(88, 201);
            this.lblSensor3.Name = "lblSensor3";
            this.lblSensor3.Size = new System.Drawing.Size(49, 13);
            this.lblSensor3.TabIndex = 7;
            this.lblSensor3.Text = "Sensor 3";
            // 
            // lblEstadoSenor
            // 
            this.lblEstadoSenor.AutoSize = true;
            this.lblEstadoSenor.Location = new System.Drawing.Point(12, 177);
            this.lblEstadoSenor.Name = "lblEstadoSenor";
            this.lblEstadoSenor.Size = new System.Drawing.Size(43, 13);
            this.lblEstadoSenor.TabIndex = 8;
            this.lblEstadoSenor.Text = "Estado:";
            // 
            // lblPesoMaximo
            // 
            this.lblPesoMaximo.AutoSize = true;
            this.lblPesoMaximo.Location = new System.Drawing.Point(426, 111);
            this.lblPesoMaximo.Name = "lblPesoMaximo";
            this.lblPesoMaximo.Size = new System.Drawing.Size(0, 13);
            this.lblPesoMaximo.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 453);
            this.Controls.Add(this.lblPesoMaximo);
            this.Controls.Add(this.lblEstadoSenor);
            this.Controls.Add(this.lblSensor3);
            this.Controls.Add(this.lblSensor2);
            this.Controls.Add(this.btnSensor3);
            this.Controls.Add(this.btnSensor2);
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
        private System.Windows.Forms.Button btnSensor2;
        private System.Windows.Forms.Button btnSensor3;
        private System.Windows.Forms.Label lblSensor2;
        private System.Windows.Forms.Label lblSensor3;
        private System.Windows.Forms.Label lblEstadoSenor;
        private System.Windows.Forms.Label lblPesoMaximo;
    }
}

