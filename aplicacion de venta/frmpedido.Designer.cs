namespace Ventas_Pilarr
{
    partial class frmpedido
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
            this.lblnumpedido = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblnumcliente = new System.Windows.Forms.Label();
            this.dtFechapedido = new System.Windows.Forms.DateTimePicker();
            this.lblrep = new System.Windows.Forms.Label();
            this.cmbventas = new System.Windows.Forms.ComboBox();
            this.dgdetalles = new System.Windows.Forms.DataGridView();
            this.idfab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preciounitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbloficina = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumped = new System.Windows.Forms.Label();
            this.txtnumcliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnumpedido
            // 
            this.lblnumpedido.AutoSize = true;
            this.lblnumpedido.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumpedido.Location = new System.Drawing.Point(48, 33);
            this.lblnumpedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnumpedido.Name = "lblnumpedido";
            this.lblnumpedido.Size = new System.Drawing.Size(121, 17);
            this.lblnumpedido.TabIndex = 0;
            this.lblnumpedido.Text = "Numero de Pedido";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(48, 76);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(106, 17);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "Fecha de Pedido";
            // 
            // lblnumcliente
            // 
            this.lblnumcliente.AutoSize = true;
            this.lblnumcliente.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumcliente.Location = new System.Drawing.Point(48, 119);
            this.lblnumcliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnumcliente.Name = "lblnumcliente";
            this.lblnumcliente.Size = new System.Drawing.Size(86, 17);
            this.lblnumcliente.TabIndex = 3;
            this.lblnumcliente.Text = "Num. Cliente";
            // 
            // dtFechapedido
            // 
            this.dtFechapedido.Location = new System.Drawing.Point(282, 81);
            this.dtFechapedido.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechapedido.Name = "dtFechapedido";
            this.dtFechapedido.Size = new System.Drawing.Size(186, 20);
            this.dtFechapedido.TabIndex = 5;
            // 
            // lblrep
            // 
            this.lblrep.AutoSize = true;
            this.lblrep.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrep.Location = new System.Drawing.Point(48, 157);
            this.lblrep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblrep.Name = "lblrep";
            this.lblrep.Size = new System.Drawing.Size(159, 17);
            this.lblrep.TabIndex = 6;
            this.lblrep.Text = "Representante de Ventas";
            // 
            // cmbventas
            // 
            this.cmbventas.FormattingEnabled = true;
            this.cmbventas.Location = new System.Drawing.Point(282, 162);
            this.cmbventas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbventas.Name = "cmbventas";
            this.cmbventas.Size = new System.Drawing.Size(186, 21);
            this.cmbventas.TabIndex = 7;
            this.cmbventas.SelectedIndexChanged += new System.EventHandler(this.cmbventas_SelectedIndexChanged);
            // 
            // dgdetalles
            // 
            this.dgdetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfab,
            this.Idproducto,
            this.Cantidad,
            this.Descripcion,
            this.Preciounitario,
            this.Importe});
            this.dgdetalles.Location = new System.Drawing.Point(100, 234);
            this.dgdetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dgdetalles.Name = "dgdetalles";
            this.dgdetalles.RowHeadersWidth = 51;
            this.dgdetalles.RowTemplate.Height = 24;
            this.dgdetalles.Size = new System.Drawing.Size(604, 169);
            this.dgdetalles.TabIndex = 8;
            this.dgdetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdetalles_CellContentClick);
            // 
            // idfab
            // 
            this.idfab.HeaderText = "idfab";
            this.idfab.MinimumWidth = 6;
            this.idfab.Name = "idfab";
            this.idfab.Width = 125;
            // 
            // Idproducto
            // 
            this.Idproducto.HeaderText = "Idproducto";
            this.Idproducto.MinimumWidth = 6;
            this.Idproducto.Name = "Idproducto";
            this.Idproducto.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // Preciounitario
            // 
            this.Preciounitario.HeaderText = "Preciounitario";
            this.Preciounitario.MinimumWidth = 6;
            this.Preciounitario.Name = "Preciounitario";
            this.Preciounitario.Width = 125;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 6;
            this.Importe.Name = "Importe";
            this.Importe.Width = 125;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(523, 84);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(59, 20);
            this.lbltotal.TabIndex = 9;
            this.lbltotal.Text = "TOTAL";
            this.lbltotal.Click += new System.EventHandler(this.lbltotal_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(612, 81);
            this.txttotal.Margin = new System.Windows.Forms.Padding(2);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(113, 20);
            this.txttotal.TabIndex = 10;
            // 
            // lbloficina
            // 
            this.lbloficina.AutoSize = true;
            this.lbloficina.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloficina.Location = new System.Drawing.Point(278, 200);
            this.lbloficina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbloficina.Name = "lbloficina";
            this.lbloficina.Size = new System.Drawing.Size(0, 23);
            this.lbloficina.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(504, 124);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 34);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(647, 124);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 34);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Oficina";
            // 
            // txtnumped
            // 
            this.txtnumped.AutoSize = true;
            this.txtnumped.Location = new System.Drawing.Point(282, 33);
            this.txtnumped.Name = "txtnumped";
            this.txtnumped.Size = new System.Drawing.Size(35, 13);
            this.txtnumped.TabIndex = 15;
            this.txtnumped.Text = "label2";
            // 
            // txtnumcliente
            // 
            this.txtnumcliente.FormattingEnabled = true;
            this.txtnumcliente.Location = new System.Drawing.Point(282, 119);
            this.txtnumcliente.Name = "txtnumcliente";
            this.txtnumcliente.Size = new System.Drawing.Size(121, 21);
            this.txtnumcliente.TabIndex = 16;
            // 
            // frmpedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 424);
            this.Controls.Add(this.txtnumcliente);
            this.Controls.Add(this.txtnumped);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbloficina);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.dgdetalles);
            this.Controls.Add(this.cmbventas);
            this.Controls.Add(this.lblrep);
            this.Controls.Add(this.dtFechapedido);
            this.Controls.Add(this.lblnumcliente);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblnumpedido);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmpedido";
            this.Text = "frmpedido";
            this.Load += new System.EventHandler(this.frmpedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumpedido;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblnumcliente;
        private System.Windows.Forms.DateTimePicker dtFechapedido;
        private System.Windows.Forms.Label lblrep;
        private System.Windows.Forms.ComboBox cmbventas;
        private System.Windows.Forms.DataGridView dgdetalles;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lbloficina;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preciounitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtnumped;
        private System.Windows.Forms.ComboBox txtnumcliente;
    }
}