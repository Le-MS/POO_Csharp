using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio2.Models
{
    public class Gerente:Funcionario
    {
        public decimal bonus{get; set;}

        public Gerente(string nome, decimal salario, decimal bonus) : base(nome, salario)
        {
            this.nome = nome;
            this.salario = salario;
            this.bonus = bonus;
        }

        public override void CalcularSalarioTotal()
        {
            Console.WriteLine($"Salário Total do Gerente: R$ {salario + bonus}");
        }
    }
}