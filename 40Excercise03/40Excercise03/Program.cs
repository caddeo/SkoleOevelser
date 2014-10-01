using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Excercise03
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int[] tid = {8, 12, 16};*/
            for (int i = 8; i <= 16; i++ )
            {
                /*if (tid.Contains(i))
                { */
                    if (i == 8 /*tid[0]*/ )
                    {
                        Console.WriteLine("8 - Start of the day");
                    }
                    else if (i == 12 /*tid[1]*/)
                    {
                        Console.WriteLine("Lunch Break");
                    }
                    else if(i == 16)
                    {
                        Console.WriteLine("16\nGoing home at 16");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                /*}
                else
                {
                    Console.WriteLine(i);
                }*/


            }

            Console.ReadKey();

        }
    }
}
