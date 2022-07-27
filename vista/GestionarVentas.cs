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
    public partial class GestionarVentas : Form
    {
        int fila;
        public GestionarVentas()
        {
            InitializeComponent();
            string CMD = string.Format("select * from Ventas where estado='pendiente'");
            dataGridView1.DataSource = Controladora.sql_consulta.Ejecutar(CMD).Tables[0];
            btnvta.Enabled = false;
            btnestado.Enabled = false;
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

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
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



        private void btnvta_Click(object sender, EventArgs e)
        {
            int IDvta = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value);
            ver_detalle_venta frm = new ver_detalle_venta(IDvta);
            frm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            int valor = dataGridView1.Rows.Count;
            if (fila == -1 || fila == valor)
            {
                btnvta.Enabled = false;
                btnestado.Enabled = false;
            }
            else
            {
                btnvta.Enabled = true;
                btnestado.Enabled = true;
            }

        }

        private void GestionarVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnestado_Click(object sender, EventArgs e)
        {
            int id= Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value);
            string CMD = string.Format("update Ventas set estado='Finalizado' where Id="+id);
            Controladora.sql_consulta.Ejecutar(CMD);
            dataGridView1.Rows.RemoveAt(fila);

        }
    }
}
