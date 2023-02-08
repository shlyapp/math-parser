using System;
using System.Text;

namespace stude
{
    class Program
    {
        static void Function()
        {

        }

        static void Main(string[] args)
        {
            string formula = Console.ReadLine();

            double A; double B;

            string[] pieces = formula.Split('=');

            // 1 piece
            // я вертел на хуе SOLID


            string p1 = pieces[0];
           
            if (p1.Contains("x2") && p1.Contains("x"))
            {
                p1 = p1.Replace("x2", " ");
                p1 = p1.Replace("x", " ");
            }
            else if(p1.Contains("x2"))
            {
                p1 = p1.Replace("x2", " ");
            }
            else if (p1.Contains("x"))
            {
                p1 = p1.Replace("x", " ");
            }
            else
            {
                A = 0; B = 0;
                Console.WriteLine("В первой части коэффициенты A и B равны нулю");
            }

            // piece 2

            // проверка
            string p2 = pieces[1];

            if (p2.Contains("x2") && p2.Contains("x"))
            {
                p2 = p2.Replace("x2", " ");
                p2 = p2.Replace("x", " ");
            }
            else if (p2.Contains("x2"))
            {
                p2 = p2.Replace("x2", " ");
            }
            else if (p2.Contains("x"))
            {
                p2 = p2.Replace("x", " ");
            }
            else
            {
                A = 0; B = 0;
                Console.WriteLine("Во второй части коэффициенты A и B равны нулю");
            }


            double[] coeff = new double[6];
            string[] p1_parse = p1.Split(" ");
            string[] p2_parse = p2.Split(" ");


            for (int i = 0; i < p1_parse.Length; i++)
            {
                coeff[i] = double.Parse(p1_parse[i]);
                coeff[3 + i] = double.Parse(p2_parse[i]);
            }


            Console.WriteLine($"{p1}, {p2}");
        }
    }
}
