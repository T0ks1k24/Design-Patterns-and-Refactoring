using Lab5_2.Services;

namespace Lab5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Inventory inventory = new Inventory();
            Payment payment = new Payment();
            Shipping shipping = new Shipping();

            OrderFacade orderFacade = new OrderFacade(inventory, payment, shipping);

            orderFacade.PlaceOrder(1, 3, 1500.00m, "Кредитна карта", "Київ, вул. Шевченка, 10");

                orderFacade.PlaceOrder(3, 5, 5000.00m, "PayPal", "Луцьк, вул. Львівська, 210");
        }
    }
}
