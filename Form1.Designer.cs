
namespace CefisaPrinter
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.tbxProduto = new System.Windows.Forms.TextBox();
            this.tbxQuantidade = new System.Windows.Forms.TextBox();
            this.tbxPeso = new System.Windows.Forms.TextBox();
            this.tbxLote = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(43, 42);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(43, 76);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 1;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(43, 119);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso";
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(43, 161);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(28, 13);
            this.lblLote.TabIndex = 3;
            this.lblLote.Text = "Lote";
            // 
            // tbxProduto
            // 
            this.tbxProduto.Location = new System.Drawing.Point(147, 39);
            this.tbxProduto.Name = "tbxProduto";
            this.tbxProduto.Size = new System.Drawing.Size(231, 20);
            this.tbxProduto.TabIndex = 4;
            // 
            // tbxQuantidade
            // 
            this.tbxQuantidade.Location = new System.Drawing.Point(147, 76);
            this.tbxQuantidade.Name = "tbxQuantidade";
            this.tbxQuantidade.Size = new System.Drawing.Size(75, 20);
            this.tbxQuantidade.TabIndex = 5;
            // 
            // tbxPeso
            // 
            this.tbxPeso.Location = new System.Drawing.Point(147, 119);
            this.tbxPeso.Name = "tbxPeso";
            this.tbxPeso.Size = new System.Drawing.Size(75, 20);
            this.tbxPeso.TabIndex = 6;
            // 
            // tbxLote
            // 
            this.tbxLote.Location = new System.Drawing.Point(147, 161);
            this.tbxLote.Name = "tbxLote";
            this.tbxLote.Size = new System.Drawing.Size(151, 20);
            this.tbxLote.TabIndex = 7;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(276, 242);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(174, 51);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.tbxLote);
            this.Controls.Add(this.tbxPeso);
            this.Controls.Add(this.tbxQuantidade);
            this.Controls.Add(this.tbxProduto);
            this.Controls.Add(this.lblLote);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblProduto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.TextBox tbxProduto;
        private System.Windows.Forms.TextBox tbxQuantidade;
        private System.Windows.Forms.TextBox tbxPeso;
        private System.Windows.Forms.TextBox tbxLote;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button button1;
    }
}

