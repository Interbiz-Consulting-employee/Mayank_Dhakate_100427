using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Idfc
    {
        private int balance = 100000;
        private int pin = 1234;
        
        public int Pin
        {
            set
            {
                pin = value;
                Console.WriteLine("Your Pin is Succesfully reset");
            }
        }
        public  int Balance
        {
            get
            {
                return balance;
                
            }
        }
        
        public void withdraw(int value,int amount)
        {
            if(pin==value && amount > 0)
            {
                balance -= amount;
                Console.WriteLine("your available balance is" + balance);
            }
            else
            {
                Console.WriteLine("Some thing is incorrect");
            }
        }
        public void ministatement(int n)
        {
            if (pin == n)
            {
                Console.WriteLine("Your current balance is Rs" + balance);
            }
        }
        public void showBalance()
        {
            int v = balance;
            Console.WriteLine(v);
        }
    }
}
