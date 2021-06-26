using System;

namespace Lista_de_Exercicios
{
    class Program
    {
        string entrada;
        public static void MudaParaVerde()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static void VoltaCorNormal()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void MudaParaVermelho()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }



        static void Main(string[] args)
        {
            Program objeto = new Program();
            do
            {
                MudaParaVerde();
                Console.WriteLine("1 - Média das Notas");
                Console.WriteLine("2 - Número Par ou Impar");
                Console.WriteLine("3 - Maiores de 18 anos");
                Console.WriteLine("4 - Salario Reajuste");
                Console.WriteLine("5 - Aluno mais alto");
                Console.WriteLine("6 - Calculadora");
                Console.WriteLine("7 - Permisão de acesso");
                Console.WriteLine("8 - Calculadora De Conversão");
                Console.WriteLine("9 - Maior Menor Media e Soma");
                Console.WriteLine("10 - Dinheiro gasto com cigarro");
                Console.WriteLine("11 - Nome igual o meu");
                Console.WriteLine("12 - Soma dos Pares");
                Console.WriteLine(" ");
                VoltaCorNormal();

                int opcao;
                Console.WriteLine("Escolha um dos exercicios acima:");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                switch (opcao)
                {

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

                    case 8:
                        CalculadoraDeConversao.Executar();
                        break; 
                    
                    case 9:
                        MaiorMenorMediaSoma.Executar();
                        break;

                    case 10:
                        DinheiroGastoFumante.Executar();
                        break;

                    case 11:
                        NomeIgualOMeu.Executar();
                        break;

                    case 12:
                        SomaDosPares.Executar();
                        break;

                    default:
                        Console.WriteLine("Opção não encontrada, digite uma opção válida");
                        break;
                }
                Console.WriteLine("Deseja testar outro dos nossos programas? (S/N)");
                objeto.entrada = Console.ReadLine();

            } while (objeto.entrada.ToLower() == "s" || objeto.entrada.ToLower() == "S");

            Console.WriteLine("Obrigado por testar nossa aplicação");

        }
    }
}
