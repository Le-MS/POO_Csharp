namespace Desafio2.Models
{
    public class Funcionario
    {
        protected string nome { get; set; }
        protected decimal salario { get; set; }

        public Funcionario(string nome, decimal salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public virtual void CalcularSalarioTotal()
        {
            Console.WriteLine($"Salário Total do Funcionário: R$ {salario}");
        }
    }
}