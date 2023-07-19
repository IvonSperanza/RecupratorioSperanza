namespace RecupratorioSperanza
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
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.cbxNombreCliente = new System.Windows.Forms.ComboBox();
            this.cbxDniCliente = new System.Windows.Forms.ComboBox();
            this.cbxApellidoCliente = new System.Windows.Forms.ComboBox();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.cbxTelefonoCliente = new System.Windows.Forms.ComboBox();
            this.cbxPrecioProducto = new System.Windows.Forms.ComboBox();
            this.cbxCantidadProducto = new System.Windows.Forms.ComboBox();
            this.cbxCodigoProducto = new System.Windows.Forms.ComboBox();
            this.cbxNombreProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxProductoFactura = new System.Windows.Forms.ComboBox();
            this.cbxClienteFactura = new System.Windows.Forms.ComboBox();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxNumeroFactura = new System.Windows.Forms.ComboBox();
            this.btnEliminarFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(12, 63);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(92, 67);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.Text = " Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(67, 157);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(287, 6);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(92, 35);
            this.btnCliente.TabIndex = 7;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // cbxNombreCliente
            // 
            this.cbxNombreCliente.FormattingEnabled = true;
            this.cbxNombreCliente.Location = new System.Drawing.Point(304, 47);
            this.cbxNombreCliente.Name = "cbxNombreCliente";
            this.cbxNombreCliente.Size = new System.Drawing.Size(121, 28);
            this.cbxNombreCliente.TabIndex = 12;
            this.cbxNombreCliente.Text = "Nombre";
            // 
            // cbxDniCliente
            // 
            this.cbxDniCliente.FormattingEnabled = true;
            this.cbxDniCliente.Location = new System.Drawing.Point(304, 117);
            this.cbxDniCliente.Name = "cbxDniCliente";
            this.cbxDniCliente.Size = new System.Drawing.Size(121, 28);
            this.cbxDniCliente.TabIndex = 14;
            this.cbxDniCliente.Text = "DNI";
            // 
            // cbxApellidoCliente
            // 
            this.cbxApellidoCliente.FormattingEnabled = true;
            this.cbxApellidoCliente.Location = new System.Drawing.Point(304, 83);
            this.cbxApellidoCliente.Name = "cbxApellidoCliente";
            this.cbxApellidoCliente.Size = new System.Drawing.Size(121, 28);
            this.cbxApellidoCliente.TabIndex = 15;
            this.cbxApellidoCliente.Text = "Apellido";
            // 
            // dgvFactura
            // 
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(12, 203);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.RowHeadersWidth = 62;
            this.dgvFactura.RowTemplate.Height = 28;
            this.dgvFactura.Size = new System.Drawing.Size(637, 196);
            this.dgvFactura.TabIndex = 0;
            this.dgvFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellContentClick);
            // 
            // cbxTelefonoCliente
            // 
            this.cbxTelefonoCliente.FormattingEnabled = true;
            this.cbxTelefonoCliente.Location = new System.Drawing.Point(304, 151);
            this.cbxTelefonoCliente.Name = "cbxTelefonoCliente";
            this.cbxTelefonoCliente.Size = new System.Drawing.Size(121, 28);
            this.cbxTelefonoCliente.TabIndex = 13;
            this.cbxTelefonoCliente.Text = "Telefono";
            // 
            // cbxPrecioProducto
            // 
            this.cbxPrecioProducto.FormattingEnabled = true;
            this.cbxPrecioProducto.Location = new System.Drawing.Point(132, 68);
            this.cbxPrecioProducto.Name = "cbxPrecioProducto";
            this.cbxPrecioProducto.Size = new System.Drawing.Size(121, 28);
            this.cbxPrecioProducto.TabIndex = 19;
            this.cbxPrecioProducto.Text = "Producto";
            // 
            // cbxCantidadProducto
            // 
            this.cbxCantidadProducto.FormattingEnabled = true;
            this.cbxCantidadProducto.Location = new System.Drawing.Point(132, 102);
            this.cbxCantidadProducto.Name = "cbxCantidadProducto";
            this.cbxCantidadProducto.Size = new System.Drawing.Size(121, 28);
            this.cbxCantidadProducto.TabIndex = 18;
            this.cbxCantidadProducto.Text = "Cantidad";
            // 
            // cbxCodigoProducto
            // 
            this.cbxCodigoProducto.FormattingEnabled = true;
            this.cbxCodigoProducto.Location = new System.Drawing.Point(132, 136);
            this.cbxCodigoProducto.Name = "cbxCodigoProducto";
            this.cbxCodigoProducto.Size = new System.Drawing.Size(121, 28);
            this.cbxCodigoProducto.TabIndex = 17;
            this.cbxCodigoProducto.Text = "Codigo";
            // 
            // cbxNombreProducto
            // 
            this.cbxNombreProducto.FormattingEnabled = true;
            this.cbxNombreProducto.Location = new System.Drawing.Point(132, 32);
            this.cbxNombreProducto.Name = "cbxNombreProducto";
            this.cbxNombreProducto.Size = new System.Drawing.Size(121, 28);
            this.cbxNombreProducto.TabIndex = 16;
            this.cbxNombreProducto.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Producto";
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Location = new System.Drawing.Point(269, 109);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(13, 20);
            this.lblCantidadProducto.TabIndex = 21;
            this.lblCantidadProducto.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = ".";
            // 
            // cbxProductoFactura
            // 
            this.cbxProductoFactura.FormattingEnabled = true;
            this.cbxProductoFactura.Location = new System.Drawing.Point(550, 102);
            this.cbxProductoFactura.Name = "cbxProductoFactura";
            this.cbxProductoFactura.Size = new System.Drawing.Size(121, 28);
            this.cbxProductoFactura.TabIndex = 24;
            this.cbxProductoFactura.Text = "Producto";
            // 
            // cbxClienteFactura
            // 
            this.cbxClienteFactura.FormattingEnabled = true;
            this.cbxClienteFactura.Location = new System.Drawing.Point(550, 136);
            this.cbxClienteFactura.Name = "cbxClienteFactura";
            this.cbxClienteFactura.Size = new System.Drawing.Size(121, 28);
            this.cbxClienteFactura.TabIndex = 23;
            this.cbxClienteFactura.Text = "Cliente";
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Location = new System.Drawing.Point(550, 68);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaFactura.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Factura";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbxNumeroFactura
            // 
            this.cbxNumeroFactura.FormattingEnabled = true;
            this.cbxNumeroFactura.Location = new System.Drawing.Point(550, 37);
            this.cbxNumeroFactura.Name = "cbxNumeroFactura";
            this.cbxNumeroFactura.Size = new System.Drawing.Size(121, 28);
            this.cbxNumeroFactura.TabIndex = 30;
            this.cbxNumeroFactura.Text = "Numero";
            // 
            // btnEliminarFactura
            // 
            this.btnEliminarFactura.Location = new System.Drawing.Point(675, 203);
            this.btnEliminarFactura.Name = "btnEliminarFactura";
            this.btnEliminarFactura.Size = new System.Drawing.Size(92, 67);
            this.btnEliminarFactura.TabIndex = 31;
            this.btnEliminarFactura.Text = "Eliminar Factura";
            this.btnEliminarFactura.UseVisualStyleBackColor = true;
            this.btnEliminarFactura.Click += new System.EventHandler(this.btnEliminarFactura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarFactura);
            this.Controls.Add(this.cbxNumeroFactura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxProductoFactura);
            this.Controls.Add(this.cbxClienteFactura);
            this.Controls.Add(this.lblCantidadProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPrecioProducto);
            this.Controls.Add(this.cbxCantidadProducto);
            this.Controls.Add(this.cbxCodigoProducto);
            this.Controls.Add(this.cbxNombreProducto);
            this.Controls.Add(this.cbxApellidoCliente);
            this.Controls.Add(this.cbxDniCliente);
            this.Controls.Add(this.cbxTelefonoCliente);
            this.Controls.Add(this.cbxNombreCliente);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvFactura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.ComboBox cbxNombreCliente;
        private System.Windows.Forms.ComboBox cbxDniCliente;
        private System.Windows.Forms.ComboBox cbxApellidoCliente;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.ComboBox cbxTelefonoCliente;
        private System.Windows.Forms.ComboBox cbxPrecioProducto;
        private System.Windows.Forms.ComboBox cbxCantidadProducto;
        private System.Windows.Forms.ComboBox cbxCodigoProducto;
        private System.Windows.Forms.ComboBox cbxNombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxProductoFactura;
        private System.Windows.Forms.ComboBox cbxClienteFactura;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxNumeroFactura;
        private System.Windows.Forms.Button btnEliminarFactura;
    }
}

