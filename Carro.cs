public class Carro{
    int tipoDeCarro;
    Boolean limpo=false;
    double totVal=0;
    double pv;
    int ts;
    public Carro(int i){
    int testID;
    Cli cal= new Cli();
    cal.RetVi(i);
    cal.RetLi(i);
    tipoDeCarro=cal.TL();
    testID= cal.IL();
    if(tipoDeCarro!=0 && testID!=-1){
        var s = new Lavagem();
        s.Preco(tipoDeCarro);
        ValorDeProd(s.PreSer());
        LavarCarro();
        double valorFinal = ValorFinal();
        Console.WriteLine("===========================");
        Console.WriteLine($"Serviço realizado com sucesso! Valor: R${valorFinal}");
        Console.WriteLine("===========================");
    }
    else if(testID==-1){
        Console.WriteLine("===========================");
        Console.WriteLine("Cliente não registrado");
        Console.WriteLine("Realizando serviço");
        Console.WriteLine("===========================");
        var s = new Lavagem();
        s.Preco();
        ValorDeProd(s.PreSer());
        LavarCarro();
        double valorFinal = ValorFinal();
        Console.WriteLine("===========================");
        Console.WriteLine($"Serviço realizado com sucesso! Valor: R${valorFinal}");
        Console.WriteLine("===========================");
    }
    else if(testID!=-1){
        Console.WriteLine("===========================");
        Console.WriteLine("Carro do cliente ainda não definido");
        Console.WriteLine("===========================");
    }
    }
    public void LavarCarro(){
        /* while(!limpo){
            Console.WriteLine("Qual produto foi utilizado?\n Cera(1) \n Detergente(2) \n Limpoform(3)");
            //Seila o nome de produto de limpeza :p
            int pl= Convert.ToInt32(Console.ReadLine());
            LimpProd(pl);
            Console.WriteLine ("A limpeza acabou?\n S \n N");
            string conf = Console.ReadLine();
            if(conf=="s" || conf=="S"){
                this.limpo=true;
            }
            else{
                this.limpo=false;
            }
        } */
        //Daqui vai sair quando o carro estiver limpo
    }
    /* private void LimpProd(int p){
        switch(p){
            case 1:
                pv=12.50;
                ValorDeProd(pv);
                break;
            case 2:
                pv=5.90;
                ValorDeProd(pv);
                break;
            case 3:
                pv=19.99;
                ValorDeProd(pv);
                break;
            case 4:
                break;
            default:
                Console.WriteLine("Produto fora de estoque");
                break;
        }
    } */
    private void ValorDeProd(double val){
        totVal+= val;
    }
    public double ValorFinal(){
        return totVal;
    }
    
}