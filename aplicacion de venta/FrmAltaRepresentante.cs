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
    public partial class FrmAltaRepresentante : Form
    {
        public FrmAltaRepresentante()
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
            cadenaSQL2 = "SELECT DISTINCT EstadoRep FROM Rep_Ventas";
            this.txtEstado.DataSource = objeto2.LeerDatos(cadenaSQL2);
            txtEstado.DisplayMember = "EstadoRep";
            txtEstado.ValueMember = "EstadoRep";

            cadenaSQL2 = "SELECT MAX(Num_Rep) AS nummax FROM Rep_Ventas;";
            SqlDataReader dr = objeto2.ConsultaSQL(cadenaSQL2);
            if (dr.Read())
            {
                txtNum_Rep.Text = dr["nummax"].ToString();
                int munc = Convert.ToInt32(txtNum_Rep.Text);
                munc = munc + 1;
                txtNum_Rep.Text = munc.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";
            cadenaSQL = "INSERT INTO Rep_Ventas (Num_Rep, Nombre, Edad,Titulo,Contrato, Oficina_Rep, Director, Cuota, Ventas, EstadoRep) VALUES ";
            cadenaSQL = cadenaSQL + "( " + txtNum_Rep.Text + ",'" + txtNombre.Text + "'," + txtEdad.Text + ",'" + txtTitulo.Text + "','" + txtContrato.Text + "'," + txtOficina.Text + "," + txtDirector.Text + "," + txtCuota.Text + "," + txtVentas.Text + "," + txtEstado.Text + ");";

            objeto.ejecutar(cadenaSQL);

            //Se despliega el mensaje para indicar que el registro del producto se guarto correctamente
            MessageBox.Show("Representante guardado Correctamente");

            //Se limpian los objetos
            cadenaSQL = "SELECT MAX(Num_Rep) AS nummax FROM Rep_Ventas;";
            SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);
            if (dr.Read())
            {
                txtNum_Rep.Text = dr["nummax"].ToString();
                int munc = Convert.ToInt32(txtNum_Rep.Text);
                munc = munc + 1;
                txtNum_Rep.Text = munc.ToString();
            }
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtContrato.Text = "";
            txtOficina.Text = "";
            txtEstado.Text = "";
            txtCuota.Text = "";
            txtVentas.Text = "";
        }

        private void FrmAltaRepresentante_Load(object sender, EventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
