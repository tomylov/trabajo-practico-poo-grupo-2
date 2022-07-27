using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace vista
{
    public partial class modificar_usuario : Form
    {
        int iduser;
        string email ;
        public modificar_usuario(int id)
        {
            InitializeComponent();
            string CMD = string.Format("select * from Usuarios where Id="+ id);
            DataSet ds = Controladora.sql_consulta.Ejecutar(CMD);
            txtnom.Text = ds.Tables[0].Rows[0]["Nombre"].ToString().Trim();            
            txtnom.Enabled = false;            
            txtmail.Text = ds.Tables[0].Rows[0]["Email"].ToString().Trim();
            txttel.Text = ds.Tables[0].Rows[0]["Telefono"].ToString().Trim();
            txtDNI.Text = ds.Tables[0].Rows[0]["DNI"].ToString().Trim();
            this.iduser = id;
            email = txtmail.Text;
            CMD = string.Format(" select CONVERT(varchar(max),dECRYPTBYPASSPHRASE('contraseña',Contraseña)) from Usuarios where Id="+id);
            ds = Controladora.sql_consulta.Ejecutar(CMD);
            txtcontra.Text = ds.Tables[0].Rows[0][0].ToString().Trim();
            txtcontra2.Text = ds.Tables[0].Rows[0][0].ToString().Trim();

        }

        public bool valdni()
        {
            bool validador = false;
            if (txtDNI.Text.Length == 8)
            {
                validador = true;
            }
            else
            {
                MessageBox.Show("El dni debe tener 8 caracteres");
                txtDNI.Focus();
                validador = false;
                return false;
            }

            if (txtDNI.Text.All(char.IsDigit) && validador == true)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Deben ser 8 numeros");
                return false;
            }

        }

        public bool valitel()
        {
            if (txttel.Text.All(char.IsDigit) && txttel.Text != "")

            {
                return true;
            }
            else
            {
                MessageBox.Show("Deben ser solo numeros en el telefono");
                return false;
            }
        }

        static public bool ValidacionEMAIL(string Mail)
        {

            Regex mRegxExpression;

            if (Mail.Trim() != string.Empty)
            {

                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(Mail.Trim()))
                {
                    MessageBox.Show("esta mal la direccion Email");
                    //no es correcta
                    return false;
                }
                else
                {
                    //es correcta
                    return true;
                }

            }
            else
            {
                MessageBox.Show("no hay nada en el espacio mail");
                //no es correcta, esta vacia
                return false;
            }

        }

        public bool existmail()
        {
            if (email != txtmail.Text)
            {
                string CMD = string.Format("select count(Email) from Usuarios where Email='{0}'", txtmail.Text);
                DataSet DS = Controladora.sql_consulta.Ejecutar(CMD);
                int validador = Convert.ToInt32(DS.Tables[0].Rows[0][0]);

                if (validador == 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("ya hay un usuario creado con ese mail");
                    return false;
                }
            }
            else 
            {
                return true;
            }
        }
        public bool valicontra()
        {
            if (txtcontra.Text == txtcontra2.Text && txtcontra.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("las contraseñas no coinciden");
                txtcontra.Text = "";
                txtcontra2.Text = "";
                return false;
            }

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (ValidacionEMAIL(txtmail.Text)&&existmail()&&valitel()&&valicontra()&&valdni()) {
                string cmd = string.Format("update Usuarios set Email='{0}',Contraseña=ENCRYPTBYPASSPHRASE('contraseña','{1}') ,Telefono='{2}' ,DNI='{3}' " +
                    "where Id=" + iduser, txtmail.Text, txtcontra.Text, txttel.Text, txtDNI.Text);
                //txtmail.Text +txtcontra.Text + txttel.Text + txtDNI.Text
                Controladora.sql_consulta.Ejecutar(cmd);
                this.Close();
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void modificar_usuario_Load(object sender, EventArgs e)
        {

        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
