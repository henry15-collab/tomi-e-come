# ☕ Tomi e Come — Sistema de Gestão & POS para Cafetaria

> **Nota do Projeto:** 20 / 20 🏆

O **Tomi e Come** é uma aplicação desktop desenvolvida em C# (.NET WinForms) desenhada para resolver as dores operacionais e financeiras de pequenos estabelecimentos de restauração e cafetaria. O sistema combina um ponto de venda (POS) ágil, gestão de inventário inteligente, métricas financeiras em tempo real e cópias de segurança automatizadas.

---

## 🎨 Identidade Visual & Design
* **Paleta de Cores:** Bege e Azul Corporativo.
* **Interface:** Design moderno em cartões dinâmicos, intuitivo e focado na redução da carga cognitiva do operador.

---

## 🚀 Funcionalidades Principais

* **🛒 Ponto de Venda (POS) Inteligente:**
  * Adição rápida de produtos ao carrinho.
  * Cálculo automático de IVA (23%) e subtotal.
  * Validação de stock em tempo real (impede a venda de artigos sem stock).
  * Calculadora automática de trocos.

* **📦 Gestão de Inventário (CRUD & LINQ):**
  * Pesquisa dinâmica por nome ou código do produto (normalização com `.Trim()` e `.ToLower()`).
  * Filtros rápidos por categoria.
  * Atualização automática de quantidades após cada venda.

* **📊 Dashboard Analítico & BI:**
  * Alertas visuais de **Stock Baixo** (produtos com menos de 10 unidades).
  * Faturamento isolado da **Sessão Atual** vs. **Faturamento Mensal Acumulado**.
  * Gráfico de linhas dinâmico com histórico de faturamento recente.
  * Tabela das últimas transações efetuadas.

* **📄 Relatórios & Exportação:**
  * Histórico de vendas filtrável por intervalo de datas (`DateTimePicker`).
  * Exportação direta dos dados para formato **CSV** (compatível com Excel).

* **🛡️ Segurança & Continuidade de Negócio:**
  * Sistema nativo de **Backup Automatizado por Diretório**.
  * Geração de pasta de salvaguarda com carimbo temporal (`DateTime` no formato `yyyyMMdd_HHmmss`).
  * Tratamento de exceções robusto (`try-catch`) em todas as operações de I/O de ficheiros.

---

## 🛠️ Arquitetura & Tecnologias Utilizadas

* **Linguagem:** C# (.NET Framework / WinForms)
* **Persistência de Dados:** Ficheiros de Texto Plano (`.txt`) com formatação delimitada (sem dependência de servidores de base de dados externos).
* **Manipulação de Dados:** Uso intensivo de **LINQ** (`.Where`, `.Select`, `.Sum`, `.FirstOrDefault`, `.Take`).
* **Padrão de Desenho de Janelas:** Gestão de formulários para evitar múltiplas instâncias abertas.

---

## 📁 Estrutura do Código

```text
MiniProjeto-Henrick/
│
├── Data/
│   └── FicheiroProduto.cs    # Leitura e escrita de dados em ficheiros .txt
│
├── Forms/
│   ├── CadastroProduto.cs    # Ecrã de registo e gestão de produtos
│   ├── Form1.cs              # Dashboard principal (métricas, alertas e gráfico)
│   ├── FormProdutos.cs       # Catálogo e listagem de produtos
│   ├── FormRelatorio.cs      # Módulo de relatórios e exportação CSV
│   └── FormVendas.cs         # Módulo POS (Ponto de Venda)
│
├── Models/
│   └── ProdutosModel.cs      # Modelo de dados da entidade Produto
│
├── Services/
│   └── ProdutoService.cs     # Regras de negócio associadas aos produtos
│
├── Resources/                # Recursos visuais e assets
├── Properties/               # Propriedades do projeto
├── App.config                # Configuração da aplicação
└── Program.cs                # Ponto de entrada (Entry Point)
