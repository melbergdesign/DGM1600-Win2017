using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        //method = function
        //to run press Ctrl+F5

        // var data type tells complier to figure out what date type the variable is 
        // var types are called implicitly typed variables. Must be assigned when initialized

        //constant (const) data types cannot be changed after initial assignment
        const int example = 3;
        static void Main(string[] args)
        {
            /* int x = 10;
             double y = 20;
             //Console.WriteLine moves console cursor to next line while Console.Write does not
             //output x = 10, y=20
             Console.WriteLine("x={0}, y={1}", x, y);*/

            //Use Console.Readline method to assign a string from the console window
            /*string yourName;
            Console.WriteLine("What's your name?");
            yourName = Console.ReadLine();

            Console.WriteLine("Hello {0}", yourName);*/

            //Converting data types
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old.", age);

            //arithmetic operators
            //% returns the remainder of the first number divided by second
            //use parentheses to show PEDMAS in code

            //Assignment and increment operators
            int x = 42;
            x += 2;// x becomes the value of x plus 2
            x -= 6;//x becomes the value of x minus 6
            // applies to all math operators

            //increment by one ++
            x++; //postfix; evaluates expression then increments
            ++x; //prefix; increments then evaluates expression

            //decrement by one --


        }
    }
}
