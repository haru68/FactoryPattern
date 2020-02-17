using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your main personnality trait to know whoch president you should vote for.");
            Console.WriteLine("Personnality trait are :");
            Console.WriteLine("Vénal, indécis, fou, végétarien, profiteur, psychopathe, xénophobe.");
            string userInput = Console.ReadLine().ToLower();

            UserInput.CheckUserInput(userInput);
            while (UserInput.CheckUserInput(userInput) == false)
            {
                Console.WriteLine("Please, enter valid personnality trait.");
                Console.WriteLine("Vénal, indécis, fou, végétarien, profiteur, psychopathe, xénophobe.");
                userInput = Console.ReadLine().ToLower();
            }

            Factory.CreatePresident(userInput);
        }
    }
}
