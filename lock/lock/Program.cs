namespace lock1;
using System.Threading;
public class Program
{
    public int balance = 1000;
    void withdraw()
    {
        if (balance > 700)
        {
            Console.WriteLine(Thread.CurrentThread.Name+"Withdraw 700");
            Thread.Sleep(1000);
            balance -= 700;
            Console.WriteLine(Thread.CurrentThread.Name+"Remaining balance "+balance);
        }
        else
        {
            Console.WriteLine(Thread.CurrentThread.Name+"Not enough balance");
        }
    }
    static void Main(string[] args)
    {
        Program account = new Program();
        Thread t1 = new Thread(account.withdraw);
        Thread t2 = new Thread(account.withdraw);
        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
    }
}
