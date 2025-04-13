namespace prime;
using System.Diagnostics;

class Program
{
    public static bool is_divisible(int a,int b)
    {
        if(b % a == 0){
            return true;
        }else{
            return false;
        }
    }
    public static bool is_prime(int a)
    {
        Debug.Assert(a > 0, "a must be a positive integer");
        if (a == 1){
            return false;
        }
        else if(a == 2){
            return true;
        }
        else if(a > 2)
        {
            for(int i = 2; i < a; i++){
                if(is_divisible(i,a)){
                    return false;
                }
            }
            return true;
        }
        return false;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(is_divisible(2,6));
        Console.WriteLine(is_divisible(3,14));
        Console.WriteLine("Let's chenk the primes");
        Console.WriteLine(is_prime(1));
        Console.WriteLine(is_prime(2));
        Console.WriteLine(is_prime(3));
        Console.WriteLine(is_prime(4));
        Console.WriteLine(is_prime(44));
        Console.WriteLine(is_prime(101)+"\n"); 
        Console.WriteLine("all the prime numbers less than 100\n");
        int i = 3;
        Console.WriteLine(2);
        while(i < 100){
            if(is_prime(i)){
                Console.WriteLine(i);
            }
            else{
                i += 0;
            }
            i++;

            Console.WriteLine(is_prime(-2));
        }
    }
}
