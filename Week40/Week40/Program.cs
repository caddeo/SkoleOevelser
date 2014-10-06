using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week40
{
    class Program
    {
        static void Main(string[] args)
        {



        }

        public void run()
        {
            int intAnswer = 0;
            do
            {
                Console.WriteLine(" - MENU SYSTEM -              ");
                Console.WriteLine("     1: do this               ");
                Console.WriteLine("     2: do that               ");
                Console.WriteLine("     -   etc  -               ");
                Console.WriteLine( "    0: exit                  ");
                Console.WriteLine("Enter the value of your choice");
                intAnswer = int.Parse(Console.ReadLine());

            } while (intAnswer != 0);
        }
    }
}
