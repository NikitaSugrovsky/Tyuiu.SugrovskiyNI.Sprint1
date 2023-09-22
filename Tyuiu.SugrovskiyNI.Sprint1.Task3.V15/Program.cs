using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SugrovskiyNI.Sprint1.Task3.V15.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint1.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Сугровский Н. И. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Сугровский Никита Игоревич | ИИПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
            Console.WriteLine("* выполняет указанные расчеты и печатает результат на экране              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double v1 = 80;
            double v2 = 60;
            double S = 200;
            double T = 1;

            Console.WriteLine("Введите скорость первого автомобиля:");
            v1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите скорость второго автомобиля:");
            v2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите расстояние между автомобилями");
            S = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сколько часов они уже в пути");
            T = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("За 1 час они отъехали друг от друга=" + ds.DistanceOverTime(v1, v2, S, T));

            Console.ReadLine();
        }
    }
}
