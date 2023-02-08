using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace study
{
    public class MathParser
    {
        /// <summary>
        /// Коэффициенты в уравнении
        /// </summary>
        private double[] _odds;
        
        /// <summary>
        /// Уравнение в виде формулы
        /// </summary>
        private string _formula;
        
        /// <summary>
        /// Неизвестные, которые будет заменяться на пробел
        /// </summary>
        private string[] _oddsToReplace;

        /// <summary>
        /// Замена неизвестных на пробелы
        /// </summary>
        /// <param name="piece">Правая или левая часть уравенения</param>
        /// <returns>Возвращает строку с пробелами</returns>
        private string ReplaceOdds(string piece)
        {
            // количество иксов в одной части (для дальнейшей проверки) 
            int counter = 0;

            foreach (String coeff in _oddsToReplace)
            {
                if (piece.Contains(coeff))
                {
                    counter++;
                    piece = piece.Replace(coeff, " ");
                }
            }

            return piece;
        }

        /// <summary>
        /// Получение из строки с формулой коэффициенты уравнения
        /// </summary>
        private void Parse()
        {

            // ЭТУ ХУЙНЮ НАДО НОРМАЛИЗИВАТЬ - привести к стандарному виду
            // -2,5x2+2x+1=2x2-1x+2 - тестовый пример

            string[] pieces = _formula.Split("=");

            pieces[0] = ReplaceOdds(pieces[0]);
            pieces[1] = ReplaceOdds(pieces[1]);

            string[] oddsChar = pieces[0].Split(" ").Concat(pieces[1].Split(" ")).ToArray();

            for (int i = 0; i < 6; i++)
            {
                _odds[i] = double.Parse(oddsChar[i]);
            }
        }

        /// <summary>
        /// Конструктор уравнения
        /// </summary>
        /// <param name="formula">Уравнение</param>
        public MathParser(string formula)
        {

            // TODO методы для тестирования возвращат bool
            // TODO чтобы были все коэффициенты
            // TODO сделать правильную поочередность вызова функций
            // TODO посимвольный ввод без отображения запрещенных символов
            // TODO     
            MathTestInput.TestAll(formula);


            _formula = formula;
            _odds = new double[6];
            _oddsToReplace = new string[] { "x2", "x" };

            Parse();
        }

        /// <summary>
        /// Коэффициенты уравнения
        /// </summary>
        public double[] Odds
        {
            get
            {
                return _odds;
            }
            private set
            {
                _odds = value;
            }
        }        
    }
}
