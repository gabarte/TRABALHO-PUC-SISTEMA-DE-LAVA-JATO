using System;
using System.Collections.Generic;

public class Agend
{
    string cli = "";
    double day;
    string hour = "";
    string month = "";
    string serv = "";

    int ps;
    static List<LA> agendamentos = new List<LA>();

    public Agend(int i){
        var clie = new Cli();
        clie.RetLi(i);
        string cli2 = clie.RL();
        bool cho=false;
        if(cli2 == ""){
            while(cho == false){
            Console.WriteLine("Agendar(1) \nMostrar agendamentos(2)");
            int a= Convert.ToInt32(Console.ReadLine());
        switch(a){
            case 1:
                Agend2();
                cho=true;
                break;
            case 2:
                mostrarAgends();
                cho=true;
                break;
            default:
                Console.WriteLine("Serviço inexistente");
                cho=false;
                break;
        }}
        }
        else{
        while(cho == false){
            Console.WriteLine("Agendar(1) \nMostrar agendamentos(2)");
            int a= Convert.ToInt32(Console.ReadLine());
        switch(a){
            case 1:
                Agend2(cli2);
                cho=true;
                break;
            case 2:
                mostrarAgends();
                cho=true;
                break;
            default:
                Console.WriteLine("Serviço inexistente");
                cho=false;
                break;
        }}}

    }
    public void mostrarAgends(){
        Console.WriteLine("----- Agendamentos -----");
        if (agendamentos.Count > 0)
        {
            foreach (LA Ag in agendamentos)
            {
                Console.WriteLine(Ag.Agen);
                Console.WriteLine($"Preço: R${Ag.Pre},00");
                Console.WriteLine("-----------------------------");
            }
        }
        else
        {
            Console.WriteLine("Nenhum agendamento.");
        }
    }
    public void Agend2()
    {
        //Não achei um jeito de pegar o nome do cliente na lista
        Console.WriteLine("Nome do cliente");
        cli = Console.ReadLine();
        time();
        ser();
        string agendamentoInfo = ret();
        Console.WriteLine(agendamentoInfo);
        var age= new LA(agendamentoInfo, ps);
        agendamentos.Add(age);
        Console.WriteLine("Serviço agendado com sucesso!");
    }
    public void Agend2(string name)
    {
        //Não achei um jeito de pegar o nome do cliente na lista
        cli = name;
        time();
        ser();
        string agendamentoInfo = ret();
        Console.WriteLine(agendamentoInfo);
        var age= new LA(agendamentoInfo, ps);
        agendamentos.Add(age);
        Console.WriteLine("Serviço agendado com sucesso!");
    }
    private void time()
    {
        Console.WriteLine("Em qual dia sera realizado o serviço?");
        day = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("De qual mês?");
        month = Console.ReadLine();
        Console.WriteLine("A que horas?");
        hour = Console.ReadLine();
    }

    private void ser()
    {
        var s = new Lavagem();
        s.Preco();
        serv= s.TSer();
        ps= s.PreSer();
    }

    public string ret()
    {
        if (serv == "")
        {
            if (hour == "1")
            {
                return $"o agendamento do cliente {cli} será no dia {day}/{month} a {hour} hora, nenhum serviço foi escolhido";
            }
            else
            {
                return $"o agendamento do cliente {cli} será no dia {day}/{month} às {hour} horas, nenhum serviço foi escolhido";
            }
        }
        else
        {
            if (hour == "1")
            {
                return $"o agendamento do cliente {cli} será no dia {day}/{month} a {hour} hora com o serviço: {serv}";
            }
            else
            {
                return $"o agendamento do cliente {cli} será no dia {day}/{month} às {hour} horas com o serviço: {serv}";
            }
        }
    }
    class LA
    {
        public string Agen { get; }
        public int Pre { get;}
        public LA(string AGINF, int ps){
            Agen = AGINF;
            Pre = ps;
        }
    }
}
