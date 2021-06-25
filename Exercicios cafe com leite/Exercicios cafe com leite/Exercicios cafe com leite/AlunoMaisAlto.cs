using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_cafe_com_leite
{
    class AlunoMaisAlto
    {
        public static void Executar() {
            double MaiorMatricula;
            double MaiorAltura;

            double MenorMatricula;
            double MenorAltura;

            double Matricula;
            double Altura;

            Console.WriteLine("informe a matricula do aluno");
            Matricula = double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Informe a altura do aluno");
            Altura = double.Parse(Console.ReadLine());

            MaiorMatricula = Matricula;
            MaiorAltura = Altura;

            MenorMatricula = Matricula;
            MenorAltura = Altura;

            Console.WriteLine(" ");

            for (int i = 0; i < 2; i++) {
                Console.WriteLine("Informe a matricula do aluno: ");
                Matricula = double.Parse(Console.ReadLine());

                Console.WriteLine(" ");

                Console.WriteLine("Informe a altura do aluno:");
                Altura = double.Parse(Console.ReadLine());

                if (MaiorAltura < Altura) {
                    MaiorAltura = Altura;
                    MaiorMatricula = Matricula;
                }

                if (MenorAltura > Altura) {
                    MenorMatricula = Matricula;
                    MenorAltura = Altura;
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("Maior aluno");
            Console.WriteLine("Matricula {0} altura {1}",MaiorMatricula,MaiorAltura);

            Console.WriteLine(" ");
            Console.WriteLine("Menor Aluno");
            Console.WriteLine("Matricula {0} altura {1}",MenorMatricula,MenorAltura);
        }
    }
}
