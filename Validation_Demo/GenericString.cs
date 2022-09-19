using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_Demo
{
    class GenericString
    {
        private string value;
        public string Value
        {
            get
            {
                return value;
            }
            set
            {
                if (!ValidateString(value)) Console.WriteLine(InvalidMessage);
                this.value = value;
            }
        }
        public bool IsValid { get
            {
                return ValidateString(Value);
            }
        }

        public virtual bool ValidateString(string input)
        {
            return true;
        }

        public virtual string InvalidMessage { get; protected set; }

        public GenericString(string input)
        {
            Value = input;
        }
    }
}
