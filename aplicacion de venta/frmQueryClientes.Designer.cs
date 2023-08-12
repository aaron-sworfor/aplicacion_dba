namespace Ventas_Pilarr
{
    partial class frmQueryClientes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProdExi = new System.Windows.Forms.TextBox();
            this.cmbOperadores = new System.Windows.Forms.ComboBox();
            this.cmbFab = new System.Windows.Forms.ComboBox();
            this.rbtnProdConExi = new System.Windows.Forms.RadioButton();
            this.rbtnProdFab = new System.Windows.Forms.RadioButton();
            this.rbtnListaProd = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 212);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 216);
            this.dataGridView1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(628, 19);
            this.button1.TabIndex = 8;
            this.button1.Text = "Mostrar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProdExi);
            this.groupBox1.Controls.Add(this.cmbOperadores);
            this.groupBox1.Controls.Add(this.cmbFab);
            this.groupBox1.Controls.Add(this.rbtnProdConExi);
            this.groupBox1.Controls.Add(this.rbtnProdFab);
            this.groupBox1.Controls.Add(this.rbtnListaProd);
            this.groupBox1.Location = new System.Drawing.Point(251, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(322, 132);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
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
            this.rbtnProdConExi.Size = new System.Drawing.Size(98, 17);
            this.rbtnProdConExi.TabIndex = 2;
            this.rbtnProdConExi.TabStop = true;
            this.rbtnProdConExi.Text = "limite de credito";
            this.rbtnProdConExi.UseVisualStyleBackColor = true;
            // 
            // rbtnProdFab
            // 
            this.rbtnProdFab.AutoSize = true;
            this.rbtnProdFab.Location = new System.Drawing.Point(5, 40);
            this.rbtnProdFab.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnProdFab.Name = "rbtnProdFab";
            this.rbtnProdFab.Size = new System.Drawing.Size(225, 17);
            this.rbtnProdFab.TabIndex = 1;
            this.rbtnProdFab.TabStop = true;
            this.rbtnProdFab.Text = "Clientes que pertenecen al representante: ";
            this.rbtnProdFab.UseVisualStyleBackColor = true;
            // 
            // rbtnListaProd
            // 
            this.rbtnListaProd.AutoSize = true;
            this.rbtnListaProd.Location = new System.Drawing.Point(5, 18);
            this.rbtnListaProd.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnListaProd.Name = "rbtnListaProd";
            this.rbtnListaProd.Size = new System.Drawing.Size(113, 17);
            this.rbtnListaProd.TabIndex = 0;
            this.rbtnListaProd.TabStop = true;
            this.rbtnListaProd.Text = "Listado de clientes";
            this.rbtnListaProd.UseVisualStyleBackColor = true;
            // 
            // frmQueryClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQueryClientes";
            this.Text = "frmQueryClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProdExi;
        private System.Windows.Forms.ComboBox cmbOperadores;
        private System.Windows.Forms.ComboBox cmbFab;
        private System.Windows.Forms.RadioButton rbtnProdConExi;
        private System.Windows.Forms.RadioButton rbtnProdFab;
        private System.Windows.Forms.RadioButton rbtnListaProd;
    }
}