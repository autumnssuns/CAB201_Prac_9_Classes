namespace Class
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class myClass = new Class("Timothy");
            Console.WriteLine(myClass.Name);
            SubClass mySubClass = new SubClass("Lawrence", 55);
            Console.WriteLine(mySubClass.Name);
            Console.WriteLine(mySubClass.Age);
            SubSubClass mySubSubClass = new SubSubClass("Lucas", 25, "QUT");
            Console.WriteLine(mySubSubClass.Name);
            Console.WriteLine(mySubSubClass.Age);
            Console.WriteLine(mySubSubClass.Location);
        }
    }
}