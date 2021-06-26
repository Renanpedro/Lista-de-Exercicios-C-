using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_de_Exercicios
{
    class NomeIgualOMeu:Program
    {
        public static void Executar()
        {
        string MeuNome = "RENAN";
        string NomeUsuario,NomeRecebido;

        Console.WriteLine("Favor informar o seu nome: ");
            NomeRecebido = Console.ReadLine();
            NomeUsuario = NomeRecebido.ToUpper();
            Console.WriteLine(" ");

            if (MeuNome == NomeUsuario)
            {
                MudaParaVerde();
                Console.WriteLine("NOME CORRETO - Parabéns você é digno de carregar este nome! ");
                VoltaCorNormal();
            }
            else {
                MudaParaVermelho();
                Console.WriteLine("NOME INCORRETO - Não é digno de carregar o nome dos deuses!");
                VoltaCorNormal();
            }
        }

    }
}
