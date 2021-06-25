using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_cafe_com_leite
{
    class DinheiroGastoFumante:Program
    {
        public static void Executar() {
            int anos;
            int cigarros;
            int PrecoMacoCigarro;
            int dia;
            decimal resultado;

            Console.WriteLine("A quantos anos você fuma? ");
            anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos cigarros você fuma por dia? ");
            cigarros = int.Parse(Console.ReadLine());

            Console.WriteLine("Quanto você paga em cada maço de cigarro? ");
            PrecoMacoCigarro = int.Parse(Console.ReadLine());

            dia = anos*365;
            resultado = (dia * cigarros) * PrecoMacoCigarro;

            MudaParaVerde();
            Console.WriteLine("Você já gastou R$ {0} em cigarros durante a sua vida",resultado);
            VoltaCorNormal();
        }
    }
}
