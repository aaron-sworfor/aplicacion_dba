using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Pilarr
{
    public partial class frmQueryoficinas : Form
    {
        public frmQueryoficinas()
        {
            InitializeComponent();
            cmbOperadores.Items.AddRange(new string[] { "=", "<", "<=", ">", ">=" });
            cmbOperadores2.Items.AddRange(new string[] { "=", "<", "<=", ">", ">=" });
            cmbOperadores.SelectedIndex = 0;
            cmbOperadores2.SelectedIndex = 0;
            BaseSQL objeto = new BaseSQL();
            cmbInvProv.DataSource = objeto.LeerDatos("Select distinct Region from Oficinas");
            cmbInvProv.DisplayMember = "Region";
            //llenar el combo de total de inventario por proveedor
            cmbFab.DataSource = objeto.LeerDatos("Select distinct Num_Rep_Dir from Oficinas");
            cmbFab.DisplayMember = "Num_Rep_Dir";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnListaProd.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT * FROM Oficinas";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                // Desactivar el checkBox que fue seleccionado
                rbtnListaProd.Checked = false;
                // Habilitar el checbox
                rbtnListaProd.Enabled = true;
            }
            else if (rbtnProdFab.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT * FROM Oficinas where Num_Rep_Dir=" + cmbFab.Text + "";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtnProdFab.Checked = false;
                rbtnProdFab.Enabled = true;
            }
            else if (rbtnProdConExi.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT * FROM Oficinas WHERE Objetivo " + cmbOperadores.Text + " " + txtProdExi.Text + "";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtnProdConExi.Checked = false;
                rbtnProdConExi.Enabled = true;
            }
            else if (rbtncuota.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT * FROM Oficinas where Cuota" + cmbOperadores2.Text + "" + txtcuota.Text + "";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtncuota.Checked = false;
                rbtncuota.Enabled = true;
            }
            else if (rbtnEdoProd.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT * FROM Oficinas where Region="+ cmbInvProv.Text + "";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtnEdoProd.Checked = false;
                rbtnEdoProd.Enabled = true;
            }
        }
    }
}
