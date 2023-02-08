using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study
{
    public class MathLogger
    {
        /// <summary>
        /// Вывод коэффициентов уравнения
        /// </summary>
        /// <param name="odds">Коэффициенты уравнения</param>
        public static void ShowOdds(double[] odds)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{i + 1} коэффициент равен {odds[i]}");
            }
        }
    }
}
