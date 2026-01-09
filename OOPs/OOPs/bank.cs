using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class bank
    {
        private int pin = 1234;
        private int balance = 20000;

        public int PIN
        {
            set
            {
                pin = value;
                Console.WriteLine("Successfully Pin set");
            }
        }
        public  int Balance
        {
            get
            {
                return balance;
            }
        }
        public void Deposit(int pin1,int amount)
        {
            if(pin1==pin && amount > 0)
            {
                balance = balance + amount;
                Console.WriteLine("your balance is" + balance);
            }
            else
            {
                Console.WriteLine("Some thing invalid or incorrect");
            }
        }
    }
}
