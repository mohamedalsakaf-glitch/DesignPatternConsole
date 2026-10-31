using DesignPatternConsole.Behavioral;
using System.IO;
using System.Runtime.ConstrainedExecution;
using static DesignPatternConsole.Behavioral.IteratorPattern;
using static DesignPatternConsole.Behavioral.ObserverPattern;
using static DesignPatternConsole.Behavioral.StatePattern;
using static DesignPatternConsole.Creational.FactoryMethod;
using static DesignPatternConsole.Creational.Singleton;
using static DesignPatternConsole.Structural.AdapterPattern;
using static DesignPatternConsole.Structural.CompositePattern;
using static DesignPatternConsole.Structural.DecoratorPattern;
using static DesignPatternConsole.Structural.FacadePattern;
using static DesignPatternConsole.Behavioral.ChainOfResponsibility;

class Program
{
    static void Main(string[] args)
    {
        Logger.Instance.Log("Application started");
        Logger.Instance.Log("Processing completed");

        Employee employee = new EmployeeBuilder()
                .SetName("John")
                .SetDepartment("IT")
                //.SetAge(30)
                .Build();

        INotification notification = NotificationFactory.Create("email");
        notification.Send("Welcome!");

        IPayment payment = new PaymentAdapter();
        payment.Pay(50.25);

        var converter = new WordToPdfFacade();
        converter.Convert("Document.docx");

        ICar car = new BasicCar();
        Console.WriteLine($"Car Description: {car.GetDescription()}, Cost: {car.GetCost()}");

        car = new SunroofDecorator(car);
        Console.WriteLine($"Car Description: {car.GetDescription()}, Cost: {car.GetCost()}");

        car = new LeatherSeatsDecorator(car);
        Console.WriteLine($"Car Description: {car.GetDescription()}, Cost: {car.GetCost()}");

        Composite composite = new Composite();
        composite.Add(new Leaf("Leaf A"));
        composite.Add(new Leaf("Leaf B"));
        Composite composite2 = new Composite();
        composite2.Add(new Leaf("Leaf C"));
        composite.Add(composite2);
        
        composite.Display(1);

        var paymentstrategy = new PaymentContext(new UpiPayment());
        paymentstrategy.MakePayment(5000);

        var stock = new Stock();

        stock.Subscribe(new MobileApp());
        stock.Subscribe(new EmailService());
        stock.Subscribe(new DirectService());

        stock.SetPrice(1500);

        var order = new Order();

        order.Process(); // Created → Paid
        order.Process(); // Paid → Shipped
        order.Process(); // Shipped → Delivered
        order.Process(); // Already delivered

        var employees = new EmployeeCollection();

        employees.Add("John");
        employees.Add("David");
        employees.Add("Smith");

        foreach (var emp in employees.GetEmployees())
            Console.WriteLine(emp);

        var manager = new Manager();
        var director = new Director();
        var ceo = new CEO();

        manager.SetNext(director);
        director.SetNext(ceo);

        manager.Approve(500000);

        Console.WriteLine(employee);
    }
}