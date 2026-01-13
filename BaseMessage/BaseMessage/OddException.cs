using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMessage
{
    public class OddException : Exception
    {
        public OddException()
        {

        }
        public OddException(string message) : base(message)
        {

        }
        public override string HelpLink
        {
            get
            {
                return "please visit our website";
            }
        }
    }
}
