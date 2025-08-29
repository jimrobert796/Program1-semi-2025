namespace miPrimerProyectoCsharp
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblSerie = new System.Windows.Forms.Label();
            this.txtxSerie = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblDesviacionTipica = new System.Windows.Forms.Label();
            this.lblbArmonica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(46, 50);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(39, 16);
            this.lblSerie.TabIndex = 0;
            this.lblSerie.Text = "Serie";
            // 
            // txtxSerie
            // 
            this.txtxSerie.Location = new System.Drawing.Point(91, 46);
            this.txtxSerie.Name = "txtxSerie";
            this.txtxSerie.Size = new System.Drawing.Size(178, 20);
            this.txtxSerie.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(91, 193);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 75);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(46, 85);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(58, 16);
            this.lblMedia.TabIndex = 3;
            this.lblMedia.Text = "Media: ?";
            // 
            // lblDesviacionTipica
            // 
            this.lblDesviacionTipica.AutoSize = true;
            this.lblDesviacionTipica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesviacionTipica.Location = new System.Drawing.Point(46, 119);
            this.lblDesviacionTipica.Name = "lblDesviacionTipica";
            this.lblDesviacionTipica.Size = new System.Drawing.Size(58, 16);
            this.lblDesviacionTipica.TabIndex = 3;
            this.lblDesviacionTipica.Text = "Tipica: ?";
            // 
            // lblbArmonica
            // 
            this.lblbArmonica.AutoSize = true;
            this.lblbArmonica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbArmonica.Location = new System.Drawing.Point(46, 149);
            this.lblbArmonica.Name = "lblbArmonica";
            this.lblbArmonica.Size = new System.Drawing.Size(77, 16);
            this.lblbArmonica.TabIndex = 3;
            this.lblbArmonica.Text = "Armonica: ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 290);
            this.Controls.Add(this.lblbArmonica);
            this.Controls.Add(this.lblDesviacionTipica);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtxSerie);
            this.Controls.Add(this.lblSerie);
            this.Name = "Form1";
            this.Text = "Estadistica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox txtxSerie;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblDesviacionTipica;
        private System.Windows.Forms.Label lblbArmonica;
    }
}

