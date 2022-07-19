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
        public ver_detalle_venta(string valor)
        {
            InitializeComponent();
            string CMD = string.Format("select * from Detalle_ventas where Id=" +valor);
            dataGridView1.DataSource = Controladora.sql_consulta.Ejecutar(CMD).Tables[0];
        }

        private void ver_detalle_venta_Load(object sender, EventArgs e)
        {

        }
    }
}
