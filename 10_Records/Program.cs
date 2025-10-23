namespace _10_Records
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

            // в данном случае сделать так: book.Author = "" - не получится. Так как по умолчанию свойства класса в виде {get; init;}, а не {get; set;}
        }
    }

    // Из-за использование син. сахара в виде record, все описание класса уместилось в одной строке, вместо 30 (подзадача 6)
    record class Book(string Title, string Author, int Year);
}
