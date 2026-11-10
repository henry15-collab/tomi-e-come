namespace MiniProjeto_Henrick
{
    partial class FormVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rtSalgados = new System.Windows.Forms.RadioButton();
            this.rtDoces = new System.Windows.Forms.RadioButton();
            this.rtBebidasFrias = new System.Windows.Forms.RadioButton();
            this.rtCafe = new System.Windows.Forms.RadioButton();
            this.rtTodos = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listcarrinho = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblImposto = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.txtValorEntregue = new System.Windows.Forms.TextBox();
            this.rbCartao = new System.Windows.Forms.RadioButton();
            this.rbMBway = new System.Windows.Forms.RadioButton();
            this.rbDinheiro = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.rtSalgados);
            this.groupBox1.Controls.Add(this.rtDoces);
            this.groupBox1.Controls.Add(this.rtBebidasFrias);
            this.groupBox1.Controls.Add(this.rtCafe);
            this.groupBox1.Controls.Add(this.rtTodos);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(28, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 691);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleção de Produtos";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 105);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(436, 580);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // rtSalgados
            // 
            this.rtSalgados.AutoSize = true;
            this.rtSalgados.Location = new System.Drawing.Point(375, 69);
            this.rtSalgados.Name = "rtSalgados";
            this.rtSalgados.Size = new System.Drawing.Size(87, 20);
            this.rtSalgados.TabIndex = 5;
            this.rtSalgados.TabStop = true;
            this.rtSalgados.Text = "Salgados";
            this.rtSalgados.UseVisualStyleBackColor = true;
            this.rtSalgados.CheckedChanged += new System.EventHandler(this.rtSalgados_CheckedChanged);
            // 
            // rtDoces
            // 
            this.rtDoces.AutoSize = true;
            this.rtDoces.Location = new System.Drawing.Point(301, 69);
            this.rtDoces.Name = "rtDoces";
            this.rtDoces.Size = new System.Drawing.Size(68, 20);
            this.rtDoces.TabIndex = 4;
            this.rtDoces.TabStop = true;
            this.rtDoces.Text = "Doces";
            this.rtDoces.UseVisualStyleBackColor = true;
            this.rtDoces.CheckedChanged += new System.EventHandler(this.rtDoces_CheckedChanged);
            // 
            // rtBebidasFrias
            // 
            this.rtBebidasFrias.AutoSize = true;
            this.rtBebidasFrias.Location = new System.Drawing.Point(192, 69);
            this.rtBebidasFrias.Name = "rtBebidasFrias";
            this.rtBebidasFrias.Size = new System.Drawing.Size(112, 20);
            this.rtBebidasFrias.TabIndex = 3;
            this.rtBebidasFrias.TabStop = true;
            this.rtBebidasFrias.Text = "Bebidas Frias";
            this.rtBebidasFrias.UseVisualStyleBackColor = true;
            this.rtBebidasFrias.CheckedChanged += new System.EventHandler(this.rtBebidasFrias_CheckedChanged);
            // 
            // rtCafe
            // 
            this.rtCafe.AutoSize = true;
            this.rtCafe.Location = new System.Drawing.Point(71, 69);
            this.rtCafe.Name = "rtCafe";
            this.rtCafe.Size = new System.Drawing.Size(125, 20);
            this.rtCafe.TabIndex = 2;
            this.rtCafe.TabStop = true;
            this.rtCafe.Text = "Bebidas Quente";
            this.rtCafe.UseVisualStyleBackColor = true;
            this.rtCafe.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rtTodos
            // 
            this.rtTodos.AutoSize = true;
            this.rtTodos.Location = new System.Drawing.Point(6, 69);
            this.rtTodos.Name = "rtTodos";
            this.rtTodos.Size = new System.Drawing.Size(68, 20);
            this.rtTodos.TabIndex = 1;
            this.rtTodos.TabStop = true;
            this.rtTodos.Text = "Todos";
            this.rtTodos.UseVisualStyleBackColor = true;
            this.rtTodos.CheckedChanged += new System.EventHandler(this.rtTodos_CheckedChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(17, 30);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(436, 22);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.listcarrinho);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.lblImposto);
            this.groupBox2.Controls.Add(this.lblSubtotal);
            this.groupBox2.Location = new System.Drawing.Point(502, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 384);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carrinho de Venda Atual";
            // 
            // listcarrinho
            // 
            this.listcarrinho.FormattingEnabled = true;
            this.listcarrinho.ItemHeight = 16;
            this.listcarrinho.Location = new System.Drawing.Point(10, 23);
            this.listcarrinho.Name = "listcarrinho";
            this.listcarrinho.Size = new System.Drawing.Size(464, 228);
            this.listcarrinho.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(288, 315);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(174, 16);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "TOTAL A PAGAR: € 0,00";
            this.lblTotal.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblImposto
            // 
            this.lblImposto.AutoSize = true;
            this.lblImposto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImposto.Location = new System.Drawing.Point(259, 287);
            this.lblImposto.Name = "lblImposto";
            this.lblImposto.Size = new System.Drawing.Size(194, 16);
            this.lblImposto.TabIndex = 2;
            this.lblImposto.Text = "IMPOSTO (IVA 23%): € 0,00";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(317, 256);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(135, 16);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "SUBTOTAL: € 0,00";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.btnCancelarPedido);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTroco);
            this.groupBox3.Controls.Add(this.txtValorEntregue);
            this.groupBox3.Controls.Add(this.rbCartao);
            this.groupBox3.Controls.Add(this.rbMBway);
            this.groupBox3.Controls.Add(this.rbDinheiro);
            this.groupBox3.Location = new System.Drawing.Point(506, 417);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 292);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Metódo de Pagamento";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.YellowGreen;
            this.button6.Location = new System.Drawing.Point(285, 190);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(173, 63);
            this.button6.TabIndex = 8;
            this.button6.Text = "Finalizar Venda";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelarPedido.Location = new System.Drawing.Point(125, 190);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(172, 63);
            this.btnCancelarPedido.TabIndex = 7;
            this.btnCancelarPedido.Text = "Cancelar Pedido";
            this.btnCancelarPedido.UseVisualStyleBackColor = false;
            this.btnCancelarPedido.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Troco";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor Entregue";
            // 
            // txtTroco
            // 
            this.txtTroco.Location = new System.Drawing.Point(91, 137);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(246, 22);
            this.txtTroco.TabIndex = 4;
            this.txtTroco.Text = "€ 0,00";
            // 
            // txtValorEntregue
            // 
            this.txtValorEntregue.Location = new System.Drawing.Point(108, 105);
            this.txtValorEntregue.Name = "txtValorEntregue";
            this.txtValorEntregue.Size = new System.Drawing.Size(253, 22);
            this.txtValorEntregue.TabIndex = 3;
            this.txtValorEntregue.Text = "€ 0,00";
            this.txtValorEntregue.TextChanged += new System.EventHandler(this.txtValorEntregue_TextChanged);
            // 
            // rbCartao
            // 
            this.rbCartao.AutoSize = true;
            this.rbCartao.Location = new System.Drawing.Point(172, 66);
            this.rbCartao.Name = "rbCartao";
            this.rbCartao.Size = new System.Drawing.Size(158, 20);
            this.rbCartao.TabIndex = 2;
            this.rbCartao.TabStop = true;
            this.rbCartao.Text = "Cartão Crédito/Débito";
            this.rbCartao.UseVisualStyleBackColor = true;
            // 
            // rbMBway
            // 
            this.rbMBway.AutoSize = true;
            this.rbMBway.Location = new System.Drawing.Point(91, 66);
            this.rbMBway.Name = "rbMBway";
            this.rbMBway.Size = new System.Drawing.Size(72, 20);
            this.rbMBway.TabIndex = 1;
            this.rbMBway.TabStop = true;
            this.rbMBway.Text = "MBway";
            this.rbMBway.UseVisualStyleBackColor = true;
            // 
            // rbDinheiro
            // 
            this.rbDinheiro.AutoSize = true;
            this.rbDinheiro.Location = new System.Drawing.Point(6, 66);
            this.rbDinheiro.Name = "rbDinheiro";
            this.rbDinheiro.Size = new System.Drawing.Size(78, 20);
            this.rbDinheiro.TabIndex = 0;
            this.rbDinheiro.TabStop = true;
            this.rbDinheiro.Text = "Dinheiro";
            this.rbDinheiro.UseVisualStyleBackColor = true;
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVendas";
            this.Text = "Tomi e Come - POS/Vendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rtSalgados;
        private System.Windows.Forms.RadioButton rtDoces;
        private System.Windows.Forms.RadioButton rtBebidasFrias;
        private System.Windows.Forms.RadioButton rtCafe;
        private System.Windows.Forms.RadioButton rtTodos;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblImposto;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.TextBox txtValorEntregue;
        private System.Windows.Forms.RadioButton rbCartao;
        private System.Windows.Forms.RadioButton rbMBway;
        private System.Windows.Forms.RadioButton rbDinheiro;
        private System.Windows.Forms.ListBox listcarrinho;
    }
}