using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_de_Exercicios
{
    class ReajusteSalario
    {
        public static void Executar()
        {
            double Salario;
            double NovoSalario;

            Console.WriteLine("Informe o atual salario do funcionário");
            Salario = double.Parse(Console.ReadLine());

            if (Salario <= 300)
            {
                NovoSalario = Salario * 1.50;
            }
            else {
                NovoSalario = Salario + (Salario * 0.30);
            }

            Console.WriteLine("O novo salario do funcionário é: {0}", NovoSalario);


        }


    }
}
