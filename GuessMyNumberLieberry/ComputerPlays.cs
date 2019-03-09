using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberLieberry
{
    public class ComputerPlays
    {
        public void computerPlays()
        {
            Restart:
            try
            {
                Random rnd = new Random();
                List<int> Numbers = Enumerable.Range(1, 100).ToList();

                Console.WriteLine("Let's play a game where the computer guesses a number you pick from 1 - 100!!!");
                Console.WriteLine("Please guess a whole number from 1 - 100:");
                int UserNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Your number is {UserNum}");

                int x = rnd.Next(1, 100);
                Console.WriteLine($"The computer guessed {x}");
                Console.WriteLine($"The range to check is {Numbers.First()} - {Numbers.Last()}.\n");

                BisectionSearch(UserNum, Numbers, x);
            }
            catch
            {
                Console.WriteLine("Please enter a whole number from 1 -1000!!!!!!!");
                goto Restart;
            }
        }
        public void BisectionSearch(int UserNum, List<int> Numbers, int x)
        {
            Restart:
            try
            {
                Random rnd = new Random();
                int mid = (Numbers.First() + Numbers.Last()) / 2;

                Console.WriteLine("Did the computer guess right or is the computer too high or too low?? (DONT LIE)");
                Console.WriteLine("(Type C for correct guess / type H for high / type L for low!!!)");
                string highLow = Console.ReadLine();
                if (highLow.ToUpper() == "L")
                {
                    int first = Numbers.First();
                    int last = Numbers.Last();
                    Numbers.Clear();
                    for (int i = x + 1; i < last; i++)
                    {
                        Numbers.Add(i);
                    }
                    Console.WriteLine($"\nYour number is {UserNum}");
                    Console.WriteLine($"The new range to check is {x + 1} - {Numbers.Last()}");
                    x = rnd.Next(x + 1, Numbers.Last());
                    Console.WriteLine($"The computers new guess is {x}");
                    BisectionSearch(UserNum, Numbers, x);
                }
                else if (highLow.ToUpper() == "H")
                {
                    int last = Numbers.Last();
                    int first = Numbers.First();
                    Numbers.Clear();
                    for (int i = first; i <= x - 1; i++)
                    {
                        Numbers.Add(i);
                    }
                    Console.WriteLine($"\nYour number is {UserNum}");
                    Console.WriteLine($"The new range to check is {Numbers.First()} - {x - 1}");
                    x = rnd.Next(Numbers.First(), x - 1);
                    Console.WriteLine($"The computers new guess is {x}");
                    BisectionSearch(UserNum, Numbers, x);
                }
                else if (highLow.ToUpper() == "C")
                {
                    Console.WriteLine($"The computer guessed the right number!!!");
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("ONLY VALID INPUTS ARE: C / H / L");
                goto Restart;
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a whole number from 1 -1000!!!!!!!");
                goto Restart;
            }
        }
    }
}
