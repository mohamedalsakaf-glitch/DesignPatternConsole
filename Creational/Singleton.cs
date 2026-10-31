using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Creational
{
    // Singleton Pattern ensures that a class has only one instance and provides a global point of access to it.
    internal class Singleton
    {
        public sealed class Logger
        {
            private static Logger? _instance = null;
            private static readonly object _lock = new object();

            private Logger() { }

            public static Logger Instance
            {
                get
                {
                    lock (_lock)
                    {
                        return _instance ??= new Logger();
                    }
                }
            }

            public void Log(string message) => Console.WriteLine(message);
        }
                
    }
}
