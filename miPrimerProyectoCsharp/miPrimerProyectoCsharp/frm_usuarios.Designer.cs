namespace miPrimerProyectoCsharp
{
    partial class frm_usuarios
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
            this.grbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.txtTelefonoUsuario = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccionUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDireccionUsuario = new System.Windows.Forms.Label();
            this.txtClaveUsuario = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.idUsuario = new System.Windows.Forms.Label();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.grbEdicionUsuario = new System.Windows.Forms.GroupBox();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.grbNavegacionUsuario = new System.Windows.Forms.GroupBox();
            this.btnUltimoUsuario = new System.Windows.Forms.Button();
            this.lblRegistroUsuario = new System.Windows.Forms.Label();
            this.btnSiguienteUsuario = new System.Windows.Forms.Button();
            this.btnAnteriorUsuario = new System.Windows.Forms.Button();
            this.btnPrimeroUsuario = new System.Windows.Forms.Button();
            this.grbDatosUsuario.SuspendLayout();
            this.grbEdicionUsuario.SuspendLayout();
            this.grbNavegacionUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosUsuario
            // 
            this.grbDatosUsuario.Controls.Add(this.txtTelefonoUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblTelefono);
            this.grbDatosUsuario.Controls.Add(this.txtDireccionUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblNombreAlumno);
            this.grbDatosUsuario.Controls.Add(this.txtNombreUsuario);
            this.grbDatosUsuario.Controls.Add(this.label1);
            this.grbDatosUsuario.Controls.Add(this.lblUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblDireccionUsuario);
            this.grbDatosUsuario.Controls.Add(this.txtClaveUsuario);
            this.grbDatosUsuario.Controls.Add(this.txtUsuario);
            this.grbDatosUsuario.Controls.Add(this.idUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblIdUsuario);
            this.grbDatosUsuario.Enabled = false;
            this.grbDatosUsuario.Location = new System.Drawing.Point(12, 12);
            this.grbDatosUsuario.Name = "grbDatosUsuario";
            this.grbDatosUsuario.Size = new System.Drawing.Size(308, 266);
            this.grbDatosUsuario.TabIndex = 1;
            this.grbDatosUsuario.TabStop = false;
            this.grbDatosUsuario.Text = "DATOS";
            this.grbDatosUsuario.Enter += new System.EventHandler(this.grbDatosUsuario_Enter);
            // 
            // txtTelefonoUsuario
            // 
            this.txtTelefonoUsuario.Location = new System.Drawing.Point(82, 218);
            this.txtTelefonoUsuario.Name = "txtTelefonoUsuario";
            this.txtTelefonoUsuario.Size = new System.Drawing.Size(118, 20);
            this.txtTelefonoUsuario.TabIndex = 1;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(9, 221);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(67, 13);
            this.lblTelefono.TabIndex = 0;
            this.lblTelefono.Text = "TELEFONO:";
            // 
            // txtDireccionUsuario
            // 
            this.txtDireccionUsuario.Location = new System.Drawing.Point(81, 178);
            this.txtDireccionUsuario.Name = "txtDireccionUsuario";
            this.txtDireccionUsuario.Size = new System.Drawing.Size(210, 20);
            this.txtDireccionUsuario.TabIndex = 1;
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Location = new System.Drawing.Point(18, 140);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(57, 13);
            this.lblNombreAlumno.TabIndex = 0;
            this.lblNombreAlumno.Text = "NOMBRE:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(82, 137);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(179, 20);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLAVE:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(24, 63);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "USUARIO:";
            // 
            // lblDireccionUsuario
            // 
            this.lblDireccionUsuario.AutoSize = true;
            this.lblDireccionUsuario.Location = new System.Drawing.Point(6, 181);
            this.lblDireccionUsuario.Name = "lblDireccionUsuario";
            this.lblDireccionUsuario.Size = new System.Drawing.Size(69, 13);
            this.lblDireccionUsuario.TabIndex = 0;
            this.lblDireccionUsuario.Text = "DIRECCION:";
            // 
            // txtClaveUsuario
            // 
            this.txtClaveUsuario.Location = new System.Drawing.Point(82, 93);
            this.txtClaveUsuario.Name = "txtClaveUsuario";
            this.txtClaveUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtClaveUsuario.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(82, 56);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // idUsuario
            // 
            this.idUsuario.AutoSize = true;
            this.idUsuario.Location = new System.Drawing.Point(79, 30);
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Size = new System.Drawing.Size(15, 13);
            this.idUsuario.TabIndex = 0;
            this.idUsuario.Text = "id";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(43, 30);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(21, 13);
            this.lblIdUsuario.TabIndex = 0;
            this.lblIdUsuario.Text = "ID:";
            // 
            // grbEdicionUsuario
            // 
            this.grbEdicionUsuario.Controls.Add(this.btnEliminarUsuario);
            this.grbEdicionUsuario.Controls.Add(this.btnModificarUsuario);
            this.grbEdicionUsuario.Controls.Add(this.btnAgregarUsuario);
            this.grbEdicionUsuario.Location = new System.Drawing.Point(344, 131);
            this.grbEdicionUsuario.Name = "grbEdicionUsuario";
            this.grbEdicionUsuario.Size = new System.Drawing.Size(316, 78);
            this.grbEdicionUsuario.TabIndex = 4;
            this.grbEdicionUsuario.TabStop = false;
            this.grbEdicionUsuario.Text = "Edicion";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(211, 27);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(96, 32);
            this.btnEliminarUsuario.TabIndex = 0;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.Location = new System.Drawing.Point(102, 27);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(103, 32);
            this.btnModificarUsuario.TabIndex = 0;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.Location = new System.Drawing.Point(6, 27);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(92, 32);
            this.btnAgregarUsuario.TabIndex = 0;
            this.btnAgregarUsuario.Text = "Nuevo";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // grbNavegacionUsuario
            // 
            this.grbNavegacionUsuario.Controls.Add(this.btnUltimoUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.lblRegistroUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnSiguienteUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnAnteriorUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnPrimeroUsuario);
            this.grbNavegacionUsuario.Location = new System.Drawing.Point(344, 60);
            this.grbNavegacionUsuario.Name = "grbNavegacionUsuario";
            this.grbNavegacionUsuario.Size = new System.Drawing.Size(262, 65);
            this.grbNavegacionUsuario.TabIndex = 6;
            this.grbNavegacionUsuario.TabStop = false;
            this.grbNavegacionUsuario.Text = "Navegacion";
            // 
            // btnUltimoUsuario
            // 
            this.btnUltimoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoUsuario.Location = new System.Drawing.Point(207, 27);
            this.btnUltimoUsuario.Name = "btnUltimoUsuario";
            this.btnUltimoUsuario.Size = new System.Drawing.Size(37, 32);
            this.btnUltimoUsuario.TabIndex = 0;
            this.btnUltimoUsuario.Text = ">|";
            this.btnUltimoUsuario.UseVisualStyleBackColor = true;
            this.btnUltimoUsuario.Click += new System.EventHandler(this.btnUltimoUsuario_Click);
            // 
            // lblRegistroUsuario
            // 
            this.lblRegistroUsuario.AutoSize = true;
            this.lblRegistroUsuario.Location = new System.Drawing.Point(107, 39);
            this.lblRegistroUsuario.Name = "lblRegistroUsuario";
            this.lblRegistroUsuario.Size = new System.Drawing.Size(40, 13);
            this.lblRegistroUsuario.TabIndex = 0;
            this.lblRegistroUsuario.Text = "X de N";
            // 
            // btnSiguienteUsuario
            // 
            this.btnSiguienteUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteUsuario.Location = new System.Drawing.Point(164, 27);
            this.btnSiguienteUsuario.Name = "btnSiguienteUsuario";
            this.btnSiguienteUsuario.Size = new System.Drawing.Size(37, 32);
            this.btnSiguienteUsuario.TabIndex = 0;
            this.btnSiguienteUsuario.Text = ">";
            this.btnSiguienteUsuario.UseVisualStyleBackColor = true;
            this.btnSiguienteUsuario.Click += new System.EventHandler(this.btnSiguienteUsuario_Click);
            // 
            // btnAnteriorUsuario
            // 
            this.btnAnteriorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorUsuario.Location = new System.Drawing.Point(55, 27);
            this.btnAnteriorUsuario.Name = "btnAnteriorUsuario";
            this.btnAnteriorUsuario.Size = new System.Drawing.Size(37, 32);
            this.btnAnteriorUsuario.TabIndex = 0;
            this.btnAnteriorUsuario.Text = "<";
            this.btnAnteriorUsuario.UseVisualStyleBackColor = true;
            this.btnAnteriorUsuario.Click += new System.EventHandler(this.btnAnteriorUsuario_Click);
            // 
            // btnPrimeroUsuario
            // 
            this.btnPrimeroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroUsuario.Location = new System.Drawing.Point(12, 27);
            this.btnPrimeroUsuario.Name = "btnPrimeroUsuario";
            this.btnPrimeroUsuario.Size = new System.Drawing.Size(37, 32);
            this.btnPrimeroUsuario.TabIndex = 0;
            this.btnPrimeroUsuario.Text = "|<";
            this.btnPrimeroUsuario.UseVisualStyleBackColor = true;
            this.btnPrimeroUsuario.Click += new System.EventHandler(this.btnPrimeroUsuario_Click);
            // 
            // frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 309);
            this.Controls.Add(this.grbNavegacionUsuario);
            this.Controls.Add(this.grbEdicionUsuario);
            this.Controls.Add(this.grbDatosUsuario);
            this.Name = "frm_usuarios";
            this.Text = "usuarios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDatosUsuario.ResumeLayout(false);
            this.grbDatosUsuario.PerformLayout();
            this.grbEdicionUsuario.ResumeLayout(false);
            this.grbNavegacionUsuario.ResumeLayout(false);
            this.grbNavegacionUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbDatosUsuario;
        private System.Windows.Forms.TextBox txtTelefonoUsuario;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDireccionUsuario;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDireccionUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label idUsuario;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClaveUsuario;
        private System.Windows.Forms.GroupBox grbEdicionUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.GroupBox grbNavegacionUsuario;
        private System.Windows.Forms.Button btnUltimoUsuario;
        private System.Windows.Forms.Label lblRegistroUsuario;
        private System.Windows.Forms.Button btnSiguienteUsuario;
        private System.Windows.Forms.Button btnAnteriorUsuario;
        private System.Windows.Forms.Button btnPrimeroUsuario;
    }
}

