namespace Thread
{
    using System.Threading;
    public class Program
    {
        static void Main(string[] args)
        {
            {
                // Create two threads
                Thread thread1 = new Thread(PrintNumbers);
                Thread thread2 = new Thread(PrintLetters);

                // Start the threads
                thread1.Start();
                thread2.Start();

                Console.WriteLine("Main thread continues...");
            }

            // Method for first thread
            static void PrintNumbers()
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Number: " + i);
                    Thread.Sleep(500); // pause for 0.5 sec
                }
            }

            // Method for second thread
            static void PrintLetters()
            {
                for (char c = 'A'; c <= 'E'; c++)
                {
                    Console.WriteLine("Letter: " + c);
                    Thread.Sleep(500); // pause for 0.5 sec
                }
            }
        }
    }
}
