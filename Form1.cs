using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impressao;

namespace CefisaPrinter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImpressaoZebra();
        }

        public void ImpressaoZebra()
        {
            try
            {
                string produto = tbxProduto.Text;
                string quantidade = tbxQuantidade.Text;
                string peso = tbxPeso.Text;
                string lote = DateTime.Now.ToString();

                var sb = new StringBuilder();
                PrintDialog pd = new PrintDialog();
                pd.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
                sb.AppendLine("I8,A,001");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("Q400,024");
                sb.AppendLine("q831");
                sb.AppendLine("rN");
                sb.AppendLine("S4");
                sb.AppendLine("D7");
                sb.AppendLine("ZT");
                sb.AppendLine("JF");
                sb.AppendLine("OD");
                sb.AppendLine("R16,0");
                sb.AppendLine("f100");
                sb.AppendLine("N");

                sb.AppendLine(string.Format(CultureInfo.InvariantCulture,
                    "A765,248,2,4,1,2,N,\"{0}\"", produto));
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture,
                    "A768,176,2,4,2,2,N,\"{0}\"","Quantidade"));
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture,
                    "A768,115,2,4,2,2,N,\"{0}\"", "Peso: "));
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture,
                    "A766,53,2,4,2,2,N,\"{0}\"", "Lote: "));
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture,
                    "A606,54,2,4,2,2,R,\"{0}\"",  lote));
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture,
                    "A596,118,2,4,2,2,R,\"{0}\"", peso));
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture,
                    "A404,175,2,4,2,2,R,\"{0}\"", quantidade));
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture,
                    "A500,388,2,4,2,2,R,\"{0}\"", "CEFISA"));
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture,
                    "A537,337,2,4,1,1,R,\"{0}\"", "PRODUTOS INFANTIS"));

                sb.AppendLine("P1,1");
                if (DialogResult.OK == pd.ShowDialog(this))
                {
                    LinhaImpressaoHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, sb.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Print Error: " + ex.Message);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroSemiAcabado cad = new CadastroSemiAcabado();
            cad.ShowDialog();
        }
    }
}
