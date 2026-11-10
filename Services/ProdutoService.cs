using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProjeto_Henrick.Data;
using MiniProjeto_Henrick.Models;
using System.IO;
using System.Windows.Forms;
namespace MiniProjeto_Henrick.Services
{
    public class ProdutoService
    {
        public bool ValidarProduto(ProdutoModel produto)
        {
            try
            {
                if (string.IsNullOrEmpty(produto.Codigo))
                {
                    return false;
                }
                if (string.IsNullOrEmpty(produto.Nome))
                {
                    return false;
                }
                if (string.IsNullOrEmpty(produto.Categoria))
                {
                    return false;
                }
                if (produto.Preco <= 0)
                {
                    return false;
                }
                if (produto.Stock < 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na validação do produto: {ex.Message}");
                return false;
            }
           
        }
        
        public bool ValidarCodigoExistente(string codigo)
        {
            try
            {
                List<ProdutoModel> produtos = new FicheiroProduto().LerProduto();
                if (produtos.Exists(p => p.Codigo == codigo))
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na validação do código do produto: {ex.Message}");
                return false;
            }
            
        }

        public bool RemoverProduto(string codigo)
        {
            try
            {
                FicheiroProduto ficheiro = new FicheiroProduto();
                List<ProdutoModel> produtos = ficheiro.LerProduto();

                ProdutoModel produtoRemover = produtos.FirstOrDefault(p => p.Codigo == codigo);
                if (produtoRemover != null)
                {
                    produtos.Remove(produtoRemover);
                    ficheiro.GuardarLista(produtos);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover produto: {ex.Message}");
                return false;
            }
        }

        public bool EditarProduto (ProdutoModel produto, string codigoEdit)
        {
            try 
            {
                FicheiroProduto ficheiro = new FicheiroProduto();
                List<ProdutoModel> produtos = ficheiro.LerProduto();
                int indice = produtos.FindIndex(p => p.Codigo == codigoEdit);
                if (indice != -1)
                {
                    produtos[indice] = produto;
                    ficheiro.GuardarLista(produtos);
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar produto: {ex.Message}");
                return false;
            }
        }
    }
}
