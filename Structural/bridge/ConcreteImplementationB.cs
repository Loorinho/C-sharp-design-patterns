namespace Design_Patterns.Structural.bridge;

public class ConcreteImplementationB: IImplementation
{
    public string OperationImplementation()
    {
        return "ConcreteImplementationB: The result in MacOS.\n";
    }
}