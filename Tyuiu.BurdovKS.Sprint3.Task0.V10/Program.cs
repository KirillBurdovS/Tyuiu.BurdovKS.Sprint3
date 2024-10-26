


using Tyuiu.BurdovKS.Sprint3.Task0.V10.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        int value = 5;
        int startValue = 1;
        int stopValue = 5;




        Console.Title = "Спринт #3 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл for,                                  *");
        Console.WriteLine("* которая вычисляет произведение ряда по формуле, при x = 5               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");




        Console.WriteLine("Переменная X = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        Console.WriteLine("РЕЗУЛЬТАТ: ");

        Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));

        Console.ReadKey();
    }
}
