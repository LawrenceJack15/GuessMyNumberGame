using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberLieberry
{
    public class HumanPlays
    {
        public void UserPlays()
        {
            Restart:
            try
            {
                Random rnd = new Random();
                int x = rnd.Next(1, 1000);
                List<int> Numbers = Enumerable.Range(1, 1000).ToList();
                //Console.WriteLine($"The randomly generated number is {x}");

                Console.WriteLine("Let's play a game where you guess the number that the computor picks from 1 - 1000!!!");
                Console.WriteLine("You only have 10 guess!!!!!!!!!");
                Console.WriteLine("Please guess a whole number from 1 - 1000:");
                int UserNum = Convert.ToInt32(Console.ReadLine());
                BisectionSearch(UserNum, Numbers, x);
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter a whole number from 1 -1000!!!!!!!");
                goto Restart;
            }
        }
        public void BisectionSearch(int UserNum, List<int> Numbers, int x)
        {
            try
            {
                int mid = (Numbers.First() + Numbers.Last()) / 2;
                if (UserNum < x)
                {
                    int first = Numbers.First();
                    Console.WriteLine($"Your guess is too low!!!!!");
                    Console.WriteLine($"Please try again:");
                    int UserInput = Convert.ToInt32(Console.ReadLine());
                    Numbers.Clear();
                    for (int i = first; i < mid; i++)
                    {
                        Numbers.Add(i);
                    }
                    BisectionSearch(UserInput, Numbers, x);
                }
                else if (UserNum > x)
                {
                    int last = Numbers.Last();
                    Console.WriteLine($"Your guess is too high!!!!!");
                    Console.WriteLine($"Please try again:");
                    int UserInput = Convert.ToInt32(Console.ReadLine());
                    Numbers.Clear();
                    for (int i = mid + 1; i <= last; i++)
                    {
                        Numbers.Add(i);
                    }
                    BisectionSearch(UserInput, Numbers, x);
                }
                else
                {
                    Console.WriteLine($"You guessed the right number it is {x}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You ran out of guesses!!!!!!");
            }
        }
    }
}