namespace Aula03
{
    partial class Form2
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
            this.buscar = new System.Windows.Forms.Button();
            this.tbCep = new System.Windows.Forms.TextBox();
            this.cpf = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbEestado = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.tbNumLote = new System.Windows.Forms.TextBox();
            this.lbnumLote = new System.Windows.Forms.Label();
            this.salvar = new System.Windows.Forms.Button();
            this.lbBairro = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(224, 32);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 0;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // tbCep
            // 
            this.tbCep.Location = new System.Drawing.Point(83, 35);
            this.tbCep.Name = "tbCep";
            this.tbCep.Size = new System.Drawing.Size(135, 20);
            this.tbCep.TabIndex = 1;
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Location = new System.Drawing.Point(49, 38);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(27, 13);
            this.cpf.TabIndex = 2;
            this.cpf.Text = "CPF";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(83, 73);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(216, 20);
            this.tbEndereco.TabIndex = 4;
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(83, 147);
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(216, 20);
            this.tbComplemento.TabIndex = 6;
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Location = new System.Drawing.Point(6, 150);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(71, 13);
            this.lbComplemento.TabIndex = 7;
            this.lbComplemento.Text = "Complemento";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(23, 76);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(53, 13);
            this.lbEndereco.TabIndex = 8;
            this.lbEndereco.Text = "Endereço";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(37, 213);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(40, 13);
            this.lbCidade.TabIndex = 9;
            this.lbCidade.Text = "Cidade";
            // 
            // lbEestado
            // 
            this.lbEestado.AutoSize = true;
            this.lbEestado.Location = new System.Drawing.Point(37, 252);
            this.lbEestado.Name = "lbEestado";
            this.lbEestado.Size = new System.Drawing.Size(40, 13);
            this.lbEestado.TabIndex = 10;
            this.lbEestado.Text = "Estado";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(83, 213);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(216, 20);
            this.tbCidade.TabIndex = 11;
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(83, 249);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(216, 20);
            this.tbEstado.TabIndex = 12;
            // 
            // tbNumLote
            // 
            this.tbNumLote.Location = new System.Drawing.Point(83, 110);
            this.tbNumLote.Name = "tbNumLote";
            this.tbNumLote.Size = new System.Drawing.Size(216, 20);
            this.tbNumLote.TabIndex = 13;
            // 
            // lbnumLote
            // 
            this.lbnumLote.AutoSize = true;
            this.lbnumLote.Location = new System.Drawing.Point(6, 113);
            this.lbnumLote.Name = "lbnumLote";
            this.lbnumLote.Size = new System.Drawing.Size(70, 13);
            this.lbnumLote.TabIndex = 14;
            this.lbnumLote.Text = "Numero/Lote";
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(159, 287);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 15;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(42, 184);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(34, 13);
            this.lbBairro.TabIndex = 16;
            this.lbBairro.Text = "Bairro";
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(83, 181);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(216, 20);
            this.tbBairro.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbBairro);
            this.panel1.Controls.Add(this.lbBairro);
            this.panel1.Controls.Add(this.salvar);
            this.panel1.Controls.Add(this.lbnumLote);
            this.panel1.Controls.Add(this.tbNumLote);
            this.panel1.Controls.Add(this.tbEstado);
            this.panel1.Controls.Add(this.tbCidade);
            this.panel1.Controls.Add(this.lbEestado);
            this.panel1.Controls.Add(this.lbCidade);
            this.panel1.Controls.Add(this.lbEndereco);
            this.panel1.Controls.Add(this.lbComplemento);
            this.panel1.Controls.Add(this.tbComplemento);
            this.panel1.Controls.Add(this.tbEndereco);
            this.panel1.Controls.Add(this.cpf);
            this.panel1.Controls.Add(this.tbCep);
            this.panel1.Controls.Add(this.buscar);
            this.panel1.Location = new System.Drawing.Point(155, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 323);
            this.panel1.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Endereco";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox tbCep;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbEestado;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.TextBox tbNumLote;
        private System.Windows.Forms.Label lbnumLote;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Panel panel1;
    }
}