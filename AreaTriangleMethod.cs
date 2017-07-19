using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a = 7;
            double b = 5;
            double c = 8.6023252670426267;

            Console.WriteLine(TextWrite(GetAreaTriangle(a, b, c)));
            Console.ReadKey();
        }

        /// <summary>
        /// Метод, вычисляющий площадь прямоугольного треугольника.
        /// </summary>
        /// <param name="a">катет а</param>
        /// <param name="b">катет b</param>
        /// <param name="c">гипотенуза</param>
        /// <returns>
        /// Площадь прямоугольного теугольника.
        /// </returns>
        public static double GetAreaTriangle(double a, double b, double c)
        {
            bool isTrueHypotenuse = c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            if (!isTrueHypotenuse)
                return -1;
            if (a <= 0)
                return -2;
            if (b <= 0)
                return -3;

            double S = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            return S;
        }

        private static string TextWrite(double area)
        {
            string retText = String.Empty;
            if (area == -1)
            {
                retText = "Неверно задана гипотенуза";
            }
            else if (area == -2)
            {
                retText = "Катет a, не должен быть отридцательным!";
            }
            else if (area == -3)
            {
                retText = "Катет b, не должен быть отридцательным!";
            }

            retText = "площадь прямоугольного треуголька = " + area;

            return retText;
        }
    }
}