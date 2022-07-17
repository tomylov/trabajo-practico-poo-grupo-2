using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static bool valilog(int user, string pass)
        {
            bool validador= false;
            try
            {
                Modelo.Usuario usuario = Controladora.Controladora_usuarios.obtener_instancia().Obtener_Usuario(user);
                if (usuario.Contraseña == pass)
                {
                    validador = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("usuario/contraseña incorrecto", "validador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return validador;
        }

        private void btnini_Click(object sender, EventArgs e)
        {
            int user = int.Parse(txtuser.Text);
            string passw = txtpass.Text;

            if (valilog(user, passw))
            {
                vista_admin frm = new vista_admin();
                frm.Show();
                //MessageBox.Show("ingreso exitoso", "validador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
