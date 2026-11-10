using MiniProjeto_Henrick.Data;
using MiniProjeto_Henrick.Models;

using MiniProjeto_Henrick.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MiniProjeto_Henrick
{
    
    public partial class FormVendas : Form
    {
        private List<ProdutoModel> listaProdutos;

        // Lista de dados do carrinho (nome diferente do controlo visual da ListBox)
        private List<ItemCarrinho> carrinho = new List<ItemCarrinho>();

        private decimal valorTotalGlobal = 0;

        public FormVendas()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            // Executa apenas quando o botão passa a estar selecionado (Checked = true)
            if (rb != null && rb.Checked)
            {

                CarregarProdutosNoPainel("Bebidas Quentes", txtPesquisa.Text.Trim());
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            

            CarregarProdutosNoPainel("Todos", "");

            // Atrela o evento para calcular o troco em tempo real quando o utilizador digita o valor entregue
            if (txtValorEntregue != null)
            {
                txtValorEntregue.TextChanged += txtValorEntregue_TextChanged;
            }
        }

        private void CarregarProdutosNoPainel(string categoriaFiltro, string pesquisa)
        {
            FicheiroProduto ficheiro = new FicheiroProduto();
            listaProdutos = ficheiro.LerProduto() ?? new List<ProdutoModel>();

            flowLayoutPanel1.Controls.Clear();

            // Normaliza os textos de pesquisa e filtro para minúsculas e sem espaços extras
            string pesquisaLimpa = pesquisa?.Trim().ToLower() ?? "";
            string filtroLimpo = categoriaFiltro?.Trim().ToLower() ?? "";

            var produtosFiltrados = listaProdutos.Where(p =>
            {
                if (p == null) return false;

                string categoriaProd = p.Categoria?.Trim().ToLower() ?? "";
                string nomeProd = p.Nome?.Trim().ToLower() ?? "";

                // 1. Regra da Categoria: Se for "todos", estiver vazio ou for igual à categoria do produto
                bool matchCategoria = string.IsNullOrEmpty(filtroLimpo) ||
                                      filtroLimpo == "todos" ||
                                      categoriaProd.Contains(filtroLimpo) ||
                                      filtroLimpo.Contains(categoriaProd);

                // 2. Regra da Pesquisa por Nome/Código
                bool matchPesquisa = string.IsNullOrEmpty(pesquisaLimpa) ||
                                     nomeProd.Contains(pesquisaLimpa) ||
                                     (p.Codigo != null && p.Codigo.ToLower().Contains(pesquisaLimpa));

                return matchCategoria && matchPesquisa;
            }).ToList();

            foreach (var produto in produtosFiltrados)
            {
                Panel pnlCard = new Panel
                {
                    Width = 140,
                    Height = 90,
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Cursor = Cursors.Hand,
                    Tag = produto
                };

                Label lblNome = new Label
                {
                    Text = produto.Nome,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    Location = new Point(5, 5),
                    AutoSize = true,
                    MaximumSize = new Size(130, 0)
                };

                Label lblPreco = new Label
                {
                    Text = $"{produto.Preco:C2}",
                    Location = new Point(5, 40),
                    AutoSize = true,
                    ForeColor = Color.DarkGreen,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold)
                };

                Label lblStock = new Label
                {
                    Text = $"Stock: {produto.Stock}",
                    Location = new Point(5, 65),
                    AutoSize = true,
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 8, FontStyle.Regular)
                };

                pnlCard.Controls.Add(lblNome);
                pnlCard.Controls.Add(lblPreco);
                pnlCard.Controls.Add(lblStock);

                EventHandler adicionarClick = (s, ev) =>
                {
                    AdicionarAoCarrinho(produto);
                };

                pnlCard.Click += adicionarClick;
                lblNome.Click += adicionarClick;
                lblPreco.Click += adicionarClick;
                lblStock.Click += adicionarClick;

                flowLayoutPanel1.Controls.Add(pnlCard);
            }
        }

        private void AdicionarAoCarrinho(ProdutoModel produto)
        {
            if (produto.Stock <= 0)
            {
                MessageBox.Show("Este produto encontra-se sem stock!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var itemExistente = carrinho.FirstOrDefault(i => i.Produto.Codigo == produto.Codigo);
            if (itemExistente != null)
            {
                if (itemExistente.Quantidade < produto.Stock)
                {
                    itemExistente.Quantidade++;
                }
                else
                {
                    MessageBox.Show("Não há stock suficiente para adicionar mais unidades.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                carrinho.Add(new ItemCarrinho { Produto = produto, Quantidade = 1 });
            }
            AtualizarCarrinhoUI();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (carrinho.Count == 0)
            {
                MessageBox.Show("O carrinho de compras está vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validação do Método de Pagamento
            string metodoPagamento = "";
            if (rbDinheiro.Checked) metodoPagamento = "Dinheiro";
            else if (rbMBway.Checked) metodoPagamento = "MBway";
            else if (rbCartao.Checked) metodoPagamento = "Cartão Crédito/Débito";
            else
            {
                MessageBox.Show("Por favor, selecione um método de pagamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validação do valor entregue caso seja dinheiro
            if (metodoPagamento == "Dinheiro")
            {
                string textoValor = txtValorEntregue.Text.Trim().Replace('.', ',');
                if (!decimal.TryParse(textoValor, out decimal valorEntregue) || valorEntregue <= 0 || valorEntregue < valorTotalGlobal)
                {
                    MessageBox.Show("O valor entregue é inválido ou insuficiente para pagar o total.", "Erro de Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ProdutoService service = new ProdutoService();
            bool sucessoTotal = true;

            foreach (var item in carrinho)
            {
                item.Produto.Stock -= item.Quantidade;
                bool atualizado = service.EditarProduto(item.Produto, item.Produto.Codigo);
                if (!atualizado) sucessoTotal = false;
            }

            if (sucessoTotal)
            {
                // Regista a venda no vendas.txt
                RegistarVendaNoFicheiro(metodoPagamento);

                MessageBox.Show("Venda registada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                carrinho.Clear();
                AtualizarCarrinhoUI();
                txtValorEntregue.Clear();
                txtTroco.Clear();
                CarregarProdutosNoPainel("Todos", "");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o stock dos produtos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarCarrinhoUI()
        {
            listcarrinho.Items.Clear();
            decimal subtotal = 0;

            foreach (var item in carrinho)
            {
                decimal totalItem = item.Produto.Preco * item.Quantidade;
                subtotal += totalItem;
                listcarrinho.Items.Add($"{item.Quantidade}x {item.Produto.Nome} — {totalItem:C2}");
            }

            // Correção aplicada: operador '*' adicionado e traço removido
            decimal impostoIva = subtotal * 0.23m;
            valorTotalGlobal = subtotal + impostoIva;

            lblSubtotal.Text = $"SUBTOTAL: {subtotal:C2}";
            lblImposto.Text = $"IMPOSTO (IVA 23%): {impostoIva:C2}";
            lblTotal.Text = $"TOTAL A PAGAR: {valorTotalGlobal:C2}";

            CalcularTroco();
        }

        private void CalcularTroco()
        {
            string textoLimpo = txtValorEntregue.Text.Trim().Replace('.', ',');

            if (decimal.TryParse(textoLimpo, out decimal valorEntregue))
            {
                decimal troco = valorEntregue - valorTotalGlobal;
                txtTroco.Text = troco >= 0 ? troco.ToString("C2") : "Valor insuficiente";
            }
            else
            {
                txtTroco.Text = "€ 0,00";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            carrinho.Clear();
            AtualizarCarrinhoUI();
            txtValorEntregue.Clear();
            txtTroco.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CarregarProdutosNoPainel("Todos", txtPesquisa.Text.Trim());
        }

        private void RegistarVendaNoFicheiro(string metodoPagamento)
        {
            try
            {
                string caminhoFicheiro = "vendas.txt";
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"--- Data/Hora: {DateTime.Now} ---");
                sb.AppendLine($"Método de Pagamento: {metodoPagamento}");
                sb.AppendLine($"Total Pago: {valorTotalGlobal:C2}");
                sb.AppendLine("Itens da Venda:");

                foreach (var item in carrinho)
                {
                    sb.AppendLine($" - {item.Quantidade}x {item.Produto.Nome} (Preço Unitário: {item.Produto.Preco:C2})");
                }
                sb.AppendLine("----------------------------------------");

                File.AppendAllText(caminhoFicheiro, sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gravar o registo da venda: {ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtValorEntregue_TextChanged(object sender, EventArgs e)
        {
            CalcularTroco();
        }

        private void rtTodos_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            // Executa apenas quando o botão passa a estar selecionado (Checked = true)
            if (rb != null && rb.Checked)
            {
                
                CarregarProdutosNoPainel("Todos", "");
            }
        }

        private void rtBebidasFrias_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            // Executa apenas quando o botão passa a estar selecionado (Checked = true)
            if (rb != null && rb.Checked)
            {

                CarregarProdutosNoPainel("Bebidas Frias", txtPesquisa.Text.Trim());
            }
        }

        private void rtDoces_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            // Executa apenas quando o botão passa a estar selecionado (Checked = true)
            if (rb != null && rb.Checked)
            {

                CarregarProdutosNoPainel("Doces", txtPesquisa.Text.Trim());
            }
        }

        private void rtSalgados_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            // Executa apenas quando o botão passa a estar selecionado (Checked = true)
            if (rb != null && rb.Checked)
            {

                CarregarProdutosNoPainel("Salgados", txtPesquisa.Text.Trim());
            }
        }
    }

    public class ItemCarrinho
    {
        public ProdutoModel Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
