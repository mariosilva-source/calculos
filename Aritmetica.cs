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
    class Aritmetica
    {
        /// <summary>
        /// Operação Somar
        /// </summary>
        /// <returns>Retorna a soma de 2 números</returns>
        public int Somar(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Operação Subtrair
        /// </summary>
        /// <returns>Retorna a subtração de 2 números</returns>
        public int Subtrair(int x, int y)
        {
            return x - y;
        }
        /// <summary>
        /// Operação Multiplicar
        /// </summary>
        /// <returns>Retorna a multiplicação de 2 números</returns>
        public int Multiplicar(int x, int y)
        {
            return x * y;
        }
        /// <summary>
        /// Operação Dividir
        /// </summary>
        /// <returns>Retorna a divisão de 2 números</returns>
        public int Dividir(int x, int y)
        {
            if (y != 0)
            {
                return x - y;
            }
            else
            {
                return 0;
            }

        }
    }
}
