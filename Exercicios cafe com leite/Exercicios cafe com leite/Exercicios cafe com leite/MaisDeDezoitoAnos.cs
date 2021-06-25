using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_cafe_com_leite
{
    class MaisDeDezoitoAnos
    {
        int idade;
        int quantidade;
        int resultado = 0;

        public static void Executar() {
            MaisDeDezoitoAnos objeto = new MaisDeDezoitoAnos();

            Console.WriteLine("Informe a quantidade de pessoas: ");
            objeto.quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            for (int i = 1; i <= objeto.quantidade; i++) {
                Console.WriteLine("Informe a idade da {0} Pessoa", i);
                objeto.idade = int.Parse(Console.ReadLine());

                if (objeto.idade >= 18)
                {
                    objeto.resultado += 1;
                }
                else { 
                    
                }
                               
            }

            Console.WriteLine(" ");
            Console.WriteLine($"Foram informados {objeto.quantidade} pessoas, destas {objeto.resultado} são maiores de 18 anos");

        }
    }
}
