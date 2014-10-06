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
                Console.WriteLine("     -        MENU SYSTEM        -                   ");
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
                    double h = double.Parse(Console.ReadLine());

                    Console.WriteLine("Input the width of the triangle");
                    double w = double.Parse(Console.ReadLine());

                    trianglelist.Add(new RightTriangle(h,w));

                    Console.WriteLine("Triangle with the properties h: "+trianglelist[trianglelist.Count-1].Height+
                        " and w: "+
                        trianglelist[trianglelist.Count-1].Width+" added to the list");

                    Console.WriteLine("\nTryk en vilkårlig knap for at fortsætte");
                    Console.ReadKey();
                } 
                else if(intAnswer == 2) 
                {
                    Console.WriteLine("Input the height of the square");
                    double h = double.Parse(Console.ReadLine());

                    Console.WriteLine("Input the width of the square");
                    double w = double.Parse(Console.ReadLine());

                    squarelist.Add(new Square(h,w));

                    Console.WriteLine("\nTryk en vilkårlig knap for at fortsætte");
                    Console.ReadKey();
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

                        Console.WriteLine();

                        Console.WriteLine("\nTryk en vilkårlig knap for at fortsætte");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("The list is empty");

                        Console.WriteLine("\nTryk en vilkårlig knap for at fortsætte");
                        Console.ReadKey();
                    }

                } 
                else if(intAnswer == 4) 
                {
                    if (squarelist.Count > 0)
                    {
                        foreach (Square s in squarelist)
                        {
                            Console.WriteLine("Square with the properties h: " + s.Height + " w: " + s.Width +
                                "\nArea: " + s.Area() + "\nCircumference: " + s.Circumference() + "\n");
                        }

                        Console.WriteLine("\nTryk en vilkårlig knap for at fortsætte");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("The list is empty");

                        Console.WriteLine("\nTryk en vilkårlig knap for at fortsætte");
                        Console.ReadKey();
                    }
                }
                else if (intAnswer == 5)
                {
                    if (trianglelist.Count > 0)
                    {
                        RightTriangle rt = trianglelist[trianglelist.Count - 1];
                        Console.WriteLine("Removing last added triangle with the properties h: " + rt.Height + " w: " + rt.Width);
                        trianglelist.Remove(rt);

                        Console.WriteLine("\nTryk en vilkårlig knap for at fortsætte");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("There's no triangles in the list to delete");
                        Console.WriteLine("\nTryk en vilkårlig knap for at fortsætte");
                        Console.ReadKey();
                    }

                }
                else if (intAnswer == 6)
                {
                    if (squarelist.Count > 0)
                    {
                        Square s = squarelist[squarelist.Count - 1];
                        Console.WriteLine("Removing last added triangle with the properties h: " + s.Height + " w: " + s.Width);
                        squarelist.Remove(s);

                        Console.WriteLine("\nTryk en vilkårlig knap for at fortsætte");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("There's no squares in the list to delete");

                        Console.WriteLine("\nTryk en vilkårlig knap for at fortsætte");
                        Console.ReadKey();
                    }
                }
                else if (intAnswer == 7)
                {

                    RightTriangle rt = new RightTriangle();

                    if (trianglelist.Count > 1)
                    {
                        for (int i = 0; i < trianglelist.Count; i++)
                        {
                            if (trianglelist[i].Height >= rt.Height)
                            {
                                rt = trianglelist[i];
                            }
                        }

                        Console.WriteLine(rt.Height);

                        Console.WriteLine("\nTryk en vilkårlig knap for at fortsætte");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("There is not enough triangles, in the list, to compare with (There's only "+trianglelist.Count+" triangles. You need at least 2)");
                        
                        Console.WriteLine("\nTryk en vilkårlig knap for at fortsætte");
                        Console.ReadKey();
                    }
                }
                else if (intAnswer == 8)
                {
                    if (squarelist.Count > 1)
                    {
                        double avgwidth = 0;

                        foreach (Square s in squarelist)
                        {
                            s.Width += avgwidth;
                        }
                        Console.WriteLine(avgwidth / squarelist.Count);

                        Console.WriteLine("\nTryk en vilkårlig knap for at fortsætte");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Noget enough squares in, in the list, to compare with (There's only "+squarelist.Count+ " squares. You need at least 2)");
                    
                        Console.WriteLine("\nTryk en vilkårlig knap for at fortsætte");
                        Console.ReadKey();
                    }
                }
                else
                {

                }

            } while (intAnswer != 0);
        }
    }
}
