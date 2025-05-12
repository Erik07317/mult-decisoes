Console.WriteLine("Digite uma opcao: ");
Console.WriteLine(
    @"
    menu de opcoes
    -----------------

    N. novo arquivo
    a. abrir arquivo
    h. salvar arquivo
    x. sair
");

string entrada = Console.ReadLine()!.ToUpper().Substring(0, 1);


// Verifica se a entrada é nula ou vazia
switch (entrada)
{
    case "N":
        Console.WriteLine("Novo arquivo");
        break;
    case "A":
        Console.WriteLine("Abrir arquivo");
        break;
    case "H":
        Console.WriteLine("Salvar arquivo");
        break;
    case "X":
        Console.WriteLine("Sair");
        break;
    default:
        Console.WriteLine("Opcao invalida");
        break;
}
