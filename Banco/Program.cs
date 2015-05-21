using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public struct pessoas
{
    public int serv;
    public int prio;
    public string img;

}

    class Program
    {
        public static pessoas[] fila = new pessoas[10];

        static ide ide = new ide();


        public static void principal()
        { ide.caixa(fila);
                  
        }

        public static void final() {
            ide.finalizarcaixa(fila);
            ide.telafinal();
        }
        
        public static void menu()
        {
            inicio:
            ConsoleKey a = Console.ReadKey().Key;
            switch (a)
            {
                case ConsoleKey.Escape:
                    goto inicio;
                default:
                    ide.telafinal();
                    System.Threading.Thread.Sleep(100);
                    goto inicio;

            }
        }
       
        static void Main(string[] args)
        {
            Console.SetWindowSize(79, 26);
            Console.SetBufferSize(79, 26);
            for (int c = 0; c < 10; c++)
            { // limpa o vetor antes do uso...
                fila[c].prio = -1;
                fila[c].serv = -1;
            }
          
            
        System.Threading.Thread pri = new System.Threading.Thread(principal);
        System.Threading.Thread r= new System.Threading.Thread(ide.relogio);
        System.Threading.Thread fim = new System.Threading.Thread(final);
        r.Start();
        pri.Start();
        final();
        inicio:
        
            ConsoleKey a = Console.ReadKey().Key;


            switch (a)
            {
                case ConsoleKey.Escape:
                    goto inicio;
                case ConsoleKey.E:
                    try
                    {
                        r.Suspend();
                        pri.Suspend();
                        ide.telafinal();
                        goto inicio;
                    }
                    catch
                    {
                        goto inicio;
                    }
                default:
                    if (r.IsAlive)
                    {
                        try
                        {
                            r.Resume();
                            pri.Resume();

                        }

                        catch
                        {
                            goto inicio;
                        }

                    }
                    else
                    {
                        final();
                    }
                    System.Threading.Thread.Sleep(100);
                    goto inicio;

            }
        
}
            public static void tela(pessoas[] a)
            {
                Console.Clear();

                Console.Write("╔════════════════════════════════════════════════════════════════════════════╗\n");
                Console.Write("║                         BANCO NACIONAL DO SEREZZANI                        ║\n");
                Console.Write("╠════════════════════════════════════════════════════════════════════════════╣\n");
                Console.Write("║ ╠══╣                                                                       ║\n");
                Console.Write("║ ║C ║                                                                       ║\n");
                Console.Write("║ ║A ║                                                                       ║\n");
                Console.Write("║ ║I ║                                                                       ║\n");
                Console.Write("║ ║X ║                                                                       ║\n");
                Console.Write("║ ║A ║                                                                       ║\n");
                Console.Write("║ ╠══╣                                                                       ║\n");
                Console.Write("║                                                                            ║\n");
                Console.Write("║                                                                            ║\n");
                Console.Write("║                                                                            ║\n");
                Console.Write("║                                                                            ║\n");
                Console.Write("║                                                                            ║\n");
                Console.Write("║                                                                            ║\n");
                Console.Write("║                                                                            ║\n");
                Console.Write("╠════════════════════════════════════════════════════════════════════════════╣\n");
                Console.Write("╠════════════════════════════════════════════════════════════════════════════╣\n");
                Console.Write("║                                                                            ║\n");
                Console.Write("║                                                                            ║\n");
                Console.Write("║                                                                            ║\n");
                Console.Write("║                                                                            ║\n");
                Console.Write("║                                                                            ║\n");
                Console.Write("╚════════════════════════════════════════════════════════════════════════════╝\n");
            Console.SetCursorPosition(6, 8);
            Console.Write("═══════════════════════════════════════════════════════════════════════");
            // Tirar as quebras de linha
            Console.SetCursorPosition(6, 9);
            Console.Write("                                                              ╔═══════╗");
            Console.SetCursorPosition(6, 10);
            Console.Write("                                                              ║ BEM   ║");
            Console.SetCursorPosition(6, 11);
            Console.Write("                                                              ║ VINDO ║");
            Console.SetCursorPosition(6, 12);
            Console.Write("                                                              ╚═══════╝\n");
            //posição 0
            ide.cor(a[0]);
            Console.SetCursorPosition(8, 5);
            ide.impkbca(a[0].prio);
            Console.SetCursorPosition(8, 6);
            Console.Write(a[0].img);
            Console.SetCursorPosition(8, 7);
            ide.imppes(a[0].prio);
            Console.ForegroundColor = ConsoleColor.Gray;
            //posição 1
            ide.cor(a[1]);
            Console.SetCursorPosition(14, 5);
            ide.impkbca(a[1].prio);
            Console.SetCursorPosition(14, 6);
            Console.Write(a[1].img);
            Console.SetCursorPosition(14, 7);
            ide.imppes(a[1].prio);
            Console.ForegroundColor = ConsoleColor.Gray;
            //posição 2
            ide.cor(a[2]);
            Console.SetCursorPosition(20, 5);
            ide.impkbca(a[2].prio);
            Console.SetCursorPosition(20, 6);
            Console.Write(a[2].img);
            Console.SetCursorPosition(20, 7);
            ide.imppes(a[2].prio);
            Console.ForegroundColor = ConsoleColor.Gray;
            //posição 3
            ide.cor(a[3]);
            Console.SetCursorPosition(26, 5);
            ide.impkbca(a[3].prio);
            Console.SetCursorPosition(26, 6);
            Console.Write(a[3].img);
            Console.SetCursorPosition(26, 7);
            ide.imppes(a[3].prio);
            Console.ForegroundColor = ConsoleColor.Gray;
            //posição 4
            ide.cor(a[4]);
            Console.SetCursorPosition(32, 5);
            ide.impkbca(a[4].prio);
            Console.SetCursorPosition(32, 6);
            Console.Write(a[4].img);
            Console.SetCursorPosition(32, 7);
            ide.imppes(a[4].prio);
            Console.ForegroundColor = ConsoleColor.Gray;
            //posição 5
            ide.cor(a[5]);
            Console.SetCursorPosition(38, 5);
            ide.impkbca(a[5].prio);
            Console.SetCursorPosition(38, 6);
            Console.Write(a[5].img);
            Console.SetCursorPosition(38, 7);
            ide.imppes(a[5].prio);
            Console.ForegroundColor = ConsoleColor.Gray;
            //posição 6
            ide.cor(a[6]);
            Console.SetCursorPosition(44, 5);
            ide.impkbca(a[6].prio);
            Console.SetCursorPosition(44, 6);
            Console.Write(a[6].img);
            Console.SetCursorPosition(44, 7);
            ide.imppes(a[6].prio);
            Console.ForegroundColor = ConsoleColor.Gray;
            //posição 7
            ide.cor(a[7]);
            Console.SetCursorPosition(50, 5);
            ide.impkbca(a[7].prio);
            Console.SetCursorPosition(50, 6);
            Console.Write(a[7].img);
            Console.SetCursorPosition(50, 7);
            ide.imppes(a[7].prio);
            Console.ForegroundColor = ConsoleColor.Gray;
            //posição 8
            ide.cor(a[8]);
            Console.SetCursorPosition(56, 5);
            ide.impkbca(a[8].prio);
            Console.SetCursorPosition(56, 6);
            Console.Write(a[8].img);
            Console.SetCursorPosition(56, 7);
            ide.imppes(a[8].prio);
            Console.ForegroundColor = ConsoleColor.Gray;
            //posição 9

            Console.SetCursorPosition(65, 5);
            ide.impkbca(a[9].prio);
            Console.SetCursorPosition(65, 6);
            Console.Write(a[9].img);
            Console.SetCursorPosition(65, 7);
            ide.imppes(a[9].prio);
            // Contadores
            Console.SetCursorPosition(56, 23);
            if (ide.getH() < 16)
            {
                Console.Write("Agora são: {0}:{1}:{2}h ", ide.getH(), ide.getM(), ide.getS()); // Tempo de funcionamento
                Console.SetCursorPosition(10, 15);
                Console.WriteLine("Pressione a tecla E para visualizar as estatísticas");
            }
            else
            {
                Console.SetCursorPosition(56, 23);
                Console.WriteLine("BANCO FECHADO");
                Console.SetCursorPosition(10, 15);
                Console.WriteLine("Pressione qualquer teclas para atender os clientes restantes");
                
            }

            
            Console.SetCursorPosition(3, 19);
            Console.Write("LEGENDA:");
            Console.SetCursorPosition(3, 21);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("* DEPÓSITO");
            Console.SetCursorPosition(3, 22);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("* SAQUE");
            Console.SetCursorPosition(3, 23);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("* PAGAMENTO");
            Console.ForegroundColor = ConsoleColor.Gray;
            ide.rel(20,20);
        }


     
        public static void estatisticas() {
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
            Console.Write("╠════════════════════════════════════════════════════════════════════════════╣\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("║                                                                            ║\n");
            Console.Write("╚════════════════════════════════════════════════════════════════════════════╝\n");
            
        }
    
       
    }
     
}
