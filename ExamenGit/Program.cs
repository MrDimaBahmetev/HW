using System;

namespace ExamenGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Menu();
                    if (Convert.ToInt16(UserChoice()) == 1)
                    {
                        ShowGap(FindGap(EnterPoint(), EnterPoint()));
                    }
                    else
                        break;
                }
                catch (Exception e)
                {
                    if (e.Message == "Input string was not in a correct format.")
                        break;
                }

            } while (true);
            Console.ReadKey();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1. Вычислить промежуток");
            Console.WriteLine("Клавиша. Выход");
            Console.Write("Введите: ");
        }
        static string UserChoice()
        {
            return Console.ReadLine();
        }
        static void ShowEnterPoint()
        {
            Console.Write("Введите точку: ");
        }

        static decimal EnterPoint()
        {
            ShowEnterPoint();
            return Convert.ToDecimal(Console.ReadLine());
        }
        static void ShowGap(decimal gap)
        {
            Console.WriteLine("Промежуток: "+gap);
            Console.ReadKey();
        }
        static decimal FindGap(decimal pointA, decimal pointB)
        {
            if(pointA < pointB)
            {
                return pointB - pointA;
            }
            else
            {
                return pointA - pointB;
            }
        }
    }
    public class Geometry
    {
        public static decimal TraingleArea(decimal side, decimal height)
        {
            return 1 / 2 * side * height;
        }

        public static decimal SquareArea(decimal side)
        {
            return side*side;
        }
        public static decimal RectungleArea(decimal sideA, decimal sideB)
        {
            return sideA * sideB;
        }

    }
}
