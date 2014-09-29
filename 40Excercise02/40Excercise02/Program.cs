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


            /* int k = 0;
               int i = 0;
             while (k < 4)
             {
                 k++;
                 int i = 5;

             }
               Console.WriteLine(i);
             */

            /*Soccer odense = new Soccer();
            odense.HomeField = "OB";
            odense.goalscore = new List<GoalScore>();

            GoalScore first = new GoalScore();
            first.Name = "Benny";
            odense.goalscore.Add(first);

            Console.WriteLine(odense.goalscore[0].Name);

            Console.WriteLine("Hit enter-key to stop the program.");
            Console.ReadKey();*/

            List<BankAccountClass> bac = new List<BankAccountClass>();

            BankAccountClass bac1 = new BankAccountClass();

            bac1.accountNumber = bac.Count + 1;
            bac1.dateOpened = "29-09-2014";
            bac1.accountType = "Løn konto";

            Console.WriteLine(bac1.GetBalance());

            bac1.Deposit(10);
            bac1.Deposit(100);
            bac1.Deposit(230);

            Console.WriteLine(bac1.GetBalance());

            bac1.Withdraw(50);
            bac1.Withdraw(100);

            Console.WriteLine(bac1.GetBalance());

           for (int i = 0; i < bac1.posteringer.Count; i++)
            {
                Console.WriteLine(bac1.posteringer[i].Beskrivelse+" "+bac1.posteringer[i].Beløb+" kr.");
            }

            Console.WriteLine(bac1.GetBalance());

            Console.ReadKey();
            
           /* Console.Write("Enter height: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            double b1 = double.Parse(Console.ReadLine());

            Square sq = new Square();
            sq.Height = a1;
            sq.Width = b1;

            Console.WriteLine("Area: " + sq.Area());
            Console.WriteLine("Circumference: " + sq.Circumference());

            Console.WriteLine("Hit enter-key to stop the program.");
            Console.ReadKey();

            Console.Write("Enter height: ");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            double b2 = double.Parse(Console.ReadLine());

            RightTriangle rt = new RightTriangle();
            rt.Height = a2;
            rt.Width = b2;
            Console.WriteLine("Area: " + rt.Area());
            Console.WriteLine("Circumference: " + rt.Circumference());

            Console.WriteLine("Hit key to stop program.");
            Console.ReadKey();*/

        }
    }
}
