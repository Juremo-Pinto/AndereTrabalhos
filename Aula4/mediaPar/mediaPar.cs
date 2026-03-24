using System;
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
            falar("Defina a quantidade de numeros da sequencia.");
            int quant = ouvirP();
            
        }
    }
}