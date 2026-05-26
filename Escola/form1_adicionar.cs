using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoAura4
{
    public partial class Form1 : Form
    {
        public List<Produto> ListaEstoque = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
            ConfigurarGrade();
            txtNome.CharacterCasing = CharacterCasing.Upper; }

        private void ConfigurarGrade()
        {
            dgvEstoque.Columns.Clear();
            dgvEstoque.Columns.Add("colNome", "produto");
			dgvEstoque.Columns.Add("colQuantidade", "Quantidade");
			dgvEstoque.Columns.Add("colValor", "Preço Unitário");
			dgvEstoque.Columns.Add("colTotalItem", "total do Item");

            dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.ReadOnly = true;
            dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

        private void btnSaida_Click(object sender, EventArgs e)
        {
          
		}
         

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            if (string.IsNullOrEmpty(nome) ||
                !int.TryParse(txtQuantidade.Text, out int quantidade) ||
                !decimal.TryParse(txtValor.Text, out decimal valor))
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente", "aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            Produto novoProduto = new Produto
            {
                Nome = nome,
                Quantidade = quantidade,
                Valor = valor
            };
            ListaEstoque.Add(novoProduto);
            AtualizarTabelaTela();
            txtNome.Clear();
            txtQuantidade.Clear();
            txtValor.Clear();
            txtNome.Focus();



        }
        private void AtualizarTabelaTela()
        {
            dgvEstoque.Rows.Clear();
            decimal ValorTotalAcumulado = 0;
            foreach (Produto prod in ListaEstoque)
            {
                decimal TotalDoItem = prod.Quantidade * prod.Valor;
                ValorTotalAcumulado += TotalDoItem;

                dgvEstoque.Rows.Add(prod.Nome, prod.Quantidade, prod.Valor.ToString("C"),
                TotalDoItem.ToString("C"));

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_(object sender, KeyPressEventArgs e)
        {

		}

		private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& e.KeyChar!= (char)Keys.Back)
                {
                e.Handled = true;
            }
        }


		private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back) return;
            if (e.KeyChar == ',' && !txtValor.Text.Contains(","))return;
            e.Handled = true;
			}

        private void BtnSaida_Click_1(object sender, EventArgs e)
        {
            if (dgvEstoque.CurrentRow == null)
            {
                MessageBox.Show("Selecione um produto na tabela antes de dar saída", "aviso",
          MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return; }

            if (!int.TryParse(txtQuantidade.Text, out int quantidadeRetirar) || quantidadeRetirar <= 0)

            {
                MessageBox.Show("Insira uma quantidade valida maior que 0 para ser retirada", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int indexSelecionado = dgvEstoque.CurrentRow.Index;
            Produto produtoSelecionado = ListaEstoque[indexSelecionado];
            if (produtoSelecionado.Quantidade < quantidadeRetirar)

            {
                MessageBox.Show($"Estoque insuficiente! O produto '{produtoSelecionado.Nome}" +
                    $"'" + $" possui apenas {produtoSelecionado.Quantidade} unidades", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            produtoSelecionado.Quantidade -= quantidadeRetirar;
            AtualizarTabelaTela(); txtQuantidade.Clear();
            MessageBox.Show("Saída realizada com sucesso!", "sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information); 
		}

    }
    public class Produto 
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }

    


}

