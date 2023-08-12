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
    public partial class FrmAltaOficina : Form
    {
        public FrmAltaOficina()
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

            cadenaSQL2 = "SELECT MAX(Oficina) AS nummax FROM Oficinas;";
            SqlDataReader dr = objeto2.ConsultaSQL(cadenaSQL2);
            if (dr.Read())
            {
                txtOficina.Text = dr["nummax"].ToString();
                int munc = Convert.ToInt32(txtOficina.Text);
                munc = munc + 1;
                txtOficina.Text = munc.ToString();
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";
            cadenaSQL = "AltasOficinas '" + txtOficina.Text + "','" + txtCiudad.Text + "','" + txtRegion.Text + "','" + txtNum_Rep_Dir.Text + "','" + txtObjetivo.Text + "','" + txtVentas.Text + "'";

            try
            {
                objeto.ejecutar(cadenaSQL);
                MessageBox.Show("La Oficina se agrego correctamente!");
            }
            catch (Exception ex)
            {
                //Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + cadenaSQL);
            }


            //Se limpian los objetos
            txtOficina.Text = "";
            txtCiudad.Text = "";
            txtRegion.Text = "";
            txtNum_Rep_Dir.Text = "";
            txtObjetivo.Text = "";
            txtOficina.Text = "";
            txtVentas.Text = "";
            
        }
    }
}
