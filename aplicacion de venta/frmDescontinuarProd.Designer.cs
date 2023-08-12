namespace Ventas_Pilarr
{
    partial class frmDescontinuarProd
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
            this.lblIDFab = new System.Windows.Forms.Label();
            this.lblIDProd = new System.Windows.Forms.Label();
            this.lblIDes = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.lblExi = new System.Windows.Forms.Label();
            this.lblSta = new System.Windows.Forms.Label();
            this.cmbIDFab = new System.Windows.Forms.ComboBox();
            this.cmbIDProd = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIDFab
            // 
            this.lblIDFab.AutoSize = true;
            this.lblIDFab.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDFab.Location = new System.Drawing.Point(64, 40);
            this.lblIDFab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDFab.Name = "lblIDFab";
            this.lblIDFab.Size = new System.Drawing.Size(128, 17);
            this.lblIDFab.TabIndex = 0;
            this.lblIDFab.Text = "Clave del Fabricante";
            // 
            // lblIDProd
            // 
            this.lblIDProd.AutoSize = true;
            this.lblIDProd.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProd.Location = new System.Drawing.Point(64, 81);
            this.lblIDProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDProd.Name = "lblIDProd";
            this.lblIDProd.Size = new System.Drawing.Size(121, 17);
            this.lblIDProd.TabIndex = 1;
            this.lblIDProd.Text = "Clave del Producto";
            // 
            // lblIDes
            // 
            this.lblIDes.AutoSize = true;
            this.lblIDes.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDes.Location = new System.Drawing.Point(64, 117);
            this.lblIDes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDes.Name = "lblIDes";
            this.lblIDes.Size = new System.Drawing.Size(78, 17);
            this.lblIDes.TabIndex = 2;
            this.lblIDes.Text = "Descripción";
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPre.Location = new System.Drawing.Point(64, 158);
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
            this.lblExi.Location = new System.Drawing.Point(64, 193);
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
            this.lblSta.Location = new System.Drawing.Point(64, 228);
            this.lblSta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSta.Name = "lblSta";
            this.lblSta.Size = new System.Drawing.Size(129, 17);
            this.lblSta.TabIndex = 5;
            this.lblSta.Text = "Estado del Producto";
            // 
            // cmbIDFab
            // 
            this.cmbIDFab.FormattingEnabled = true;
            this.cmbIDFab.Location = new System.Drawing.Point(269, 45);
            this.cmbIDFab.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIDFab.Name = "cmbIDFab";
            this.cmbIDFab.Size = new System.Drawing.Size(92, 21);
            this.cmbIDFab.TabIndex = 6;
            this.cmbIDFab.SelectedIndexChanged += new System.EventHandler(this.cmbIDFab_SelectedIndexChanged);
            // 
            // cmbIDProd
            // 
            this.cmbIDProd.FormattingEnabled = true;
            this.cmbIDProd.Location = new System.Drawing.Point(269, 84);
            this.cmbIDProd.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIDProd.Name = "cmbIDProd";
            this.cmbIDProd.Size = new System.Drawing.Size(92, 21);
            this.cmbIDProd.TabIndex = 7;
            this.cmbIDProd.SelectedIndexChanged += new System.EventHandler(this.cmbIDProd_SelectedIndexChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(186, 117);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(18, 17);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "\"\"";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(130, 158);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(18, 17);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "\"\"";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(173, 193);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(18, 17);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "\"\"";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(242, 228);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(18, 17);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "\"\"";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(103, 294);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Descontinuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(167, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Descontinuar";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // frmDescontinuarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 366);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.cmbIDProd);
            this.Controls.Add(this.cmbIDFab);
            this.Controls.Add(this.lblSta);
            this.Controls.Add(this.lblExi);
            this.Controls.Add(this.lblPre);
            this.Controls.Add(this.lblIDes);
            this.Controls.Add(this.lblIDProd);
            this.Controls.Add(this.lblIDFab);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDescontinuarProd";
            this.Text = "frmDescontinuarProd";
            this.Load += new System.EventHandler(this.frmDescontinuarProd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDFab;
        private System.Windows.Forms.Label lblIDProd;
        private System.Windows.Forms.Label lblIDes;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.Label lblExi;
        private System.Windows.Forms.Label lblSta;
        private System.Windows.Forms.ComboBox cmbIDFab;
        private System.Windows.Forms.ComboBox cmbIDProd;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
    }
}