using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio1
{
    public class Produto
    {
        public int codigo { get; set; }
        public string? nome { get; set; }
        public decimal preco { get; set; }

      


        public void ExibirInformacoes()
        {
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: {preco}");
        }
    }
}