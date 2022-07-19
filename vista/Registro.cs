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
                return true;
            }
            else
            {
                MessageBox.Show("las contraseñas no coinciden");
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
                MessageBox.Show("El dni debe tener 8 caracteres");
                txtdni.Focus();
                validador = false;
                return false;
            }

            if(txtdni.Text.All(char.IsDigit)&&validador==true)
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
            if (txtdni.Text.All(char.IsDigit)&&txtphone.Text!="")
                
            {
                return true;
            }
            else
            {
                MessageBox.Show("Deben ser solo numeros en el telefono");                
                return false;
            }
        }

        public bool valinom()
        {
            if(txtname.Text.All(char.IsLetter)&&txtname.Text!="")
            {
                return true;
            }
            else
            {
                MessageBox.Show("en nombre solo debe poseer letras");
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
                MessageBox.Show("no hay nada en el espacio mail");
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
                return true;
            }
            else
            {
                MessageBox.Show("ya hay un usuario creado con ese mail");
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
                MessageBox.Show("usuario creado con exito");
                this.Close();
            }

        }
    }
}
