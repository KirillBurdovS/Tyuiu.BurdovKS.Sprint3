


using Tyuiu.BurdovKS.Sprint3.Task3.V22.Lib;



class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        string value = "tbtbbb dsfbg bbg";
        char item = 'b';

        Console.Title = "Спринт #3 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл do...while,                           *");
        Console.WriteLine("*  которая вычисляет произведение ряда по формуле, при х=5                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");




        Console.WriteLine("Строка:" + value);
        Console.WriteLine("Символ: " + item);

        Console.WriteLine("РЕЗУЛЬТАТ: ");

        Console.WriteLine("Количество символа = " + ds.GetMaxCharCount(value, item));

        Console.ReadKey();
    }
}
