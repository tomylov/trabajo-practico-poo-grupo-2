﻿using System;
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
        public Registro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public bool valicontra()
        {
            //hacer validacion
            return true;
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
                usuario.PerfilId = 2;
                Controladora.Controladora_usuarios.obtener_instancia().Agregar_Usuario(usuario);
            }

        }
    }
}
