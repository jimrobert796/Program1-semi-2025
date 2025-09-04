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
            this.lblA = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cboAconv = new System.Windows.Forms.ComboBox();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.lblinicio = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(303, 131);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(23, 18);
            this.lblA.TabIndex = 18;
            this.lblA.Text = "A:";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(303, 98);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(34, 18);
            this.lblDe.TabIndex = 19;
            this.lblDe.Text = "De:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(64, 99);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(79, 18);
            this.lblCantidad.TabIndex = 20;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(301, 188);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(157, 124);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // cboAconv
            // 
            this.cboAconv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAconv.FormattingEnabled = true;
            this.cboAconv.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda cuadrada",
            "Metro Cuadrado",
            "Tareas",
            "Manzana",
            "Hectareas"});
            this.cboAconv.Location = new System.Drawing.Point(339, 131);
            this.cboAconv.Margin = new System.Windows.Forms.Padding(2);
            this.cboAconv.Name = "cboAconv";
            this.cboAconv.Size = new System.Drawing.Size(139, 21);
            this.cboAconv.TabIndex = 14;
            // 
            // cboOrigen
            // 
            this.cboOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda cuadrada",
            "Metro Cuadrado",
            "Tareas",
            "Manzana",
            "Hectareas"});
            this.cboOrigen.Location = new System.Drawing.Point(339, 96);
            this.cboOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(139, 21);
            this.cboOrigen.TabIndex = 15;
            // 
            // lblinicio
            // 
            this.lblinicio.AutoSize = true;
            this.lblinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinicio.Location = new System.Drawing.Point(154, 27);
            this.lblinicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinicio.Name = "lblinicio";
            this.lblinicio.Size = new System.Drawing.Size(251, 20);
            this.lblinicio.TabIndex = 13;
            this.lblinicio.Text = "Conversor de area (superficie)";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(43, 221);
            this.lblRespuesta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(107, 18);
            this.lblRespuesta.TabIndex = 12;
            this.lblRespuesta.Text = "Respuesta: ?";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(148, 96);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(140, 20);
            this.txtCantidad.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 342);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cboAconv);
            this.Controls.Add(this.cboOrigen);
            this.Controls.Add(this.lblinicio);
            this.Controls.Add(this.lblRespuesta);
            this.Name = "Form1";
            this.Text = "Conversor de  de Area";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cboAconv;
        private System.Windows.Forms.ComboBox cboOrigen;
        private System.Windows.Forms.Label lblinicio;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}

