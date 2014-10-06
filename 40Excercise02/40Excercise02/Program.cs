using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.run();
        }

        public void run()
        {
            List<RightTriangle> trianglelist = new List<RightTriangle>();
            List<Square> squarelist = new List<Square>();

            int intAnswer = 0;
            do
            {
                Console.WriteLine(" - MENU SYSTEM -                                     ");
                Console.WriteLine("     1: Add a triangle to the list                   ");
                Console.WriteLine("     2: Add a square to the list                     ");
                Console.WriteLine("     3: Print all triangles                          ");
                Console.WriteLine("     4: Print all squares                            ");
                Console.WriteLine("     5: Delete the last added triangle               ");
                Console.WriteLine("     6: Delete the last added square                 ");
                Console.WriteLine("     7: Print the triangle with the largest height   ");
                Console.WriteLine("     8: Print the average width of all squares       ");
                Console.WriteLine("     0: exit                                         ");
                Console.WriteLine("Enter the value of your choice                       ");
                intAnswer = int.Parse(Console.ReadLine());

                if (intAnswer == 1)
                {
                    Console.WriteLine("Input the height of the triangle");
                    // output en string, og så parse til double fra int eller string
                    double h = double.Parse(Console.ReadLine());

                    Console.WriteLine("Input the width of the triangle");
                    // output en string, og så parse til double fra int eller string
                    double w = double.Parse(Console.ReadLine());

                    RightTriangle rt = new RightTriangle(h, w);
                    trianglelist.Add(rt);

                    Console.WriteLine("Triangle with the properties h: "+trianglelist[trianglelist.Count-1].Height+
                        " and w: "+
                        trianglelist[trianglelist.Count-1].Width+" added to the list");
                } 
                else if(intAnswer == 2) 
                {

                } 
                else if(intAnswer == 3)
                {
                    Console.WriteLine("Triangles that contains in the list: ");

                    if (trianglelist.Count > 0)
                    {
                        foreach (RightTriangle rt in trianglelist)
                        {
                            Console.WriteLine("Triangle with the properties h: " + rt.Height + " w: " + rt.Width +
                                "\nArea: " + rt.Area() + "\nCircumference: " + rt.Circumference() + "\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The list is empty");
                    }

                } 
                else if(intAnswer == 4) 
                {

                }
                else if (intAnswer == 5)
                {
                    if(trianglelist.Count > 0) {
                    RightTriangle rt = trianglelist[trianglelist.Count-1];
                    Console.WriteLine("Removing last added triangle with the properties h: "+rt.Height+" w: "+rt.Width);
                    trianglelist.Remove(rt);
                    }
                    else
                    {
                        Console.WriteLine("There's no triangles in the list to delete");
                    }

                }
                else if (intAnswer == 6)
                {

                }
                else if (intAnswer == 7)
                {

                    RightTriangle rt = new RightTriangle();

                    if (trianglelist.Count > 0)
                    {
                        for (int i = 0; i < trianglelist.Count; i++)
                        {
                            if (trianglelist[i].Height >= rt.Height)
                            {
                                rt = trianglelist[i];
                            }
                        }

                        Console.WriteLine(rt.Height);
                    }
                    else
                    {

                    }
                }
                else if (intAnswer == 8)
                {

                }
                else
                {

                }

            } while (intAnswer != 0);
        }
    }
}
