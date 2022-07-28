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
    public partial class ver_detalle_venta : Form
    {
        public ver_detalle_venta(int valor)
        {
            
            InitializeComponent();
            string CMD = string.Format("select Articulos.nombre,cantidad,ArticulosId from Detalle_ventas inner join Articulos on Articulos.Id = ArticulosId where VentasId=" + valor);
            dataGridView1.DataSource = Controladora.sql_consulta.Ejecutar(CMD).Tables[0];

            CMD = string.Format("select Usuarios.Nombre,Usuarios.Email from Ventas inner join Usuarios on UsuarioId =Usuarios.Id where Ventas.Id="+valor);
            DataSet ds =Controladora.sql_consulta.Ejecutar(CMD);
            txtnombre.Text = ds.Tables[0].Rows[0][0].ToString().Trim();
            txtemail.Text = ds.Tables[0].Rows[0][1].ToString().Trim();
            txtemail.Enabled = false;
            txtnombre.Enabled = false;
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

        private void ver_detalle_venta_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
