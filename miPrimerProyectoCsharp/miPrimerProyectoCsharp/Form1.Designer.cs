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
            this.grbDatosDocente = new System.Windows.Forms.GroupBox();
            this.txtTelefonoDocente = new System.Windows.Forms.TextBox();
            this.txtDireccionDocente = new System.Windows.Forms.TextBox();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.txtMateriaDocente = new System.Windows.Forms.TextBox();
            this.txtCodigoDocente = new System.Windows.Forms.TextBox();
            this.lblTelefonoDocente = new System.Windows.Forms.Label();
            this.lblDireccionDocente = new System.Windows.Forms.Label();
            this.lblMateriaDocente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodigoDocentes = new System.Windows.Forms.Label();
            this.idDocentes = new System.Windows.Forms.Label();
            this.lblidDocentes = new System.Windows.Forms.Label();
            this.lblXdeN = new System.Windows.Forms.Label();
            this.grbNavegacionDocente = new System.Windows.Forms.GroupBox();
            this.btnUltimoDocente = new System.Windows.Forms.Button();
            this.btnSiguienteDocente = new System.Windows.Forms.Button();
            this.btnAnteriorDocente = new System.Windows.Forms.Button();
            this.btnPrimerDocente = new System.Windows.Forms.Button();
            this.grbAdministarDocente = new System.Windows.Forms.GroupBox();
            this.btnNuevoDocente = new System.Windows.Forms.Button();
            this.btnModificarDocente = new System.Windows.Forms.Button();
            this.btnEliminarDocente = new System.Windows.Forms.Button();
            this.grbBusquedaDocente = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.txtBusquedaDocente = new System.Windows.Forms.TextBox();
            this.grvBusqueda = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDatosDocente.SuspendLayout();
            this.grbNavegacionDocente.SuspendLayout();
            this.grbAdministarDocente.SuspendLayout();
            this.grbBusquedaDocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosDocente
            // 
            this.grbDatosDocente.Controls.Add(this.txtTelefonoDocente);
            this.grbDatosDocente.Controls.Add(this.txtDireccionDocente);
            this.grbDatosDocente.Controls.Add(this.txtNombreDocente);
            this.grbDatosDocente.Controls.Add(this.txtMateriaDocente);
            this.grbDatosDocente.Controls.Add(this.txtCodigoDocente);
            this.grbDatosDocente.Controls.Add(this.lblTelefonoDocente);
            this.grbDatosDocente.Controls.Add(this.lblDireccionDocente);
            this.grbDatosDocente.Controls.Add(this.lblMateriaDocente);
            this.grbDatosDocente.Controls.Add(this.label3);
            this.grbDatosDocente.Controls.Add(this.lblCodigoDocentes);
            this.grbDatosDocente.Controls.Add(this.idDocentes);
            this.grbDatosDocente.Controls.Add(this.lblidDocentes);
            this.grbDatosDocente.Location = new System.Drawing.Point(12, 12);
            this.grbDatosDocente.Name = "grbDatosDocente";
            this.grbDatosDocente.Size = new System.Drawing.Size(280, 235);
            this.grbDatosDocente.TabIndex = 0;
            this.grbDatosDocente.TabStop = false;
            this.grbDatosDocente.Text = "Datos Docente";
            // 
            // txtTelefonoDocente
            // 
            this.txtTelefonoDocente.Location = new System.Drawing.Point(80, 179);
            this.txtTelefonoDocente.Name = "txtTelefonoDocente";
            this.txtTelefonoDocente.Size = new System.Drawing.Size(122, 20);
            this.txtTelefonoDocente.TabIndex = 2;
            // 
            // txtDireccionDocente
            // 
            this.txtDireccionDocente.Location = new System.Drawing.Point(80, 153);
            this.txtDireccionDocente.Name = "txtDireccionDocente";
            this.txtDireccionDocente.Size = new System.Drawing.Size(193, 20);
            this.txtDireccionDocente.TabIndex = 2;
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Location = new System.Drawing.Point(80, 120);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(193, 20);
            this.txtNombreDocente.TabIndex = 2;
            // 
            // txtMateriaDocente
            // 
            this.txtMateriaDocente.Location = new System.Drawing.Point(80, 94);
            this.txtMateriaDocente.Name = "txtMateriaDocente";
            this.txtMateriaDocente.Size = new System.Drawing.Size(122, 20);
            this.txtMateriaDocente.TabIndex = 2;
            // 
            // txtCodigoDocente
            // 
            this.txtCodigoDocente.Location = new System.Drawing.Point(80, 68);
            this.txtCodigoDocente.Name = "txtCodigoDocente";
            this.txtCodigoDocente.Size = new System.Drawing.Size(122, 20);
            this.txtCodigoDocente.TabIndex = 2;
            // 
            // lblTelefonoDocente
            // 
            this.lblTelefonoDocente.AutoSize = true;
            this.lblTelefonoDocente.Location = new System.Drawing.Point(6, 186);
            this.lblTelefonoDocente.Name = "lblTelefonoDocente";
            this.lblTelefonoDocente.Size = new System.Drawing.Size(67, 13);
            this.lblTelefonoDocente.TabIndex = 1;
            this.lblTelefonoDocente.Text = "TELEFONO:";
            // 
            // lblDireccionDocente
            // 
            this.lblDireccionDocente.AutoSize = true;
            this.lblDireccionDocente.Location = new System.Drawing.Point(5, 160);
            this.lblDireccionDocente.Name = "lblDireccionDocente";
            this.lblDireccionDocente.Size = new System.Drawing.Size(69, 13);
            this.lblDireccionDocente.TabIndex = 1;
            this.lblDireccionDocente.Text = "DIRECCION:";
            // 
            // lblMateriaDocente
            // 
            this.lblMateriaDocente.AutoSize = true;
            this.lblMateriaDocente.Location = new System.Drawing.Point(16, 97);
            this.lblMateriaDocente.Name = "lblMateriaDocente";
            this.lblMateriaDocente.Size = new System.Drawing.Size(58, 13);
            this.lblMateriaDocente.TabIndex = 1;
            this.lblMateriaDocente.Text = "MATERIA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "NOMBRE:";
            // 
            // lblCodigoDocentes
            // 
            this.lblCodigoDocentes.AutoSize = true;
            this.lblCodigoDocentes.Location = new System.Drawing.Point(22, 71);
            this.lblCodigoDocentes.Name = "lblCodigoDocentes";
            this.lblCodigoDocentes.Size = new System.Drawing.Size(52, 13);
            this.lblCodigoDocentes.TabIndex = 1;
            this.lblCodigoDocentes.Text = "CODIGO:";
            // 
            // idDocentes
            // 
            this.idDocentes.AutoSize = true;
            this.idDocentes.Location = new System.Drawing.Point(105, 37);
            this.idDocentes.Name = "idDocentes";
            this.idDocentes.Size = new System.Drawing.Size(15, 13);
            this.idDocentes.TabIndex = 0;
            this.idDocentes.Text = "id";
            // 
            // lblidDocentes
            // 
            this.lblidDocentes.AutoSize = true;
            this.lblidDocentes.Location = new System.Drawing.Point(50, 37);
            this.lblidDocentes.Name = "lblidDocentes";
            this.lblidDocentes.Size = new System.Drawing.Size(21, 13);
            this.lblidDocentes.TabIndex = 0;
            this.lblidDocentes.Text = "ID:";
            // 
            // lblXdeN
            // 
            this.lblXdeN.AutoSize = true;
            this.lblXdeN.Location = new System.Drawing.Point(123, 34);
            this.lblXdeN.Name = "lblXdeN";
            this.lblXdeN.Size = new System.Drawing.Size(40, 13);
            this.lblXdeN.TabIndex = 1;
            this.lblXdeN.Text = "X de N";
            // 
            // grbNavegacionDocente
            // 
            this.grbNavegacionDocente.Controls.Add(this.btnUltimoDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnSiguienteDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnAnteriorDocente);
            this.grbNavegacionDocente.Controls.Add(this.lblXdeN);
            this.grbNavegacionDocente.Controls.Add(this.btnPrimerDocente);
            this.grbNavegacionDocente.Location = new System.Drawing.Point(12, 253);
            this.grbNavegacionDocente.Name = "grbNavegacionDocente";
            this.grbNavegacionDocente.Size = new System.Drawing.Size(274, 72);
            this.grbNavegacionDocente.TabIndex = 1;
            this.grbNavegacionDocente.TabStop = false;
            this.grbNavegacionDocente.Text = "Navegacion";
            // 
            // btnUltimoDocente
            // 
            this.btnUltimoDocente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUltimoDocente.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoDocente.Location = new System.Drawing.Point(228, 19);
            this.btnUltimoDocente.Name = "btnUltimoDocente";
            this.btnUltimoDocente.Size = new System.Drawing.Size(40, 37);
            this.btnUltimoDocente.TabIndex = 0;
            this.btnUltimoDocente.Text = ">|";
            this.btnUltimoDocente.UseVisualStyleBackColor = true;
            this.btnUltimoDocente.Click += new System.EventHandler(this.btnUltimoDocente_Click);
            // 
            // btnSiguienteDocente
            // 
            this.btnSiguienteDocente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguienteDocente.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteDocente.Location = new System.Drawing.Point(179, 19);
            this.btnSiguienteDocente.Name = "btnSiguienteDocente";
            this.btnSiguienteDocente.Size = new System.Drawing.Size(43, 37);
            this.btnSiguienteDocente.TabIndex = 0;
            this.btnSiguienteDocente.Text = ">";
            this.btnSiguienteDocente.UseVisualStyleBackColor = true;
            this.btnSiguienteDocente.Click += new System.EventHandler(this.btnSiguienteDocente_Click);
            // 
            // btnAnteriorDocente
            // 
            this.btnAnteriorDocente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnteriorDocente.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorDocente.Location = new System.Drawing.Point(52, 19);
            this.btnAnteriorDocente.Name = "btnAnteriorDocente";
            this.btnAnteriorDocente.Size = new System.Drawing.Size(40, 37);
            this.btnAnteriorDocente.TabIndex = 0;
            this.btnAnteriorDocente.Text = "<";
            this.btnAnteriorDocente.UseVisualStyleBackColor = true;
            this.btnAnteriorDocente.Click += new System.EventHandler(this.btnAnteriorDocente_Click);
            // 
            // btnPrimerDocente
            // 
            this.btnPrimerDocente.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimerDocente.Location = new System.Drawing.Point(6, 19);
            this.btnPrimerDocente.Name = "btnPrimerDocente";
            this.btnPrimerDocente.Size = new System.Drawing.Size(40, 37);
            this.btnPrimerDocente.TabIndex = 0;
            this.btnPrimerDocente.Text = "|<";
            this.btnPrimerDocente.UseVisualStyleBackColor = true;
            this.btnPrimerDocente.Click += new System.EventHandler(this.btnPrimerDocente_Click);
            // 
            // grbAdministarDocente
            // 
            this.grbAdministarDocente.Controls.Add(this.btnNuevoDocente);
            this.grbAdministarDocente.Controls.Add(this.btnModificarDocente);
            this.grbAdministarDocente.Controls.Add(this.btnEliminarDocente);
            this.grbAdministarDocente.Location = new System.Drawing.Point(293, 253);
            this.grbAdministarDocente.Name = "grbAdministarDocente";
            this.grbAdministarDocente.Size = new System.Drawing.Size(263, 72);
            this.grbAdministarDocente.TabIndex = 2;
            this.grbAdministarDocente.TabStop = false;
            this.grbAdministarDocente.Text = "Administracion";
            // 
            // btnNuevoDocente
            // 
            this.btnNuevoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDocente.Location = new System.Drawing.Point(10, 19);
            this.btnNuevoDocente.Name = "btnNuevoDocente";
            this.btnNuevoDocente.Size = new System.Drawing.Size(76, 37);
            this.btnNuevoDocente.TabIndex = 0;
            this.btnNuevoDocente.Text = "Nuevo";
            this.btnNuevoDocente.UseVisualStyleBackColor = true;
            this.btnNuevoDocente.Click += new System.EventHandler(this.btnNuevoDocente_Click);
            // 
            // btnModificarDocente
            // 
            this.btnModificarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDocente.Location = new System.Drawing.Point(92, 19);
            this.btnModificarDocente.Name = "btnModificarDocente";
            this.btnModificarDocente.Size = new System.Drawing.Size(83, 37);
            this.btnModificarDocente.TabIndex = 0;
            this.btnModificarDocente.Text = "Modificar";
            this.btnModificarDocente.UseVisualStyleBackColor = true;
            this.btnModificarDocente.Click += new System.EventHandler(this.btnModificarDocente_Click);
            // 
            // btnEliminarDocente
            // 
            this.btnEliminarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDocente.Location = new System.Drawing.Point(181, 19);
            this.btnEliminarDocente.Name = "btnEliminarDocente";
            this.btnEliminarDocente.Size = new System.Drawing.Size(76, 37);
            this.btnEliminarDocente.TabIndex = 0;
            this.btnEliminarDocente.Text = "Eliminar";
            this.btnEliminarDocente.UseVisualStyleBackColor = true;
            this.btnEliminarDocente.Click += new System.EventHandler(this.btnEliminarDocente_Click);
            // 
            // grbBusquedaDocente
            // 
            this.grbBusquedaDocente.Controls.Add(this.grvBusqueda);
            this.grbBusquedaDocente.Controls.Add(this.txtBusquedaDocente);
            this.grbBusquedaDocente.Location = new System.Drawing.Point(303, 12);
            this.grbBusquedaDocente.Name = "grbBusquedaDocente";
            this.grbBusquedaDocente.Size = new System.Drawing.Size(452, 235);
            this.grbBusquedaDocente.TabIndex = 3;
            this.grbBusquedaDocente.TabStop = false;
            this.grbBusquedaDocente.Text = "Busqueda";
            // 
            // txtBusquedaDocente
            // 
            this.txtBusquedaDocente.Location = new System.Drawing.Point(6, 34);
            this.txtBusquedaDocente.Name = "txtBusquedaDocente";
            this.txtBusquedaDocente.Size = new System.Drawing.Size(431, 20);
            this.txtBusquedaDocente.TabIndex = 2;
            this.txtBusquedaDocente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // grvBusqueda
            // 
            this.grvBusqueda.AllowUserToAddRows = false;
            this.grvBusqueda.AllowUserToDeleteRows = false;
            this.grvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo,
            this.Materia,
            this.Nombre,
            this.Direccion,
            this.Telefono});
            this.grvBusqueda.Location = new System.Drawing.Point(6, 60);
            this.grvBusqueda.Name = "grvBusqueda";
            this.grvBusqueda.ReadOnly = true;
            this.grvBusqueda.Size = new System.Drawing.Size(431, 169);
            this.grvBusqueda.TabIndex = 3;
            this.grvBusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdDocentes";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "materia";
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            this.Materia.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 200;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 337);
            this.Controls.Add(this.grbBusquedaDocente);
            this.Controls.Add(this.grbAdministarDocente);
            this.Controls.Add(this.grbNavegacionDocente);
            this.Controls.Add(this.grbDatosDocente);
            this.Name = "Form1";
            this.Text = "ACADEMICA DOCENTES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDatosDocente.ResumeLayout(false);
            this.grbDatosDocente.PerformLayout();
            this.grbNavegacionDocente.ResumeLayout(false);
            this.grbNavegacionDocente.PerformLayout();
            this.grbAdministarDocente.ResumeLayout(false);
            this.grbBusquedaDocente.ResumeLayout(false);
            this.grbBusquedaDocente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBusqueda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbDatosDocente;
        private System.Windows.Forms.GroupBox grbNavegacionDocente;
        private System.Windows.Forms.GroupBox grbAdministarDocente;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.TextBox txtCodigoDocente;
        private System.Windows.Forms.Label lblXdeN;
        private System.Windows.Forms.Label lblDireccionDocente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCodigoDocentes;
        private System.Windows.Forms.Label lblidDocentes;
        private System.Windows.Forms.TextBox txtTelefonoDocente;
        private System.Windows.Forms.TextBox txtDireccionDocente;
        private System.Windows.Forms.Label idDocentes;
        private System.Windows.Forms.TextBox txtMateriaDocente;
        private System.Windows.Forms.Label lblMateriaDocente;
        private System.Windows.Forms.Button btnUltimoDocente;
        private System.Windows.Forms.Button btnSiguienteDocente;
        private System.Windows.Forms.Button btnAnteriorDocente;
        private System.Windows.Forms.Button btnPrimerDocente;
        private System.Windows.Forms.Button btnNuevoDocente;
        private System.Windows.Forms.Button btnModificarDocente;
        private System.Windows.Forms.Button btnEliminarDocente;
        private System.Windows.Forms.Label lblTelefonoDocente;
        private System.Windows.Forms.GroupBox grbBusquedaDocente;
        private System.Windows.Forms.DataGridView grvBusqueda;
        private System.Windows.Forms.TextBox txtBusquedaDocente;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}

