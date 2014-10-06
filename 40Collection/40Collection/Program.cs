using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Collection
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Exercise 1
            List<Person> personliste = new List<Person>()
            {
                new Person("Obama", "1961", 80.5),
                new Person("Vladimir", "1952", 73.3),
                new Person("Thorning", "1966", 76.9),
                new Person("Zlatan", "1981", 93.4),
                new Person("Hulk", "1962", 178.0),
                new Person("Batman", "1939", 92.4)
            };

            // Exercise 2

            Console.WriteLine("Fødselsdag før 1963: ");
            for (int i = 0; i < personliste.Count; i++)
            {
                if (int.Parse(personliste[i].YearOfBirth) < 1963)
                {
                    Console.WriteLine(personliste[i].Name);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Vejer mere end 90 kg.: ");
            for (int i = 0; i < personliste.Count; i++)
            {
                if (personliste[i].Weight > 90)
                {
                    Console.WriteLine(personliste[i].Name);
                }
            }
            Console.WriteLine();


            Console.WriteLine("Vejer mere end "+personliste[0].Weight+" kg.: ");
            for (int i = 1; i < personliste.Count; i++)
            {
                if (personliste[i].Weight >= personliste[0].Weight)
                {
                    Console.WriteLine(personliste[i].Name);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Navne i listen, baglæns: ");
            for (int i = personliste.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(personliste[i].Name);
            }
            Console.WriteLine();

            double avgweight = 0;

            Console.WriteLine("Gennemsnitlige vægt: ");
            for (int i = 0; i < personliste.Count; i++)
            {
                // avgweight = avgweight + personliste[i].weight;
                avgweight += personliste[i].Weight;
            }

            Console.WriteLine(avgweight / personliste.Count);
            Console.WriteLine();

            Console.WriteLine("Den 'lexikale order' er større end ordret \"Superman\"");
            for (int i = 0; i < personliste.Count; i++)
            {
                if (String.Compare("Superman", personliste[i].Name) < String.Compare(personliste[i].Name, "Superman"))
                {
                    Console.WriteLine(personliste[i].Name);
                }
            }
            Console.WriteLine();

            /*
            // Exercise 3
            while (true)
            {
                Console.WriteLine("Skriv et index, som du vil tage fra listen (0-"+(personliste.Count-1)+")");
                int input = int.Parse(Console.ReadLine());

                Console.WriteLine("\nFør remove: \n");
                foreach (Person p in personliste)
                {
                    Console.WriteLine(p.Name);
                }

                if (input >= 0 && input < personliste.Count)
                {
                    personliste.Remove(personliste[input]);
                    Console.WriteLine("Efter remove: \n");
                    foreach (Person p in personliste)
                    {
                        Console.WriteLine(p.Name);
                    }
                    break;

                }
                else
                {
                    Console.WriteLine("Index skal være indenfor 0 og " + (personliste.Count-1));
                }
            }

            Console.WriteLine();
            */

            Dictionary<string, Person> persondic = new Dictionary<string, Person>();

            foreach (Person p in personliste)
            {
                persondic.Add(p.Name.ToLower(), p);
            }

            while (true)
            {
                Console.WriteLine("Skriv navnet, på den person du vil finde: ");
                string input = Console.ReadLine().ToLower();

                Person p;
                if (persondic.ContainsKey(input))
                {
                    persondic.TryGetValue(input, out p);
                    Console.WriteLine(p.Name+", "+p.YearOfBirth+", "+p.Weight);
                    break;
                }
                else
                {
                    Console.WriteLine("Person findes ikke!!!!!!!!!!!!!!!!!!!!!!!!!!!blaze it fgt000");
                }
            }


            // Afslut program
            Console.WriteLine("Press enter to exit the program.");
            Console.ReadKey();
        }
    }
}

