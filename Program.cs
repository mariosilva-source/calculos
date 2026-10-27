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
            Console.WriteLine("Aplicação Cálculos");
            Console.WriteLine("4 + 2 = " + Aritmetica.Somar(4, 2));
            Console.WriteLine("4 - 2 = " + Aritmetica.Subtrair(4, 2));
            Console.WriteLine("4 * 2 = " + Aritmetica.Multiplicar(4, 2));
            Console.WriteLine("4 / 3 = " + Aritmetica.Dividir(4, 3));

            double t1 = Conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.CelsiusFahrenheit, 10);
            double t2 = Conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.FahrenheitCelsius, 72);

            Console.WriteLine("10º Celsius = " + t1 + "º Farenheit");
            Console.WriteLine("72º Farenheit = " + t2 + "º Celsius");

            Console.ReadKey();
        }
    }
}
