namespace Aula03
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.lbSobrenome = new System.Windows.Forms.Label();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.lbNomeMae = new System.Windows.Forms.Label();
            this.lbNomePai = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbRG = new System.Windows.Forms.Label();
            this.lbOrgaoEx = new System.Windows.Forms.Label();
            this.tbSobrenome = new System.Windows.Forms.TextBox();
            this.tbDataNascimento = new System.Windows.Forms.TextBox();
            this.tbNomeMae = new System.Windows.Forms.TextBox();
            this.tbNomePai = new System.Windows.Forms.TextBox();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbRG = new System.Windows.Forms.TextBox();
            this.tbOrgaoEx = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbOrgaoEx);
            this.panel1.Controls.Add(this.tbRG);
            this.panel1.Controls.Add(this.tbCPF);
            this.panel1.Controls.Add(this.tbNomePai);
            this.panel1.Controls.Add(this.tbNomeMae);
            this.panel1.Controls.Add(this.tbDataNascimento);
            this.panel1.Controls.Add(this.tbSobrenome);
            this.panel1.Controls.Add(this.lbOrgaoEx);
            this.panel1.Controls.Add(this.lbRG);
            this.panel1.Controls.Add(this.lbCPF);
            this.panel1.Controls.Add(this.lbNomePai);
            this.panel1.Controls.Add(this.lbNomeMae);
            this.panel1.Controls.Add(this.lbDataNascimento);
            this.panel1.Controls.Add(this.lbSobrenome);
            this.panel1.Controls.Add(this.btSalvar);
            this.panel1.Controls.Add(this.lbNome);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Location = new System.Drawing.Point(26, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 295);
            this.panel1.TabIndex = 0;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(119, 47);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 20);
            this.tbNome.TabIndex = 0;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(78, 50);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(241, 239);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 2;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // lbSobrenome
            // 
            this.lbSobrenome.AutoSize = true;
            this.lbSobrenome.Location = new System.Drawing.Point(268, 50);
            this.lbSobrenome.Name = "lbSobrenome";
            this.lbSobrenome.Size = new System.Drawing.Size(61, 13);
            this.lbSobrenome.TabIndex = 3;
            this.lbSobrenome.Text = "Sobrenome";
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Location = new System.Drawing.Point(78, 96);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(89, 13);
            this.lbDataNascimento.TabIndex = 4;
            this.lbDataNascimento.Text = "Data Nascimento";
            // 
            // lbNomeMae
            // 
            this.lbNomeMae.AutoSize = true;
            this.lbNomeMae.Location = new System.Drawing.Point(78, 180);
            this.lbNomeMae.Name = "lbNomeMae";
            this.lbNomeMae.Size = new System.Drawing.Size(77, 13);
            this.lbNomeMae.TabIndex = 5;
            this.lbNomeMae.Text = "Nome da  Mãe";
            // 
            // lbNomePai
            // 
            this.lbNomePai.AutoSize = true;
            this.lbNomePai.Location = new System.Drawing.Point(286, 180);
            this.lbNomePai.Name = "lbNomePai";
            this.lbNomePai.Size = new System.Drawing.Size(68, 13);
            this.lbNomePai.TabIndex = 6;
            this.lbNomePai.Text = "Nome do Pai";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(309, 96);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(27, 13);
            this.lbCPF.TabIndex = 7;
            this.lbCPF.Text = "CPF";
            // 
            // lbRG
            // 
            this.lbRG.AutoSize = true;
            this.lbRG.Location = new System.Drawing.Point(78, 139);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(23, 13);
            this.lbRG.TabIndex = 8;
            this.lbRG.Text = "RG";
            // 
            // lbOrgaoEx
            // 
            this.lbOrgaoEx.AutoSize = true;
            this.lbOrgaoEx.Location = new System.Drawing.Point(268, 135);
            this.lbOrgaoEx.Name = "lbOrgaoEx";
            this.lbOrgaoEx.Size = new System.Drawing.Size(86, 13);
            this.lbOrgaoEx.TabIndex = 9;
            this.lbOrgaoEx.Text = "Órgão Expedidor";
            // 
            // tbSobrenome
            // 
            this.tbSobrenome.Location = new System.Drawing.Point(335, 47);
            this.tbSobrenome.Name = "tbSobrenome";
            this.tbSobrenome.Size = new System.Drawing.Size(100, 20);
            this.tbSobrenome.TabIndex = 10;
            // 
            // tbDataNascimento
            // 
            this.tbDataNascimento.Location = new System.Drawing.Point(173, 93);
            this.tbDataNascimento.Name = "tbDataNascimento";
            this.tbDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.tbDataNascimento.TabIndex = 11;
            // 
            // tbNomeMae
            // 
            this.tbNomeMae.Location = new System.Drawing.Point(161, 177);
            this.tbNomeMae.Name = "tbNomeMae";
            this.tbNomeMae.Size = new System.Drawing.Size(100, 20);
            this.tbNomeMae.TabIndex = 12;
            // 
            // tbNomePai
            // 
            this.tbNomePai.Location = new System.Drawing.Point(360, 177);
            this.tbNomePai.Name = "tbNomePai";
            this.tbNomePai.Size = new System.Drawing.Size(100, 20);
            this.tbNomePai.TabIndex = 13;
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(342, 93);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(100, 20);
            this.tbCPF.TabIndex = 14;
            // 
            // tbRG
            // 
            this.tbRG.Location = new System.Drawing.Point(107, 136);
            this.tbRG.Name = "tbRG";
            this.tbRG.Size = new System.Drawing.Size(100, 20);
            this.tbRG.TabIndex = 15;
            // 
            // tbOrgaoEx
            // 
            this.tbOrgaoEx.Location = new System.Drawing.Point(360, 132);
            this.tbOrgaoEx.Name = "tbOrgaoEx";
            this.tbOrgaoEx.Size = new System.Drawing.Size(100, 20);
            this.tbOrgaoEx.TabIndex = 16;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbOrgaoEx;
        private System.Windows.Forms.TextBox tbRG;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.TextBox tbNomePai;
        private System.Windows.Forms.TextBox tbNomeMae;
        private System.Windows.Forms.TextBox tbDataNascimento;
        private System.Windows.Forms.TextBox tbSobrenome;
        private System.Windows.Forms.Label lbOrgaoEx;
        private System.Windows.Forms.Label lbRG;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbNomePai;
        private System.Windows.Forms.Label lbNomeMae;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.Label lbSobrenome;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNome;
    }
}