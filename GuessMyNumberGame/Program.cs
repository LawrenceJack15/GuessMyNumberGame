using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessMyNumberLieberry;

namespace GuessMyNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch = 0;

            Console.WriteLine("Please select a number:");
            Console.WriteLine("1.Implement bisection algorithm");
            Console.WriteLine("2.Guess my number, human");
            Console.WriteLine("3.Guess my number, computer");
            caseSwitch = Convert.ToInt32(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    Console.Clear();
                    BisectionMethod bisectionMethod = new BisectionMethod();
                    bisectionMethod.UserInput();
                    break;
                case 2:
                    Console.Clear();
                    HumanPlays humanPlays = new HumanPlays();
                    humanPlays.UserPlays();
                    break;
                case 3:
                    Console.Clear();
                    ComputerPlays computerPlays = new ComputerPlays();
                    computerPlays.computerPlays();
                    break;
            }

        }
    }
}
