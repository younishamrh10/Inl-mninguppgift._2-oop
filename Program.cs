using System;

namespace Inlämninguppgift._2_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            namn p = new namn();
            Console.WriteLine("Förnamn?");
            p.Förnamn = Console.ReadLine();
            Console.WriteLine("Efternamn");
            p.Efternamn = Console.ReadLine();
            Console.WriteLine("");
            p.Namn(); 
        }
    }
}