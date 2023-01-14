using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao4.Entities
{
    internal class IsPerfectNum
    {
        public static void Perfect(long num)
        {
            long soma = 0;

            for (long i = num; i > 0; i--)
            {
                if (num % i == 0 &&
                    i != num) soma += i;
            }

            Console.WriteLine("______________________________");
            if (soma == num)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{num} é um número perfeito!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{num} não é um número perfeito!");
                Console.ResetColor();
            }
        }
    }
}
