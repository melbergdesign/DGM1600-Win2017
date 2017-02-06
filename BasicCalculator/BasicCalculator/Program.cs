using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("It works");
            do
            {
                Console.Write("x=");
                string str = Console.ReadLine();

                if (str == "exit")
                    break;
                
            
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("y=");
                int y = Convert.ToInt32(Console.ReadLine());

                int sum = x + y;
                Console.WriteLine("Result: {0}", sum);
            } while (true);
        }
    }
}
