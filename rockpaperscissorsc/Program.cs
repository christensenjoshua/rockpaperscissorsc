using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissorsc
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("The Rock Paper Scissors Game!");
            bool playing = true;
            string[] choices = new string[] { "R", "P", "S" };
            string[] wins = new string[] { "S", "R", "P" };
            while (playing)
            {
                Console.WriteLine("Choose (R)ock, (P)aper, or (S)cissors: ");
                string userChoice = Console.ReadLine();
                userChoice = userChoice.ToUpper();
                if(userChoice.Equals("R") || userChoice.Equals("P") || userChoice.Equals("S"))
                {
                    // Answer is ok!
                }
                else
                {
                    Console.WriteLine("Invalid selection, try again");
                    continue;
                }
                int compNum = rnd.Next(1, 3);
                string compChoice = choices[compNum];
                if (compChoice.Equals(userChoice))
                {
                    Console.WriteLine("Result: Draw");
                }
                else
                {
                    //Determine who won.
                    int winIndex = Array.IndexOf(choices,userChoice);
                    string winner = wins[winIndex];
                    if (compChoice.Equals(winner))
                    {
                        Console.WriteLine("Win! You chose " + userChoice + " and computer " + compChoice);
                    }
                    else
                    {
                        Console.WriteLine("Lose! You chose " + userChoice + " and computer " + compChoice);
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
