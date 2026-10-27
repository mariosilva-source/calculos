using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações aritméticas
    /// </summary>
    static class Aritmetica
    {
        /// <summary>
        /// Tipos de conversão de temperatura a executar
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }
        /// <summary>
        /// Operação Somar
        /// </summary>
        /// <returns>Retorna a soma de 2 números</returns>
        public static int Somar(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Operação Subtrair
        /// </summary>
        /// <returns>Retorna a subtração de 2 números</returns>
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }
        /// <summary>
        /// Operação Multiplicar
        /// </summary>
        /// <returns>Retorna a multiplicação de 2 números</returns>
        public static int Multiplicar(int x, int y)
        {
            return x * y;
        }
        /// <summary>
        /// Operação Dividir
        /// </summary>
        /// <returns>Retorna a divisão de 2 números</returns>
        public static Single Dividir(int x, int y)
        {
            if (y != 0)
            {
                return (Single)(x / y);
            }
            else
            {
                return 0;
            }

        }
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.8);
            }
            return -1;
        }
    }
}
