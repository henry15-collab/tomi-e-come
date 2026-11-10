using MiniProjeto_Henrick.Data;
using MiniProjeto_Henrick.Forms;

using MiniProjeto_Henrick.Models;
using MiniProjeto_Henrick.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MiniProjeto_Henrick
{
    public partial class FormProdutos : Form
    {
       
        public FormProdutos()
        {
            InitializeComponent();
        }
        void CarregarListaProdutos(string filtroPesquisa = "")
        {
            try
            {
                FicheiroProduto ficheiroProduto = new FicheiroProduto();
                List<ProdutoModel> produtos = ficheiroProduto.LerProduto();

                // Aplica a pesquisa automática por nome ou código se houver texto
                if (!string.IsNullOrEmpty(filtroPesquisa))
                {
                    produtos = produtos.Where(p =>
                        p.Nome.IndexOf(filtroPesquisa, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        p.Codigo.IndexOf(filtroPesquisa, StringComparison.OrdinalIgnoreCase) >= 0
                    ).ToList();
                }

                dgvProdutos.DataSource = null;
                dgvProdutos.AutoGenerateColumns = false;
                dgvProdutos.DataSource = produtos;

                // Atualiza os indicadores (Total, Stock Baixo e Valor do Inventário)
                AtualizarEstatisticas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarEstatisticas()
        {
            try
            {
                FicheiroProduto ficheiro = new FicheiroProduto();
                var listaTotal = ficheiro.LerProduto();

                int totalProdutos = listaTotal.Count;
                int stockBaixo = listaTotal.Count(p => p.Stock < 5); // Stock baixo se for menor que 5
                decimal valorTotalInventario = listaTotal.Sum(p => p.Preco * p.Stock);

                // Atribui os valores às TextBoxes (ajusta os nomes se necessário de acordo com o teu Designer)
                if (txtTotalProdutos != null) txtTotalProdutos.Text = totalProdutos.ToString();
                if (txtStockBaixo != null) txtStockBaixo.Text = stockBaixo.ToString();
                if (txtValorInventario != null) txtValorInventario.Text = valorTotalInventario.ToString("C2");
            }
            catch
            {
                // Evita qualquer interrupção caso alguma caixa ainda esteja a ser nomeada
            }
        }


        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            using (CadastroProduto formCadastroProduto = new CadastroProduto())
            {
                if (formCadastroProduto.ShowDialog() == DialogResult.OK)
                {
                    CarregarListaProdutos("");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            CarregarListaProdutos("");
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um produto na lista para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProdutoModel produtoSelecionado = (ProdutoModel)dgvProdutos.CurrentRow.DataBoundItem;

            DialogResult confirmacao = MessageBox.Show(
                $"Tem a certeza que deseja excluir o produto '{produtoSelecionado.Nome}'?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacao == DialogResult.Yes)
            {
                ProdutoService service = new ProdutoService();
                if (service.RemoverProduto(produtoSelecionado.Codigo))
                {
                    MessageBox.Show("Produto removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarListaProdutos(txtPesquisa.Text.Trim());
                    
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um produto na lista para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ProdutoModel produtoSelecionado = (ProdutoModel)dgvProdutos.CurrentRow.DataBoundItem;

            using (CadastroProduto formCadastroProduto = new CadastroProduto(produtoSelecionado))
            {
                if (formCadastroProduto.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Produto alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarListaProdutos(txtPesquisa.Text.Trim());
                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarListaProdutos(txtPesquisa.Text.Trim());
        }
    }
}
