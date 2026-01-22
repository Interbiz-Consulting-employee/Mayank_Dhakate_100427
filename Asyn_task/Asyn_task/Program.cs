using System.Threading.Tasks;

namespace Asyn_task
{
    public class Program
    {
       
        static  void Main(string[] args)
        {
            A a = new A();
            await a.method();
        }
        
    }
    
}
