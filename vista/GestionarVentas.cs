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
            if (fila == -1 || fila == valor - 1)
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
