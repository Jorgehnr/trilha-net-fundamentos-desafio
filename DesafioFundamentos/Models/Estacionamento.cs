namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicialCarro = 0;
        private decimal precoPorHoraCarro = 0;
        private decimal precoInicialMoto = 0;
        private decimal precoPorHoraMoto = 0;
        private List<Veiculo> listaVeiculos = new List<Veiculo>();

        public Estacionamento(decimal precoInicialCarro, decimal precoPorHoraCarro, decimal precoInicialMoto, decimal precoPorHoraMoto)
        {
            this.precoInicialCarro = precoInicialCarro;
            this.precoPorHoraCarro = precoPorHoraCarro;
            this.precoInicialMoto = precoInicialMoto;
            this.precoPorHoraMoto = precoPorHoraMoto;
        }

        public void AdicionarVeiculo()
        {

            Veiculo veiculoAdicionar = new Veiculo();
            int menu = 1;

            // Solicita o tipo do veiculor a ser adicionado ao estacionamento
            while (menu == 1)
            {
                Console.WriteLine("Digite o tipo de veículo para estacionar: \n 1 - Carro \n 2 - Moto");
                switch (Console.ReadLine())
                {
                    case "1":
                        veiculoAdicionar.tipoVeiculo = "Carro";
                        menu = 0;
                        break;

                    case "2":
                        veiculoAdicionar.tipoVeiculo = "Moto";
                        menu = 0;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        menu = 1;
                        break;
                }
            }

            // Solicita os dados do veiculo ser adicionado ao estacionamento
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculoAdicionar.placaVeiculo = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite o nome do motorista do veículo para estacionar:");
            veiculoAdicionar.nomeMotorista = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite o telefone de contato:");
            veiculoAdicionar.telefoneContato = Console.ReadLine();


            listaVeiculos.Add(veiculoAdicionar);

        }

        public void RemoverVeiculo()
        {

            Veiculo veiculoExcluir = new Veiculo();
            decimal valorTotal = 0;

            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine().ToUpper();


            // Verifica se o veículo existe
            if (listaVeiculos.Any(x => x.placaVeiculo == placa))
            {
                // Busca os dados do veiculo
                foreach (var item in listaVeiculos)
                {
                    if (item.placaVeiculo == placa)
                    {
                        veiculoExcluir = item;
                    }
                }

                // Exibir os dados do veiculo
                Console.WriteLine($"Veiculo Tipo: {veiculoExcluir.tipoVeiculo} - Placa: {veiculoExcluir.placaVeiculo} - Motorista: {veiculoExcluir.nomeMotorista} - Contato: {veiculoExcluir.telefoneContato}");

                // Pedi confirmaçào para excluir o veiculo
                Console.WriteLine($"Deseja realizar a saida do veículo {placa}?(1 - SIM, 2 - NÃO)");
                int confirmacao = Convert.ToInt32(Console.ReadLine());

                if (confirmacao == 1)
                {
                    
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    int horas = Convert.ToInt32(Console.ReadLine());


                    // Realizar o calculo do valor a ser cobrado de acordo com o tipo de veiculo
                    if (veiculoExcluir.tipoVeiculo == "Carro")
                    {
                        valorTotal = precoInicialCarro + precoPorHoraCarro * horas;
                    }
                    else
                    {
                        valorTotal = precoInicialMoto + precoPorHoraMoto * horas;
                    }

                    
                    listaVeiculos.Remove(veiculoExcluir);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine($"Retirada do veículo {placa} cancelada.");
                }
                
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (listaVeiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                int contador = 1;
                foreach (var item in listaVeiculos)
                {
                    Console.WriteLine($"Veiculo {contador} - Tipo: {item.tipoVeiculo} - Placa: {item.placaVeiculo} - Motorista: {item.nomeMotorista} - Contato: {item.telefoneContato}");
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
