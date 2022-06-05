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
    public class InserirBd
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        public string msg = ""; //erro ou sucess

        public void Adicionar(string codigocefisa, string nome, int qtd, int peso)
        {
            //comando sql

            cmd.CommandText = "INSERT INTO embalagemParts (codigoCefisa, nomeParts, qtdParts, pesoParts)" +
                "VALUES (@codigoCefisa, @nomeParts, @qtdParts, @pesoParts)";
            cmd.Parameters.AddWithValue("@codigoCefisa", codigocefisa);
            cmd.Parameters.AddWithValue("@nomeParts", nome);
            cmd.Parameters.AddWithValue("@qtdParts", qtd);
            cmd.Parameters.AddWithValue("@pesoParts", peso);
            

          

            cmd.Connection = conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
            this.msg = " ADICIONADO AO BANDO DE DADOS AS" + DateTime.Now.ToString();

        }
    }
}
