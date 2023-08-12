using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Pilarr
{
    public partial class formaltausuarios : Form
    {
        public formaltausuarios()
        {
            string cadenaSQL2 = "";
            BaseSQL objeto2 = new BaseSQL();
            InitializeComponent();
            cadenaSQL2 = "SELECT DISTINCT Num_Rep FROM Rep_Ventas";
            this.tbnum_rep.DataSource = objeto2.LeerDatos(cadenaSQL2);
            tbnum_rep.DisplayMember = "Num_Rep";
            tbnum_rep.ValueMember = "Num_Rep";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            StringBuilder cadena = new StringBuilder();
            cadena.Append ("open symmetric key KeySym decryption by certificate CertSeg;");
            cadena.Append ("Insert into dbo.usuarios2(num_Rep, nom_usu, clav_usu) values (" + tbnum_rep.Text + ", ENCRYPTBYKEY(KEY_GUID('KeySym'),'" + txtusuario.Text + "'),ENCRYPTBYKEY(KEY_GUID('KeySym'),'" + txtclave.Text +"'));");
           cadena.Append("close all symmetric keys");
            objeto.ejecutar(cadena.ToString());
            MessageBox.Show("El usuario se agrego!" );

        }
    }
}
