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

        public static bool valilog(string user, string pass)
        {
            bool validador= false;
            string Contraseña="";
            try
            {
                //Modelo.Usuario usuario = Controladora.Controladora_usuarios.obtener_instancia().Obtener_Usuario(user);
                string CMD = string.Format("select * from Usuarios where Email='{0}'",user);
                DataSet ds = Controladora.consuta_sql.Ejecutar(CMD);
                Contraseña = ds.Tables[0].Rows[0]["Contraseña"].ToString().Trim(); 
            }
            catch (Exception)
            {
                validador = false;
            }

            if (Contraseña != pass && pass!="")
            {
                validador = false;
                MessageBox.Show("usuario/contraseña incorrecto", "validador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                validador = true;
                
            }


            return validador;
        }

        private void btnini_Click(object sender, EventArgs e)
        {

            string user = txtuser.Text;
            string passw = txtpass.Text;

            if (valilog(user, passw))
            {                
                GestionarUsuarios frm = new GestionarUsuarios();
                frm.Show();
            }
            
        }
    }
}
