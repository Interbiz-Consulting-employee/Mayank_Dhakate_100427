using System;

namespace Task_77
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter number of stones: ");
            int n = int.Parse(Console.ReadLine());

            bool canWin = false;

            // Loop to check possible moves
            for (int i = 1; i <= 3; i++)
            {
                if (n - i == 0)
                {
                    canWin = true;
                    break;
                }
                else if ((n - i) % 4 == 0)
                {
                    canWin = true;
                    break;
                }
            }

            // Output result
            if (canWin)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}