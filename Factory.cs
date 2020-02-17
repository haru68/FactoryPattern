using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Factory
    {

        public static President CreatePresident(string character)
        {
            if (character == "vénal")
            {
                President president = new PresidentLREM();
                Console.WriteLine(president.slogan);
                return president;
            }
            else if (character == "indécis")
            {
                President president = new PresidentCentre();
                Console.WriteLine(president.slogan);
                return president;
            }
            else if (character == "fou")
            {
                President president = new PresidentExtremeGauche();
                Console.WriteLine(president.slogan);
                return president;
            }
            else if (character == "végétarien")
            {
                President president = new PresidentEcolo();
                Console.WriteLine(president.slogan);
                return president;
            }
            else if (character == "profiteur")
            {
                President president = new PresidentGauche();
                Console.WriteLine(president.slogan);
                return president;
            }
            else if (character == "psychopathe")
            {
                President president = new PresidentDroite();
                Console.WriteLine(president.slogan);
                return president;
            }
            else if (character == "xénophobe")
            {
                President president = new PresidentExtremeDroite();
                Console.WriteLine(president.slogan);
                return president;
            }
            else
            {
                throw new ArgumentException("Wrong input");
            }

        }
    }
}
