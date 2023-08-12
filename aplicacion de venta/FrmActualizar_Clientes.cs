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

namespace Ventas_Pilarr
{
    public partial class FrmActualizar_Clientes : Form
    {
        public FrmActualizar_Clientes()
        {
            string cadenaSQL2 = "";
            BaseSQL objeto2 = new BaseSQL();
            InitializeComponent();
            cadenaSQL2 = "SELECT DISTINCT Num_Clie,Empresa FROM Clientes";
            this.txtnumClie.DataSource = objeto2.LeerDatos(cadenaSQL2);
            txtnumClie.DisplayMember = "Empresa";
            txtnumClie.ValueMember = "Num_Clie";
            cadenaSQL2 = "SELECT DISTINCT Num_Rep, Nombre FROM Rep_Ventas";
            this.txtNum_Rep.DataSource = objeto2.LeerDatos(cadenaSQL2);
            txtNum_Rep.DisplayMember = "Nombre";
            txtNum_Rep.ValueMember = "Num_Rep";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();

            string cadenaSQL = "";
            cadenaSQL = "EXEC ActualizarClientes '" + this.txtnumClie.SelectedValue + "','" + txtEmp.Text + "','" + this.txtNum_Rep.SelectedValue + "','" + txtLim.Text + "' ";
            
            try
            {
                objeto.ejecutar(cadenaSQL);
                MessageBox.Show("El Cliente se Actualizo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta SQL: "  + cadenaSQL);
            }
            
            //Se limpian los objetos
            
            txtEmp.Text = "";
            txtLim.Text = "";
            cadenaSQL = "SELECT DISTINCT Num_Clie,Empresa FROM Clientes";
            this.txtnumClie.DataSource = objeto.LeerDatos(cadenaSQL);
            txtnumClie.DisplayMember = "Empresa";
            txtnumClie.ValueMember = "Num_Clie";

        }

        private void txtnumClie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            BaseSQL objeto = new BaseSQL();

            string cadenaSQL = "";
            if (txtnumClie.SelectedValue != null)
            {
                //Obtiene el Id_Fab seleccionado

                //Llena el comboBox cmbIDProd por medio de la clase leerDatos.
                cadenaSQL = "SELECT Empresa,Lim_Cred,Num_Rep FROM Clientes WHERE Num_Clie = " + this.txtnumClie.SelectedValue + "";
                SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);
                if (dr.Read())
                {
                    txtEmp.Text = dr["Empresa"].ToString();
                    txtLim.Text = dr["Lim_Cred"].ToString();
                    txtNum_Rep.SelectedValue= dr["Num_Rep"].ToString();
                    }
            }

        }
            catch (Exception ed)
            {

            }
}
    }
}
