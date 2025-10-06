namespace MercatoManager
{
    partial class Form1
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
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.groupBoxProductos = new System.Windows.Forms.GroupBox();
            this.groupBoxAsignacion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBoxClientes.SuspendLayout();
            this.groupBoxProductos.SuspendLayout();
            this.groupBoxAsignacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxClientes
            //
            this.groupBoxClientes.Controls.Add(this.dgvClientes);
            this.groupBoxClientes.Controls.Add(this.label1);
            this.groupBoxClientes.Controls.Add(this.label2);
            this.groupBoxClientes.Controls.Add(this.label3);
            this.groupBoxClientes.Controls.Add(this.label4);
            this.groupBoxClientes.Controls.Add(this.txtNombres);
            this.groupBoxClientes.Controls.Add(this.txtApellidos);
            this.groupBoxClientes.Controls.Add(this.txtDNI);
            this.groupBoxClientes.Controls.Add(this.txtCelular);
            this.groupBoxClientes.Controls.Add(this.btnAgregarCliente);
            this.groupBoxClientes.Location = new System.Drawing.Point(20, 20);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxClientes.Size = new System.Drawing.Size(860, 260);
            this.groupBoxClientes.TabIndex = 0;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Registro de Clientes";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(20, 50);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(180, 23);
            this.txtNombres.TabIndex = 0;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(215, 50);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(180, 23);
            this.txtApellidos.TabIndex = 1;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(410, 50);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(130, 23);
            this.txtDNI.TabIndex = 2;
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Celular:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(555, 50);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(130, 23);
            this.txtCelular.TabIndex = 3;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(700, 50);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(140, 30);
            this.btnAgregarCliente.TabIndex = 4;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.BtnAgregarCliente_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(20, 95);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.Size = new System.Drawing.Size(820, 145);
            this.dgvClientes.TabIndex = 5;
            //
            // groupBoxProductos
            //
            this.groupBoxProductos.Controls.Add(this.dgvProductos);
            this.groupBoxProductos.Controls.Add(this.label5);
            this.groupBoxProductos.Controls.Add(this.label6);
            this.groupBoxProductos.Controls.Add(this.label7);
            this.groupBoxProductos.Controls.Add(this.label8);
            this.groupBoxProductos.Controls.Add(this.txtCodigo);
            this.groupBoxProductos.Controls.Add(this.txtNombreProd);
            this.groupBoxProductos.Controls.Add(this.txtCategoria);
            this.groupBoxProductos.Controls.Add(this.txtPrecio);
            this.groupBoxProductos.Controls.Add(this.btnAgregarProducto);
            this.groupBoxProductos.Location = new System.Drawing.Point(20, 295);
            this.groupBoxProductos.Name = "groupBoxProductos";
            this.groupBoxProductos.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxProductos.Size = new System.Drawing.Size(860, 260);
            this.groupBoxProductos.TabIndex = 1;
            this.groupBoxProductos.TabStop = false;
            this.groupBoxProductos.Text = "Registro de Productos";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(20, 50);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(150, 23);
            this.txtCodigo.TabIndex = 0;
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre:";
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(185, 50);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(220, 23);
            this.txtNombreProd.TabIndex = 1;
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Categoría:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(420, 50);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(170, 23);
            this.txtCategoria.TabIndex = 2;
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(605, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(605, 50);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 3;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(715, 50);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(125, 30);
            this.btnAgregarProducto.TabIndex = 4;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(20, 95);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(820, 145);
            this.dgvProductos.TabIndex = 5;
            //
            // groupBoxAsignacion
            //
            this.groupBoxAsignacion.Controls.Add(this.label9);
            this.groupBoxAsignacion.Controls.Add(this.label10);
            this.groupBoxAsignacion.Controls.Add(this.cmbClientes);
            this.groupBoxAsignacion.Controls.Add(this.cmbProductos);
            this.groupBoxAsignacion.Controls.Add(this.btnAsignar);
            this.groupBoxAsignacion.Controls.Add(this.lblTotal);
            this.groupBoxAsignacion.Location = new System.Drawing.Point(20, 570);
            this.groupBoxAsignacion.Name = "groupBoxAsignacion";
            this.groupBoxAsignacion.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxAsignacion.Size = new System.Drawing.Size(860, 130);
            this.groupBoxAsignacion.TabIndex = 2;
            this.groupBoxAsignacion.TabStop = false;
            this.groupBoxAsignacion.Text = "Asignación de Productos a Clientes";
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Seleccionar Cliente:";
            // 
            // cmbClientes
            //
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(20, 50);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(280, 23);
            this.cmbClientes.TabIndex = 0;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            //
            // label10
            //
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Seleccionar Producto:";
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(320, 50);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(360, 23);
            this.cmbProductos.TabIndex = 1;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(695, 45);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(145, 35);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar Producto";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // lblTotal
            //
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(20, 95);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(147, 19);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total Gastado: S/ 0.00";
            //
            // label11
            //
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 15);
            this.label11.TabIndex = 0;
            this.label11.Visible = false;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 720);
            this.Controls.Add(this.groupBoxAsignacion);
            this.Controls.Add(this.groupBoxProductos);
            this.Controls.Add(this.groupBoxClientes);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MercatoManager - Sistema de Gestión";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBoxClientes.ResumeLayout(false);
            this.groupBoxClientes.PerformLayout();
            this.groupBoxProductos.ResumeLayout(false);
            this.groupBoxProductos.PerformLayout();
            this.groupBoxAsignacion.ResumeLayout(false);
            this.groupBoxAsignacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.GroupBox groupBoxProductos;
        private System.Windows.Forms.GroupBox groupBoxAsignacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}