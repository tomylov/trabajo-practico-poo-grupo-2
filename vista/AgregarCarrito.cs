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
        int fila;
        public AgregarCarrito()
        {
            InitializeComponent();
            btnAgregar.Enabled = false;
            btneliminar.Enabled = false;
            txtSub.Text = "0";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void AgregarCarrito_Load(object sender, EventArgs e)
        {
        }

        public static int cont_fila = 0;

        

        

        public bool valinumero()
        {
            if(txtCant.Text.All(Char.IsDigit) && txtCant.Text!="")
            {
                return true;
            }
            else
            {
                MessageBox.Show("la cantidad debe ser un numero");
                return false;
            }
        }

        public bool cantidad()
        {
            string cmd = string.Format("Select * from Articulos where Id ="+txtCod.Text);
            DataSet ds = Controladora.sql_consulta.Ejecutar(cmd);
            int stock = Convert.ToInt32(ds.Tables[0].Rows[0]["stock"]);
            string id = ds.Tables[0].Rows[0]["Id"].ToString();
            if (stock >= Convert.ToInt32(txtCant.Text))
            {
                //update de los artiuclos dentro de la bd
                int nuevoS = stock - Convert.ToInt32(txtCant.Text);
                cmd = string.Format("update Articulos set stock="+nuevoS+"where Id= "+id);
                Controladora.sql_consulta.Ejecutar(cmd);
                return true;
            } else
            {
                MessageBox.Show("se ha excedido de la cantidad disponible");
                return false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (valinumero()&&cantidad())
            {
                double importe = 0;
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

                CMD = string.Format("Select COUNT(Id) from Detalle_ventas");
                ds = Controladora.sql_consulta.Ejecutar(CMD);
                string ideta = ds.Tables[0].Rows[0][0].ToString();

                importe = Convert.ToDouble(txtCant.Text) * (Convert.ToDouble(precio));
                dataGridView1.Rows.Add(txtCod.Text, txtDesc.Text, precio, txtCant.Text, importe,ideta);

                txtSub.Text = (Convert.ToDouble(txtSub.Text)+importe).ToString();                
            }
             
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
        

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[fila].Cells[5].Value);
            string cmd = string.Format("delete from Detalle_ventas where Id=" + id);
            Controladora.sql_consulta.Ejecutar(cmd);

            int idart = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value);
            cmd = string.Format("select * from Articulos where Id=" + idart);
            DataSet ds = Controladora.sql_consulta.Ejecutar(cmd);
            int stockSQL = Convert.ToInt32(ds.Tables[0].Rows[0]["stock"]);
            int stock = Convert.ToInt32(dataGridView1.Rows[fila].Cells[3].Value);
            int suma = stockSQL + stock;
            cmd = string.Format("update Articulos set stock=" + suma +"where Id="+idart);
            Controladora.sql_consulta.Ejecutar(cmd);

            double precio = Convert.ToDouble(dataGridView1.Rows[fila].Cells[4].Value);
            txtSub.Text = (Convert.ToDouble(txtSub.Text)-precio).ToString();
            dataGridView1.Rows.RemoveAt(fila);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            int valor = dataGridView1.Rows.Count;
            if (fila == -1 || fila==valor-1)
            {
                btneliminar.Enabled = false;
            }
            else
            {
                btneliminar.Enabled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("select count(Id) from Ventas");
            DataSet ds = sql_consulta.Ejecutar(cmd);
            string Idvta =  ds.Tables[0].Rows[0][0].ToString();

            cmd = string.Format("update Ventas set estado='pendiente' where Id="+Idvta);
            sql_consulta.Ejecutar(cmd);
            MessageBox.Show("venta recibida con exito");
            this.Close();
        }
    }
}