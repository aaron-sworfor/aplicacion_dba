namespace Ventas_Pilarr
{
    partial class FrmQueryRepresentante
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbtitulo = new System.Windows.Forms.ComboBox();
            this.rbtntitulo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.cmbOperadores = new System.Windows.Forms.ComboBox();
            this.director = new System.Windows.Forms.ComboBox();
            this.rbtnedad = new System.Windows.Forms.RadioButton();
            this.rbtndirector = new System.Windows.Forms.RadioButton();
            this.rbtnListarep = new System.Windows.Forms.RadioButton();
            this.cmboficina = new System.Windows.Forms.ComboBox();
            this.radiooficina = new System.Windows.Forms.RadioButton();
            this.rbtncuota = new System.Windows.Forms.RadioButton();
            this.rbtnventas = new System.Windows.Forms.RadioButton();
            this.txtcuota = new System.Windows.Forms.TextBox();
            this.cmbOperadores2 = new System.Windows.Forms.ComboBox();
            this.textventas = new System.Windows.Forms.TextBox();
            this.cmbOperadores3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textventas);
            this.groupBox2.Controls.Add(this.cmbOperadores3);
            this.groupBox2.Controls.Add(this.txtcuota);
            this.groupBox2.Controls.Add(this.cmboficina);
            this.groupBox2.Controls.Add(this.cmbOperadores2);
            this.groupBox2.Controls.Add(this.cmbtitulo);
            this.groupBox2.Controls.Add(this.radiooficina);
            this.groupBox2.Controls.Add(this.rbtntitulo);
            this.groupBox2.Controls.Add(this.rbtnventas);
            this.groupBox2.Controls.Add(this.rbtncuota);
            this.groupBox2.Location = new System.Drawing.Point(396, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(360, 132);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "datos";
            // 
            // cmbtitulo
            // 
            this.cmbtitulo.FormattingEnabled = true;
            this.cmbtitulo.Location = new System.Drawing.Point(146, 68);
            this.cmbtitulo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbtitulo.Name = "cmbtitulo";
            this.cmbtitulo.Size = new System.Drawing.Size(92, 21);
            this.cmbtitulo.TabIndex = 3;
            // 
            // rbtntitulo
            // 
            this.rbtntitulo.AutoSize = true;
            this.rbtntitulo.Location = new System.Drawing.Point(5, 72);
            this.rbtntitulo.Margin = new System.Windows.Forms.Padding(2);
            this.rbtntitulo.Name = "rbtntitulo";
            this.rbtntitulo.Size = new System.Drawing.Size(142, 17);
            this.rbtntitulo.TabIndex = 2;
            this.rbtntitulo.TabStop = true;
            this.rbtntitulo.Text = "Titulo del representante :";
            this.rbtntitulo.UseVisualStyleBackColor = true;
            this.rbtntitulo.CheckedChanged += new System.EventHandler(this.rbtnEdoProd_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtedad);
            this.groupBox1.Controls.Add(this.cmbOperadores);
            this.groupBox1.Controls.Add(this.director);
            this.groupBox1.Controls.Add(this.rbtnedad);
            this.groupBox1.Controls.Add(this.rbtndirector);
            this.groupBox1.Controls.Add(this.rbtnListarep);
            this.groupBox1.Location = new System.Drawing.Point(11, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(355, 132);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Representante";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(224, 74);
            this.txtedad.Margin = new System.Windows.Forms.Padding(2);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(76, 20);
            this.txtedad.TabIndex = 5;
            this.txtedad.Text = "0";
            // 
            // cmbOperadores
            // 
            this.cmbOperadores.FormattingEnabled = true;
            this.cmbOperadores.Location = new System.Drawing.Point(153, 73);
            this.cmbOperadores.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOperadores.Name = "cmbOperadores";
            this.cmbOperadores.Size = new System.Drawing.Size(62, 21);
            this.cmbOperadores.TabIndex = 4;
            // 
            // director
            // 
            this.director.FormattingEnabled = true;
            this.director.Location = new System.Drawing.Point(242, 40);
            this.director.Margin = new System.Windows.Forms.Padding(2);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(92, 21);
            this.director.TabIndex = 3;
            // 
            // rbtnedad
            // 
            this.rbtnedad.AutoSize = true;
            this.rbtnedad.Location = new System.Drawing.Point(5, 72);
            this.rbtnedad.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnedad.Name = "rbtnedad";
            this.rbtnedad.Size = new System.Drawing.Size(141, 17);
            this.rbtnedad.TabIndex = 2;
            this.rbtnedad.TabStop = true;
            this.rbtnedad.Text = "Edad de representantes:";
            this.rbtnedad.UseVisualStyleBackColor = true;
            // 
            // rbtndirector
            // 
            this.rbtndirector.AutoSize = true;
            this.rbtndirector.Location = new System.Drawing.Point(5, 40);
            this.rbtndirector.Margin = new System.Windows.Forms.Padding(2);
            this.rbtndirector.Name = "rbtndirector";
            this.rbtndirector.Size = new System.Drawing.Size(233, 17);
            this.rbtndirector.TabIndex = 1;
            this.rbtndirector.TabStop = true;
            this.rbtndirector.Text = "Reprersentantes que pertenecen al director:";
            this.rbtndirector.UseVisualStyleBackColor = true;
            // 
            // rbtnListarep
            // 
            this.rbtnListarep.AutoSize = true;
            this.rbtnListarep.Location = new System.Drawing.Point(5, 18);
            this.rbtnListarep.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnListarep.Name = "rbtnListarep";
            this.rbtnListarep.Size = new System.Drawing.Size(147, 17);
            this.rbtnListarep.TabIndex = 0;
            this.rbtnListarep.TabStop = true;
            this.rbtnListarep.Text = "Listado de Representante";
            this.rbtnListarep.UseVisualStyleBackColor = true;
            // 
            // cmboficina
            // 
            this.cmboficina.FormattingEnabled = true;
            this.cmboficina.Location = new System.Drawing.Point(151, 100);
            this.cmboficina.Margin = new System.Windows.Forms.Padding(2);
            this.cmboficina.Name = "cmboficina";
            this.cmboficina.Size = new System.Drawing.Size(92, 21);
            this.cmboficina.TabIndex = 7;
            // 
            // radiooficina
            // 
            this.radiooficina.AutoSize = true;
            this.radiooficina.Location = new System.Drawing.Point(5, 101);
            this.radiooficina.Margin = new System.Windows.Forms.Padding(2);
            this.radiooficina.Name = "radiooficina";
            this.radiooficina.Size = new System.Drawing.Size(143, 17);
            this.radiooficina.TabIndex = 6;
            this.radiooficina.TabStop = true;
            this.radiooficina.Text = "Oficina del representante";
            this.radiooficina.UseVisualStyleBackColor = true;
            this.radiooficina.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtncuota
            // 
            this.rbtncuota.AutoSize = true;
            this.rbtncuota.Location = new System.Drawing.Point(5, 18);
            this.rbtncuota.Margin = new System.Windows.Forms.Padding(2);
            this.rbtncuota.Name = "rbtncuota";
            this.rbtncuota.Size = new System.Drawing.Size(137, 17);
            this.rbtncuota.TabIndex = 0;
            this.rbtncuota.TabStop = true;
            this.rbtncuota.Text = "cuota del representante";
            this.rbtncuota.UseVisualStyleBackColor = true;
            // 
            // rbtnventas
            // 
            this.rbtnventas.AutoSize = true;
            this.rbtnventas.Location = new System.Drawing.Point(5, 44);
            this.rbtnventas.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnventas.Name = "rbtnventas";
            this.rbtnventas.Size = new System.Drawing.Size(143, 17);
            this.rbtnventas.TabIndex = 1;
            this.rbtnventas.TabStop = true;
            this.rbtnventas.Text = "Ventas del representante";
            this.rbtnventas.UseVisualStyleBackColor = true;
            // 
            // txtcuota
            // 
            this.txtcuota.Location = new System.Drawing.Point(217, 18);
            this.txtcuota.Margin = new System.Windows.Forms.Padding(2);
            this.txtcuota.Name = "txtcuota";
            this.txtcuota.Size = new System.Drawing.Size(76, 20);
            this.txtcuota.TabIndex = 7;
            this.txtcuota.Text = "0";
            // 
            // cmbOperadores2
            // 
            this.cmbOperadores2.FormattingEnabled = true;
            this.cmbOperadores2.Location = new System.Drawing.Point(146, 17);
            this.cmbOperadores2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOperadores2.Name = "cmbOperadores2";
            this.cmbOperadores2.Size = new System.Drawing.Size(62, 21);
            this.cmbOperadores2.TabIndex = 6;
            // 
            // textventas
            // 
            this.textventas.Location = new System.Drawing.Point(217, 45);
            this.textventas.Margin = new System.Windows.Forms.Padding(2);
            this.textventas.Name = "textventas";
            this.textventas.Size = new System.Drawing.Size(76, 20);
            this.textventas.TabIndex = 9;
            this.textventas.Text = "0";
            // 
            // cmbOperadores3
            // 
            this.cmbOperadores3.FormattingEnabled = true;
            this.cmbOperadores3.Location = new System.Drawing.Point(146, 42);
            this.cmbOperadores3.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOperadores3.Name = "cmbOperadores3";
            this.cmbOperadores3.Size = new System.Drawing.Size(62, 21);
            this.cmbOperadores3.TabIndex = 8;
            // 
            // FrmQueryRepresentante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQueryRepresentante";
            this.Text = "FrmQueryRepresentante";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbtitulo;
        private System.Windows.Forms.RadioButton rbtntitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.ComboBox cmbOperadores;
        private System.Windows.Forms.ComboBox director;
        private System.Windows.Forms.RadioButton rbtnedad;
        private System.Windows.Forms.RadioButton rbtndirector;
        private System.Windows.Forms.RadioButton rbtnListarep;
        private System.Windows.Forms.ComboBox cmboficina;
        private System.Windows.Forms.RadioButton radiooficina;
        private System.Windows.Forms.TextBox txtcuota;
        private System.Windows.Forms.ComboBox cmbOperadores2;
        private System.Windows.Forms.RadioButton rbtnventas;
        private System.Windows.Forms.RadioButton rbtncuota;
        private System.Windows.Forms.TextBox textventas;
        private System.Windows.Forms.ComboBox cmbOperadores3;
    }
}