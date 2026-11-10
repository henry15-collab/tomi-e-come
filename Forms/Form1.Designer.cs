namespace MiniProjeto_Henrick
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVendasDoDia = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVendasHoje = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblVendasMes = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvStockBaixo = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUltimasVendas = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnVerRelatorio = new System.Windows.Forms.Button();
            this.btnGerenciarProdutos = new System.Windows.Forms.Button();
            this.btnNovoPedidoDH = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockBaixo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimasVendas)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.flowLayoutPanel1.Controls.Add(this.btnDashboard);
            this.flowLayoutPanel1.Controls.Add(this.btnProdutos);
            this.flowLayoutPanel1.Controls.Add(this.btnVendas);
            this.flowLayoutPanel1.Controls.Add(this.btnRelatorios);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(180, 721);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Image = global::MiniProjeto_Henrick.Properties.Resources._21;
            this.btnDashboard.Location = new System.Drawing.Point(3, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(165, 95);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Image = global::MiniProjeto_Henrick.Properties.Resources._1;
            this.btnProdutos.Location = new System.Drawing.Point(3, 104);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(165, 96);
            this.btnProdutos.TabIndex = 0;
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Image = global::MiniProjeto_Henrick.Properties.Resources._3;
            this.btnVendas.Location = new System.Drawing.Point(3, 206);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(165, 102);
            this.btnVendas.TabIndex = 1;
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Image = global::MiniProjeto_Henrick.Properties.Resources._4;
            this.btnRelatorios.Location = new System.Drawing.Point(3, 314);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(165, 95);
            this.btnRelatorios.TabIndex = 3;
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(207, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 119);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Gestão do Café - Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(498, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 82);
            this.panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblVendasDoDia);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 85);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendas do Dia";
            // 
            // lblVendasDoDia
            // 
            this.lblVendasDoDia.AutoSize = true;
            this.lblVendasDoDia.Location = new System.Drawing.Point(54, 42);
            this.lblVendasDoDia.Name = "lblVendasDoDia";
            this.lblVendasDoDia.Size = new System.Drawing.Size(41, 16);
            this.lblVendasDoDia.TabIndex = 5;
            this.lblVendasDoDia.Text = "€ 0,00";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(258, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 82);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVendasHoje);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendas de Hoje";
            // 
            // lblVendasHoje
            // 
            this.lblVendasHoje.AutoSize = true;
            this.lblVendasHoje.Location = new System.Drawing.Point(54, 42);
            this.lblVendasHoje.Name = "lblVendasHoje";
            this.lblVendasHoje.Size = new System.Drawing.Size(41, 16);
            this.lblVendasHoje.TabIndex = 4;
            this.lblVendasHoje.Text = "€ 0,00";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.groupBox4);
            this.panel5.Location = new System.Drawing.Point(699, 143);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 82);
            this.panel5.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblVendasMes);
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(170, 85);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total de Vendas no mês";
            // 
            // lblVendasMes
            // 
            this.lblVendasMes.AutoSize = true;
            this.lblVendasMes.Location = new System.Drawing.Point(64, 42);
            this.lblVendasMes.Name = "lblVendasMes";
            this.lblVendasMes.Size = new System.Drawing.Size(41, 16);
            this.lblVendasMes.TabIndex = 7;
            this.lblVendasMes.Text = "€ 0,00";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chart1);
            this.groupBox5.Location = new System.Drawing.Point(201, 258);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(481, 423);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Desempenho de Vendas";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DottedGrid;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.MintCream;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 21);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.CustomProperties = "DrawingStyle=LightToDark";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(469, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvStockBaixo);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.dgvUltimasVendas);
            this.groupBox6.Location = new System.Drawing.Point(696, 249);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(298, 253);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resumo de Atividades";
            // 
            // dgvStockBaixo
            // 
            this.dgvStockBaixo.AllowUserToAddRows = false;
            this.dgvStockBaixo.AllowUserToDeleteRows = false;
            this.dgvStockBaixo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvStockBaixo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvStockBaixo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStockBaixo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockBaixo.Location = new System.Drawing.Point(9, 151);
            this.dgvStockBaixo.Name = "dgvStockBaixo";
            this.dgvStockBaixo.ReadOnly = true;
            this.dgvStockBaixo.RowHeadersWidth = 51;
            this.dgvStockBaixo.RowTemplate.Height = 24;
            this.dgvStockBaixo.Size = new System.Drawing.Size(283, 96);
            this.dgvStockBaixo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alerta de Estoque Baixo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Últimas Vendas";
            // 
            // dgvUltimasVendas
            // 
            this.dgvUltimasVendas.AllowUserToAddRows = false;
            this.dgvUltimasVendas.AllowUserToDeleteRows = false;
            this.dgvUltimasVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvUltimasVendas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUltimasVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUltimasVendas.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvUltimasVendas.Location = new System.Drawing.Point(6, 44);
            this.dgvUltimasVendas.Name = "dgvUltimasVendas";
            this.dgvUltimasVendas.ReadOnly = true;
            this.dgvUltimasVendas.RowHeadersWidth = 51;
            this.dgvUltimasVendas.RowTemplate.Height = 24;
            this.dgvUltimasVendas.Size = new System.Drawing.Size(286, 85);
            this.dgvUltimasVendas.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.White;
            this.groupBox7.Controls.Add(this.btnBackup);
            this.groupBox7.Controls.Add(this.btnVerRelatorio);
            this.groupBox7.Controls.Add(this.btnGerenciarProdutos);
            this.groupBox7.Controls.Add(this.btnNovoPedidoDH);
            this.groupBox7.Location = new System.Drawing.Point(699, 508);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(292, 173);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBackup.Location = new System.Drawing.Point(144, 87);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(118, 47);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Fazer Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnVerRelatorio
            // 
            this.btnVerRelatorio.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVerRelatorio.Location = new System.Drawing.Point(20, 87);
            this.btnVerRelatorio.Name = "btnVerRelatorio";
            this.btnVerRelatorio.Size = new System.Drawing.Size(118, 47);
            this.btnVerRelatorio.TabIndex = 2;
            this.btnVerRelatorio.Text = "Ver Relatórios";
            this.btnVerRelatorio.UseVisualStyleBackColor = false;
            this.btnVerRelatorio.Click += new System.EventHandler(this.btnVerRelatorio_Click);
            // 
            // btnGerenciarProdutos
            // 
            this.btnGerenciarProdutos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGerenciarProdutos.Location = new System.Drawing.Point(144, 32);
            this.btnGerenciarProdutos.Name = "btnGerenciarProdutos";
            this.btnGerenciarProdutos.Size = new System.Drawing.Size(118, 49);
            this.btnGerenciarProdutos.TabIndex = 1;
            this.btnGerenciarProdutos.Text = "Gerenciar Produtos";
            this.btnGerenciarProdutos.UseVisualStyleBackColor = false;
            this.btnGerenciarProdutos.Click += new System.EventHandler(this.btnGerenciarProdutos_Click);
            // 
            // btnNovoPedidoDH
            // 
            this.btnNovoPedidoDH.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNovoPedidoDH.Location = new System.Drawing.Point(20, 32);
            this.btnNovoPedidoDH.Name = "btnNovoPedidoDH";
            this.btnNovoPedidoDH.Size = new System.Drawing.Size(118, 49);
            this.btnNovoPedidoDH.TabIndex = 0;
            this.btnNovoPedidoDH.Text = "Novo Pedido (POS)";
            this.btnNovoPedidoDH.UseVisualStyleBackColor = false;
            this.btnNovoPedidoDH.Click += new System.EventHandler(this.btnNovoPedidoDH_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormPrincipal";
            this.Text = "Tomi e Come - Dashboard";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockBaixo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimasVendas)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblVendasDoDia;
        private System.Windows.Forms.Label lblVendasHoje;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblVendasMes;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnVerRelatorio;
        private System.Windows.Forms.Button btnGerenciarProdutos;
        private System.Windows.Forms.Button btnNovoPedidoDH;
        private System.Windows.Forms.DataGridView dgvStockBaixo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUltimasVendas;
    }
}

