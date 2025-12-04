using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_gerenciador_produtos
{
    internal class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        internal Produto(int id, string nome, string categoria, double preco, int estoque) // construtor com 5 parametros
        {
            this.Id = id;
            this.Nome = nome;
            this.Categoria = categoria;
            this.Preco = preco;
            this.Estoque = estoque;
        }
    }
        
}
