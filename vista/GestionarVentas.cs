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
        }

        private void btnvta_Click(object sender, EventArgs e)
        {
            string IDvta = dataGridView1.Rows[fila].Cells[0].Value.ToString();
            ver_detalle_venta frm = new ver_detalle_venta(IDvta);
            frm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            int valor = dataGridView1.Rows.Count;
            if (fila == -1 || fila == valor - 1)
            {
                btnvta.Enabled = false;
            }
            else
            {
                btnvta.Enabled = true;
            }

        }

        private void GestionarVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
