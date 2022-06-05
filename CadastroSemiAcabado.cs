using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using Bd;

namespace CefisaPrinter
{
    public partial class CadastroSemiAcabado : Form
    {
        public CadastroSemiAcabado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxCodigo.Text.Trim().ToString() == "" || (tbxProduto.Text.Trim().ToString() == "" || tbxQuantidade.Text.Trim().ToString() == "" || tbxPeso.Text.Trim().ToString() == ""))
            {
                MessageBox.Show("POR FAVOR PREENCHER TODOS OS CAMPOS!");
            }
            else
            {
                InserirBd inserir = new InserirBd();
                inserir.Adicionar(tbxCodigo.Text.ToString(), tbxProduto.Text.ToString(), int.Parse(tbxQuantidade.Text.ToString()), int.Parse(tbxPeso.Text.ToString()));
                MessageBox.Show("ITEM ADICIONADO COM SUCESSO!");
            }
        }
    }
}
