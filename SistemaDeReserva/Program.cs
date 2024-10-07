using SistemaDeReserva.Models;

decimal precoPorDiaria = 0;

Console.WriteLine("Seja bem vindo ao sistema de hospedagem!\n" + "Digite o valor da diária:");
precoPorDiaria = Convert.ToDecimal(Console.ReadLine());

Reservas rsv = new Reservas(precoPorDiaria);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar hospede");
    Console.WriteLine("2 - Remover hospede");
    Console.WriteLine("3 - Listar hospedagens");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            rsv.AdicionarReserva();
            break;
        case "2":
            rsv.RemoverReserva();
            break;
        case "3":
            rsv.ListarReserva();
            break;
        case "4":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}
Console.WriteLine("O programa se encerrou");