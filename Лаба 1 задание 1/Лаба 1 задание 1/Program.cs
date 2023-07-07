using System;

namespace Лаба_1_задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x = 0, y = 0, h, R;
            int a, b, E = 0; //Задание переменных
            Console.Write("Введите начало отрезка a=");
            a = Convert.ToInt16(Console.ReadLine()); //Присваивание значения переменной "a" (начало отрезка)
            Console.Write("Введите конец отрезка b=");
            b = Convert.ToInt16(Console.ReadLine()); //Присваивание значения переменной "b" (конец отрезка)
            Console.Write("Введите длинну шага h=");
            h = Convert.ToDouble(Console.ReadLine()); //Присваивание значения переменной "h" (длинна шага)
            Console.Write("Введите радиус полуокружности R=");
            R = Convert.ToDouble(Console.ReadLine()); //Присваивание значения переменной "R" (радиус полуокружности)
            for (x = a; x <= b; x += h) //Начало цикла 
            {
                E = 0;
                if (x >= -8 - R & x < -8 + R) y = Math.Sqrt(R * R - ((x + 8) * (x + 8))) -2; //Функция полукруга
                else
                {
                    E += 1;
                    if (x >= -6 & x <= 2) y = (x + 2) / 2; //Функция прямой
                    else E += 1;
                    if (x >= 6 & x <= 8) y = Math.Pow(x - 6, 2); //Функция ветки параболы
                    else E += 1;
                }
            if (E == 3) Console.WriteLine($"Функция не существует при х={x}");
            else
                Console.WriteLine($"x={x} {"\t"} y={y}"); //Вывод значений
            }
            Console.ReadKey();
        }
    }
}
