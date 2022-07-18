using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;

namespace vista
{
    public partial class AgregarCarrito : Form
    {
        public AgregarCarrito()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void AgregarCarrito_Load(object sender, EventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string CMD = string.Format("select max(Id) from Ventas ");
            DataSet ds = Controladora.sql_consulta.Ejecutar(CMD);
            int va = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            Modelo.Detalle_ventas detalle = new Modelo.Detalle_ventas();
            detalle.cantidad = txtCant.Text;
            detalle.ArticulosId = Convert.ToInt32(txtCod.Text);
            detalle.VentasId = va;
            Controladora.Controladora_Detalle.obtener_instancia().Agregar_Detalle(detalle);
            String var = "where VentasId = "+ va.ToString();
            dataGridView1.DataSource = sql_consulta.LlenarDataGV("Detalle_Ventas ",var).Tables[0];
        }
    }
}
