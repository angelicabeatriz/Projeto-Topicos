namespace Aula03
{
    partial class Inicial
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
            this.btPessoa = new System.Windows.Forms.Button();
            this.btEndereco = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSobre = new System.Windows.Forms.Button();
            this.btPagDev = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btPessoa
            // 
            this.btPessoa.Location = new System.Drawing.Point(49, 44);
            this.btPessoa.Name = "btPessoa";
            this.btPessoa.Size = new System.Drawing.Size(104, 61);
            this.btPessoa.TabIndex = 0;
            this.btPessoa.Text = "Pessoa";
            this.btPessoa.UseVisualStyleBackColor = true;
            // 
            // btEndereco
            // 
            this.btEndereco.Location = new System.Drawing.Point(226, 44);
            this.btEndereco.Name = "btEndereco";
            this.btEndereco.Size = new System.Drawing.Size(104, 61);
            this.btEndereco.TabIndex = 1;
            this.btEndereco.Text = "Endereco";
            this.btEndereco.UseVisualStyleBackColor = true;
            this.btEndereco.Click += new System.EventHandler(this.btEndereco_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btPagDev);
            this.panel1.Controls.Add(this.btSobre);
            this.panel1.Controls.Add(this.btEndereco);
            this.panel1.Controls.Add(this.btPessoa);
            this.panel1.Location = new System.Drawing.Point(50, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 278);
            this.panel1.TabIndex = 2;
            // 
            // btSobre
            // 
            this.btSobre.Location = new System.Drawing.Point(49, 149);
            this.btSobre.Name = "btSobre";
            this.btSobre.Size = new System.Drawing.Size(104, 62);
            this.btSobre.TabIndex = 2;
            this.btSobre.Text = "Página de Sobre";
            this.btSobre.UseVisualStyleBackColor = true;
            // 
            // btPagDev
            // 
            this.btPagDev.Location = new System.Drawing.Point(226, 149);
            this.btPagDev.Name = "btPagDev";
            this.btPagDev.Size = new System.Drawing.Size(104, 62);
            this.btPagDev.TabIndex = 3;
            this.btPagDev.Text = "Página do Desenvolvedor";
            this.btPagDev.UseVisualStyleBackColor = true;
            this.btPagDev.Click += new System.EventHandler(this.button2_Click);
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Inicial";
            this.Text = "Inical";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPessoa;
        private System.Windows.Forms.Button btEndereco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btPagDev;
        private System.Windows.Forms.Button btSobre;
    }
}

