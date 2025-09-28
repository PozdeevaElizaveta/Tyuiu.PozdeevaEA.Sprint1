using Tyuiu.PozdeevaEA.Sprint1.Task3.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет, сколько квадратов со стороной C  *");
        Console.WriteLine("* можно разместить внутри прямоугольника с размерами A x B без наложений. *");
        Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double a, b, c;

        Console.WriteLine("Введите значение стороны a прямоугольника");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение стороны b прямоугольника");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение стороны c прямоугольника");
        c = Convert.ToDouble(Console.ReadLine());
     
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(Math.Round(ds.HowManySquares(a, b, c), 3));

        Console.ReadLine();
    }
}