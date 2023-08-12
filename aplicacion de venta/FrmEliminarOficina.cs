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
    public partial class FrmEliminarOficina : Form
    {
        public FrmEliminarOficina()
        {
            string cadenaSQL2 = "";
            BaseSQL objeto2 = new BaseSQL();
            InitializeComponent();
            cadenaSQL2 = "SELECT DISTINCT Oficina,Ciudad FROM Oficinas";
            this.txtOficina.DataSource = objeto2.LeerDatos(cadenaSQL2);
            txtOficina.DisplayMember = "Ciudad";
            txtOficina.ValueMember = "Oficina";
        }

        private void btmEliminar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";
            cadenaSQL = "elimina_oficinas '" + this.txtOficina.SelectedValue + "','" + txtNum_Rep_Dir.Text + "'";

            try
            {
                objeto.ejecutar(cadenaSQL);
                cadenaSQL = "SELECT DISTINCT Oficina,Ciudad FROM Oficinas";
                this.txtOficina.DataSource = objeto.LeerDatos(cadenaSQL);
                txtOficina.DisplayMember = "Ciudad";
                txtOficina.ValueMember = "Oficina";
                MessageBox.Show("La Oficina se ELIMINO correctamente!");

            }
            catch (Exception ex)
            {
                //Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL: " );
            }


            //Se limpian los objetos
            txtOficina.Text = "";
            txtNum_Rep_Dir.Text = "";
        }

        private void txtOficina_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BaseSQL objeto = new BaseSQL();

                string cadenaSQL = "";
                if (txtOficina.SelectedValue != null)
                {
                    //Obtiene el Id_Fab seleccionado

                    //Llena el comboBox cmbIDProd por medio de la clase leerDatos.
                    cadenaSQL = "SELECT Num_Rep_Dir FROM Oficinas WHERE Oficina = " + txtOficina.SelectedValue + "";
                    SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);
                    if (dr.Read())
                    {
                        txtNum_Rep_Dir.Text = dr["Num_Rep_Dir"].ToString();
                   }
                }

            }
            catch (Exception ed)
            {

            }
        }
    }
}
