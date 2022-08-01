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
            btneliminar.Enabled = false;
            btnmodificar.Enabled = false;
            datagridinterfaz();
        }

        public void datagridinterfaz()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Turquoise;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Beige;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Green;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Oxygen", 12);
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersVisible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            
                int id = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value);
                modificar_usuario frm = new modificar_usuario(id);
                frm.Show();            
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Registro frm = new Registro(3);
            frm.Show();            
        }

        

        private void btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult DG = MessageBox.Show("Esta seguro que desea eliminar al usuario seleccionado?","control",MessageBoxButtons.YesNo);
            if (DG==DialogResult.Yes) {
                int id = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value);
                string cmd = string.Format(" delete from Usuarios where Id = " + id);
                Controladora.sql_consulta.Ejecutar(cmd);
                dataGridView1.Rows.RemoveAt(fila);
                MessageBox.Show("Usuario eliminado con exito");
            }
                    
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            int valor = dataGridView1.Rows.Count;
            if (fila == -1 || fila == valor)
            {
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
            }
            else
            {
                btneliminar.Enabled = true;
                btnmodificar.Enabled = true;
            }
        }

        private void GestionarUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string CMD = string.Format("select * from Usuarios where PerfilId=3");
            dataGridView1.DataSource = Controladora.sql_consulta.Ejecutar(CMD).Tables[0];
        }
    }
}
