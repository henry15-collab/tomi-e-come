using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniProjeto_Henrick.Services;
using MiniProjeto_Henrick.Models;
using MiniProjeto_Henrick.Data;
namespace MiniProjeto_Henrick.Forms
{
    public partial class CadastroProduto : Form
    {
        private string codigoOriginal = null;
        public CadastroProduto()
        {
            InitializeComponent();
            this.Text = "Cadastrar Produto";
            

        }

        public CadastroProduto(ProdutoModel produto)
        {
            InitializeComponent();
            this.Text = "Atualizar Produto";
            label1.Text = "Atualizar Produto";

            
            codigoOriginal = produto.Codigo;

            
            txtCodigo.Text = produto.Codigo;
            txtNome.Text = produto.Nome;
            cbCategoria.SelectedItem = produto.Categoria;
            numPreco.Value = produto.Preco;
            numStock.Value = produto.Stock;


        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            if (cbCategoria.Items.Count == 0)
            {
                cbCategoria.Items.AddRange(new string[] { "Bebidas Frias", "Bebidas Quentes", "Doces", "Salgados" });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProdutoService produtoService = new ProdutoService();
            ProdutoModel produto = new ProdutoModel
            {
                Codigo = txtCodigo.Text.Trim(),
                Nome = txtNome.Text.Trim(),
                Categoria = cbCategoria.SelectedItem?.ToString(),
                Preco = numPreco.Value,
                Stock = (int)numStock.Value
            };

            
            if (!string.IsNullOrEmpty(codigoOriginal))
            {
                if (produtoService.ValidarProduto(produto))
                {
                    if (produtoService.EditarProduto(produto, codigoOriginal))
                    {
                        MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            else
            {
                if (produtoService.ValidarProduto(produto) && produtoService.ValidarCodigoExistente(produto.Codigo))
                {
                    FicheiroProduto ficheiroProduto = new FicheiroProduto();
                    ficheiroProduto.GuardarProduto(produto);
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, preencha todos os campos corretamente ou verifique se o código já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
