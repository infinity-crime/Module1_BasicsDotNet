namespace _3_ConsoleCalculator
{
    internal class Program
    {
        static readonly char[] _validOperations = { '+', '-', '/', '*', '%' };

        static string? _input = default;

        static bool isRunning = true;

        static void Main(string[] args)
        {
            Console.WriteLine("--------Консольный калькулятор-----------");

            
            while(isRunning)
            {
                try
                {
                    PerformCalculation();

                    ContinueQuestion();
                }
                catch(DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
                }
            }
        }

        static void PerformCalculation()
        {
            Console.Write("\nВведите первое число: ");
            double num1 = GetNumber();

            Console.Write("Введите операцию (+, -, *, /, %): ");
            char operation = GetOperation();

            Console.Write("Введите второе число: ");
            double num2 = GetNumber();

            double result = Calculate(num1, num2, operation);

            Console.WriteLine($"\nРезультат: {num1} {operation} {num2} = {result}");
        }

        static void ContinueQuestion()
        {
            while(true)
            {
                Console.Write("Продолжить вычисления? (y/n): ");

                string? response = Console.ReadLine()?.ToLower();
                if(response == "y" || response == "n")
                {
                    isRunning = (response == "y");
                    return;
                }
            }
        }

        static double GetNumber()
        {
            while(true)
            {
                _input = Console.ReadLine();
                if(double.TryParse(_input, out double result))
                {
                    return result;
                }

                Console.Write("Введено некорректное число! Повторите ввод: ");
            }
        }

        static char GetOperation()
        {
            while (true)
            {
                _input = Console.ReadLine();
                if(!string.IsNullOrEmpty(_input) && _validOperations.Contains(_input[0]))
                {
                    return _input[0];
                }

                Console.Write("Ошибка! Введите одну из операций (+, -, *, /, %): ");
            }
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Ошибка: Деление на ноль невозможно!");
            }
            return a / b;
        }

        static double RemainderFromDivision(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Ошибка: остаток деления на ноль невозможно");
            }
            return a % b;
        }

        static double Calculate(double a, double b, char operation)
        {
            return operation switch
            {
                '+' => Add(a, b),
                '-' => Subtract(a, b),
                '*' => Multiply(a, b),
                '/' => Divide(a, b),
                '%' => RemainderFromDivision(a, b),
                _ => throw new InvalidOperationException($"Неизвестная операция: {operation}")
            };
        }
    }
}
