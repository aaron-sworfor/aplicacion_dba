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
    public partial class FrmEliminarCliente : Form
    {
        public FrmEliminarCliente()
        {
            string cadenaSQL2 = "";
            BaseSQL objeto2 = new BaseSQL();
            InitializeComponent();
            cadenaSQL2 = "SELECT DISTINCT Num_Clie,Empresa FROM Clientes";
            this.txtNumClie.DataSource = objeto2.LeerDatos(cadenaSQL2);
            txtNumClie.DisplayMember = "Empresa";
            txtNumClie.ValueMember = "Num_Clie";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();

            string cadenaSQL = "";
            cadenaSQL = "exec elimina_clientes " + this.txtNumClie.SelectedValue + ","  + Num_Rep.Text + "";

            try
            {
                objeto.ejecutar(cadenaSQL);
                MessageBox.Show("El Cliente se Elimino!");
                
                cadenaSQL = "SELECT DISTINCT Num_Clie,Empresa FROM Clientes";
                this.txtNumClie.DataSource = objeto.LeerDatos(cadenaSQL);
                txtNumClie.DisplayMember = "Empresa";
                txtNumClie.ValueMember = "Num_Clie";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta SQL: "+ cadenaSQL);
            }

            //Se limpian los objetos
            Num_Rep.Text = "";

        }

        private void txtNumClie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BaseSQL objeto = new BaseSQL();

                string cadenaSQL = "";
                if (txtNumClie.SelectedValue != null)
                {
                    //Obtiene el Id_Fab seleccionado

                    //Llena el comboBox cmbIDProd por medio de la clase leerDatos.
                    cadenaSQL = "SELECT Num_Rep FROM Clientes WHERE Num_Clie = " + this.txtNumClie.SelectedValue + "";
                    SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);
                    if (dr.Read())
                    {
                        Num_Rep.Text = dr["Num_Rep"].ToString();
                    }
                }

            }
            catch (Exception ed)
            {

            }
        }
    }
}
