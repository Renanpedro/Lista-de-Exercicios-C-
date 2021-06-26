using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_de_Exercicios
{
    class SomaDosPares:Program
    {
        public static void Executar()
        {
            int[] Numero = new int[5];
            int ResultadoSoma = 0;

            for(int i=1; i <=4; i++){
                Console.WriteLine("Favor informar o {0} numero",i);
                Numero[i] = int.Parse(Console.ReadLine());

                if ((Numero[i] % 2) == 0)
                {
                    ResultadoSoma += Numero[i];                 
                }

                Console.WriteLine(" ");
            }

            MudaParaVerde();
            Console.WriteLine($"A soma dos numeros pares é: {ResultadoSoma}");
            Console.WriteLine(" ");
            VoltaCorNormal();
        }

        
    }
}
