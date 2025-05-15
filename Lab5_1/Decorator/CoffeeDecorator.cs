namespace Lab5_1.Decorator;

class CoffeeDecorator : ICoffee
{
    private readonly ICoffee _coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual string Cost(float cost) => _coffee.Cost(cost);
}
