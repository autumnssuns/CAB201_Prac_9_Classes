namespace Assignment_Hint
{
    class Program
    {
        public static void Main(string[] args)
        {
            string tableHeader = "Client Menu";
            Console.WriteLine(tableHeader);
            string dashes = "";
            foreach (char c in tableHeader)
            {
                dashes += "-";
            }
            Console.WriteLine(dashes);
        }
    }
}