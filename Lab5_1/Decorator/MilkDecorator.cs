namespace Lab5_1.Decorator;

class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) {}

    public override string Cost(float cost)
    {
        float newCost = cost + 29.99f;
        return $"{base.Cost(cost)} \n\twith milk NewCost {newCost} grn";
    }
}
