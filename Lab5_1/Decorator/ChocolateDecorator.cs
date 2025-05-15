namespace Lab5_1.Decorator;

class ChocolateDecorator : CoffeeDecorator
{
    public ChocolateDecorator(ICoffee coffee) : base(coffee) {}

    public override string Cost(float cost) 
    {
        float newCost = cost + 45.99f;
        return $"{base.Cost(cost)} \n\twith chocolate NewCost {newCost} grn";
    }
}
