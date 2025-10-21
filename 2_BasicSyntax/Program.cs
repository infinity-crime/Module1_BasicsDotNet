namespace _2_BasicSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int int_a = 100;
            double double_b = 333.333;
            string str = "Hello, Techcore!";
            bool isTrue = true;

            Console.WriteLine($"Целое число: {int_a}");
            Console.WriteLine($"Дробное число: {double_b}");
            Console.WriteLine($"Строка: {str}");
            Console.WriteLine($"Логическое значение: {isTrue}");

            Console.WriteLine("-----------Проверка if/else-------------");
            if(double_b < 0)
                Console.WriteLine("int_a < 0");
            else
                Console.WriteLine("int_a > 0");

            Console.WriteLine("\n----------Проверка switch------------");
            switch(int_a % 2)
            {
                case 0:
                    Console.WriteLine("int_a - четное число");
                    break;

                case 1:
                    Console.WriteLine("int_a - нечетное число");
                    break;
            }

            Console.WriteLine("\n-------------Цикл for---------------");
            for(int i = 1; i <= 10; ++i)
            {
                Console.WriteLine($"Итерация {i}");
            }

            Console.WriteLine("\n--------------Цикл while-------------");
            int counter = 1;
            while(int_a >= 0)
            {
                Console.WriteLine($"Итерация while (int_a = {int_a}): {counter}");
                ++counter;
                int_a -= 20;
            }
        }
    }
}
