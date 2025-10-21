using System.ComponentModel;

namespace _4_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = [23, 55, 12, 2, 1, 56, 1234, 2, 4, 5, 6, 7, 8, 345, 21];
            List<string> strings = ["Hello", "Hola", "Tech", "Core", "Techcore", "Good", "eqeji4j12409h"];

            Console.WriteLine($"Найденое максимальное число в массиве numbers: {FindMaximum(numbers)}");

            var result = GetLongStrings5(strings);
            Console.Write($"Строки длинее 5 символов из массива strings: ");
            foreach(var str in result)
            {
                Console.Write(str + ' ');
            }
        }

        static List<string> GetLongStrings5(List<string> strs)
        {
            var res = new List<string>();
            for(int i = 0; i < strs.Count; ++i)
            {
                if (strs[i].Length > 5)
                    res.Add(strs[i]);
            }

            return res;
        }

        static int FindMaximum(int[] numbers)
        {
            return FindMax(numbers, 0);
        }

        /*
        так как массив маленький, используем рекурсию (при огромных размерах -> переполнение стека)
        как минимум на 1 вызов в стеке тратится 12-16 байт => если свыше 70к чисел, то вызовет переполнение
        */
        static int FindMax(int[] numbers, int index, int currentMax = 0) 
        {
            if(index == 0)
                currentMax = numbers[0];

            if (index == numbers.Length) 
            {
                return currentMax;
            }
            else
            {
                currentMax = Math.Max(currentMax, numbers[index]);
                return FindMax(numbers, index + 1, currentMax);
            }
        }
    }
}
