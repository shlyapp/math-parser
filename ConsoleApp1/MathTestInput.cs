using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MathTestInput
    {

        public static void TestAll(string formula)
        {
            //Console.WriteLine(Xmnogo(formula));
            //Console.WriteLine(Ravno(formula));
            //CountXEqualsZero(formula);
            //NullStr(formula);

            Console.WriteLine(CorrectSymbols(formula).ToString());
        }


        static string Xmnogo(string formula)
        {
            string[] chasti = formula.Split('=');
            int schet1 = 0;
            int schet2 = 0;
            int schet3 = 0;
            int schet4 = 0;

            for (int i = 0; i < chasti[0].Length - 1; i++)
            {
                if (chasti[0][i] == 'x') schet1++;
                if (chasti[0][i] == 'x' && chasti[0][i + 1] == '2') schet2++;
            }
            for (int i = 0; i < chasti[1].Length - 1; i++)
            {
                if (chasti[1][i] == 'x') schet3++;
                if (chasti[1][i] == 'x' && chasti[1][i + 1] == '2') schet4++;
            }

            if (schet1 > 1  || schet2 > 1 || schet3 > 1 || schet4 > 1)
            {
                return "Переменных в одной из частей слишком много.";
            }
            else return "Всё нормально.";
        }

            static string Ravno(string formula)
        {
            int schet = 0;

            for (int i = 0; i < formula.Length; i++)
            {
                if (formula[i] == '=') schet++;
            }

            if (schet == 0)
            {
                return "Миша, всё фигня, давай по новой! Равно нет.";
            }
            else if (schet == 1)
            {
                return "Всё нормально.";
            }
            else
            {
                return "Миша, всё фигня, давай по новой! Равно слишком много.";
            }
        }
        static void CountXEqualsZero(string inputString)
        {
            int countOfX = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == 'x')
                    countOfX++;
            }

            if (countOfX == 0) { Console.WriteLine("Неккоректно задано уравнение! Нет переменной x!"); }
        }

        static void NullStr(string inputString)
        {
            if (string.IsNullOrEmpty(inputString)) Console.WriteLine("Вы ввели пустую строку");
        }

        public static bool CorrectSymbols(string str)
        {
            char[] symbols = new char[] {'0', '1', '2', '3', '4', '5', '6', '7',
                                        '8', '9', 'x', 'X', '=', '+', '-'};
            bool result = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (!symbols.Contains(str[i]))
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
