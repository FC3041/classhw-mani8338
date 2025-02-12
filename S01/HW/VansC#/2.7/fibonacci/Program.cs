namespace fibonacci;

class Program
{
    public static int FibonacciSq(int n)
    {
        if(n == 1){
            return 1;
        }
        else if(n == 2){
            return 1;
        }
        else{
            return FibonacciSq(n-1)+FibonacciSq(n-2);
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine(FibonacciSq(1));
        Console.WriteLine(FibonacciSq(2));
        Console.WriteLine(FibonacciSq(3));
        Console.WriteLine(FibonacciSq(7)+"\n");
        for(int i = 1; i <= 20; i++){
            Console.WriteLine(FibonacciSq(i));
        }
    }
}
