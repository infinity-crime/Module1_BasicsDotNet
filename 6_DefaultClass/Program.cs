namespace _6_DefaultClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // проверка класса Book
            var book = new Book("Techcore Development", "Kirill", 2025);

            Console.WriteLine($"Назавние: {book.Title}");
            Console.WriteLine($"Автор: {book.Author}");
            Console.WriteLine($"Год: {book.Year}");
        }
    }
}
