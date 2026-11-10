
# 📚 Documentação Técnica — Sistema CaféForge

* **Tecnologia:** C# (.NET Framework / .NET Core), Windows Forms.
* **Persistência de Dados:** Ficheiros de texto plano (`produtos.txt`, `vendas.txt`).
* **Objetivo:** Sistema completo de gestão para estabelecimentos de café, incluindo POS (Ponto de Venda), controlo de stock, dashboard analítico, relatórios e salvaguarda de dados.

---

## 1. Arquitetura e Organização de Classes

O projeto segue uma arquitetura modular dividida por responsabilidades (Camadas):

* **`Models/` (Modelos de Dados):**
* `ProdutoModel`: Estrutura de dados que define as propriedades de um produto (`Codigo`, `Nome`, `Categoria`, `Preco`, `Stock`).


* **`Data/` (Persistência e Acesso a Ficheiros):**
* `FicheiroProduto`: Classe responsável por ler e escrever os produtos no ficheiro `produtos.txt`. Converte objetos em linhas de texto e vice-versa.


* **`Services/` (Lógica de Negócio):**
* `ProdutoService`: Contém as regras de validação (validação de campos, verificação de códigos duplicados) e orquestra a edição/criação de produtos.


* **Forms (Interface Gráfica - Windows Forms):**
* `Form1` (Dashboard): O painel central com métricas em tempo real, alertas de stock baixo, últimas vendas e gráficos de desempenho.

* `FormProdutos` / `CadastroProduto`: Gestão completa de inventário (CRUD) com grelha (`DataGridView`) e filtros de pesquisa.

* `FormVendas`: Ponto de Venda (POS) interativo com catálogo por categorias (`FlowLayoutPanel`), carrinho de compras, cálculo automático de IVA (23%), verificação de stock em tempo real e cálculo de trocos.

* `FormRelatorio`: Consulta histórica de transações com filtro por intervalo de datas, métricas de faturamento do período e exportação para Excel (CSV).



---

## 2. O que faz cada Módulo e Função?

### 🛒 Módulo de Produtos (`FormProdutos` e `CadastroProduto`)

* **CRUD Completo:** Permite criar, ler, atualizar e apagar produtos.

* **Atualização Automática (`DialogResult.OK`):** Ao cadastrar ou editar um produto, o formulário secundário devolve um sinal de sucesso (`DialogResult.OK`), permitindo que a grelha principal (`DataGridView`) limpe e recarregue instantaneamente a lista atualizada.

* **Filtro de Pesquisa em Tempo Real:** Pesquisa de produtos por nome ou código com normalização de texto (`ToLower()` e `.Contains()`), garantindo robustez perante espaços ou maiúsculas.

### 💰 Módulo de Vendas / POS (`FormVendas`)

* **Catálogo Dinâmico:** Carrega os cartões de produtos dinamicamente num `FlowLayoutPanel`.

* **Filtros por Categoria e "Todos":** Utiliza eventos `CheckedChanged` nos `RadioButtons` para filtrar os produtos por categoria de forma isolada e limpa.

* **Carrinho e Validação de Stock:** Impede a venda de quantidades superiores ao stock disponível.

* **Cálculo Fiscal e Financeiro:** Aplica automaticamente a taxa de IVA (23%), calcula o subtotal, o total e processa o pagamento em Dinheiro/Outros métodos, validando se o valor entregue é suficiente e calculando o troco exato.

* **Registo Transacional:** Grava cada venda detalhadamente no ficheiro `vendas.txt` com data, hora, método de pagamento e produtos associados, baixando automaticamente o stock no ficheiro de produtos.

### 📊 Dashboard (`Form1`)

* **Métricas de Sessão e Mensais:** Monitoriza as vendas efetuadas na sessão atual (desde que a aplicação abriu) e o faturamento total acumulado no mês.

* **Alerta de Stock Baixo:** Analisa a lista de produtos em tempo real e preenche uma grelha dedicada com os artigos cujo stock é inferior a 5 unidades.

