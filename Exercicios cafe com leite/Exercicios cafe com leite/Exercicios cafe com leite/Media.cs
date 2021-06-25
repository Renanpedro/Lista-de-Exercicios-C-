using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_cafe_com_leite
{
    class Media
    {
        public static void Executar()
        {
            double somatorio = 0;
            double media;
            string entrada;

            Console.WriteLine("Qual o tamanho da turma?");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int TamanhoTurma);
            Console.WriteLine(" ");

            for (int i = 1; i <= TamanhoTurma; i++)
            {
                Console.WriteLine($"Digite a nota do {i}º Aluno");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double NotaAtual);
                Console.WriteLine(" ");

                if (NotaAtual >= 0 && NotaAtual <= 10)
                {
                    somatorio += NotaAtual;

                }
                else
                {
                    Console.WriteLine("Nota digitada inválida, Digite uma nota entre 0 até 10");
                    Console.WriteLine(" ");
                    i--;
                }

            }

            media = somatorio / TamanhoTurma;
            Console.WriteLine(" ");
            Console.WriteLine($"A turma contém {TamanhoTurma} alunos, e a média geral é : {media}");



        }
        
    }
}
