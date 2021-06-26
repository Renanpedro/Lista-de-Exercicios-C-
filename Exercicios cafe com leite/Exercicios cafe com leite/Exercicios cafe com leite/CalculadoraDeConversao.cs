using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_de_Exercicios
{
    class CalculadoraDeConversao
    {
        public static void MudaParaVerde() {
            Console.ForegroundColor = ConsoleColor.Green;                      
        }

        public static void VoltaCorNormal() {
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void MudaParaVermelho() {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public static void Executar()
        {
            string entrada;
            double resultado;
            double Numero;

            CalculadoraDeConversao objeto = new CalculadoraDeConversao();

            Console.WriteLine("P -> Converter de Polegadas para centímetros");
            Console.WriteLine("F -> Converter de Fahrenheit para Celsius");
            Console.WriteLine("M -> Converter de Milhas para Quilômetros");
            Console.WriteLine("R -> Converter de Reais para Dolares");

            Console.WriteLine("Escolha uma das opções acima para converter conversão:");
            entrada = Console.ReadLine();
            Console.WriteLine(" ");

           switch (entrada) {
                case "P":
                    Console.WriteLine("informe o valor de Polegadas que deseja converter para centímetros: ");
                    Numero = double.Parse(Console.ReadLine());
                    resultado = Numero * 2.54;

                    Console.WriteLine(" ");

                    MudaParaVerde();
                    Console.WriteLine($"{Numero} Polegas equivale a {resultado} centíemtros");
                    VoltaCorNormal();
                    break;


                case "F":
                    Console.WriteLine("informe o valor de ºFahrenheit que deseja converter para ºCelsius: ");
                    Numero = double.Parse(Console.ReadLine());
                    resultado = (Numero - 32) / 1.8;

                    Console.WriteLine(" ");

                    MudaParaVerde();
                    Console.WriteLine($"º{Numero} ºFahrenheit convertidos para Ceulsius são: º{resultado} Celsius");
                    VoltaCorNormal();
                    break;


                case "M":
                    Console.WriteLine("informe o valor de Milhas que deseja converter para Quilômetros: ");
                    Numero = double.Parse(Console.ReadLine());
                    resultado = Numero*1.609;

                    Console.WriteLine(" ");

                    MudaParaVerde();
                    Console.WriteLine($"{Numero} Milhas convertidos para kilômetros são: {resultado} Quilômetros");
                    VoltaCorNormal();
                    break;

                case "R":
                    Console.WriteLine("informe o valor de Reais que deseja converter para Dolares: ");
                    Numero = double.Parse(Console.ReadLine());
                    resultado = Numero/4.91;

                    Console.WriteLine(" ");

                    MudaParaVerde();
                    Console.WriteLine($"{Numero} Reais convertidos para Reais são: {resultado} Dolares");
                    VoltaCorNormal();
                    break;

                default:
                    MudaParaVermelho();
                    Console.WriteLine("Opção inválida, escolha uma opção válida");
                    VoltaCorNormal();
                    break;
            }
        }
    }
}
