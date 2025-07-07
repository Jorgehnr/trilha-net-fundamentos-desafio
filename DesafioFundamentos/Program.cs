using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicialCarro = 0;
decimal precoPorHoraCarro = 0;
decimal precoInicialMoto = 0;
decimal precoPorHoraMoto = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial para Carro:");
precoInicialCarro = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora para Carro:");
precoPorHoraCarro = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o preço inicial para Moto:");
precoInicialMoto = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora para Motos:");
precoPorHoraMoto = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicialCarro, precoPorHoraCarro, precoInicialMoto, precoPorHoraMoto);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
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
