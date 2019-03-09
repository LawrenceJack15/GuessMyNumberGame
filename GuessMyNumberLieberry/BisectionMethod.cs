using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberLieberry
{

    public class BisectionMethod
    {
        public void UserInput()
        {
            BisectionMethod bisectionMethod = new BisectionMethod();

            Restart:
            int UserNum;
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            try
            {
                Console.WriteLine("Please pick any whole number from 1 - 10:");
                UserNum = checked(Convert.ToInt32(Console.ReadLine()));
                if (UserNum < 1 || UserNum > 10) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a whole number from 1 -10!!!!!!!");
                goto Restart;
            }

            bisectionMethod.BisectionSearch(UserNum, Numbers);
        }
        public void BisectionSearch(int UserNum, List<int> Numbers)
        {
            int mid = (Numbers.First() + Numbers.Last()) / 2;
            if (UserNum < mid)
            {
                int first = Numbers.First();
                Console.WriteLine($"Your number is lower than {mid}!!!!!");
                Numbers.Clear();
                for (int i = first; i < mid; i++)
                {
                    Numbers.Add(i);
                }
                BisectionSearch(UserNum, Numbers);
            }
            else if (UserNum > mid)
            {
                int last = Numbers.Last();
                Console.WriteLine($"Your number is higher than {mid}!!!!!");
                Numbers.Clear();
                for (int i = mid + 1; i <= last; i++)
                {
                    Numbers.Add(i);
                }
                BisectionSearch(UserNum, Numbers);
            }
            else
            {
                Console.WriteLine($"Your number is equal to {UserNum}");
                Console.WriteLine($"The value searched for,{UserNum}, has been found!!!!!!!!!!!!");
            }
        }
    }
}
