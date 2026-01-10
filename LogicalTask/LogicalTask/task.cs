using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalTask
{
    public class task
    {
        public char Show(char[] arr,char target)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > target)
                {
                    return arr[i];
                    
                }
                
            }
            return arr[0];
        }
    }
}
