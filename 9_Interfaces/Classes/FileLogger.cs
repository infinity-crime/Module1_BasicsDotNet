using _9_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Interfaces.Classes
{
    public class FileLogger : ILoggable
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log in file: {message}");
        }
    }
}
