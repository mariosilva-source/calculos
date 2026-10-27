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
                return ((Single)x / (Single)y);
            }
            else
            {
                return 0;
            }

        }
        /// <summary>
        /// Operação Potencia
        /// </summary>
        /// <returns>Retorna uma potencia</returns>
        public static Double Potencia(int x, int y)
        {
            return Math.Pow(x,y);
        }

    }
}
