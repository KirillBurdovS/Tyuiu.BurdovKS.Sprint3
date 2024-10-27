


using Tyuiu.BurdovKS.Sprint3.Task5.V1.Lib;


class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        int x = 5;

        int startValue1 = 1;

        int startValue2 = 1;

        int stopValue1 = 3;

        int stopValue2 = 10;


        Console.Title = "Спринт #3 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Вложенные циклы                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Определить сумму рядов, используя циклы, при х = 5.                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");




        Console.WriteLine("Начало 1:" + startValue1);
        Console.WriteLine("Конец 1: " + stopValue1);

        Console.WriteLine("Начало 2:" + startValue2);
        Console.WriteLine("Конец 2: " + stopValue2);


        Console.WriteLine("РЕЗУЛЬТАТ: ");

        Console.WriteLine(ds.GetSumSumSeries(x,startValue1,startValue2,stopValue1,stopValue2));

        Console.ReadKey();
    }
}
