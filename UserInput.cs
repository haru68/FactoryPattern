using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class UserInput
    {
        public static bool CheckUserInput(string input)
        {
            if (input == "vénal" || input == "indécis" || input == "fou" || input == "végétarien" || input == "profiteur" || input == "psychopathe" || input == "xénophobe")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