* **Últimas Vendas:** Lê o histórico do `vendas.txt` e apresenta as transações mais recentes numa tabela limpa.

* **Gráfico de Desempenho (`Chart`):** Alimenta dinamicamente uma série de linhas com os valores das últimas transações registadas.

### 📑 Relatórios e Exportação (`FormRelatorio`)

* **Filtro por Intervalo de Datas:** Permite selecionar uma data inicial e final através de `DateTimePicker` para auditar vendas num período específico.

* **Métricas do Período:** Calcula automaticamente o *Total Faturado*, o *Número de Vendas* e o *Ticket Médio*.

* **Exportação para CSV:** Converte os dados filtrados num ficheiro `.csv` estruturado por ponto e vírgula, compatível com o Microsoft Excel.

### 💾 Sistema de Backup (`FolderBrowserDialog`)

* Permite ao operador escolher uma pasta de destino no computador através de uma caixa de diálogo nativa.

* Cria uma pasta carimbada com a data e hora exata e copia de forma segura os ficheiros `produtos.txt` e `vendas.txt`, garantindo a salvaguarda integral dos dados.

---

## 3. Validações e Regras de Negócio Implementadas

1. **Validação de Campos Vazios e Nulos:** Verificação rigorosa para impedir o registo de produtos com campos em branco ou preços/stocks negativos.

2. **Duplicidade de Código:** Validação prévia para garantir que não existem dois produtos cadastrados com o mesmo código identificador.

3. **Integridade de Pagamento:** Impedimento de finalização de vendas caso o valor entregue pelo cliente seja inferior ao total da compra ou esteja vazio.

4. **Tratamento de Exceções (`try-catch`):** Proteção em todas as leituras e escritas de ficheiros para evitar que falhas de E/S encerrem a aplicação abruptamente.

5. **Tratamento de Cultura (Ponto e Vírgula):** Limpeza e conversão segura de strings numéricas monetárias (`Replace('.', ',')`) para evitar erros de parsing independentemente da formatação regional do sistema operativo.

---

## 4. Novas Funções e Conceitos Utilizados

* **LINQ (`Language Integrated Query`):** Utilizado intensivamente para filtrar, projetar, somar e agitar listas de produtos e vendas (`.Where()`, `.Sum()`, `.Select()`, `.Cast()`).

* **Manipulação de Ficheiros (`System.IO`):** Uso de `File.Exists`, `File.ReadAllLines`, `File.WriteAllLines`, `File.Copy` e `Directory.CreateDirectory`.

* **Programação Orientada a Eventos:** Interligação de cliques em cartões gerados dinamicamente no POS, associação de eventos `CheckedChanged` e gestão de diálogos modulares (`ShowDialog()`).

* **Componentes Avançados de WinForms:** `FlowLayoutPanel` para componentes dinâmicos, `Chart` para representação visual de dados, `DateTimePicker` para intervalos temporais e `FolderBrowserDialog` para gestão de diretórios.

---

## 5. O que Aprendemos com este Projeto?

* **Arquitetura e Separação de Responsabilidades:** Compreender a importância de separar a interface gráfica (`Forms`), a lógica de negócio (`Services`) e a persistência (`Data`), tornando o código mais limpo e fácil de debugar.

* **Gestão de Estado em WinForms:** Aprender a passar dados e atualizar formulários principais a partir de ações em formulários secundários utilizando `DialogResult` e métodos de recarregamento (`Refresh`).

* **Resiliência e Tratamento de Erros:** Perceber que aplicações desktop reais precisam de antecipar ficheiros inexistentes, conversões de moeda falhadas e seleções nulas em grelhas (`DataGridView`).

* **Autonomia no Desenvolvimento:** Capacidade de conceber um software de ponta a ponta — desde a conceção visual no Designer até à persistência em ficheiro e exportação de dados analíticos.