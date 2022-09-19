using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            using (var ws = new ServiceReference1.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(tbCep.Text);
                    tbEndereco.Text = resultado.end;
                    tbComplemento.Text = resultado.complemento2;
                    tbBairro.Text = resultado.bairro;
                    tbCidade.Text = resultado.cidade;
                    tbEstado.Text = resultado.uf;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            //SqlConnetction sql = new SqlConnetction("Data");
            //SqlConnection command = new SqlCommnd("insert into Endereco(cep, endereco, numero, complemento, bairro, cidade, estado") +
            //                             "values(@cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)", sql);
            //command.Parameters.Add("@cep", SqlDbType.VarChar).Value = tbCep.Text


            //    try
            //{
            //    sql.Open();
            //    commad.ExecuteNonQuery();
            //    MessageBox.Show("Endereço Cadastrado com Sucesso");
            //    tcCep.Clear();
        
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show("Erro:" + ex);
            //}
            //finally
            //{
            //    sql.Close();
            //}
        }
    }
}
