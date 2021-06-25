using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_cafe_com_leite
{
    class Calculadora
    {
        public static void Executar()
        {
            int numero1;
            int numero2;
            int resultado;
            int operacao;
            string entrada;

            do
            {


                Console.WriteLine("Escolha uma das opçãoes abaixo: ");
                Console.WriteLine("1 - Adição ");
                Console.WriteLine("2 - Subtração ");
                Console.WriteLine("3 - Multiplicação ");
                Console.WriteLine("4 - Divisão ");
                Console.WriteLine(" ");
                operacao = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        Console.WriteLine("ADIÇÃO");
                        Console.WriteLine("Digite o Primeiro Numero: ");
                        numero1 = int.Parse(Console.ReadLine());

                        Console.WriteLine(" ");

                        Console.WriteLine("Digite o Segundo Numero: ");
                        numero2 = int.Parse(Console.ReadLine());

                        resultado = numero1 + numero2;

                        Console.WriteLine("A soma do numero {0} + {1} tem como resultado: {2}", numero1, numero2, resultado);
                        break;

                    case 2:
                        Console.WriteLine("SUBTRAÇÃO");
                        Console.WriteLine("Digite o Primeiro Numero: ");
                        numero1 = int.Parse(Console.ReadLine());

                        Console.WriteLine(" ");

                        Console.WriteLine("Digite o Segundo Numero: ");
                        numero2 = int.Parse(Console.ReadLine());

                        resultado = numero1 - numero2;

                        Console.WriteLine("A Subtração do numero {0} - {1} tem como resultado: {2}", numero1, numero2, resultado);
                        break;

                    case 3:
                        Console.WriteLine("MULTIPLICAÇÃO");
                        Console.WriteLine("Digite o Primeiro Numero: ");
                        numero1 = int.Parse(Console.ReadLine());

                        Console.WriteLine(" ");

                        Console.WriteLine("Digite o Segundo Numero: ");
                        numero2 = int.Parse(Console.ReadLine());

                        resultado = numero1 * numero2;

                        Console.WriteLine("A Multiplicação do numero {0} * {1} tem como resultado: {2}", numero1, numero2, resultado);
                        break;

                    case 4:
                        Console.WriteLine("DIVISÃO");

                        Console.WriteLine("Digite o Primeiro Numero: ");
                        numero1 = int.Parse(Console.ReadLine());

                        if (numero1 <= 0)
                        {
                            
                            do
                            {
                                Console.WriteLine("Não é possível dividir por 0 ou numero negativos");
                                Console.WriteLine(" ");
                                Console.WriteLine("Digite outro número novamente");
                                numero1 = int.Parse(Console.ReadLine());

                            } while (numero1 <= 0);
                            {

                            }

                        }

                        Console.WriteLine("Digite o Segundo Numero: ");
                        numero2 = int.Parse(Console.ReadLine());

                        if (numero2 <= 0)
                        {

                            do
                            {
                                Console.WriteLine("Não é possível dividir por 0 ou numero negativos");
                                Console.WriteLine(" ");
                                Console.WriteLine("Digite outro número novamente");
                                numero1 = int.Parse(Console.ReadLine());

                            } while (numero2 <= 0);
                            {

                            }

                        }
                        resultado = numero1 / numero2;


                        Console.WriteLine("A Divisão do numero {0} / {1} tem como resultado: {2}", numero1, numero2, resultado);
                        break;

                    default:
                        Console.WriteLine("Está opção não existe, favor escolher uma válida.");
                        break;
                }
                Console.WriteLine("Deseja realizar outra operação? (S/N)");
                entrada = Console.ReadLine();

            } while (entrada.ToLower() == "s" || entrada.ToLower() == "S");

            Console.WriteLine("Obrigado por testar nossa aplicação");






        }

    }
}

