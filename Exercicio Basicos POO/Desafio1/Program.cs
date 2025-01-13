using System.Collections;
using Desafio1;

List <Produto> listaProdutos = new List<Produto>();

for(int i=1; i<=3; i++)
{
    Produto p = new Produto();
    Console.Write("\nDigite o código do produto: ");
    p.codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o nome do produto: ");
    p.nome = Console.ReadLine();
    Console.Write("Digite o preço do produto: ");
    p.preco = Convert.ToDecimal(Console.ReadLine());

    listaProdutos.Add(p);
}

for(int i=0;i<=2; i++)
{
    Console.WriteLine($"\nProduto {i+1}:");
    listaProdutos[i].ExibirInformacoes();
}