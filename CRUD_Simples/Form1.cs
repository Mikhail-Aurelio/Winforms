using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro Cad = new Cadastro(txtBoxNome.Text);
            MessageBox.Show(Cad.Mensagem);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            AtualizaDados Atualizar = new AtualizaDados();
            Atualizar.Atualizar(dataGridView1.CurrentCell.Value.ToString(),txtBoxNome.Text);
            MessageBox.Show("Atualizado com Sucesso");
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            MostraDados Mostrar = new MostraDados();
            if (txtBoxNome.Text.Equals(""))
            {
                dataGridView1.DataSource = Mostrar.Mostrar();
            }
            else
            {
                dataGridView1.DataSource = Mostrar.Mostrar(txtBoxNome.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ExcluiDados Excluir = new ExcluiDados();
            Excluir.Excluir(dataGridView1.CurrentCell.Value.ToString());
            MessageBox.Show("Excluído com Sucesso");
        }
    }
}
