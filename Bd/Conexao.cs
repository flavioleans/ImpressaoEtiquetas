using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace Bd
{
    public class Conexao
    {
        MySqlConnection con = new MySqlConnection();

        // Metodo construtor
        public Conexao()
        {
            con.ConnectionString = "Server=localhost;port=3306;Database=cefisa;Uid=root;Pwd=admin";
        }

        // Metodo Conectar
        public MySqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        // Metodo Desconectar
        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
