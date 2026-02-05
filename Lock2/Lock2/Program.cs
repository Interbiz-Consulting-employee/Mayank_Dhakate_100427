namespace Lock2
{
    using System;
    using System.Threading;
    public class Program
    {
        public int balance = 1000;
        Object objlock = new object();
        void withdraw()
        {
            lock (objlock)
            {
                if (balance > 700)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "Withrawing 700");
                    balance -= 700;
                    Console.WriteLine(Thread.CurrentThread.Name + "remianing balance" + balance);
                }
                else
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "Not enough balance");
                }
            }
        
         
        }
        static void Main(string[] args)
        {
            Program acc = new Program();
            Thread MayankWithdraw = new Thread(acc.withdraw);
            Thread AmitWithdraw = new Thread(acc.withdraw);
            MayankWithdraw.Start();
            AmitWithdraw.Start();
            MayankWithdraw.Join();
            AmitWithdraw.Join();
        }
    }
}
