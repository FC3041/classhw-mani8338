namespace Factorial;
using System.Diagnostics;
class Program
{
    public static long CalculateFactorial2(int n)
    {
        Debug.Assert(n >= 0, "n must be a non-negative integer");
        long result = 1;
        for (int i = 1; i <= n; i++){
            result *= i;
        }
        Debug.Assert(result > 0, "result should be positive");
        return result;
    }
    public static void CalculateFactorial(int n)
    {
        long result = 1;
        for (int i = 1; i <= n; i++){
            result *= i;
        }
        Console.WriteLine(result);
    }
    static void Main(string[] args)
    {
        Console.WriteLine(CalculateFactorial2(0));
        Console.WriteLine(CalculateFactorial2(1));
        Console.WriteLine(CalculateFactorial2(2));
        Console.WriteLine(CalculateFactorial2(5));
        Console.WriteLine(CalculateFactorial2(6)+"\n");

        CalculateFactorial(0);
        CalculateFactorial(1);
        CalculateFactorial(2);
        CalculateFactorial(5);
        CalculateFactorial(6);
        
        Console.WriteLine();
        for(int i = 0; i <= 20; i++){
            Console.Write(CalculateFactorial2(i)+"\n");
        }


        Console.WriteLine(CalculateFactorial2(-5));
    }
}
