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
    public partial class Registro : Form
    {
        int id=0;
        public Registro(int valor)
        {
            InitializeComponent();
            this.id = valor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public bool valicontra()
        {
            if (txtpass.Text == txtpass2.Text)
            {
                return true;
            }
            else
            {
                MessageBox.Show("las contraseñas no coinciden");
                txtpass.Text = "";
                txtpass2.Text = "";
                return false;                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (valicontra())
            {
                Modelo.Usuario usuario = new Modelo.Usuario();
                usuario.Nombre = txtname.Text;
                usuario.DNI = txtdni.Text;
                usuario.Email = txtmail.Text;             
                usuario.Contraseña = txtpass.Text;
                usuario.Telefono = txtphone.Text;
                usuario.PerfilId = id;
                Controladora.Controladora_usuarios.obtener_instancia().Agregar_Usuario(usuario);
                MessageBox.Show("usuario creado con exito");
                this.Close();
            }

        }
    }
}
