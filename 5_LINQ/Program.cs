namespace _5_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = [23, 55, 12, 2, 1, 56, 1234, 2, 4, 5, 6, 7, 8, 345, 21];

            var result = numbers.Where(x => x % 2 == 0)
                .Select(x => x * 2)
                .OrderByDescending(x => x);

            ShowList(result);
        }

        static void ShowList(IEnumerable<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item);
                Console.Write(" ");
            }
        }
    }
}
