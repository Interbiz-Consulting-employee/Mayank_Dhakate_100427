using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class AddException : Exception
    {
        public override string Message
        {
            get {
                return "first no is  odd";
            }
        }

    
        public override string? HelpLink
        {
            get {
                return "Please visit-www.abc.com";
            }
        }
    }
}