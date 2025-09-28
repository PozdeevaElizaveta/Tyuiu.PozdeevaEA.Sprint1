using Tyuiu.PozdeevaEA.Sprint1.Task6.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что строка    *");
        Console.WriteLine("* составлена только из строчных русских букв.                             *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        
        Console.WriteLine("Введите текст: ");
        string text = Console.ReadLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        
        
        if (string.IsNullOrEmpty(text))
        {
            Console.WriteLine("Строка пустая!");
            return;
        }


        bool res = ds.CheckLowerCaseRusLetters(text);
        if (res)
        {
            Console.WriteLine("Строка состоит только из строчных русских букв.");
        }
        else
        {
            Console.WriteLine("Строка содержит другие символы кроме строчных русских букв.");
        }
   
        Console.ReadLine();
    }
}