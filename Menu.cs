using System;

class Program
{
    public static void Main(string[] args)
    {
        bool sair = false;
        while (!sair)
        {
            Console.Clear();
            Console.WriteLine("=== MENU DO LAVA-JATO ===");
            Console.WriteLine("1. Cadastrar Cliente");
            Console.WriteLine("2. Agendar Serviço");
            Console.WriteLine("3. Realizar Lavagem");
            Console.WriteLine("4. Sair");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    var cl = new Cli();
                    cl.CadastrarClientes();
                    break;
                case "2":
                    AgendarServico();
                    break;
                case "3":
                    RealizarLavagem();
                    break;
                case "4":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void AgendarServico()
    {
        Console.Clear();
        Console.WriteLine("=== AGENDAR SERVIÇO ===");
        Console.WriteLine("Digite o ID do Cliente");
        int i = Convert.ToInt32(Console.ReadLine());
        Agend agendamento = new Agend(i);
    }

    static void RealizarLavagem()
    {
        Console.Clear();
        Console.WriteLine("=== REALIZAR LAVAGEM ===");
        Console.Write("Cliente ID: ");
        int clienteId = Convert.ToInt32(Console.ReadLine());

        // Verifique se o cliente e o veículo estão associados corretamente na lista de clientes e veículos ou no banco de dados.

        Carro carro = new Carro(clienteId);
        // Atualize o estado do carro e registre o valor final da lavagem, por exemplo, em um banco de dados.
    }
}
