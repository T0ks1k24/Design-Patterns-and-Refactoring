namespace Lab5_1.Decorator;

class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string Cost(float cost)
    {
        float newCost = cost + 19.99f;
        return $"{base.Cost(cost)} \n\twith chocolate NewCost {newCost} grn";
    }
}