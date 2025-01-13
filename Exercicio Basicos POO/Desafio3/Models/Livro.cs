using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio3.Models
{
    public class Livro
    {
        private string titulo;
        private string autor;
        private decimal preco;

        public Livro(string novoTitulo, string novoAutor, decimal novoPreco)
        {
            Titulo = novoTitulo;
            Autor = novoAutor;
            Preco = novoPreco;
        }

        public string Titulo
        {
            get{return titulo; }
            set{
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentException("O título não pode estar vazio.");
                titulo = value;
            }
        }
        public string Autor
        {
            get{return autor;}
            set{
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentException("O autor não pode estar vazio.");
                autor = value;
            }
        }
        public decimal Preco{
            get{return preco;}
            set{
                if(value < 0)
                    throw new ArgumentException("O preço não pode ser negativo.");
                preco = value;
            }
        }

    }
}