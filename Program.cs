using System;
using dotnet__poo.src.Entities;

namespace dotnet___poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard_White jenica = new Wizard_White("Jenica", 40, "White Wizard");
            Ninja wedge = new Ninja("Wedge", 32, "Ninja");
            Black topapa = new Black("Topapa", 56, "Black Wizard");

            Console.WriteLine(jenica.Attack(1));
            Console.WriteLine(topapa.Attack(9));
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wedge.Attack());
        }
    }
}
