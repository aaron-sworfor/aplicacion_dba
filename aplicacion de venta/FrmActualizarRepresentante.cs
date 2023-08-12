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
    public partial class FrmActualizarRepresentante : Form
    {
        public FrmActualizarRepresentante()
        {
            string cadenaSQL2 = "";
            BaseSQL objeto2 = new BaseSQL();
            InitializeComponent();
            cadenaSQL2 = "SELECT DISTINCT Director FROM Rep_Ventas";
            this.txtDirector.DataSource = objeto2.LeerDatos(cadenaSQL2);
            txtDirector.DisplayMember = "Director";
            txtDirector.ValueMember = "Director";
            cadenaSQL2 = "SELECT DISTINCT Titulo FROM Rep_Ventas";
            this.txtTitulo.DataSource = objeto2.LeerDatos(cadenaSQL2);
            txtTitulo.DisplayMember = "Titulo";
            txtTitulo.ValueMember = "Titulo";
            cadenaSQL2 = "SELECT DISTINCT Nombre,Num_Rep FROM Rep_Ventas";
            this.txtNum_Rep.DataSource = objeto2.LeerDatos(cadenaSQL2);
            txtNum_Rep.DisplayMember = "Nombre";
            txtNum_Rep.ValueMember = "Num_Rep";
            cadenaSQL2 = "SELECT DISTINCT EstadoRep FROM Rep_Ventas";
            this.txtEstado.DataSource = objeto2.LeerDatos(cadenaSQL2);
            txtEstado.DisplayMember = "EstadoRep";
            txtEstado.ValueMember = "EstadoRep";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";
            cadenaSQL = "ActualizarRepVentas " + this.txtNum_Rep.SelectedValue + ",'" + txtNombre.Text + "'," + txtEdad.Text + ",'" + txtTitulo.Text + "','" + txtContrato.Text + "'," + txtCuota.Text + "," + txtVentas.Text + "," + txtOficina.Text + "," + txtEstado.Text + "";

            try
            {
                objeto.ejecutar(cadenaSQL);
                MessageBox.Show("El Representante se actualizo correctamente!");
            }
            catch (Exception ex)
            {
                //Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL: ");
            }


            //Se limpian los objetos
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtContrato.Text = "";
            txtOficina.Text = "";
            txtCuota.Text = "";
            txtVentas.Text = "";
            cadenaSQL = "SELECT DISTINCT Nombre,Num_Rep FROM Rep_Ventas";
            this.txtNum_Rep.DataSource = objeto.LeerDatos(cadenaSQL);
            txtNum_Rep.DisplayMember = "Nombre";
            txtNum_Rep.ValueMember = "Num_Rep";
        }

        private void txtNum_Rep_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BaseSQL objeto = new BaseSQL();

                string cadenaSQL = "";
                if (txtNum_Rep.SelectedValue != null)
                {
                    //Obtiene el Id_Fab seleccionado

                    //Llena el comboBox cmbIDProd por medio de la clase leerDatos.
                    cadenaSQL = "SELECT * FROM Rep_Ventas WHERE Num_Rep = " + this.txtNum_Rep.SelectedValue + "";
                    SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);
                    if (dr.Read())
                    {
                        txtEdad.Text = dr["Edad"].ToString();
                        txtNombre.Text = dr["Nombre"].ToString();
                        txtOficina.Text = dr["Oficina_Rep"].ToString();
                        DateTime contratoDate = (DateTime)dr["Contrato"];
                        string contratoFormatted = contratoDate.ToString("yyyy-MM-dd");
                        txtContrato.Text = contratoFormatted;
                        txtCuota.Text = dr["Cuota"].ToString();
                        txtVentas.Text = dr["Ventas"].ToString();
                        txtEstado.Text = dr["EstadoRep"].ToString();
                        txtTitulo.SelectedValue = dr["Titulo"].ToString();
                        txtDirector.SelectedValue = dr["Director"].ToString();
                    }
                }

            }
            catch (Exception ed)
            {

            }
        }

        private void FrmActualizarRepresentante_Load(object sender, EventArgs e)
        {

        }
    }
}
