using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_Demo
{
    class Email:GenericString
    {
        public Email(string inputEmail) : base(inputEmail)
        {
            InvalidMessage = "The email must consist of a @, a prefix, and a suffix";
        }

        public override bool ValidateString(string input)
        {
            bool hasAtSymbol = false;
            foreach (char c in input)
            {
                if (c == '@') hasAtSymbol = true;
            }
            bool correctPrefix = true;
            bool correctSuffix = true;
            return hasAtSymbol & correctPrefix & correctSuffix;
        }
    }
}
