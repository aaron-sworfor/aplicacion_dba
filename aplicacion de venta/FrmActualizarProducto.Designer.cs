namespace Ventas_Pilarr
{
    partial class FrmActualizarProducto
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
            this.lbllDFab = new System.Windows.Forms.Label();
            this.lbllDProd = new System.Windows.Forms.Label();
            this.lbllDes = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.lblExi = new System.Windows.Forms.Label();
            this.lblSta = new System.Windows.Forms.Label();
            this.cmbIDFab = new System.Windows.Forms.ComboBox();
            this.cmbIDProd = new System.Windows.Forms.ComboBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.nudPre = new System.Windows.Forms.NumericUpDown();
            this.nudExi = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.Actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExi)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllDFab
            // 
            this.lbllDFab.AutoSize = true;
            this.lbllDFab.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllDFab.Location = new System.Drawing.Point(68, 43);
            this.lbllDFab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllDFab.Name = "lbllDFab";
            this.lbllDFab.Size = new System.Drawing.Size(128, 17);
            this.lbllDFab.TabIndex = 0;
            this.lbllDFab.Text = "Clave del Fabricante";
            // 
            // lbllDProd
            // 
            this.lbllDProd.AutoSize = true;
            this.lbllDProd.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllDProd.Location = new System.Drawing.Point(68, 85);
            this.lbllDProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllDProd.Name = "lbllDProd";
            this.lbllDProd.Size = new System.Drawing.Size(121, 17);
            this.lbllDProd.TabIndex = 1;
            this.lbllDProd.Text = "Clave del Producto";
            // 
            // lbllDes
            // 
            this.lbllDes.AutoSize = true;
            this.lbllDes.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllDes.Location = new System.Drawing.Point(68, 128);
            this.lbllDes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllDes.Name = "lbllDes";
            this.lbllDes.Size = new System.Drawing.Size(78, 17);
            this.lbllDes.TabIndex = 2;
            this.lbllDes.Text = "Descripcion";
            this.lbllDes.Click += new System.EventHandler(this.lbllDes_Click);
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPre.Location = new System.Drawing.Point(68, 178);
            this.lblPre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(45, 17);
            this.lblPre.TabIndex = 3;
            this.lblPre.Text = "Precio";
            // 
            // lblExi
            // 
            this.lblExi.AutoSize = true;
            this.lblExi.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExi.Location = new System.Drawing.Point(68, 224);
            this.lblExi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExi.Name = "lblExi";
            this.lblExi.Size = new System.Drawing.Size(72, 17);
            this.lblExi.TabIndex = 4;
            this.lblExi.Text = "Existencias";
            // 
            // lblSta
            // 
            this.lblSta.AutoSize = true;
            this.lblSta.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSta.Location = new System.Drawing.Point(68, 269);
            this.lblSta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSta.Name = "lblSta";
            this.lblSta.Size = new System.Drawing.Size(129, 17);
            this.lblSta.TabIndex = 5;
            this.lblSta.Text = "Estado del Producto";
            // 
            // cmbIDFab
            // 
            this.cmbIDFab.FormattingEnabled = true;
            this.cmbIDFab.Location = new System.Drawing.Point(260, 43);
            this.cmbIDFab.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIDFab.Name = "cmbIDFab";
            this.cmbIDFab.Size = new System.Drawing.Size(92, 21);
            this.cmbIDFab.TabIndex = 6;
            this.cmbIDFab.SelectedIndexChanged += new System.EventHandler(this.cmbIDFab_SelectedIndexChanged);
            // 
            // cmbIDProd
            // 
            this.cmbIDProd.FormattingEnabled = true;
            this.cmbIDProd.Location = new System.Drawing.Point(260, 89);
            this.cmbIDProd.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIDProd.Name = "cmbIDProd";
            this.cmbIDProd.Size = new System.Drawing.Size(92, 21);
            this.cmbIDProd.TabIndex = 7;
            this.cmbIDProd.SelectedIndexChanged += new System.EventHandler(this.cmbIDProd_SelectedIndexChanged);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(191, 133);
            this.txtDes.Margin = new System.Windows.Forms.Padding(2);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(266, 20);
            this.txtDes.TabIndex = 8;
            // 
            // nudPre
            // 
            this.nudPre.Location = new System.Drawing.Point(191, 178);
            this.nudPre.Margin = new System.Windows.Forms.Padding(2);
            this.nudPre.Name = "nudPre";
            this.nudPre.Size = new System.Drawing.Size(90, 20);
            this.nudPre.TabIndex = 9;
            // 
            // nudExi
            // 
            this.nudExi.Location = new System.Drawing.Point(191, 224);
            this.nudExi.Margin = new System.Windows.Forms.Padding(2);
            this.nudExi.Name = "nudExi";
            this.nudExi.Size = new System.Drawing.Size(90, 20);
            this.nudExi.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(292, 269);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(21, 19);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "\"\"";
            // 
            // Actualizar
            // 
            this.Actualizar.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar.Location = new System.Drawing.Point(89, 331);
            this.Actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(192, 33);
            this.Actualizar.TabIndex = 12;
            this.Actualizar.Text = "Actualizar Registro";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // FrmActualizarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 383);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.nudExi);
            this.Controls.Add(this.nudPre);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.cmbIDProd);
            this.Controls.Add(this.cmbIDFab);
            this.Controls.Add(this.lblSta);
            this.Controls.Add(this.lblExi);
            this.Controls.Add(this.lblPre);
            this.Controls.Add(this.lbllDes);
            this.Controls.Add(this.lbllDProd);
            this.Controls.Add(this.lbllDFab);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmActualizarProducto";
            this.Text = "FrmActualizarProducto";
            this.Load += new System.EventHandler(this.FrmActualizarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllDFab;
        private System.Windows.Forms.Label lbllDProd;
        private System.Windows.Forms.Label lbllDes;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.Label lblExi;
        private System.Windows.Forms.Label lblSta;
        private System.Windows.Forms.ComboBox cmbIDFab;
        private System.Windows.Forms.ComboBox cmbIDProd;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.NumericUpDown nudPre;
        private System.Windows.Forms.NumericUpDown nudExi;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button Actualizar;
    }
}