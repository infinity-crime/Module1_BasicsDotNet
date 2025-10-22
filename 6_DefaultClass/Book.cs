using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DefaultClass
{
    public class Book
    {
        private string _title;
        private string _author;
        private int _year;

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public int Year
        {
            get => _year;
            set => _year = value;
        }

        public Book(string title, string author, int year)
        {
            _title = title;
            _author = author;
            _year = year;
        }
    }
}
