namespace Validation_Demo
{
    class Program
    {
        public static void Main(string[] args)
        {
            GetValidatedString("name");
            GetValidatedString("email");
        }
        
        public static GenericString GetValidatedString(string type)
        {
            GenericString validatedString = null;
            Console.WriteLine("Please enter the name");
            string input = Console.ReadLine();
            // Validation using polymorphism
            if (type == "name")
            {
                validatedString = new Name(input);
            } else if (type == "email")
            {
                validatedString = new Email(input);
            }
            
            while (!validatedString.IsValid)
            {
                Console.WriteLine($"The client's name is invalid, please reset it");
                input = Console.ReadLine();
                validatedString.Value = input;
            }
            Console.WriteLine($"The client's name is {validatedString.Value}");
            return validatedString;
        }

        public static Name GetClientName()
        {
            Console.WriteLine("Please enter the name");
            string input = Console.ReadLine();
            Name clientName = new Name(input);
            while (!clientName.IsValid)
            {
                Console.WriteLine($"The client's name is invalid, please reset it");
                input = Console.ReadLine();
                clientName.Value = input;
            }
            Console.WriteLine($"The client's name is {clientName.Value}");
            return clientName;
        }

        public static Email GetClientEmail()
        {
            Console.WriteLine("Please enter the email");
            string input = Console.ReadLine();
            Email clientEmail = new Email(input);
            while (!clientEmail.IsValid)
            {
                Console.WriteLine($"The client's name is invalid, please reset it");
                input = Console.ReadLine();
                clientEmail.Value = input;
            }
            Console.WriteLine($"The client's name is {clientEmail.Value}");
            return clientEmail;
        }
    }
}