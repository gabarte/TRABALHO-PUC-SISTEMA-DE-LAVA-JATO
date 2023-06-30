using System;

    class Lavagem
    {
        public int servico;
        public string tiser="";

        public void Preco()
        {
            int se;
            Console.WriteLine("Qual o porte do carro?\n (1)Pequeno \n (2)Medio \n (3)Grande \n");
            int lavca= Convert.ToInt32(Console.ReadLine());
            if(lavca==1){
                Console.WriteLine("Escolha o tipo de serviço que deseja: \n (1)Lavagem Rápida: 50 R$ \n (2)Lavagem Normal: 80 R$ \n (3)Lavagem Completa: 130 R$ \n (4)Lavagem de Motor: 40 R$ \n (5)Aspiração: 15 R$");
            se = Convert.ToInt32(Console.ReadLine());

            switch (se)
            {
                case 1:
                    Console.WriteLine("Lavagem Rápida selecionada");
                    servico= 50;
                    tiser= "Lavagem Rápida";
                    PreSer();
                    TSer();
                    break;
                case 2:
                    Console.WriteLine("Lavagem Normal selecionada");
                    servico= 80;
                    tiser= "Lavagem Normal";
                    PreSer();
                    TSer();
                    break;
                case 3:
                    Console.WriteLine("Lavagem Completa selecionada");
                    servico= 130;
                    tiser= "Lavagem Completa";
                    PreSer();
                    TSer();
                    break;
                case 4:
                    Console.WriteLine("Lavagem de Motor selecionada");
                    servico= 40;
                    tiser= "Lavagem de Motor";
                    PreSer();
                    TSer();
                    break;
                case 5:
                    Console.WriteLine("Aspiração selecionada");
                    servico= 15;
                    tiser= "Aspiração";
                    PreSer();
                    TSer();
                    break;
                default:
                    Console.WriteLine("Serviço indisponível");
                    break;
            }
            if(se!=5){
                Console.WriteLine("Deseja realizar uma aspiração tambem?\n SIM(1) \n NÃO(2)");
                int rep= Convert.ToInt32(Console.ReadLine());
                if(rep==1){
                    servico+= 15;
                    tiser+= ", Aspiração";
                    PreSer();
                    TSer();
                }
                else if(rep==2){

                }
                else{
                    Console.WriteLine("Nenhuma opção selecionada");
                }
            }
            }
            else if(lavca==2){
                Console.WriteLine("Escolha o tipo de serviço que deseja: \n (1)Lavagem Rápida: 70 R$ \n (2)Lavagem Normal: 100 R$ \n (3)Lavagem Completa: 150 R$ \n (4)Lavagem de Motor: 50 R$ \n (5)Aspiração: 30 R$");
            se = Convert.ToInt32(Console.ReadLine());

            switch (se)
            {
                case 1:
                    Console.WriteLine("Lavagem Rápida selecionada");
                    servico= 70;
                    tiser= "Lavagem Rápida";
                    PreSer();
                    TSer();
                    break;
                case 2:
                    Console.WriteLine("Lavagem Normal selecionada");
                    servico= 100;
                    tiser= "Lavagem Normal";
                    PreSer();
                    TSer();
                    break;
                case 3:
                    Console.WriteLine("Lavagem Completa selecionada");
                    servico= 150;
                    tiser= "Lavagem Completa";
                    PreSer();
                    TSer();
                    break;
                case 4:
                    Console.WriteLine("Lavagem de Motor selecionada");
                    servico= 50;
                    tiser= "Lavagem de Motor";
                    PreSer();
                    TSer();
                    break;
                case 5:
                    Console.WriteLine("Aspiração selecionada");
                    servico= 30;
                    tiser= "Aspiração";
                    PreSer();
                    TSer();
                    break;
                default:
                    Console.WriteLine("Serviço indisponível");
                    break;
            }
            if(se!=5){
                Console.WriteLine("Deseja realizar uma aspiração tambem?\n SIM(1) \n NÃO(2)");
                int rep= Convert.ToInt32(Console.ReadLine());
                if(rep==1){
                    servico+= 30;
                    tiser+= ", Aspiração";
                    PreSer();
                    TSer();
                }
                else if(rep==2){

                }
                else{
                    Console.WriteLine("Nenhuma opção selecionada");
                }
            }
            }
            else if(lavca==3){
                Console.WriteLine("Escolha o tipo de serviço que deseja: \n (1)Lavagem Rápida: 90 R$ \n (2)Lavagem Normal: 115 R$ \n (3)Lavagem Completa: 180 R$ \n (4)Lavagem de Motor: 60 R$ \n (5)Aspiração: 45 R$");
            se = Convert.ToInt32(Console.ReadLine());

            switch (se)
            {
                case 1:
                    Console.WriteLine("Lavagem Rápida selecionada");
                    servico= 90;
                    tiser= "Lavagem Rápida";
                    PreSer();
                    TSer();
                    break;
                case 2:
                    Console.WriteLine("Lavagem Normal selecionada");
                    servico= 115;
                    tiser= "Lavagem Normal";
                    PreSer();
                    TSer();
                    break;
                case 3:
                    Console.WriteLine("Lavagem Completa selecionada");
                    servico= 180;
                    tiser= "Lavagem Completa";
                    PreSer();
                    TSer();
                    break;
                case 4:
                    Console.WriteLine("Lavagem de Motor selecionada");
                    servico= 60;
                    tiser= "Lavagem de Motor";
                    PreSer();
                    TSer();
                    break;
                case 5:
                    Console.WriteLine("Aspiração selecionada");
                    servico= 45;
                    tiser= "Aspiração";
                    PreSer();
                    TSer();
                    break;
                default:
                    Console.WriteLine("Serviço indisponível");
                    break;
            }
            if(se!=5){
                Console.WriteLine("Deseja realizar uma aspiração tambem?\n SIM(1) \n NÃO(2)");
                int rep= Convert.ToInt32(Console.ReadLine());
                if(rep==1){
                    servico+= 45;
                    tiser+= ", Aspiração";
                    PreSer();
                    TSer();
                }
                else if(rep==2){

                }
                else{
                    Console.WriteLine("Nenhuma opção selecionada");
                }
            }
            }
            else{
                Console.WriteLine("Porte de carro invalido");
            }
        }
        public void Preco(int lavca)
        {
            int se;
            if(lavca==1){
                Console.WriteLine("Escolha o tipo de serviço que deseja: \n (1)Lavagem Rápida: 50 R$ \n (2)Lavagem Normal: 80 R$ \n (3)Lavagem Completa: 130 R$ \n (4)Lavagem de Motor: 40 R$ \n (5)Aspiração: 15 R$");
            se = Convert.ToInt32(Console.ReadLine());

            switch (se)
            {
                case 1:
                    Console.WriteLine("Lavagem Rápida selecionada");
                    servico= 50;
                    tiser= "Lavagem Rápida";
                    PreSer();
                    TSer();
                    break;
                case 2:
                    Console.WriteLine("Lavagem Normal selecionada");
                    servico= 80;
                    tiser= "Lavagem Normal";
                    PreSer();
                    TSer();
                    break;
                case 3:
                    Console.WriteLine("Lavagem Completa selecionada");
                    servico= 130;
                    tiser= "Lavagem Completa";
                    PreSer();
                    TSer();
                    break;
                case 4:
                    Console.WriteLine("Lavagem de Motor selecionada");
                    servico= 40;
                    tiser= "Lavagem de Motor";
                    PreSer();
                    TSer();
                    break;
                case 5:
                    Console.WriteLine("Aspiração selecionada");
                    servico= 15;
                    tiser= "Aspiração";
                    PreSer();
                    TSer();
                    break;
                default:
                    Console.WriteLine("Serviço indisponível");
                    break;
            }
            if(se!=5){
                Console.WriteLine("Deseja realizar uma aspiração tambem?\n SIM(1) \n NÃO(2)");
                int rep= Convert.ToInt32(Console.ReadLine());
                if(rep==1){
                    servico+= 15;
                    tiser+= ", Aspiração";
                    PreSer();
                    TSer();
                }
                else if(rep==2){

                }
                else{
                    Console.WriteLine("Nenhuma opção selecionada");
                }
            }
            }
            else if(lavca==2){
                Console.WriteLine("Escolha o tipo de serviço que deseja: \n (1)Lavagem Rápida: 70 R$ \n (2)Lavagem Normal: 100 R$ \n (3)Lavagem Completa: 150 R$ \n (4)Lavagem de Motor: 50 R$ \n (5)Aspiração: 30 R$");
            se = Convert.ToInt32(Console.ReadLine());

            switch (se)
            {
                case 1:
                    Console.WriteLine("Lavagem Rápida selecionada");
                    servico= 70;
                    tiser= "Lavagem Rápida";
                    PreSer();
                    TSer();
                    break;
                case 2:
                    Console.WriteLine("Lavagem Normal selecionada");
                    servico= 100;
                    tiser= "Lavagem Normal";
                    PreSer();
                    TSer();
                    break;
                case 3:
                    Console.WriteLine("Lavagem Completa selecionada");
                    servico= 150;
                    tiser= "Lavagem Completa";
                    PreSer();
                    TSer();
                    break;
                case 4:
                    Console.WriteLine("Lavagem de Motor selecionada");
                    servico= 50;
                    tiser= "Lavagem de Motor";
                    PreSer();
                    TSer();
                    break;
                case 5:
                    Console.WriteLine("Aspiração selecionada");
                    servico= 30;
                    tiser= "Aspiração";
                    PreSer();
                    TSer();
                    break;
                default:
                    Console.WriteLine("Serviço indisponível");
                    break;
            }
            if(se!=5){
                Console.WriteLine("Deseja realizar uma aspiração tambem?\n SIM(1) \n NÃO(2)");
                int rep= Convert.ToInt32(Console.ReadLine());
                if(rep==1){
                    servico+= 30;
                    tiser+= ", Aspiração";
                    PreSer();
                    TSer();
                }
                else if(rep==2){

                }
                else{
                    Console.WriteLine("Nenhuma opção selecionada");
                }
            }
            }
            else if(lavca==3){
                Console.WriteLine("Escolha o tipo de serviço que deseja: \n (1)Lavagem Rápida: 90 R$ \n (2)Lavagem Normal: 115 R$ \n (3)Lavagem Completa: 180 R$ \n (4)Lavagem de Motor: 60 R$ \n (5)Aspiração: 45 R$");
            se = Convert.ToInt32(Console.ReadLine());

            switch (se)
            {
                case 1:
                    Console.WriteLine("Lavagem Rápida selecionada");
                    servico= 90;
                    tiser= "Lavagem Rápida";
                    PreSer();
                    TSer();
                    break;
                case 2:
                    Console.WriteLine("Lavagem Normal selecionada");
                    servico= 115;
                    tiser= "Lavagem Normal";
                    PreSer();
                    TSer();
                    break;
                case 3:
                    Console.WriteLine("Lavagem Completa selecionada");
                    servico= 180;
                    tiser= "Lavagem Completa";
                    PreSer();
                    TSer();
                    break;
                case 4:
                    Console.WriteLine("Lavagem de Motor selecionada");
                    servico= 60;
                    tiser= "Lavagem de Motor";
                    PreSer();
                    TSer();
                    break;
                case 5:
                    Console.WriteLine("Aspiração selecionada");
                    servico= 45;
                    tiser= "Aspiração";
                    PreSer();
                    TSer();
                    break;
                default:
                    Console.WriteLine("Serviço indisponível");
                    break;
            }
            if(se!=5){
                Console.WriteLine("Deseja realizar uma aspiração tambem?\n SIM(1) \n NÃO(2)");
                int rep= Convert.ToInt32(Console.ReadLine());
                if(rep==1){
                    servico+= 45;
                    tiser+= ", Aspiração";
                    PreSer();
                    TSer();
                }
                else if(rep==2){

                }
                else{
                    Console.WriteLine("Nenhuma opção selecionada");
                }
            }
            }
            else{
                Console.WriteLine("Porte de carro invalido");
            }
        }
        public int PreSer(){
            return servico;
        }
        public string TSer(){
            return tiser;
        }
    }

