using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ventas_Pilarr
{
    public partial class FrmAltaClientes : Form
    {
        public FrmAltaClientes()
        {
            string cadenaSQL2 = "";
            BaseSQL objeto2 = new BaseSQL();
            InitializeComponent();
            cadenaSQL2 = "SELECT DISTINCT Num_Rep, Nombre FROM Rep_Ventas";
            this.txtNum_Rep.DataSource = objeto2.LeerDatos(cadenaSQL2);
            txtNum_Rep.DisplayMember = "Nombre";
            txtNum_Rep.ValueMember = "Num_Rep";
            cadenaSQL2 = "SELECT MAX(Num_Clie) AS nummax FROM Clientes;";
            SqlDataReader dr = objeto2.ConsultaSQL(cadenaSQL2);
            if (dr.Read())
            {
                txtnumClie.Text = dr["nummax"].ToString();
                int munc = Convert.ToInt32(txtnumClie.Text);
                munc = munc + 1;
                txtnumClie.Text = munc.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            String ver ="";
            string cadenaSQL = "";
            cadenaSQL = "INSERT INTO Clientes (Num_Clie, Empresa, Num_Rep,Lim_Cred) VALUES ";
            cadenaSQL = cadenaSQL + "(" + txtnumClie.Text + ",'" + txtnomEmp.Text + "'," + this.txtNum_Rep.SelectedValue + "," + txtlLimi.Text + ");";

            objeto.ejecutar(cadenaSQL);

            //Se despliega el mensaje para indicar que el registro del producto se guarto correctamente
            MessageBox.Show("Cliente guardado Correctamente");

            //Se limpian los objetos
            cadenaSQL = "SELECT MAX(Num_Clie) AS nummax FROM Clientes;";
            SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);
            if (dr.Read())
            {
                txtnumClie.Text = dr["nummax"].ToString();
                int munc = Convert.ToInt32(txtnumClie.Text);
                munc = munc + 1;
                txtnumClie.Text = munc.ToString();
            }
            txtnomEmp.Text = "";
            txtlLimi.Text = "";
            
        }

        private void FrmAltaClientes_Load(object sender, EventArgs e)
        {

        }

        private void txtNum_Rep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
