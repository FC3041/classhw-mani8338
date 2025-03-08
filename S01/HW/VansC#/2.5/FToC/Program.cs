namespace FToC;

class Program
{
    public static double FToC(double F)
    {
        return (F-32)*5.0/9.0;
    }
    //let's add a function to consolewriteline(print(printf(std::cout))) as well
    public static void FToCp(double F)
    {
        Console.WriteLine((F-32)*5.0/9.0);
    }
    static void Main(string[] args)
    {
        double C1 = FToC(32);
        Console.WriteLine(Math.Round(C1,2));

        double C2 = FToC(100);
        Console.WriteLine(Math.Round(C2,2));

        double C3 = FToC(208);
        Console.WriteLine(Math.Round(C3,2)+"\n");

        FToCp(32);
        FToCp(100);
        FToCp(208);


    }
    
}
