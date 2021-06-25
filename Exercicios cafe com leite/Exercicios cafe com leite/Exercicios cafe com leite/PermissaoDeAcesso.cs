using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_cafe_com_leite
{
    class PermissaoDeAcesso
    {
        public static void Executar()
        {
            int idade;

            Console.WriteLine("Informe a sua idade");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Acesso liberado");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem permição de acesso");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
