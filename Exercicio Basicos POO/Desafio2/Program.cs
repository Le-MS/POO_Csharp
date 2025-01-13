using Desafio2.Models;

Console.WriteLine("Cadastro do funcionário:");
Console.Write($"Nome: ");
string nomeFuncionario = Console.ReadLine();
Console.Write($"Salario:");
decimal salariofuncionario = Convert.ToDecimal(Console.ReadLine());

Funcionario f1 = new Funcionario(nomeFuncionario, salariofuncionario);

Console.WriteLine("\nCadastro do Gerente:");
Console.Write("Nome: ");
string nomeGerente = Console.ReadLine();
Console.Write("Salário: ");
decimal salarioGerente = Convert.ToDecimal(Console.ReadLine());
Console.Write("Bônus: ");
decimal bonusGerente = Convert.ToDecimal(Console.ReadLine());

Gerente g1 = new Gerente(nomeGerente, salarioGerente, bonusGerente);


f1.CalcularSalarioTotal();
g1.CalcularSalarioTotal();
