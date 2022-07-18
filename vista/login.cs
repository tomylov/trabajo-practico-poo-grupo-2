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
        int idperfil;

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool valilog(string user, string pass)
        {
            string Contraseña = "";
            bool validador= false;
            try
            {
                string CMD = string.Format("select * from Usuarios where Email='{0}'", user);
                DataSet ds = Controladora.sql_consulta.Ejecutar(CMD);
                Contraseña = ds.Tables[0].Rows[0]["Contraseña"].ToString().Trim();
                idperfil= Convert.ToInt32(ds.Tables[0].Rows[0]["PerfilId"]);
            }
            catch (Exception)
            {
                validador = false;
            }

            if (Contraseña != pass || pass == "")
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
                switch (idperfil)
                {
                    case 1:
                        GestionarUsuarios adm = new GestionarUsuarios();
                        adm.Show();

                        break;
                    case 2:
                        VistaCliente frm = new VistaCliente(user);
                        frm.Show();
                        break;
                    case 3:
                        GestionarVentas vend = new GestionarVentas();
                        vend.Show();
                        break;
                }
                
               
            }
            
        }
    }
}
