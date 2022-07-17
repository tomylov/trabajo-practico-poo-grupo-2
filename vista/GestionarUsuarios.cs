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
    public partial class GestionarUsuarios : Form
    {
        public GestionarUsuarios()
        {
            InitializeComponent();
            dataGridView1.DataSource =Controladora.consuta_sql.LlenarDataGV("Usuarios","").Tables[0];
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GestionarUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }
    }
}
