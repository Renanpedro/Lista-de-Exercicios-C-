using System;

namespace Exercicios_cafe_com_leite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Média das Notas");
            Console.WriteLine("2 - Número Par ou Impar");
            Console.WriteLine("3 - Maiores de 18 anos");
            Console.WriteLine("4 - Salario Reajuste");
            Console.WriteLine("5 - Aluno mais alto");
            Console.WriteLine("6 - Calculadora");
            Console.WriteLine("7 - Permisão de acesso");
            Console.WriteLine(" ");

            int opcao;
            Console.WriteLine("Escolha um dos exercicios acima:");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            switch(opcao){

                case 1:
                    Media.Executar();
                    break;

                case 2:
                    NumeroParOuImpar.Executar();
                    break;


                case 3:
                    MaisDeDezoitoAnos.Executar();
                    break;

                case 4:
                    ReajusteSalario.Executar();
                    break;

                case 5:
                    AlunoMaisAlto.Executar();
                    break;

                case 6:
                    Calculadora.Executar();
                    break;

                case 7:
                    PermissaoDeAcesso.Executar();
                    break;

                default:
                    break;
            }

        }
    }
}
