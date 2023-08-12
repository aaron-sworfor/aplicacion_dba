using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Pilarr
{
    public partial class frmQueryClientes : Form
    {
        public frmQueryClientes()
        {
            InitializeComponent();
            cmbOperadores.Items.AddRange(new string[] { "=", "<", "<=", ">", ">=" });
            cmbOperadores.SelectedIndex = 0;
            BaseSQL objeto = new BaseSQL();
            //llenar el combo de Productos del fabricante
            cmbFab.DataSource = objeto.LeerDatos("Select distinct Num_Rep,Nombre from Rep_Ventas");
            cmbFab.DisplayMember = "Nombre";
            cmbFab.ValueMember = "Num_Rep";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnListaProd.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT Num_Clie, Empresa, Num_Rep, Lim_Cred FROM Clientes";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                // Desactivar el checkBox que fue seleccionado
                rbtnListaProd.Checked = false;
                // Habilitar el checbox
                rbtnListaProd.Enabled = true;
            }
            else if (rbtnProdFab.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT * FROM Clientes where Num_Rep=" + this.cmbFab.SelectedValue + "";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtnProdConExi.Checked = false;
                rbtnProdConExi.Enabled = true;
            }
            else if (rbtnProdConExi.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT * FROM Clientes WHERE Lim_Cred " + cmbOperadores.Text + " " + txtProdExi.Text + "";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtnProdConExi.Checked = false;
                rbtnProdConExi.Enabled = true;
            }
        
        }
    }
}
