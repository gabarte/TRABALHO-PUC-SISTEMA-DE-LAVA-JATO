using System;
using System.Collections.Generic;

class Cli
{
    static List<Cliente> clientes = new List<Cliente>();
    static List<Veiculo> veic = new List<Veiculo>();
    public void CadastrarClientes(){
    {
        Console.Clear();
        bool executar = true;
        while (executar)
        {
            Console.WriteLine("----- Cadastro de Clientes -----");
            Console.WriteLine("1. Cadastrar novo cliente");
            Console.WriteLine("2. Cadastrar veiculo");
            Console.WriteLine("3. Mostrar todos os clientes");
            Console.WriteLine("4. Sair");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();
            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    CadastrarCliente();
                    Console.WriteLine("Cliente cadastrado com sucesso!");
                    Console.WriteLine();
                    break;
                case "2":
                Console.WriteLine("Digite o id do cliente");
                int i = Convert.ToInt32(Console.ReadLine());
                    CadastrarVeiculo(i);
                    Console.WriteLine();
                    break;
                case "3":
                    MostrarClientes();
                    Console.WriteLine();
                    break;

                case "4":
                    executar = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                    Console.WriteLine();
                    break;
            }
        }
    }

    static void CadastrarCliente()
    {
        Console.Clear();
        Console.WriteLine("----- Cadastro de Novo Cliente -----");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();
        int clienteId=0;
        int comp = 1;
        foreach (Cliente clien in clientes){
            if(clien.ID == comp){
                
            }
            else{
                clienteId = comp;
            }
            comp++;
        }
        

        Cliente cliente = new Cliente(nome, telefone, clienteId);
        clientes.Add(cliente);
    }
    static void CadastrarVeiculo(int i)
    {
        Console.Clear();
        var clie = new Cli();
        clie.RetLi(i);
        int cli2 = clie.IL();
        if(cli2 != -1){
        Console.WriteLine("=== CADASTRAR VEÍCULO ===");
        Console.Write("Porte do Carro:\n (1)Pequeno \n (2)Medio \n (3)Grande \n");
        int tipoCarro = Convert.ToInt32(Console.ReadLine());
        Console.Write("Modelo do carro: ");
        string modeloCarro = Console.ReadLine();

        Veiculo veiculo = new Veiculo(cli2, tipoCarro, modeloCarro);
        veic.Add(veiculo);
        // Salve o veículo associado ao cliente, por exemplo, em uma lista de veículos ou em um banco de dados.
        Console.WriteLine("Veículo cadastrado com sucesso!");}
        else{
            Console.WriteLine("ID invalido");
        }
    }

    static void MostrarClientes()
    {
        Console.WriteLine("----- Lista de Clientes -----");
        if (clientes.Count > 0)
        {
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"Nome: {cliente.Nome}");
                Console.WriteLine($"Telefone: {cliente.Telefone}");
                Console.WriteLine("-----------------------------");
            }
        }
        else
        {
            Console.WriteLine("Nenhum cliente cadastrado.");
        }
    }
}

class Cliente
{
    public string Nome { get; }
    public string Telefone { get; }
    public int ID { get; }

    public Cliente(string nome, string telefone, int id)
    {
        Nome = nome;
        Telefone = telefone;
        ID = id;
    }
}
    string Exit="";
    int ExID=-1;
    int ExTv;
    public void RetLi(int ID){
        foreach (Cliente cliente in clientes)
            {
                var id= cliente.ID;
                if(id==ID){
                    Exit=cliente.Nome;
                    ExID=id;
                }
                else{
                    Console.WriteLine("O ID escolhido não existe");
                    Exit="";
                }
            }
    }
    public void RetVi(int ID){
        foreach (Veiculo v in veic)
            {
                var id= v.ClienteId;
                if(id==ID){
                    ExTv=v.TipoCarro;
                    ExID=id;
                }
                else{
                    Console.WriteLine("Não há um carro cadastrado para este cliente");
                    ExTv=0;
                }
            }
    }
    public string RL(){
        return Exit;
    }
    public int IL(){
        return ExID;
    }
    public int TL(){
        return ExTv;
    }
    public class Veiculo
{
    public int ClienteId { get; set; }
    public int TipoCarro { get; set; }
    public string ModeloCarro { get; }

    public Veiculo(int clienteId, int tipoCarro, string modeloCarro)
    {
        ClienteId = clienteId;
        ModeloCarro = modeloCarro;
        TipoCarro = tipoCarro;
    }
}
}