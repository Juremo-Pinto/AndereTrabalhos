using System;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
namespace Tabuada
{
    class Programinha
    {
        static void falar(string m) => Console.Write(m);
        static int ouvirP() => int.Parse(Console.ReadLine());
        static double ouvir2() => Convert.ToDouble(Console.ReadLine());
        static void Main()
        {
            falar("Defina a quantidade de numeros da sequencia: ");
            int quant = ouvirP();
            double soma = 0;
            int counter;


            for (counter = 0; counter < quant;)
            {
                falar("Numero par: ");
                double num = ouvir2();
                if (num % 2 == 0)
                {
                    counter++;
                    soma += num;

                }
                else
                {
                    falar("Não pode ser impar >:[\n");
                }
            }

            falar($"A média é de {soma / counter}");

        }
    }
}