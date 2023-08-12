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
    public partial class FrmQueryRepresentante : Form
    {
        public FrmQueryRepresentante()
        {
            InitializeComponent();
            cmbOperadores.Items.AddRange(new string[] { "=", "<", "<=", ">", ">=" });
            cmbOperadores2.Items.AddRange(new string[] { "=", "<", "<=", ">", ">=" });
            cmbOperadores3.Items.AddRange(new string[] { "=", "<", "<=", ">", ">=" });
            cmbOperadores.SelectedIndex = 0;
            cmbOperadores2.SelectedIndex = 0;
            cmbOperadores3.SelectedIndex = 0;
            BaseSQL objeto = new BaseSQL();
            //llenar el combo de Productos del fabricante
            cmbtitulo.DataSource = objeto.LeerDatos("Select distinct Titulo from Rep_Ventas");
            cmbtitulo.DisplayMember = "Titulo";
            //llenar el combo de total de inventario por proveedor
            director.DataSource = objeto.LeerDatos("Select distinct Director from Rep_Ventas");
            director.DisplayMember = "Director";
            cmboficina.DataSource = objeto.LeerDatos("Select distinct Oficina_Rep from Rep_Ventas");
            cmboficina.DisplayMember = "Oficina_Rep";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnEdoProd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnListarep.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT * FROM Rep_Ventas";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                // Desactivar el checkBox que fue seleccionado
                rbtnListarep.Checked = false;
                // Habilitar el checbox
                rbtnListarep.Enabled = true;
            }
            else if (rbtndirector.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT * FROM Rep_Ventas where Director=" + director.Text + "";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtnedad.Checked = false;
                rbtnedad.Enabled = true;
            }
            else if (rbtnedad.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT * FROM Rep_Ventas WHERE Edad " + cmbOperadores.Text + " " + txtedad.Text + "";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtnedad.Checked = false;
                rbtnedad.Enabled = true;
            }
            else if (rbtncuota.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT * FROM Rep_Ventas where Cuota"+cmbOperadores2.Text+""+txtcuota.Text+"";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtncuota.Checked = false;
                rbtncuota.Enabled = true;
            }
            else if (rbtnventas.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT * FROM Rep_Ventas where Ventas" + cmbOperadores3.Text + "" + textventas.Text + "";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtnventas.Checked = false;
                rbtnventas.Enabled = true;
            }
            else if (rbtntitulo.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT * FROM Rep_Ventas where Titulo=" + cmbtitulo.Text + "";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtntitulo.Checked = false;
                rbtntitulo.Enabled = true;
            }else if (radiooficina.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT * FROM Rep_Ventas where Oficina_Rep=" + cmboficina.Text + "";
                objeto.llenargrid(cadenaSQL, dataGridView1);
                rbtntitulo.Checked = false;
                rbtntitulo.Enabled = true;
            }
        }
    }
}
