using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PozdeevaEA.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            static bool Russian(char c)
            {
                return (c >= 'а' && c <= 'я') || c == 'ё';

            }

            bool Lowercase = true;

            for (int i = 0; i < value.Length; i++)
            {
                char c = value[i];
                if (!char.IsLower(c) || !Russian(c))
                {
                    Lowercase = false;
                    break;
                }
            }

            if (Lowercase)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
