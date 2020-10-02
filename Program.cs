using System;
using System.Diagnostics;

namespace OuchThatIsSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string v;
            try
            {
                if (args.Length > 0)
                {
                    v = (args[0]);
                }

                else
                {
                    v = "NOINPUT";
                }
                Console.WriteLine($"Hello {v}, Welcome To The World!");
                Console.WriteLine($"Your name has {v.Length} letters in it!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e}");
            }
        }
    }
}