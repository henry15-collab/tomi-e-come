using MiniProjeto_Henrick.Data;
using MiniProjeto_Henrick.Models;
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
    /*
     * Aprender o que cada função nova faz
     * Programa incompleto
     * IA utilizada como Guia = Gemini
     */
    public partial class FormPrincipal : Form
    {
        private static DateTime sessionStartTime = DateTime.Now;
        private FormProdutos formProdutos = null;
        private FormVendas formVendas = null; // para quando criares o de vendas
        private FormRelatorio formRelatorio = null; // para quando criares o de relatorios

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
           
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            btnDashboard.Enabled = false;

            CarregarDashboard();
        }

        private void CarregarDashboard()
        {
            try
            {
                // 1. ALERTA DE STOCK BAIXO
                FicheiroProduto ficheiroProd = new FicheiroProduto();
                List<ProdutoModel> listaProdutos = ficheiroProd.LerProduto() ?? new List<ProdutoModel>();
                var stockBaixoList = listaProdutos.Where(p => p.Stock < 10).ToList();

                if (dgvStockBaixo != null)
                {
                    dgvStockBaixo.DataSource = null;
                    dgvStockBaixo.DataSource = stockBaixoList.Select(p => new {
                        Tempo = "Atual",
                        Produto = p.Nome,
                        Stock = p.Stock
                    }).ToList();
                }

                // 2. VENDAS DA SESSÃO, VENDAS DO MÊS E ÚLTIMAS VENDAS
                decimal vendasSessao = 0;
                decimal vendasMes = 0;
                var ultimasVendasList = new List<object>();

                if (File.Exists("vendas.txt"))
                {
                    string[] linhas = File.ReadAllLines("vendas.txt");
                    DateTime hoje = DateTime.Today;
                    string dataVendaStr = "";

                    for (int i = 0; i < linhas.Length; i++)
                    {
                        if (linhas[i].Contains("Data/Hora:"))
                        {
                            dataVendaStr = linhas[i].Replace("--- Data/Hora:", "").Replace("---", "").Trim();
                        }
                        else if (linhas[i].StartsWith("Total Pago:"))
                        {
                            string valStr = linhas[i].Replace("Total Pago:", "").Trim()
                                .Replace("€", "").Replace(" ", "").Replace('.', ',');

                            if (decimal.TryParse(valStr, out decimal valorVenda))
                            {
                                if (DateTime.TryParse(dataVendaStr, out DateTime dataVenda))
                                {
                                    // Vendas apenas da sessão atual (desde que o app abriu)
                                    if (dataVenda >= sessionStartTime)
                                    {
                                        vendasSessao += valorVenda;
                                    }

                                    // Vendas Totais do Mês atual
                                    if (dataVenda.Month == hoje.Month && dataVenda.Year == hoje.Year)
                                    {
                                        vendasMes += valorVenda;
                                    }
                                }

                                // Registo para a tabela de Últimas Vendas
                                ultimasVendasList.Add(new
                                {
                                    Tempo = dataVendaStr,
                                    Produto = "Pedido CaféForge",
                                    Valor = valorVenda.ToString("C2")
                                });
                            }
                        }
                    }
                }

                // Atualiza as Labels de Vendas da Sessão e Vendas do Mês
                if (lblVendasHoje != null) lblVendasHoje.Text = vendasSessao.ToString("C2");
                if (lblVendasDoDia != null) lblVendasDoDia.Text = vendasSessao.ToString("C2");
                if (lblVendasMes != null) lblVendasMes.Text = vendasMes.ToString("C2");

                // Preenche o DataGridView de Últimas Vendas
                if (dgvUltimasVendas != null)
                {
                    dgvUltimasVendas.DataSource = null;
                    dgvUltimasVendas.DataSource = ultimasVendasList.Cast<object>().Reverse().Take(10).ToList();
                }

                // 3. GRÁFICO (Chart) - Com nome de série personalizado ("Faturamento")
                if (chart1 != null)
                {
                    chart1.Series.Clear();
                    // Aqui definimos o nome da série diretamente em código:
                    var serie = chart1.Series.Add("Faturamento");
                    serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                    int pontoX = 1;
                    foreach (var v in ultimasVendasList.Cast<dynamic>().Take(7))
                    {
                        string valLimpo = v.Valor.Replace("€", "").Trim().Replace('.', ',');
                        if (decimal.TryParse(valLimpo, out decimal valNum))
                        {
                            serie.Points.AddXY($"V{pontoX++}", (double)valNum);
                        }
                    }

                    if (serie.Points.Count == 0)
                    {
                        serie.Points.AddXY("0", 0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o dashboard: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
          
            if (formVendas != null && !formVendas.IsDisposed)
            {
                formVendas.BringToFront(); 
                return; 
            }

         
            formVendas = new FormVendas();

           
            btnVendas.Enabled = false;

           
            formVendas.FormClosed += (s, args) =>
            {
                formVendas = null;
                btnVendas.Enabled = true;
            };

           
            formVendas.Show();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            
            if (formRelatorio != null && !formRelatorio.IsDisposed)
            {
                formRelatorio.BringToFront();
                return; 
            }

            
            formRelatorio = new FormRelatorio();

            
            btnRelatorios.Enabled = false;

            
            formRelatorio.FormClosed += (s, args) =>
            {
                formRelatorio = null;
                btnRelatorios.Enabled = true;
            };

            
            formRelatorio.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            // 1. Verifica se a janela já existe e se ainda está aberta
            if (formProdutos != null && !formProdutos.IsDisposed)
            {
                formProdutos.BringToFront(); // Traz a janela existente para primeiro plano
                return; // Sai do método para não abrir outra
            }

            // 2. Se não estiver aberta, cria uma nova instância
            formProdutos = new FormProdutos();

            // 3. Desativa o botão para indicar que já estamos lá dentro
            btnProdutos.Enabled = false;

            // 4. Quando o formulário for fechado, libertamos a referência e reativamos o botão
            formProdutos.FormClosed += (s, args) =>
            {
                formProdutos = null;
                btnProdutos.Enabled = true;
            };

            // 5. Mostra o formulário
            formProdutos.Show();
        }

        private void btnNovoPedidoDH_Click(object sender, EventArgs e)
        {
            FormVendas form = new FormVendas();
            form.ShowDialog();
            CarregarDashboard();
        }

        private void btnGerenciarProdutos_Click(object sender, EventArgs e)
        {
           
            FormProdutos form = new FormProdutos();
            form.ShowDialog();
            CarregarDashboard(); // Atualiza ao voltar
        }

        private void btnVerRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorio form = new FormRelatorio();
            form.ShowDialog();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    fbd.Description = "Selecione a pasta onde deseja guardar o backup do CaféForge";

                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        string pastaDestino = fbd.SelectedPath;
                        // Cria uma pasta com data e hora exata do backup para manter organizado
                        string pastaBackup = Path.Combine(pastaDestino, $"Backup_CafeForge_{DateTime.Now:yyyyMMdd_HHmmss}");
                        Directory.CreateDirectory(pastaBackup);

                        int ficheirosCopiados = 0;

                        // Copiar produtos.txt se existir
                        if (File.Exists("produtos.txt"))
                        {
                            File.Copy("produtos.txt", Path.Combine(pastaBackup, "produtos.txt"), true);
                            ficheirosCopiados++;
                        }

                        // Copiar vendas.txt se existir
                        if (File.Exists("vendas.txt"))
                        {
                            File.Copy("vendas.txt", Path.Combine(pastaBackup, "vendas.txt"), true);
                            ficheirosCopiados++;
                        }

                        if (ficheirosCopiados > 0)
                        {
                            MessageBox.Show($"Backup realizado com sucesso!\n\nPasta de destino:\n{pastaBackup}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Aviso: Nenhum ficheiro de dados ('produtos.txt' ou 'vendas.txt') foi encontrado para salvaguardar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar o backup: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
