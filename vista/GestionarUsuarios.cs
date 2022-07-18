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
        int fila;
        public GestionarUsuarios()
        {
            InitializeComponent();
            string CMD = string.Format("select * from Usuarios where PerfilId=3");
            dataGridView1.DataSource = Controladora.sql_consulta.Ejecutar(CMD).Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Registro frm = new Registro(3);
            frm.Show();
            string CMD = string.Format("select * from Usuarios where PerfilId=3");
            dataGridView1.DataSource = Controladora.sql_consulta.Ejecutar(CMD).Tables[0];
        }

        public bool valifila()
        {
            if (fila == -1)
            {
                MessageBox.Show("debe seleccionar un usuario para eliminar");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if(valifila())
            {
                int id = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value);
                string cmd = string.Format(" delete from Usuarios where Id = "+id);
                Controladora.sql_consulta.Ejecutar(cmd);
                dataGridView1.Rows.RemoveAt(fila);
            }            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
        }
    }
}
