using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_cafe_com_leite
{
    class NumeroParOuImpar
    {
        int numero;
        int resutaldo;

        public static void Executar() {

            NumeroParOuImpar objeto = new NumeroParOuImpar();

            Console.WriteLine("Digite um numero");
            objeto.numero = int.Parse(Console.ReadLine());

            objeto.resutaldo = objeto.numero % 2;

            if (objeto.resutaldo == 0) {
                Console.WriteLine("O numero informado é PAR");
            } else
            {
                Console.WriteLine("O numero informado é IMPAR");
            }

        }
        
        

    }
}
