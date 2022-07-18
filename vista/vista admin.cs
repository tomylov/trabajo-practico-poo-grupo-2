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
    public partial class vista_admin : Form
    {
        public vista_admin()
        {
            InitializeComponent();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            GestionarUsuarios frm = new GestionarUsuarios();
            frm.Show();
        }

        private void btnart_Click(object sender, EventArgs e)
        {
        }

        private void btnprov_Click(object sender, EventArgs e)
        {
            GestionarProveedores frm = new GestionarProveedores();
            frm.Show();
        }
    }
}
