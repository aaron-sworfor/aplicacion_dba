namespace Ventas_Pilarr
{
    partial class FrmActualizar_Clientes
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.txtLim = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtnumClie = new System.Windows.Forms.ComboBox();
            this.txtNum_Rep = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero del Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de Representante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Limite de Credito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(495, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingresa los siguientes datos para actualizar los datos del cliente:";
            // 
            // txtEmp
            // 
            this.txtEmp.Location = new System.Drawing.Point(210, 138);
            this.txtEmp.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(178, 20);
            this.txtEmp.TabIndex = 6;
            // 
            // txtLim
            // 
            this.txtLim.Location = new System.Drawing.Point(210, 249);
            this.txtLim.Margin = new System.Windows.Forms.Padding(2);
            this.txtLim.Name = "txtLim";
            this.txtLim.Size = new System.Drawing.Size(95, 20);
            this.txtLim.TabIndex = 8;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(105, 307);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(264, 39);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar Cliente";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtnumClie
            // 
            this.txtnumClie.FormattingEnabled = true;
            this.txtnumClie.Location = new System.Drawing.Point(210, 88);
            this.txtnumClie.Name = "txtnumClie";
            this.txtnumClie.Size = new System.Drawing.Size(178, 21);
            this.txtnumClie.TabIndex = 10;
            this.txtnumClie.SelectedIndexChanged += new System.EventHandler(this.txtnumClie_SelectedIndexChanged);
            // 
            // txtNum_Rep
            // 
            this.txtNum_Rep.FormattingEnabled = true;
            this.txtNum_Rep.Location = new System.Drawing.Point(210, 184);
            this.txtNum_Rep.Name = "txtNum_Rep";
            this.txtNum_Rep.Size = new System.Drawing.Size(178, 21);
            this.txtNum_Rep.TabIndex = 11;
            // 
            // FrmActualizar_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 392);
            this.Controls.Add(this.txtNum_Rep);
            this.Controls.Add(this.txtnumClie);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtLim);
            this.Controls.Add(this.txtEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmActualizar_Clientes";
            this.Text = "FrmActualizarClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.TextBox txtLim;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox txtnumClie;
        private System.Windows.Forms.ComboBox txtNum_Rep;
    }
}