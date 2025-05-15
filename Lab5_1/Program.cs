using Lab5_1.Decorator;

namespace Lab5_1;

internal class Program
{
    static void Main(string[] args)
    {
        ICoffee coffee = new Coffee();

        ICoffee milkDecorator = new MilkDecorator(coffee);
        Console.WriteLine(milkDecorator.Cost());
        Console.WriteLine("----------------");
        
        ICoffee chocalateDecorator = new ChocolateDecorator(milkDecorator);
        Console.WriteLine(chocalateDecorator.Cost(150.00f));
        Console.WriteLine("----------------");

        ICoffee sugarDecorator = new SugarDecorator(coffee);
        Console.WriteLine(sugarDecorator.Cost(110.00f));
        Console.WriteLine("----------------");
        Console.ReadLine();

    }
}
