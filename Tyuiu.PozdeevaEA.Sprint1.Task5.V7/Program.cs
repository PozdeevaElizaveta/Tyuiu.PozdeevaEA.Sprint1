using Tyuiu.PozdeevaEA.Sprint1.Task5.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
        Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток до     *");
        Console.WriteLine("* того момента (в первой половине дня), когда часовая стрелка             *");
        Console.WriteLine("* повернулась на f градусов (0<f<360, f – вещественное число).            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double f;

        Console.WriteLine("Введите значение f:");
        f = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.AngleToHoursMinutes(f);
        res = Math.Truncate(res);
        int h = Convert.ToInt32(res);
        Console.WriteLine(h);

        Console.ReadLine();
    }
}