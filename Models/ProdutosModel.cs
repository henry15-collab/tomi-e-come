using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjeto_Henrick.Models
{
    public class ProdutoModel
    {
        
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }
        public int Stock { get; set; }

        
    }
}
