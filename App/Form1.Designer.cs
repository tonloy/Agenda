namespace App
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNumeroContactos = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.txbFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dtgContactos = new System.Windows.Forms.DataGridView();
            this.cNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNumeroContactos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 483);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(678, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblNumeroContactos
            // 
            this.lblNumeroContactos.BackColor = System.Drawing.SystemColors.Control;
            this.lblNumeroContactos.Name = "lblNumeroContactos";
            this.lblNumeroContactos.Size = new System.Drawing.Size(139, 17);
            this.lblNumeroContactos.Text = "0 Contactos Encontrados";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnEliminar,
            this.toolStripSeparator2,
            this.btnEditar,
            this.toolStripSeparator3,
            this.btnAgregar,
            this.toolStripSeparator4,
            this.txbFiltrar,
            this.toolStripLabel1,
            this.btnExportar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(678, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(57, 22);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 22);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // txbFiltrar
            // 
            this.txbFiltrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txbFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFiltrar.Name = "txbFiltrar";
            this.txbFiltrar.Size = new System.Drawing.Size(200, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel1.Text = "Filtrar";
            // 
            // dtgContactos
            // 
            this.dtgContactos.AllowUserToAddRows = false;
            this.dtgContactos.AllowUserToDeleteRows = false;
            this.dtgContactos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgContactos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgContactos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContactos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNombres,
            this.cApellidos,
            this.cFechaNacimiento,
            this.cCorreo,
            this.cTelefono});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgContactos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgContactos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgContactos.Location = new System.Drawing.Point(0, 25);
            this.dtgContactos.MultiSelect = false;
            this.dtgContactos.Name = "dtgContactos";
            this.dtgContactos.ReadOnly = true;
            this.dtgContactos.RowHeadersVisible = false;
            this.dtgContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgContactos.Size = new System.Drawing.Size(678, 458);
            this.dtgContactos.TabIndex = 2;
            // 
            // cNombres
            // 
            this.cNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNombres.DataPropertyName = "Nombres";
            this.cNombres.HeaderText = "Nombres";
            this.cNombres.Name = "cNombres";
            this.cNombres.ReadOnly = true;
            // 
            // cApellidos
            // 
            this.cApellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cApellidos.DataPropertyName = "Apellidos";
            this.cApellidos.HeaderText = "Apellidos";
            this.cApellidos.Name = "cApellidos";
            this.cApellidos.ReadOnly = true;
            // 
            // cFechaNacimiento
            // 
            this.cFechaNacimiento.DataPropertyName = "Nacimiento";
            this.cFechaNacimiento.HeaderText = "Nacimiento";
            this.cFechaNacimiento.Name = "cFechaNacimiento";
            this.cFechaNacimiento.ReadOnly = true;
            // 
            // cCorreo
            // 
            this.cCorreo.DataPropertyName = "Correo";
            this.cCorreo.HeaderText = "Correo";
            this.cCorreo.Name = "cCorreo";
            this.cCorreo.ReadOnly = true;
            // 
            // cTelefono
            // 
            this.cTelefono.DataPropertyName = "Telefono";
            this.cTelefono.HeaderText = "Telefono";
            this.cTelefono.Name = "cTelefono";
            this.cTelefono.ReadOnly = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(70, 22);
            this.btnExportar.Text = "Exportar";
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(678, 505);
            this.Controls.Add(this.dtgContactos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dtgContactos;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox txbFiltrar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblNumeroContactos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTelefono;
        private System.Windows.Forms.ToolStripButton btnExportar;
    }
}

