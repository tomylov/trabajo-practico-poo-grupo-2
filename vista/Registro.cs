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
    public partial class Registro : Form
    {
        int id=0;
        public Registro(int valor)
        {
            InitializeComponent();
            this.id = valor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public bool valicontra()
        {
            if (txtpass.Text == txtpass2.Text&& txtpass.Text!="")
            {
                errorProvider1.SetError(txtpass,"");
                errorProvider1.SetError(txtpass2,"");
                return true;
            }
            else
            {
                errorProvider1.SetError(txtpass,"Las contraseñas no coinciden");
                errorProvider1.SetError(txtpass2, "Las contraseñas no coinciden");
                txtpass.Text = "";
                txtpass2.Text = "";
                return false;                
            }
            
        }

        public bool valdni()
        {
            bool validador = false;
            if (txtdni.Text.Length == 8)
            {
                validador = true;
            }
            else
            {
                errorProvider1.SetError(txtdni,"El dni debe tener 8 caracteres");
                txtdni.Focus();
                validador = false;
                return false;
            }

            if(txtdni.Text.All(char.IsDigit)&&validador==true)
            {
                errorProvider1.SetError(txtdni, "");
                return true;
            }
            else
            {
                errorProvider1.SetError(txtdni,"El DNI ingresado debe poseer 8 numeros");
                return false;
            }

        }

        public bool valitel()
        {            
            if (txtphone.Text.All(char.IsDigit)&&txtphone.Text!="")
                
            {
                errorProvider1.SetError(txtphone, "");
                return true;
            }
            else
            {
                errorProvider1.SetError(txtphone, "Deben ser solo numeros en el telefono");
                return false;
            }
        }

        public bool valinom()
        {
            if(txtname.Text.All(char.IsLetter)&&txtname.Text!="")
            {
                errorProvider1.SetError(txtname,"");
                return true;
            }
            else
            {
                errorProvider1.SetError(txtname,"El nombre ingresado debe poseer unicamente letras");
                txtname.Focus();
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
                MessageBox.Show("El campo email es un campo obligatorio");
                //no es correcta, esta vacia
                return false;
            }

        }

        public bool existmail()
        {
            string CMD = string.Format("select count(Email) from Usuarios where Email='{0}'",txtmail.Text);
            DataSet DS = Controladora.sql_consulta.Ejecutar(CMD);
            int validador = Convert.ToInt32(DS.Tables[0].Rows[0][0]);

            if (validador==0)
            {
                errorProvider1.SetError(txtmail, "");
                return true;
            }
            else
            {
                errorProvider1.SetError(txtmail,"Ya existe un usuario creado con ese mail");                               
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (valinom()&&valitel()&&valdni()&& ValidacionEMAIL(txtmail.Text)&& existmail() && valicontra())
            {
                Modelo.Usuario usuario = new Modelo.Usuario();
                usuario.Nombre = txtname.Text;
                usuario.DNI = txtdni.Text;
                usuario.Email = txtmail.Text;             
                usuario.Contraseña = txtpass.Text;
                usuario.Telefono = txtphone.Text;
                usuario.PerfilId = id;
                Controladora.Controladora_usuarios.obtener_instancia().Agregar_Usuario(usuario);

                string cmd =string.Format("select max(Id) FROM Usuarios");
                DataSet DS= Controladora.sql_consulta.Ejecutar(cmd);
                id = Convert.ToInt32(DS.Tables[0].Rows[0][0]);

                cmd = string.Format("update Usuarios set Contraseña =ENCRYPTBYPASSPHRASE('contraseña','{0}') where Id="+id,txtpass.Text);
                Controladora.sql_consulta.Ejecutar(cmd);

                MessageBox.Show("Usuario creado con exito");
                this.Close();
            }

        }
    }
}
