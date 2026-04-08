namespace C_
{
    public class Persons
    {
        public string Name;
        public string Address;
        public int Age;
        public static string CompanyName;
        public static int Count { get; set; }

        // static constructor
        // it is called only once when the class is first accessed or an instance of the class is created. It is used to initialize static members of the class.
        static Persons()
        {
            Console.WriteLine("Static constructor called");
            CompanyName = "ABC Corp";
            Count = 0;
        }
        // Parameterless constructor 
        // Used when you want to set default values 
        public Persons()
        {
            Console.WriteLine("Instance constructor called");
            Name = "Unknown";
            Age = 0;
        }

        // parametrized constructor 
        // Used when you want to initialize with specific values 
        // If we want to execute some custom logic at the time of object creation, that logic may be object initialization 
        // logic or some other useful logic, then as a developer, we must provide the constructor explicitly in C#.

        public Persons(string name, int age)
        {
            Console.WriteLine("parametrized constructor called");
            //we can throw an exception from the constructor. 
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            if (string.IsNullOrEmpty(Address))
            {
                Name = "Default";
                return; // We can place a return; in the constructor. 
            }
            Name = name;
            Age = age;
        }
        // copy constructor 
        // If we want to create multiple instances with the same values then we need to use the copy constructor in C# 
        // , in a copy constructor the constructor takes the same class as a parameter to it.

        public Persons(Persons person)
        {
            Console.WriteLine("Copy constructor called");
            Name = person.Name;
            Age = person.Age;
            Address = person.Address;
        }

        public Persons(string name, int age, string adress)
        {
            Name = Name;
            Age = Age;
            Address = adress;
        }
    }
    // A primary constructor is a feature in C# 12 that lets you declare constructor parameters directly in the class
    // (or struct) declaration, instead of writing a separate constructor.
    // It reduces boilerplate and makes simple classes cleaner.
    public class PrimaryPerson(string name, int age, string address)
    {
        public string Name { get; } = name;
        public int Age { get; } = age;
        public string Address { get; } = address;
        // ✅ Parameterless constructor
        public PrimaryPerson() : this("Unknown", 0, "NA")
        {
        }
    }
    public class PrivatePerson
    {
        public string Name;
        public int Age;
        public string Address;
        private PrivatePerson() : this("Unknown", 10, "NA")
        {
            Name = "Unknown";
            Age = 10;
            Address = "NA";
        }
        private PrivatePerson(string name, int age, string adress)
        {
            Name = Name;
            Age = Age;
            Address = adress;
        }
    }
    public class Test
    {
        public void TestCopyconst()
        {
            Persons obj1 = new Persons("dennis", 20, "delhi");
            Console.WriteLine($" TestCopyconst Value of obj1 = {obj1.Name} , {obj1.Age} , {obj1.Address}");
            Persons obj2 = new Persons(obj1);
            Console.WriteLine($"TestCopyconst Value of obj2 = {obj2.Name} , {obj2.Age} , {obj2.Address}");
        }
        public void TestParameterisedConst()
        {
            Persons obj1 = new Persons("dennis", 20, "delhi");
            Console.WriteLine($" TestParameterisedConst Value of obj1 = {obj1.Name} , {obj1.Age} , {obj1.Address}");
        }
        public void TestStaticConst()
        {
            Persons obj1 = new Persons("dennis", 20, "delhi");
            Console.WriteLine($" TestParameterisedConst Value of obj1 = {obj1.Name} , {obj1.Age} , {obj1.Address}");
        }
        public void TestPrimaryConst()
        {
            PrimaryPerson obj1 = new PrimaryPerson("dennis", 20, "delhi");
            Console.WriteLine($" TestPrimaryConst Value of obj1 = {obj1.Name} , {obj1.Age} , {obj1.Address}");
            PrimaryPerson obj2 = new PrimaryPerson();
            Console.WriteLine($" TestPrimaryConst Value of obj2 = {obj2.Name} , {obj2.Age} , {obj2.Address}");
        }
        public void TestPrivateConst()
        {
            //PrivatePerson obj1 = new PrivatePerson();
            //obj1.Name = "dennis";
            //Console.WriteLine($" TestPrimaryConst Value of obj1 = {obj1.Name} , {obj1.Age} , {obj1.Address}");
        }
    }
}