using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleView.Commands
{
    internal abstract class AbstractCommand
    {
        protected static string ReadString(string message = "")
        {
            if (message != "")
            {
                Console.WriteLine(message);
            }

            while (true)
            {
                Console.Write("| ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Введите строку");
                }
                else
                {
                    return input;
                }
            }
        }
        protected static int ReadInt(string message = "")
        {
            bool first = true;

            while (true)
            {
                string input = ReadString(first ? message : "");
                first = false;

                try
                {
                    int result = Convert.ToInt32(input);
                    return result;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Введите число");
                }
            }
        }

        protected static void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
