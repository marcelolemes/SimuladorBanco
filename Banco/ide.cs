using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class ide
    {
        private static int an = 0; //contador de atendimentos normais    
        private static int ag = 0; // contador de atendimentos de gestantes
        private static int ai = 0; //contador de atendimentos de idosos
        private static int h = 0; // Hora
        private static int m = 0; // Minuto
        private static int s = 0; // segundo
        private static int t = 50; // Tempo 50
        private static int deposito; // depositos
        private static int pagamento; // pagamento
        private static int saque; // saque

public int getH() {
            return h;
        }
public void setH(int h)
{
        ide.h=h;
        }
public int getM()
        {
            return m;
        }
public void setM(int m)
        {
            ide.m = m;
        }
public int getS()
        {
            return s;
        }
public void setS(int s)
        {
            ide.s = s;
        }
public int getDeposito()
{
    return deposito;
}
public void setDeposito(int d)
{
    ide.deposito = d;
}
public int getPagamento()
{
    return pagamento;
}
    public void setPagamento(int p)
{
    ide.pagamento = p;
}
public int getSaque()
{
    return saque;
}
public void setSaque(int s)
{
    ide.saque = s;
}








      public static Random rdm = new Random();
   
        public static pessoas atribuir(pessoas a) // Atribui um novo cliente à fila
        {
            
            a.serv = rdm.Next(3); // tipo de de atendimento
            a.prio = rdm.Next(3); //prioridade de atendimento
            if (a.prio<2) { // diminuir idosos e grávidas
                a.prio = rdm.Next(3);     
            }
            switch (a.prio) // definir o desenho baseado na prioridade
            {
                case 2: a.img = "/▌\\";
                    break;
                case 0: a.img = "/██▌\\";
                    break;
                case 1: a.img = "/▌\\¬";
                    break;
                    
            }
            return a;
        }

        public static void caixa(pessoas[] a)
        {// Método principal
            if (h < 16)
            {
                while (h > 0)
                {
                    while (m < 60)
                    {
                        while (s < 60)
                        {
                            {
                                switch (a[0].prio)
                                {  // Recebe as estatísticas de atendimento
                                    case 0:
                                        ag++;
                                        break;
                                    case 1:
                                        ai++;
                                        break;
                                    case 2:
                                        an++;
                                        break;
                                }
                                switch (a[0].serv)
                                {  // Recebe as estatísticas de atendimento
                                    case 0:
                                        deposito++;
                                        break;
                                    case 1:
                                        saque++;
                                        break;
                                    case 2:
                                        pagamento++;
                                        break;
                                }
                                switch (a[0].serv)
                                {  // tempo Sleep igual à Sleep(50);
                                    case 0:
                                        System.Threading.Thread.Sleep(2*t);
                                        break;
                                    case 1:
                                        System.Threading.Thread.Sleep(3 * t);
                                        break;
                                    case 2:
                                        System.Threading.Thread.Sleep(4 * t);
                                        break;
                                }
                            }
                            for (int x = 0; x <= 9; x++)
                            {
                                pessoas aux;
                                try
                                {
                                    aux = a[x + 1];

                                }
                                catch
                                {
                                    aux = atribuir(a[9]);

                                }
                                a[x] = aux;
                                System.Threading.Thread.Sleep(2 * t);
                                ordenar(a);

                            }
                            Program.tela(a);
                        }


                    }
                }
                
            }
            
        }

        public static void finalizarcaixa(pessoas[] a)
        {// Método principal mas só para encerramento
           
              //  ordenarfinal(a);

                while (a[0].prio != -1)
                {

                    switch (a[0].prio)
                    {  // Recebe as estatísticas de atendimento
                        case 0:
                            ag++;
                            break;
                        case 1:
                            ai++;
                            break;
                        case 2:
                            an++;
                            break;
                    }
                    switch (a[0].serv)
                    {  // Recebe as estatísticas de atendimento
                        case 0:
                            deposito++;
                            break;
                        case 1:
                            saque++;
                            break;
                        case 2:
                            pagamento++;
                            break;
                    }


                    for (int x = 0; x <= 9; x++)
                    {
                        pessoas aux;
                        try
                        {
                            aux = a[x + 1];

                        }
                        catch
                        {
                            aux.img = null;
                            aux.prio = -1;
                            aux.serv = -1;

                        }
                        a[x] = aux;
                        if (x == 0)
                        {
                            Program.tela(a);
                        }
                        a[x] = aux;
                        switch (a[0].serv)
                        {  // tempo Sleep igual à Sleep(50);
                            case 0:
                                System.Threading.Thread.Sleep(2 * t);

                                break;
                            case 1:
                                System.Threading.Thread.Sleep(3 * t);

                                break;
                            case 2:
                                System.Threading.Thread.Sleep(4 * t);

                                break;
                        }


                    }

                    Program.tela(a);
                }


            }
        
        public static void relogio()
        {
            for (h = 8; h < 16; h++)
                {
                    for (m = 0; m < 60; m++)
                    {
                        for (s = 0; s < 60; s++)
                        {
                            System.Threading.Thread.Sleep(20*t);
                        }
                    }
                }
          
          }
     
        public static void impkbca(int a) // Método usado para imprimir a kbça dos bonecos apenas, utlizando apenas a prioridade como critério
        {

            switch (a) { 
                case 0:
                    Console.Write("  ☻");
                    break;
                case 1:
                    Console.Write(" ☻");
                    break;
                case 2:
                    Console.Write(" ☻");
                    break;
                default:
                    Console.Write(" ");
                    break;
            }
            }
        public static void imppes(int a) // Método usado para imprimir os pes dos bonecos apenas, utlizando apenas a prioridade como critério
        {

            switch (a) { 
                case 0:
                    Console.Write("/   \\");    
                    break;
                case 1:
                    Console.Write("/ \\|");
                    break;
                case 2:
                    Console.Write("/ \\");
                    break;
                default:
                      Console.Write(" ");
                    break;
            }
        }
        public static void cor(pessoas a)
        {
            switch(a.serv)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            
            }
        }
        public static void ordenar(pessoas [] a ) // Ordenar 
        {
            for (int x = 0; x <= 9; x++)
            {
                for (int y = x+1 ; y <9; y++)
                {
                    if (a[x].prio > a[y].prio & a[x].prio > -1)
                    {
                        pessoas aux = a[x];
                        a[x] = a[y];
                        a[y] = aux;
                    }
                }


            }
        
        }
        public static void ordenarfinal(pessoas[] a) // Ordenar final, que inclui o último da fila
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = x + 1; y < 10; y++)
                {
                    if (a[x].prio > a[y].prio & a[x].prio > -1)
                    {
                        pessoas aux = a[x];
                        a[x] = a[y];
                        a[y] = aux;
                    }
                }


            }

        }
      
        public static void rel(int x, int y) { // relatórios de atendimento
            
            Console.SetCursorPosition(x, y);
            Console.WriteLine("Atendimentos normais--> " + an);
            Console.SetCursorPosition(x, y+1);
            Console.WriteLine("Atendimentos de gestantes--> " + ag);
            Console.SetCursorPosition(x, y+2);
            Console.WriteLine("Atendimentos de idosos--> " + ai);
            Console.SetCursorPosition(x, y+3);
            Console.WriteLine("TOTAL DE ATENDIMENTOS--> " + (an + ag + ai));
         
        }
        public static void rel2(int x, int y)
        { // relatórios de atendimento

            Console.SetCursorPosition(x, y);
            Console.WriteLine("Atendimentos normais--> " + an);
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("Atendimentos de gestantes--> " + ag);
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("Atendimentos de idosos--> " + ai);
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine("TOTAL DE ATENDIMENTOS--> " + (an + ag + ai));
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("DEPÓSITOS--> " + deposito);
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine("SAQUES--> " + saque);
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine("PAGAMENTOS--> " + pagamento);
           
            
             //   Console.SetCursorPosition(10, 15);
               // Console.WriteLine("Pressione qualquer tecla para voltar ao banco");
           
        }
        public static void rel3(int x, int y)
        { // relatórios de atendimento

            Console.SetCursorPosition(x, y);
            Console.WriteLine("Atendimentos normais--> " + an);
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("Atendimentos de gestantes--> " + ag);
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("Atendimentos de idosos--> " + ai);
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine("TOTAL DE ATENDIMENTOS--> " + (an + ag + ai));
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("DEPÓSITOS--> " + deposito);
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine("SAQUES--> " + saque);
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine("PAGAMENTOS--> " + pagamento);
        //    Console.SetCursorPosition(10, 15);
          //  Console.WriteLine("Pressione qualquer tecla para voltar ao banco");

        }
        public static void telafinal()
        {// Tela para exibir os relatórios finais
            Console.Clear();

            Console.Write("╔════════════════════════════════════════════════════════════════════════════╗\n");
            Console.Write("║                         BANCO NACIONAL DO SEREZZANI                        ║\n");
            Console.Write("╠════════════════════════════════════════════════════════════════════════════╣\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("╠════════════════════════════════════════════════════════════════════════════╣\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("╚════════════════════════════════════════════════════════════════════════════╝\n");

            ide.rel2(20,7);
            if (h < 16)
            {

                Console.SetCursorPosition(10, 15);
                Console.WriteLine("Pressione qualquer tecla para voltar ao banco");
            }
            else {
                Console.SetCursorPosition(10, 15);
                Console.WriteLine("Clique no X no canto da tela para fechar o programa");
            }

        }
    }
}
