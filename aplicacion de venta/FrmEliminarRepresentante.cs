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
    public partial class FrmEliminarRepresentante : Form
    {
        public FrmEliminarRepresentante()
        {
            string cadenaSQL2 = "";
            BaseSQL objeto2 = new BaseSQL();
            InitializeComponent();
            cadenaSQL2 = "SELECT DISTINCT Num_Rep,Nombre FROM Rep_Ventas";
            this.txtNum_Rep.DataSource = objeto2.LeerDatos(cadenaSQL2);
            txtNum_Rep.DisplayMember = "Nombre";
            txtNum_Rep.ValueMember = "Num_Rep";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";
            cadenaSQL = "elimina_rep_ventas '" + this.txtNum_Rep.SelectedValue + "','" + txtDirector.Text + "'";

            try
            {
                objeto.ejecutar(cadenaSQL);
                MessageBox.Show("El Representante se ELIMINO correctamente!");
                cadenaSQL = "SELECT DISTINCT Num_Rep,Nombre FROM Rep_Ventas";
                this.txtNum_Rep.DataSource = objeto.LeerDatos(cadenaSQL);
                txtNum_Rep.DisplayMember = "Nombre";
                txtNum_Rep.ValueMember = "Num_Rep";
            }
            catch (Exception ex)
            {
                //Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL: ");
            }

            //Se limpian los objetos
            txtDirector.Text = "";
        }

        private void txtNum_Rep_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BaseSQL objeto = new BaseSQL();

                string cadenaSQL = "";
                if (txtNum_Rep.SelectedValue != null)
                {
                    cadenaSQL = "SELECT Director FROM Rep_Ventas WHERE Num_Rep = " + this.txtNum_Rep.SelectedValue + "";
                    SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);
                    if (dr.Read())
                    {
                        txtDirector.Text = dr["Director"].ToString();
                    }
                }

            }
            catch (Exception ed)
            {

            }
        }
    }
}
