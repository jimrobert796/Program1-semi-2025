namespace miPrimerProyectoCsharp
{
    partial class FrmNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblIdNota;
            System.Windows.Forms.Label lblmateria;
            System.Windows.Forms.Label lblPeriodo;
            System.Windows.Forms.Label lblFecha;
            this.idNotaLabel1 = new System.Windows.Forms.Label();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_academicaDataSet = new miPrimerProyectoCsharp.db_academicaDataSet();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.materiasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.materiasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cboPeriodos = new System.Windows.Forms.ComboBox();
            this.periodosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.periodosBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.periodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.notasTableAdapter = new miPrimerProyectoCsharp.db_academicaDataSetTableAdapters.notasTableAdapter();
            this.tableAdapterManager = new miPrimerProyectoCsharp.db_academicaDataSetTableAdapters.TableAdapterManager();
            this.dnotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dnotasTableAdapter = new miPrimerProyectoCsharp.db_academicaDataSetTableAdapters.dnotasTableAdapter();
            this.grdNotas = new System.Windows.Forms.DataGridView();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiasTableAdapter = new miPrimerProyectoCsharp.db_academicaDataSetTableAdapters.materiasTableAdapter();
            this.materiasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.periodosTableAdapter = new miPrimerProyectoCsharp.db_academicaDataSetTableAdapters.periodosTableAdapter();
            this.periodosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.periodosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.idDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblIdNota = new System.Windows.Forms.Label();
            lblmateria = new System.Windows.Forms.Label();
            lblPeriodo = new System.Windows.Forms.Label();
            lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdNota
            // 
            lblIdNota.AutoSize = true;
            lblIdNota.Location = new System.Drawing.Point(18, 43);
            lblIdNota.Name = "lblIdNota";
            lblIdNota.Size = new System.Drawing.Size(45, 13);
            lblIdNota.TabIndex = 1;
            lblIdNota.Text = "Id Nota:";
            // 
            // lblmateria
            // 
            lblmateria.AutoSize = true;
            lblmateria.Location = new System.Drawing.Point(18, 72);
            lblmateria.Name = "lblmateria";
            lblmateria.Size = new System.Drawing.Size(45, 13);
            lblmateria.TabIndex = 3;
            lblmateria.Text = "Materia:";
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Location = new System.Drawing.Point(318, 72);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new System.Drawing.Size(46, 13);
            lblPeriodo.TabIndex = 5;
            lblPeriodo.Text = "Periodo:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new System.Drawing.Point(18, 115);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(37, 13);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "fecha:";
            // 
            // idNotaLabel1
            // 
            this.idNotaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "IdNota", true));
            this.idNotaLabel1.Location = new System.Drawing.Point(81, 43);
            this.idNotaLabel1.Name = "idNotaLabel1";
            this.idNotaLabel1.Size = new System.Drawing.Size(200, 23);
            this.idNotaLabel1.TabIndex = 2;
            this.idNotaLabel1.Text = ".";
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "notas";
            this.notasBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // db_academicaDataSet
            // 
            this.db_academicaDataSet.DataSetName = "db_academicaDataSet";
            this.db_academicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboMateria
            // 
            this.cboMateria.DataSource = this.materiasBindingSource3;
            this.cboMateria.DisplayMember = "nombre";
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(81, 69);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(200, 21);
            this.cboMateria.TabIndex = 4;
            this.cboMateria.ValueMember = "IdMateria";
            this.cboMateria.SelectedIndexChanged += new System.EventHandler(this.cboMateria_SelectedIndexChanged);
            // 
            // materiasBindingSource2
            // 
            this.materiasBindingSource2.DataMember = "materias";
            this.materiasBindingSource2.DataSource = this.db_academicaDataSet;
            // 
            // materiasBindingSource3
            // 
            this.materiasBindingSource3.DataMember = "materias";
            this.materiasBindingSource3.DataSource = this.db_academicaDataSet;
            // 
            // cboPeriodos
            // 
            this.cboPeriodos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.periodosBindingSource3, "periodo", true));
            this.cboPeriodos.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.periodosBindingSource4, "IdPeriodo", true));
            this.cboPeriodos.DataSource = this.periodosBindingSource;
            this.cboPeriodos.DisplayMember = "periodo";
            this.cboPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodos.FormattingEnabled = true;
            this.cboPeriodos.Location = new System.Drawing.Point(381, 69);
            this.cboPeriodos.Name = "cboPeriodos";
            this.cboPeriodos.Size = new System.Drawing.Size(200, 21);
            this.cboPeriodos.TabIndex = 6;
            this.cboPeriodos.ValueMember = "IdPeriodo";
            this.cboPeriodos.SelectedIndexChanged += new System.EventHandler(this.cboPeriodos_SelectedIndexChanged);
            // 
            // periodosBindingSource3
            // 
            this.periodosBindingSource3.DataMember = "periodos";
            this.periodosBindingSource3.DataSource = this.db_academicaDataSet;
            // 
            // periodosBindingSource4
            // 
            this.periodosBindingSource4.DataMember = "periodos";
            this.periodosBindingSource4.DataSource = this.db_academicaDataSet;
            // 
            // periodosBindingSource
            // 
            this.periodosBindingSource.DataMember = "periodos";
            this.periodosBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notasBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(81, 111);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 8;
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alumnosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dnotasTableAdapter = null;
            this.tableAdapterManager.materiasTableAdapter = null;
            this.tableAdapterManager.notasTableAdapter = this.notasTableAdapter;
            this.tableAdapterManager.periodosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = miPrimerProyectoCsharp.db_academicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dnotasBindingSource
            // 
            this.dnotasBindingSource.DataMember = "dnotas";
            this.dnotasBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // dnotasTableAdapter
            // 
            this.dnotasTableAdapter.ClearBeforeFill = true;
            // 
            // grdNotas
            // 
            this.grdNotas.AllowUserToAddRows = false;
            this.grdNotas.AllowUserToDeleteRows = false;
            this.grdNotas.AutoGenerateColumns = false;
            this.grdNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalle,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.alumno,
            this.lab1,
            this.lab2,
            this.parcial,
            this.nota_final});
            this.grdNotas.DataSource = this.dnotasBindingSource;
            this.grdNotas.Location = new System.Drawing.Point(21, 165);
            this.grdNotas.Name = "grdNotas";
            this.grdNotas.Size = new System.Drawing.Size(644, 220);
            this.grdNotas.TabIndex = 8;
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "materias";
            this.materiasBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // materiasBindingSource1
            // 
            this.materiasBindingSource1.DataMember = "materias";
            this.materiasBindingSource1.DataSource = this.db_academicaDataSet;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // periodosTableAdapter
            // 
            this.periodosTableAdapter.ClearBeforeFill = true;
            // 
            // periodosBindingSource1
            // 
            this.periodosBindingSource1.DataMember = "periodos";
            this.periodosBindingSource1.DataSource = this.db_academicaDataSet;
            // 
            // periodosBindingSource2
            // 
            this.periodosBindingSource2.DataMember = "periodos";
            this.periodosBindingSource2.DataSource = this.db_academicaDataSet;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(709, 231);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 48);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // idDetalle
            // 
            this.idDetalle.DataPropertyName = "IdDetalle";
            this.idDetalle.HeaderText = "IdDetalle";
            this.idDetalle.Name = "idDetalle";
            this.idDetalle.ReadOnly = true;
            this.idDetalle.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idNota";
            this.dataGridViewTextBoxColumn1.HeaderText = "idNota";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idMateria";
            this.dataGridViewTextBoxColumn3.HeaderText = "idMateria";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // alumno
            // 
            this.alumno.DataPropertyName = "nombre";
            this.alumno.HeaderText = "ALUMNO";
            this.alumno.Name = "alumno";
            this.alumno.ReadOnly = true;
            this.alumno.Width = 200;
            // 
            // lab1
            // 
            this.lab1.DataPropertyName = "lab1";
            this.lab1.HeaderText = "LAB1";
            this.lab1.Name = "lab1";
            // 
            // lab2
            // 
            this.lab2.DataPropertyName = "lab2";
            this.lab2.HeaderText = "LAB2";
            this.lab2.Name = "lab2";
            // 
            // parcial
            // 
            this.parcial.DataPropertyName = "parcial";
            this.parcial.HeaderText = "PARCIAL";
            this.parcial.Name = "parcial";
            // 
            // nota_final
            // 
            this.nota_final.DataPropertyName = "nf";
            this.nota_final.HeaderText = "NF";
            this.nota_final.Name = "nota_final";
            this.nota_final.ReadOnly = true;
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 446);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grdNotas);
            this.Controls.Add(lblIdNota);
            this.Controls.Add(this.idNotaLabel1);
            this.Controls.Add(lblmateria);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(lblPeriodo);
            this.Controls.Add(this.cboPeriodos);
            this.Controls.Add(lblFecha);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Name = "FrmNotas";
            this.Text = "FrmNotas";
            this.Load += new System.EventHandler(this.FrmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_academicaDataSet db_academicaDataSet;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private db_academicaDataSetTableAdapters.notasTableAdapter notasTableAdapter;
        private db_academicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idNotaLabel1;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.ComboBox cboPeriodos;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.BindingSource dnotasBindingSource;
        private db_academicaDataSetTableAdapters.dnotasTableAdapter dnotasTableAdapter;
        private System.Windows.Forms.DataGridView grdNotas;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private db_academicaDataSetTableAdapters.materiasTableAdapter materiasTableAdapter;
        private System.Windows.Forms.BindingSource materiasBindingSource1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingSource periodosBindingSource;
        private db_academicaDataSetTableAdapters.periodosTableAdapter periodosTableAdapter;
        private System.Windows.Forms.BindingSource periodosBindingSource1;
        private System.Windows.Forms.BindingSource periodosBindingSource2;
        private System.Windows.Forms.BindingSource materiasBindingSource2;
        private System.Windows.Forms.BindingSource materiasBindingSource3;
        private System.Windows.Forms.BindingSource periodosBindingSource3;
        private System.Windows.Forms.BindingSource periodosBindingSource4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab2;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota_final;
    }
}