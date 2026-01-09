namespace OOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encapsulation e1 = new Encapsulation();
            e1.getData();
            bank b1 = new bank();
            b1.PIN = 9693;
            bank b2 = new bank();
            b2.Deposit(1234, 1000);
            b2.PIN=9693;
            b2.Deposit(9693, 100000);
            
            b2.Deposit(1225, 113211);
            Idfc i1 = new Idfc();
            i1.withdraw(9693, 20000);
            i1.ministatement(9693);
            i1.Pin = 1234;
            i1.withdraw(1234, 9000);
            i1.ministatement(1234);
            Idfc i2 = new Idfc();
            i2.showBalance();
            
         
        }
    }
}
