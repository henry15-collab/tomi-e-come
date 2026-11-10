using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MiniProjeto_Henrick.Models;

namespace MiniProjeto_Henrick.Data
{
    public class FicheiroProduto
    {
        public void GuardarProduto(ProdutoModel produto)
        {
            StreamWriter sw = new StreamWriter("produtos.txt", true);
            using (sw)
            {
                sw.WriteLine(produto.Codigo + ";" + produto.Nome + ";" + produto.Categoria + ";" + produto.Preco + ";" + produto.Stock);
            }
            sw.Dispose();
        }

        public List<ProdutoModel> LerProduto()
        {
            if (!File.Exists("produtos.txt"))
            {
                File.Create("produtos.txt").Close();
                return new List<ProdutoModel>();

            }
            else
            {
                List<ProdutoModel> produtos = new List<ProdutoModel>();
                StreamReader sr = new StreamReader("produtos.txt");
                using (sr)
                {

                    while (!sr.EndOfStream)
                    {
                        string linha = sr.ReadLine();

                        string[] dados = linha.Split(';');

                        ProdutoModel produto = new ProdutoModel();
                        produto.Codigo = dados[0];
                        produto.Nome = dados[1];
                        produto.Categoria = dados[2];
                        produto.Preco = Convert.ToDecimal(dados[3]);
                        produto.Stock = Convert.ToInt32(dados[4]);
                        produtos.Add(produto);
                    }
                }
                sr.Dispose();
                return produtos;
            }
            
        }

        public void GuardarLista(List<ProdutoModel> produtos)
        {
            using (StreamWriter sw = new StreamWriter("produtos.txt", false)) 
            {
                foreach (var p in produtos)
                {
                    sw.WriteLine($"{p.Codigo};{p.Nome};{p.Categoria};{p.Preco};{p.Stock}");
                }
            }
        }

    }
}
