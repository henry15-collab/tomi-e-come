using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjeto_Henrick
{
    public partial class FormRelatorio : Form
    {
        private class VendaItemDto
        {
            public string IdVenda { get; set; }
            public DateTime DataHora { get; set; }
            public string MetodoPagamento { get; set; }
            public decimal Total { get; set; }
        }

        private List<VendaItemDto> todasAsVendas = new List<VendaItemDto>();
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today.AddDays(-30);
            dateTimePicker2.Value = DateTime.Today;

            CarregarDadosVendasDoFicheiro();
            FiltrarRelatorio();
        }

        private void CarregarDadosVendasDoFicheiro()
        {
            todasAsVendas.Clear();

            if (!File.Exists("vendas.txt")) return;

            try
            {
                string[] linhas = File.ReadAllLines("vendas.txt");
                string idAtual = "";
                DateTime dataAtual = DateTime.Now;
                string metodoAtual = "Dinheiro";
                decimal totalAtual = 0;

                int contadorId = 1;

                foreach (var linha in linhas)
                {
                    if (linha.Contains("Data/Hora:"))
                    {
                        string dataStr = linha.Replace("--- Data/Hora:", "").Replace("---", "").Trim();
                        DateTime.TryParse(dataStr, out dataAtual);
                        idAtual = $"V-{contadorId++:D3}";
                    }
                    else if (linha.Contains("Método de Pagamento:"))
                    {
                        metodoAtual = linha.Replace("Método de Pagamento:", "").Trim();
                    }
                    else if (linha.StartsWith("Total Pago:"))
                    {
                        string valStr = linha.Replace("Total Pago:", "").Trim()
                            .Replace("€", "").Replace(" ", "").Replace('.', ',');
                        decimal.TryParse(valStr, out totalAtual);

                        // Adiciona à lista geral quando fecha o bloco da venda
                        todasAsVendas.Add(new VendaItemDto
                        {
                            IdVenda = idAtual,
                            DataHora = dataAtual,
                            MetodoPagamento = metodoAtual,
                            Total = totalAtual
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler o ficheiro de vendas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltrarRelatorio()
        {
            DateTime dataInicio = dateTimePicker1.Value.Date;
            DateTime dataFim = dateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1); // Fim do dia

            var vendasFiltradas = todasAsVendas.Where(v => v.DataHora >= dataInicio && v.DataHora <= dataFim).ToList();

            // Preenche o DataGridView (confirma se o nome no teu designer é dgvRelatorios ou dataGridView1)
            if (dgvVendas != null)
            {
                dgvVendas.DataSource = null;
                dgvVendas.DataSource = vendasFiltradas;
            }

            // Calcula Métricas do Período
            decimal totalFaturado = vendasFiltradas.Sum(v => v.Total);
            int numeroVendas = vendasFiltradas.Count;
            decimal ticketMedio = numeroVendas > 0 ? totalFaturado / numeroVendas : 0;

            // Atualiza as labels inferiores
            if (lblTotalFaturadoPeriodo != null) lblTotalFaturadoPeriodo.Text = totalFaturado.ToString("C2");
            if (lblNumeroVendasPeriodo != null) lblNumeroVendasPeriodo.Text = numeroVendas.ToString();
            if (lblTicketMedio != null) lblTicketMedio.Text = ticketMedio.ToString("C2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FiltrarRelatorio();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Ficheiro CSV (*.csv)|*.csv",
                    FileName = $"RelatorioVendas_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                    {
                        sw.WriteLine("ID Venda;Data e Hora;Método de Pagamento;Total");

                        DateTime dataInicio = dateTimePicker1.Value.Date;
                        DateTime dataFim = dateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1);
                        var vendasFiltradas = todasAsVendas.Where(v => v.DataHora >= dataInicio && v.DataHora <= dataFim);

                        foreach (var v in vendasFiltradas)
                        {
                            sw.WriteLine($"{v.IdVenda};{v.DataHora};{v.MetodoPagamento};{v.Total}");
                        }
                    }

                    MessageBox.Show("Relatório exportado com sucesso para CSV!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar ficheiro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
