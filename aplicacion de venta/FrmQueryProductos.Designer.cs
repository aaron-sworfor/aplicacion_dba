namespace Ventas_Pilarr
{
    partial class FrmQueryProductos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProdExi = new System.Windows.Forms.TextBox();
            this.cmbOperadores = new System.Windows.Forms.ComboBox();
            this.cmbFab = new System.Windows.Forms.ComboBox();
            this.rbtnProdConExi = new System.Windows.Forms.RadioButton();
            this.rbtnProdFab = new System.Windows.Forms.RadioButton();
            this.rbtnListaProd = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbInvProv = new System.Windows.Forms.ComboBox();
            this.rbtnEdoProd = new System.Windows.Forms.RadioButton();
            this.rbtnTotInvProv = new System.Windows.Forms.RadioButton();
            this.rbtnTotInv = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProdExi);
            this.groupBox1.Controls.Add(this.cmbOperadores);
            this.groupBox1.Controls.Add(this.cmbFab);
            this.groupBox1.Controls.Add(this.rbtnProdConExi);
            this.groupBox1.Controls.Add(this.rbtnProdFab);
            this.groupBox1.Controls.Add(this.rbtnListaProd);
            this.groupBox1.Location = new System.Drawing.Point(62, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(322, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // txtProdExi
            // 
            this.txtProdExi.Location = new System.Drawing.Point(224, 89);
            this.txtProdExi.Margin = new System.Windows.Forms.Padding(2);
            this.txtProdExi.Name = "txtProdExi";
            this.txtProdExi.Size = new System.Drawing.Size(76, 20);
            this.txtProdExi.TabIndex = 5;
            this.txtProdExi.Text = "0";
            // 
            // cmbOperadores
            // 
            this.cmbOperadores.FormattingEnabled = true;
            this.cmbOperadores.Location = new System.Drawing.Point(153, 88);
            this.cmbOperadores.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOperadores.Name = "cmbOperadores";
            this.cmbOperadores.Size = new System.Drawing.Size(62, 21);
            this.cmbOperadores.TabIndex = 4;
            // 
            // cmbFab
            // 
            this.cmbFab.FormattingEnabled = true;
            this.cmbFab.Location = new System.Drawing.Point(224, 40);
            this.cmbFab.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFab.Name = "cmbFab";
            this.cmbFab.Size = new System.Drawing.Size(92, 21);
            this.cmbFab.TabIndex = 3;
            // 
            // rbtnProdConExi
            // 
            this.rbtnProdConExi.AutoSize = true;
            this.rbtnProdConExi.Location = new System.Drawing.Point(5, 87);
            this.rbtnProdConExi.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnProdConExi.Name = "rbtnProdConExi";
            this.rbtnProdConExi.Size = new System.Drawing.Size(144, 17);
            this.rbtnProdConExi.TabIndex = 2;
            this.rbtnProdConExi.TabStop = true;
            this.rbtnProdConExi.Text = "Productos con existencia";
            this.rbtnProdConExi.UseVisualStyleBackColor = true;
            // 
            // rbtnProdFab
            // 
            this.rbtnProdFab.AutoSize = true;
            this.rbtnProdFab.Location = new System.Drawing.Point(5, 40);
            this.rbtnProdFab.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnProdFab.Name = "rbtnProdFab";
            this.rbtnProdFab.Size = new System.Drawing.Size(215, 17);
            this.rbtnProdFab.TabIndex = 1;
            this.rbtnProdFab.TabStop = true;
            this.rbtnProdFab.Text = "Productos que pertenecen al fabricante:";
            this.rbtnProdFab.UseVisualStyleBackColor = true;
            // 
            // rbtnListaProd
            // 
            this.rbtnListaProd.AutoSize = true;
            this.rbtnListaProd.Location = new System.Drawing.Point(5, 18);
            this.rbtnListaProd.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnListaProd.Name = "rbtnListaProd";
            this.rbtnListaProd.Size = new System.Drawing.Size(124, 17);
            this.rbtnListaProd.TabIndex = 0;
            this.rbtnListaProd.TabStop = true;
            this.rbtnListaProd.Text = "Listado de productos";
            this.rbtnListaProd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbInvProv);
            this.groupBox2.Controls.Add(this.rbtnEdoProd);
            this.groupBox2.Controls.Add(this.rbtnTotInvProv);
            this.groupBox2.Controls.Add(this.rbtnTotInv);
            this.groupBox2.Location = new System.Drawing.Point(456, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(318, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventario de Producto";
            // 
            // cmbInvProv
            // 
            this.cmbInvProv.FormattingEnabled = true;
            this.cmbInvProv.Location = new System.Drawing.Point(141, 62);
            this.cmbInvProv.Margin = new System.Windows.Forms.Padding(2);
            this.cmbInvProv.Name = "cmbInvProv";
            this.cmbInvProv.Size = new System.Drawing.Size(92, 21);
            this.cmbInvProv.TabIndex = 3;
            // 
            // rbtnEdoProd
            // 
            this.rbtnEdoProd.AutoSize = true;
            this.rbtnEdoProd.Location = new System.Drawing.Point(5, 62);
            this.rbtnEdoProd.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnEdoProd.Name = "rbtnEdoProd";
            this.rbtnEdoProd.Size = new System.Drawing.Size(139, 17);
            this.rbtnEdoProd.TabIndex = 2;
            this.rbtnEdoProd.TabStop = true;
            this.rbtnEdoProd.Text = "Estado de los productos";
            this.rbtnEdoProd.UseVisualStyleBackColor = true;
            // 
            // rbtnTotInvProv
            // 
            this.rbtnTotInvProv.AutoSize = true;
            this.rbtnTotInvProv.Location = new System.Drawing.Point(5, 40);
            this.rbtnTotInvProv.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnTotInvProv.Name = "rbtnTotInvProv";
            this.rbtnTotInvProv.Size = new System.Drawing.Size(188, 17);
            this.rbtnTotInvProv.TabIndex = 1;
            this.rbtnTotInvProv.TabStop = true;
            this.rbtnTotInvProv.Text = " Total del Inventario por proveedor";
            this.rbtnTotInvProv.UseVisualStyleBackColor = true;
            // 
            // rbtnTotInv
            // 
            this.rbtnTotInv.AutoSize = true;
            this.rbtnTotInv.Location = new System.Drawing.Point(5, 18);
            this.rbtnTotInv.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnTotInv.Name = "rbtnTotInv";
            this.rbtnTotInv.Size = new System.Drawing.Size(115, 17);
            this.rbtnTotInv.TabIndex = 0;
            this.rbtnTotInv.TabStop = true;
            this.rbtnTotInv.Text = "Total del inventario";
            this.rbtnTotInv.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 232);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(628, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mostrar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultas de Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Elige una opcion y luego preciona \"Mostrar\" para mostrar la consulta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(112, 270);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 216);
            this.dataGridView1.TabIndex = 5;
            // 
            // FrmQueryProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 522);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmQueryProductos";
            this.Text = "FrmQueryProductos";
            this.Load += new System.EventHandler(this.FrmQueryProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnProdFab;
        private System.Windows.Forms.RadioButton rbtnListaProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnProdConExi;
        private System.Windows.Forms.RadioButton rbtnEdoProd;
        private System.Windows.Forms.RadioButton rbtnTotInvProv;
        private System.Windows.Forms.RadioButton rbtnTotInv;
        private System.Windows.Forms.TextBox txtProdExi;
        private System.Windows.Forms.ComboBox cmbOperadores;
        private System.Windows.Forms.ComboBox cmbFab;
        private System.Windows.Forms.ComboBox cmbInvProv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}