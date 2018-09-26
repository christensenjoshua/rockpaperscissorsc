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
            while (playing)
            {
                Console.WriteLine("Choose (R)ock, (P)aper, or (S)cissors: ");
                string userChoice = Console.ReadLine();
                userChoice = userChoice.ToUpper();
                int compNum = rnd.Next(1, 3);
                string compChoice = choices[compNum];
                if (compChoice.Equals(userChoice))
                {
                    Console.WriteLine("Result: Draw");
                }
                else
                {
                    //Determine who won.
                    if(userChoice.Equals("R"))
                    {
                        if (compChoice.Equals("S"))
                        {
                            Console.WriteLine("Result: You won!");
                        }
                        else
                        {
                            Console.WriteLine("Result: You lost!");
                        }
                    }else if(userChoice.Equals("P"))
                    {
                        if (compChoice.Equals("R"))
                        {
                            Console.WriteLine("Result: You won!");
                        }
                        else
                        {
                            Console.WriteLine("Result: You lost!");
                        }
                    }
                    else if(userChoice.Equals("S"))
                    {
                        if (compChoice.Equals("P"))
                        {
                            Console.WriteLine("Result: You won!");
                        }
                        else
                        {
                            Console.WriteLine("Result: You lost!");
                        }
                    }
                    else
                    {
                        Console.Write("Invalid selection, try again.");
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
