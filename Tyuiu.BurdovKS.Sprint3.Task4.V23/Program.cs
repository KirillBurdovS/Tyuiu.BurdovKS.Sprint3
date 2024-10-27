


using Tyuiu.BurdovKS.Sprint3.Task4.V23.Lib;


class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        int startValue = -5;

        int stopValue = 5;


        Console.Title = "Спринт #3 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема:  Использование операторов continue и break в циклах               *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
        Console.WriteLine("* функции y=(cos(x)/x)+3. При х = 0 прервать цикл.                        *");
        Console.WriteLine("*  Полученные значения перемножать.                                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");




        Console.WriteLine("Начало:" + startValue);
        Console.WriteLine("Конец: " + stopValue);

        Console.WriteLine("РЕЗУЛЬТАТ: ");

        Console.WriteLine(ds.Calculate(startValue,stopValue));

        Console.ReadKey();
    }
}
