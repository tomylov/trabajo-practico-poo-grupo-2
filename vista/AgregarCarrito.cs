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

        public static int cont_fila = 0;

        double importe = 0;

        double subtotal;

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
            CMD = string.Format("Select * from Articulos where id= " + txtCod.Text);
            ds = Controladora.sql_consulta.Ejecutar(CMD);
            string precio = ds.Tables[0].Rows[0]["Precio"].ToString().Trim();
            
            importe = Convert.ToDouble(txtCant.Text) * (Convert.ToDouble(precio));
            dataGridView1.Rows.Add(txtCant.Text, txtDesc.Text, precio, txtCant.Text, importe);

            subtotal += importe;
            txtSub.Text = subtotal.ToString();
             
        }

        private void btnArt_Click_1(object sender, EventArgs e)
        {
            Articulos frm = new Articulos();
            frm.Show();

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            bool valido;
            try 
            {
                string CMD = string.Format("Select * from Articulos where id= " + txtCod.Text);
                DataSet ds = Controladora.sql_consulta.Ejecutar(CMD);
                txtDesc.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                valido = true;
            }
            catch (Exception)
            {
                txtDesc.Text = "no existe el codigo seleccionado";
                valido = false;
                
            }
            if (valido)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }
    }
}