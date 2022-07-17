using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Controladora
{
    public class sql_consulta
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QPP4BNK;Initial Catalog=POO_grupo2bd;Integrated Security=True");
            con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, con);
            DP.Fill(DS);

            con.Close();
            return DS;
        }

        public static DataSet LlenarDataGV(string tabla, string especifico)
        {
            DataSet DS;

            string cmd = string.Format("Select * from " + tabla + " " + especifico);
            DS = Ejecutar(cmd);

            return DS;
        }
    }
}
