namespace Ventas_Pilarr
{
    partial class FrmPagos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numpedido = new System.Windows.Forms.ComboBox();
            this.numontp = new System.Windows.Forms.NumericUpDown();
            this.tbfech = new System.Windows.Forms.TextBox();
            this.lbdeuda = new System.Windows.Forms.Label();
            this.lbcliente = new System.Windows.Forms.Label();
            this.lbcp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Deuda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numontp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto de pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero de cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad de pedido";
            // 
            // numpedido
            // 
            this.numpedido.FormattingEnabled = true;
            this.numpedido.Location = new System.Drawing.Point(228, 21);
            this.numpedido.Name = "numpedido";
            this.numpedido.Size = new System.Drawing.Size(190, 21);
            this.numpedido.TabIndex = 6;
            this.numpedido.SelectedIndexChanged += new System.EventHandler(this.numpedido_SelectedIndexChanged);
            // 
            // numontp
            // 
            this.numontp.Location = new System.Drawing.Point(228, 59);
            this.numontp.Name = "numontp";
            this.numontp.Size = new System.Drawing.Size(120, 20);
            this.numontp.TabIndex = 7;
            // 
            // tbfech
            // 
            this.tbfech.Location = new System.Drawing.Point(228, 96);
            this.tbfech.Name = "tbfech";
            this.tbfech.Size = new System.Drawing.Size(100, 20);
            this.tbfech.TabIndex = 8;
            // 
            // lbdeuda
            // 
            this.lbdeuda.AutoSize = true;
            this.lbdeuda.Location = new System.Drawing.Point(228, 127);
            this.lbdeuda.Name = "lbdeuda";
            this.lbdeuda.Size = new System.Drawing.Size(0, 13);
            this.lbdeuda.TabIndex = 9;
            // 
            // lbcliente
            // 
            this.lbcliente.AutoSize = true;
            this.lbcliente.Location = new System.Drawing.Point(228, 153);
            this.lbcliente.Name = "lbcliente";
            this.lbcliente.Size = new System.Drawing.Size(0, 13);
            this.lbcliente.TabIndex = 10;
            // 
            // lbcp
            // 
            this.lbcp.AutoSize = true;
            this.lbcp.Location = new System.Drawing.Point(228, 192);
            this.lbcp.Name = "lbcp";
            this.lbcp.Size = new System.Drawing.Size(0, 13);
            this.lbcp.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Deuda
            // 
            this.Deuda.AutoSize = true;
            this.Deuda.Location = new System.Drawing.Point(58, 126);
            this.Deuda.Name = "Deuda";
            this.Deuda.Size = new System.Drawing.Size(39, 13);
            this.Deuda.TabIndex = 13;
            this.Deuda.Text = "Deuda";
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 338);
            this.Controls.Add(this.Deuda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbcp);
            this.Controls.Add(this.lbcliente);
            this.Controls.Add(this.lbdeuda);
            this.Controls.Add(this.tbfech);
            this.Controls.Add(this.numontp);
            this.Controls.Add(this.numpedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPagos";
            this.Text = "FrmPagos";
            ((System.ComponentModel.ISupportInitialize)(this.numontp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox numpedido;
        private System.Windows.Forms.NumericUpDown numontp;
        private System.Windows.Forms.TextBox tbfech;
        private System.Windows.Forms.Label lbdeuda;
        private System.Windows.Forms.Label lbcliente;
        private System.Windows.Forms.Label lbcp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Deuda;
    }
}