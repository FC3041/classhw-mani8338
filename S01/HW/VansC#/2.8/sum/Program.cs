namespace sum;

class Program
{
    public static int compute_sum(int n)
    {
        int result = 0;
        for(int i = 1; i <= n; i++){
            result += i;
        }return result;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("N      compute_sum(N)");
        Console.WriteLine("---------------------");
        for(int i = 9; i >= 1; i--){
            Console.WriteLine(i+" "+compute_sum(i));
        }
    }
}
