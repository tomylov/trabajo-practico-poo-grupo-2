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
            if (user == "admin" && pass == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnini_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string passw = txtpass.Text;

            if (valilog(user, passw))
            {
                vista_admin frm = new vista_admin();
                frm.Show();
                //MessageBox.Show("ingreso exitoso", "validador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("error al iniciar sesion", "validador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
