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
    public partial class modificar_usuario : Form
    {
        int iduser;
        public modificar_usuario(int id)
        {
            InitializeComponent();
            string CMD = string.Format("select * from Usuarios where Id="+ id);
            DataSet ds = Controladora.sql_consulta.Ejecutar(CMD);
            txtnom.Text = ds.Tables[0].Rows[0]["Nombre"].ToString().Trim();            
            txtnom.Enabled = false;
            txtcontra.Text = ds.Tables[0].Rows[0]["Contraseña"].ToString().Trim();
            txtmail.Text = ds.Tables[0].Rows[0]["Email"].ToString().Trim();
            txttel.Text = ds.Tables[0].Rows[0]["Telefono"].ToString().Trim();
            txtDNI.Text = ds.Tables[0].Rows[0]["DNI"].ToString().Trim();
            this.iduser = id;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string cmd= string.Format("update Usuarios set Email='{0}',Contraseña='{1}' ,Telefono='{2}' ,DNI='{3}' " +
                "where Id="+iduser, txtmail.Text, txtcontra.Text, txttel.Text, txtDNI.Text);
            //txtmail.Text +txtcontra.Text + txttel.Text + txtDNI.Text
            Controladora.sql_consulta.Ejecutar(cmd);
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
