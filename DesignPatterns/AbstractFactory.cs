namespace DesignPatterns.AbstractFactory.Conceptual
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }

    class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
    public interface IAbstractProductA
    {
        string UseFulFunctionA();
    }
    class ConcreteProductA1 : IAbstractProductA
    {
        public string UseFulFunctionA()
        {
            return "The result of the product A1.";
        }
    }
    class ConcreteProductA2 : IAbstractProductA
    {
        public string UseFulFunctionA()
        {
            return "The result of the product A2.";
        }
    }

    public interface IAbstractProductB
    {
        string UseFulFunctionB();
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
    class ConcreteProductB1 : IAbstractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UseFulFunctionA();
            return $"The result of the B1 collaborating with the ({result})";
        }

        public string UseFulFunctionB()
        {
            return "The result of the product B1.";
        }
    }
    class ConcreteProductB2 : IAbstractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UseFulFunctionA();
            return $"The result of the B2 collaborating with the ({result})";
        }

        public string UseFulFunctionB()
        {
            return "The result of the product B2.";
        }
    }

    class Client
    {
        public void Main()
        {
            System.Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ConcreteFactory1());
            System.Console.WriteLine();

            System.Console.WriteLine("Client: Testing client code with the another factory type...");
            ClientMethod(new ConcreteFactory2());
            System.Console.WriteLine();
        }
        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            System.Console.WriteLine(productB.UseFulFunctionB());
            System.Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}