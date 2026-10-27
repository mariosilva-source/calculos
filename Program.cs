using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos\n");
            Console.WriteLine("4 + 2 = " + Aritmetica.Somar(4, 2));
            Console.WriteLine("4 - 2 = " + Aritmetica.Subtrair(4, 2));
            Console.WriteLine("4 * 2 = " + Aritmetica.Multiplicar(4, 2));
            Console.WriteLine("4 / 3 = " + Aritmetica.Dividir(4, 3));
            Console.WriteLine("4 ^ 3 = " + Aritmetica.Potencia(4, 3));

            double t1 = Conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.CelsiusFahrenheit, 10);
            double t2 = Conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.FahrenheitCelsius, 72);

            Console.WriteLine("\n10º Celsius = " + t1 + "º Farenheit");
            Console.WriteLine("72º Farenheit = " + t2 + "º Celsius");

            double m1 = Conversoes.ConverterDistancia(Conversoes.ConversaoDistancia.MetrosMilhas, 5000);
            double m2 = Conversoes.ConverterDistancia(Conversoes.ConversaoDistancia.MilhasMetros, 5);

            Console.WriteLine("\n5000 metros = " + m1 + " milhas");
            Console.WriteLine("5 milhas = " + m2 + " metros");


            Console.ReadKey();
        }
    }
}
