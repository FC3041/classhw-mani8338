namespace CToF;

class Program
{
    public static double CToF(double C)
    {
        return 1.8*C+32;
    }
    //let's a print one as well(because the task was to print with the funciton)
    public static void CToFp(double C)
    {
        Console.WriteLine(1.8*C+32);
    }
    static void Main(string[] args)
    {
        double C1 = 32;
        double F1 = CToF(C1);
        Console.WriteLine(C1 + " Celsius is equal to "+Math.Round(F1,2)+" Fahrenheit\n");
        double C2 = 0;
        double F2 = CToF(C2);
        Console.WriteLine(C2 + " Celsius is equal to "+Math.Round(F2,2)+" Fahrenheit\n");
        double C3 = 100;
        double F3 = CToF(C3);
        Console.WriteLine(C3 + " Celsius is equal to "+Math.Round(F3,2)+" Fahrenheit\n");
        double C4 = 5.532;
        double F4 = CToF(C4);
        Console.WriteLine(C4 + " Celsius is equal to "+Math.Round(F4,2)+" Fahrenheit\n");

        CToFp(32);
        CToFp(0);
        CToFp(100);
        CToFp(5.532);
    }
}
