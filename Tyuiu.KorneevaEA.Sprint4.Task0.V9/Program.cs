using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KorneevaEA.Sprint4.Task0.V9.Lib;

namespace Tyuiu.KorneevaEA.Sprint4.Task0.V9
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            int x = 0;

            Console.Title = "Спринт #4 | Выполнила: Корнеева Е.А. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы.(статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #9                                                             *");
            Console.WriteLine("* Выполнила: Корнеева Елизавета Андреевна | АСОиУб-23-3                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму          *");
            Console.WriteLine("* четных элементов массива.                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };

            Console.WriteLine(" Исходный массив: ");
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма четных элементов массива: ");

            x = ds.GetMultEvenArrEl(array);

            Console.WriteLine(x);

            Console.ReadKey();

        }
    }
}
