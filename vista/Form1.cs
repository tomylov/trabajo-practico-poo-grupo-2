using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vista
{
    public partial class Form1 : Form
    {               
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionarUsuarios frm = new GestionarUsuarios();
            //login frm = new login();
            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro frm = new Registro(2);
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
