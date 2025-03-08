namespace power;

class Program
{
    public static double CalculatePower(double x,int n)
    {
        double result = 1.0;
        for(int i = 0; i < n; i++){
            result *= x;
        }return result;
    }
    public static void CalculatePowerSTD(double x,int n)
    {
        double result = 1.0;
        for(int i = 0; i < n; i++){
            result *= x;
        }Console.WriteLine(result);
    }
    static void Main(string[] args)
    {
        Console.WriteLine(CalculatePower(2,3));
        Console.WriteLine(CalculatePower(0,4));
        Console.WriteLine(CalculatePower(5,0));
        Console.WriteLine(CalculatePower(5,3));
        Console.WriteLine(CalculatePower(7.71,2)+"\n");

        CalculatePowerSTD(2,3);
    }
}
