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
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblISSS = new System.Windows.Forms.Label();
            this.lblAFP = new System.Windows.Forms.Label();
            this.lblISR = new System.Windows.Forms.Label();
            this.lblSueldoNeto = new System.Windows.Forms.Label();
            this.lblTotalDeduciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.Location = new System.Drawing.Point(50, 47);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(82, 24);
            this.lblSueldo.TabIndex = 0;
            this.lblSueldo.Text = "Sueldo:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(155, 47);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(341, 64);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(155, 65);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblISSS
            // 
            this.lblISSS.AutoSize = true;
            this.lblISSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISSS.Location = new System.Drawing.Point(50, 84);
            this.lblISSS.Name = "lblISSS";
            this.lblISSS.Size = new System.Drawing.Size(77, 24);
            this.lblISSS.TabIndex = 3;
            this.lblISSS.Text = "ISSS: ?";
            // 
            // lblAFP
            // 
            this.lblAFP.AutoSize = true;
            this.lblAFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAFP.Location = new System.Drawing.Point(50, 120);
            this.lblAFP.Name = "lblAFP";
            this.lblAFP.Size = new System.Drawing.Size(73, 24);
            this.lblAFP.TabIndex = 4;
            this.lblAFP.Text = "AFP: ?";
            // 
            // lblISR
            // 
            this.lblISR.AutoSize = true;
            this.lblISR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISR.Location = new System.Drawing.Point(50, 155);
            this.lblISR.Name = "lblISR";
            this.lblISR.Size = new System.Drawing.Size(65, 24);
            this.lblISR.TabIndex = 5;
            this.lblISR.Text = "ISR: ?";
            // 
            // lblSueldoNeto
            // 
            this.lblSueldoNeto.AutoSize = true;
            this.lblSueldoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoNeto.Location = new System.Drawing.Point(50, 226);
            this.lblSueldoNeto.Name = "lblSueldoNeto";
            this.lblSueldoNeto.Size = new System.Drawing.Size(149, 24);
            this.lblSueldoNeto.TabIndex = 6;
            this.lblSueldoNeto.Text = "Sueldo Neto: ?";
            // 
            // lblTotalDeduciones
            // 
            this.lblTotalDeduciones.AutoSize = true;
            this.lblTotalDeduciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeduciones.Location = new System.Drawing.Point(50, 192);
            this.lblTotalDeduciones.Name = "lblTotalDeduciones";
            this.lblTotalDeduciones.Size = new System.Drawing.Size(195, 24);
            this.lblTotalDeduciones.TabIndex = 7;
            this.lblTotalDeduciones.Text = "Total deduciones: ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 290);
            this.Controls.Add(this.lblTotalDeduciones);
            this.Controls.Add(this.lblSueldoNeto);
            this.Controls.Add(this.lblISR);
            this.Controls.Add(this.lblAFP);
            this.Controls.Add(this.lblISSS);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.lblSueldo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblISSS;
        private System.Windows.Forms.Label lblAFP;
        private System.Windows.Forms.Label lblISR;
        private System.Windows.Forms.Label lblSueldoNeto;
        private System.Windows.Forms.Label lblTotalDeduciones;
    }
}

