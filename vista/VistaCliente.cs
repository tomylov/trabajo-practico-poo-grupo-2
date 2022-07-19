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
    public partial class VistaCliente : Form
    {
        private string valor1;
        public VistaCliente(string valor)
        {
            InitializeComponent();
            this.valor1 = valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CMD = string.Format("select * from Usuarios where Email='{0}'", valor1);
            DataSet ds = Controladora.sql_consulta.Ejecutar(CMD);
            int va = Convert.ToInt32(ds.Tables[0].Rows[0]["Id"]);
            Modelo.Ventas ventas = new Modelo.Ventas();
            ventas.fecha = DateTime.Today.ToString();            
            ventas.UsuarioId = va;
            Controladora.Controladora_ventas.obtener_instancia().Agregar_Ventas(ventas);
            AgregarCarrito frm = new AgregarCarrito();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void VistaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
