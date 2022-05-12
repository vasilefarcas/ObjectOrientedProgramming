using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_05_2022
{
    public class Logger
    {
        public static readonly Logger Instance = new Logger();
        private Logger() { }
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
