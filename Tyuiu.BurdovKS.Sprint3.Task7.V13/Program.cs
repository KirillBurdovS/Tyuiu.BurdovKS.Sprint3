

using Tyuiu.BurdovKS.Sprint3.Task7.V13.Lib;


class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

       

        Console.Title = "Спринт #3 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Вложенные циклы                                                   *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
        Console.WriteLine("*  F(x) = 3х + 2 - (2х - х)/(cos(x) + 1) (произвести табулирование)       *");
        Console.WriteLine("* f(x) на заданном диапазоне[-5; 5] с шагом 1.                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");



        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Старт = " + startValue);
        Console.WriteLine("Конец = " + stopValue);

        int len = ds.GetMassFunction(startValue, stopValue).Length;

        double[] valueArray;
        valueArray = new double[len];

        valueArray = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("|{0,5:d}    |  {1, 5:f2}  |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+----------+----------+");
        Console.ReadKey();


        Console.ReadKey();
    }
}