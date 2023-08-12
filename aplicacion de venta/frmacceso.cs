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
    public partial class frmacceso : Form
    {
        public frmacceso()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            StringBuilder cadena = new StringBuilder();
            cadena.Append("open symmetric key KeySym decryption by certificate CertSeg;");
            cadena.Append("select convert(varchar, decryptbyKey(nom_usu)),convert(varchar, decryptbyKey(clav_usu)) from dbo.usuarios where  convert(varchar, decryptbyKey(nom_usu))= '" + txtusuario.Text + "' and convert(varchar, decryptbyKey(clav_usu))='" + txtclave.Text + "'");
            cadena.Append("close all symmetric keys");
            SqlDataReader dr = objeto.ConsultaSQL(cadena.ToString());
            if (dr.Read()) {
                MessageBox.Show("Acceso permitido");
                frmMenu f = new frmMenu();
                f.Show();
                frmacceso g = new frmacceso();
                g.Close();
            } else
            {
                MessageBox.Show("Acceso denegado");
            }
        }
    }
}
