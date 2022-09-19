namespace Biscuit
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Number\tCustomer\tType\tDozens\tTotalCost");
            Console.WriteLine("-----------------------------------------");
            BiscuitOrder order = new BiscuitOrder(
                0,
                "Dan",
                "Chocolate Chip",
                2);
            order.DisplayOrder();
            SpecialCookOrder specialOrder = new SpecialCookOrder(
                1,
                "Lawrence",
                "Blueberry Chip",
                3,
                "No blueberry");
            specialOrder.Display0rder();
        }
    }
}