using System;
using Jogo_de_RPG_usando_OO.src.Entities;

namespace Jogo_de_RPG_usando_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42, "Knight");
            WhiteWizard whitewizard = new WhiteWizard("Jenica", 42, "White Wizard");
            Ninja ninja = new Ninja("Wedge", 42, "Ataque");
            BlackWizard blackwizard = new BlackWizard("Topapa", 42, "Black Wizard");

            Console.WriteLine(blackwizard.Attack(1));
            Console.WriteLine(blackwizard.Attack(7));
        }
    }
}
