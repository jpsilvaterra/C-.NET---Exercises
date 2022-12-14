using ExemploFundamentos.Models;

string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
        Console.Clear();
        Console.WriteLine("Digite a sua opção: ");
        Console.WriteLine("1 - Cadastrar cliente: ");
        Console.WriteLine("2 - Buscar cliente: ");
        Console.WriteLine("3 - Apagar cliente: ");
        Console.WriteLine("4 - Encerrar o programa");

        opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine("Cadasttro de cliente");
                break;
            case "2":
                Console.WriteLine("Busca de cliente");
                break;
            case "3":
                Console.WriteLine("Apagar cliente");
                break;
            case "4":
                Console.WriteLine("Encerrar");
                exibirMenu = false;
                //Enviroment.Exit(0)
                break;
            default:
                Console.WriteLine("Erro: Opção Invalida...");
                break;
        }
}

Console.WriteLine("O programa se encerrou.");