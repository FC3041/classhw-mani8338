namespace RocketShipFactored;

class Program
{

    public static void PrintCone()
    {
        Console.WriteLine("    ^");
        Console.WriteLine("   /|\\");
        Console.WriteLine("  //|\\\\");
        Console.WriteLine(" ///|\\\\\\");
    }
    public static void PrintTrunk()
    {
        Console.WriteLine("+*******+");
        Console.WriteLine("+*******+");
        Console.WriteLine("+*******+");
        Console.WriteLine("+*******+");
    }

    public static void PrintLine()
    {
        Console.WriteLine("+-------+");
    }
    static void Main(string[] args)
        {
            PrintCone();
            PrintLine();
            PrintTrunk();
            PrintLine();
            PrintTrunk();
            PrintLine();
            PrintCone();
        }

        
}
