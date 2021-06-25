using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_cafe_com_leite
{
    class MaiorMenorMediaSoma:Program
    {
        public static void Executar() { 
            int numero1;    int NumeroMaior = 0;
            int numero2;    int NumeroMenor = 0;
            int numero3;
            int media;
            int soma;

            Console.WriteLine("Favor informar o primeiro numero");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Favor informar o segundo numero");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Favor informar o terceiro numero");
            numero3 = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            //Para localizar o numero maior
            if (numero1 > numero2 && numero1 > numero3)
            {
                NumeroMaior = numero1;
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                NumeroMaior = numero2;
            }
            else if (numero3 > numero1 && numero3 > numero2) {
                NumeroMaior = numero3;
            }

            //Para localizar o numero Menor
            if (numero1 < numero2 && numero1 < numero3)
            {
                NumeroMenor = numero1;
            }
            else if (numero2 < numero1 && numero2 < numero3)
            {
                NumeroMenor = numero2;
            }
            else if (numero3 < numero1 && numero3 < numero2)
            {
                NumeroMenor = numero3;
            }

            media = (numero1 + numero2 + numero3) / 3;
            soma = (numero1 + numero2 + numero3);

            MudaParaVerde();
            Console.WriteLine("O maior numeros entre os 3 é: "+ NumeroMaior);
            Console.WriteLine(" ");
            Console.WriteLine("O menor numeros entre os 3 é: "+ NumeroMenor);
            Console.WriteLine(" ");
            Console.WriteLine("A soma entre os 3 é: "+ soma);
            Console.WriteLine(" ");
            Console.WriteLine("A media  entre os 3 é: "+ media);
            VoltaCorNormal();







        }
    }
}
