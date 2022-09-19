using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_Demo
{
    class Name:GenericString
    {
        public Name(string nameValue) : base(nameValue)
        {
            InvalidMessage = "The name must be non-blank";
        }

        public override bool ValidateString(string input)
        {
            return input.Length > 0;
        }
    }
}
