namespace Ventas_Pilarr
{
    partial class FrmAltaClientes
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnomEmp = new System.Windows.Forms.TextBox();
            this.txtlLimi = new System.Windows.Forms.TextBox();
            this.txtNum_Rep = new System.Windows.Forms.ComboBox();
            this.txtnumClie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de cliente sera:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de Representante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Limite de credito:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(176, 326);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 40);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar Cliente";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ingresa los siguientes datos:";
            // 
            // txtnomEmp
            // 
            this.txtnomEmp.Location = new System.Drawing.Point(238, 132);
            this.txtnomEmp.Margin = new System.Windows.Forms.Padding(2);
            this.txtnomEmp.Name = "txtnomEmp";
            this.txtnomEmp.Size = new System.Drawing.Size(181, 20);
            this.txtnomEmp.TabIndex = 7;
            // 
            // txtlLimi
            // 
            this.txtlLimi.Location = new System.Drawing.Point(238, 252);
            this.txtlLimi.Margin = new System.Windows.Forms.Padding(2);
            this.txtlLimi.Name = "txtlLimi";
            this.txtlLimi.Size = new System.Drawing.Size(181, 20);
            this.txtlLimi.TabIndex = 9;
            // 
            // txtNum_Rep
            // 
            this.txtNum_Rep.FormattingEnabled = true;
            this.txtNum_Rep.Location = new System.Drawing.Point(238, 191);
            this.txtNum_Rep.Name = "txtNum_Rep";
            this.txtNum_Rep.Size = new System.Drawing.Size(181, 21);
            this.txtNum_Rep.TabIndex = 10;
            this.txtNum_Rep.SelectedIndexChanged += new System.EventHandler(this.txtNum_Rep_SelectedIndexChanged);
            // 
            // txtnumClie
            // 
            this.txtnumClie.AutoSize = true;
            this.txtnumClie.Location = new System.Drawing.Point(235, 74);
            this.txtnumClie.Name = "txtnumClie";
            this.txtnumClie.Size = new System.Drawing.Size(0, 13);
            this.txtnumClie.TabIndex = 11;
            // 
            // FrmAltaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 395);
            this.Controls.Add(this.txtnumClie);
            this.Controls.Add(this.txtNum_Rep);
            this.Controls.Add(this.txtlLimi);
            this.Controls.Add(this.txtnomEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAltaClientes";
            this.Text = "FrmAltaClientes";
            this.Load += new System.EventHandler(this.FrmAltaClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnomEmp;
        private System.Windows.Forms.TextBox txtlLimi;
        private System.Windows.Forms.ComboBox txtNum_Rep;
        private System.Windows.Forms.Label txtnumClie;
    }
}