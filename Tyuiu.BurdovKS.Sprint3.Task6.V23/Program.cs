



using Tyuiu.BurdovKS.Sprint3.Task6.V23.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        int startValue = 18;

        int stopValue = 28;



        Console.Title = "Спринт #3 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Вложенные циклы                                                   *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                     *");
        Console.WriteLine("* принадлежащих числовому отрезку [18, 28]                                *");
        Console.WriteLine("* количество всех делителей меньше 11                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");




        Console.WriteLine("Начало: " + startValue);
        Console.WriteLine("Конец: " + stopValue);

        

        Console.WriteLine("РЕЗУЛЬТАТ: ");

        Console.WriteLine(ds.GetSumTheDivisors(startValue, stopValue));

        Console.ReadKey();
    }
}