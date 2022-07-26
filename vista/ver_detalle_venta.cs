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
        }

        private void ver_detalle_venta_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
