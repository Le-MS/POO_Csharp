using Desafio3.Models;

List<Livro> listaLivros = new List<Livro>();
bool menuAtivo = true;

while(menuAtivo)
{
    Console.Clear();
    Console.WriteLine("--- Menu de Livros ---");
    Console.WriteLine("1 - Cadastrar livro");
    Console.WriteLine("2 - Exibir livros cadastrados");
    Console.WriteLine("3 - Encerrar aplicação");

    Console.Write("Escolha uma opção: ");
    int escolha = Convert.ToInt32(Console.ReadLine());

    switch(escolha){
        case 1:
            CadastrarLivro();
            break;
        case 2:
            ExibirListaLivros();
            break;
        case 3:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;

    }
}

void CadastrarLivro()
{
    Console.Clear();
    Console.WriteLine("\n--- Cadastrar livro ---");
    Console.Write("Título: ");
    string titulo = Console.ReadLine();
    Console.Write("Autor: ");
    string autor = Console.ReadLine();
    Console.Write("Preço: ");
    decimal preco = Convert.ToDecimal(Console.ReadLine());

    try
    {
        Livro livro = new Livro(titulo, autor, preco);

        listaLivros.Add(livro);
        Console.WriteLine("Livro cadastrado!");
        Console.ReadKey();
    }
    catch(ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
        Console.ReadKey();
    }
}

void ExibirListaLivros()
{
    Console.Clear();
    Console.WriteLine("\n--- Lista de livros cadastrados ---");
    if(listaLivros.Count > 0)
    {
        foreach(Livro livro in listaLivros)
        {
            Console.WriteLine($"\nTitulo: {livro.Titulo}");
            Console.WriteLine($"Autor: {livro.Autor}");
            Console.WriteLine($"Preço: {livro.Preco}");
        }
    }
    else Console.WriteLine("Nenhum livro adicionado.");
    Console.ReadKey();

    }
