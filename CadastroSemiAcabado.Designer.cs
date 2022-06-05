
namespace CefisaPrinter
{
    partial class CadastroSemiAcabado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxPeso = new System.Windows.Forms.TextBox();
            this.tbxQuantidade = new System.Windows.Forms.TextBox();
            this.tbxProduto = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPeso
            // 
            this.tbxPeso.Location = new System.Drawing.Point(296, 190);
            this.tbxPeso.Name = "tbxPeso";
            this.tbxPeso.Size = new System.Drawing.Size(75, 20);
            this.tbxPeso.TabIndex = 12;
            // 
            // tbxQuantidade
            // 
            this.tbxQuantidade.Location = new System.Drawing.Point(296, 147);
            this.tbxQuantidade.Name = "tbxQuantidade";
            this.tbxQuantidade.Size = new System.Drawing.Size(75, 20);
            this.tbxQuantidade.TabIndex = 11;
            // 
            // tbxProduto
            // 
            this.tbxProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxProduto.Location = new System.Drawing.Point(296, 110);
            this.tbxProduto.Name = "tbxProduto";
            this.tbxProduto.Size = new System.Drawing.Size(231, 20);
            this.tbxProduto.TabIndex = 10;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(192, 190);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 9;
            this.lblPeso.Text = "Peso";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(192, 147);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 8;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(192, 113);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 7;
            this.lblProduto.Text = "Produto";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxCodigo.Location = new System.Drawing.Point(296, 71);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(118, 20);
            this.tbxCodigo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código Cefisa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 49);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastroSemiAcabado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPeso);
            this.Controls.Add(this.tbxQuantidade);
            this.Controls.Add(this.tbxProduto);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblProduto);
            this.Name = "CadastroSemiAcabado";
            this.Text = "Cadastro de Produto Semi Acabado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPeso;
        private System.Windows.Forms.TextBox tbxQuantidade;
        private System.Windows.Forms.TextBox tbxProduto;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}