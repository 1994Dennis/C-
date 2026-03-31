// See https://aka.ms/new-console-template for more information
using Design_Pattern;
using static Design_Pattern.Singleton;

Console.WriteLine("Hello, World!");

Console.WriteLine("Creational → How objects are created");
Console.WriteLine("Structural → “How objects are connected");
Console.WriteLine("Behavioral → “How objects talk");

Console.WriteLine("=== Creational Design Patterns ===");
Console.WriteLine("Singleton*");
Console.WriteLine("Factory Method*");
Console.WriteLine("Abstract Factory*");
Console.WriteLine("Builder");

Console.WriteLine("\n=== Structural Patterns ===");
Console.WriteLine("Decorator*");
Console.WriteLine("Facade*");
Console.WriteLine("Adapter*");
Console.WriteLine("Proxy");
Console.WriteLine("Composite");

Console.WriteLine("\n=== Behavioral Patterns ===");
Console.WriteLine("Strategy*");
Console.WriteLine("Observer*");
Console.WriteLine("Command*");
Console.WriteLine("Chain of Responsibility*");
Console.WriteLine("State");

Console.WriteLine("\n=== Architectural Patterns ===");
Console.WriteLine("Dependency Injection (DI) *");
Console.WriteLine("Repository Pattern*");
Console.WriteLine("Unit of Work *");
Console.WriteLine("CQRS (Command Query Responsibility Segregation)*");



Console.WriteLine("\n=== Eager And Lazy Loading ===");
// lazy loading : Load related data on demand, when you access the navigation property.

// var customer = context.Customers.First();
// var orders = customer.Orders;
// orders will be: null 
// Because EF Core:Doesn’t track navigation property access by default
// To make it work (Lazy Loading)
//  Enable proxies options.UseLazyLoadingProxies();
//  Make navigation property virtual public virtual List<Order> Orders { get; set; }
//   virtual allows EF Core to override your property using a proxy so it can detect when you access it and trigger lazy loading.
// eager loading : Load related data as part of the initial query using Include() method.

//var customer = context.Customers
//    .Include(c => c.Orders)
//    .First();

Console.WriteLine("Non Singleton==========================================================");

LoggerWithoutSingleton log1 =new LoggerWithoutSingleton();
log1.Log("First log message");
LoggerWithoutSingleton log2 = new LoggerWithoutSingleton();
log2.Log("First log message");


Console.WriteLine(" Singleton==========================================================");

//Call the GetInstance static method to get the Singleton Instance
LoggerWithSingleton fromTeachaer = LoggerWithSingleton.GetInstance();
fromTeachaer.PrintDetails("From Teacher");

//Call the GetInstance static method to get the Singleton Instance
LoggerWithSingleton fromStudent = LoggerWithSingleton.GetInstance();
fromStudent.PrintDetails("From Student");
 
