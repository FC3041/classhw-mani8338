namespace HW;

class Program
{
    static void Main(string[] args)
    {
        Bike b = new Bike(175,2014,"Harley-Davidson Fat Boy",20);
        b.printInfo();
        System.Console.WriteLine(b.Distance(14));
        System.Console.WriteLine(b.CanFitInAMediumGaradge());
        System.Console.WriteLine();

        Car c = new Car("Corolla",190,5);
        c.printInfo();
        System.Console.WriteLine(c.Distance(120));
        System.Console.WriteLine(b.CanFitInAMediumGaradge());
        System.Console.WriteLine();

        Truck t = new Truck(10,true,100000,1000);
        t.printInfo();
        System.Console.WriteLine(t.Distance(500));
        System.Console.WriteLine(b.CanFitInAMediumGaradge());
        System.Console.WriteLine();

        Truck T = new Truck(10,false,100000,1000);
        T.printInfo();
        
    }
}
