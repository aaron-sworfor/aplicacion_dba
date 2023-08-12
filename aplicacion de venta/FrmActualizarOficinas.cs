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
    public partial class FrmActualizarOficinas : Form
    {
        public FrmActualizarOficinas()
        {
            string cadenaSQL2 = "";
            BaseSQL objeto2 = new BaseSQL();
            InitializeComponent();
            cadenaSQL2 = "SELECT DISTINCT Director FROM Rep_Ventas";
            this.txtNum_Rep_Dir.DataSource = objeto2.LeerDatos(cadenaSQL2);
            txtNum_Rep_Dir.DisplayMember = "Director";
            txtNum_Rep_Dir.ValueMember = "Director";
            cadenaSQL2 = "SELECT DISTINCT Region FROM Oficinas";
            this.txtRegion.DataSource = objeto2.LeerDatos(cadenaSQL2);
            txtRegion.DisplayMember = "Region";
            txtRegion.ValueMember = "Region";
            cadenaSQL2 = "SELECT DISTINCT Oficina,Ciudad FROM Oficinas";
            this.txtOficina.DataSource = objeto2.LeerDatos(cadenaSQL2);
            txtOficina.DisplayMember = "Ciudad";
            txtOficina.ValueMember = "Oficina";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";
            cadenaSQL = "ActualizarOficinas '" + this.txtOficina.SelectedValue + "','" + txtCiudad.Text + "','" + txtRegion.Text + "','" + txtNum_Rep_Dir.Text + "','" + txtObjetivo.Text + "','" + txtVentas.Text + "'";

            try
            {
                objeto.ejecutar(cadenaSQL);
                MessageBox.Show("La Oficina se actualizo correctamente!");
            }
            catch (Exception ex)
            {
                //Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + cadenaSQL);
            }


            //Se limpian los objetos
            txtCiudad.Text = "";
            txtObjetivo.Text = "";
            txtVentas.Text = "";
            cadenaSQL = "SELECT DISTINCT Oficina,Ciudad FROM Oficinas";
            this.txtOficina.DataSource = objeto.LeerDatos(cadenaSQL);
            txtOficina.DisplayMember = "Ciudad";
            txtOficina.ValueMember = "Oficina";
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
                    cadenaSQL = "SELECT * FROM Oficinas WHERE Oficina = " + this.txtOficina.SelectedValue + "";
                    SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);
                    if (dr.Read())
                    {
                        txtCiudad.Text = dr["Ciudad"].ToString();
                        txtVentas.Text = dr["Ventas"].ToString();
                        txtObjetivo.Text = dr["Objetivo"].ToString();
                        txtNum_Rep_Dir.SelectedValue = dr["Num_Rep_Dir"].ToString();
                        txtRegion.SelectedValue = dr["Region"].ToString();
                    }
                }

            }
            catch (Exception ed)
            {

            }
        }
    }
}
