namespace Design_Patterns.Structural.decorator;

// Decorator --> More like our base decorator
public class CoffeeDecorator: Coffee
{
    protected Coffee _coffee; // This is the wrapee -> The object we want to wrap

    public CoffeeDecorator(Coffee coffee)
    {
        _coffee = coffee;
    }

    public override string GetDescription()
    {
        return _coffee.GetDescription();
    }

    public override double GetCost()
    {
        return _coffee.GetCost();
    }
}