using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers, second is optional");
            OptionalParams optionalP = new OptionalParams();
            int x = Int32.Parse(Console.ReadLine());
            int y;
            try {
                y = Int32.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                y = 0;
            }
            
            if(y == 0)
            {
                Console.WriteLine(optionalP.DoMath(x));
            }
            else
            {
               Console.WriteLine( optionalP.DoMath(x, y));
            }
            Console.ReadLine();
        }
    }
}
