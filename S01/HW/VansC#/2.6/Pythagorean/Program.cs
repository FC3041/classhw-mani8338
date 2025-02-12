namespace Pythagorean;

class Program
{
    public static void is_these_3_Pythagorean(int a,int b,int c)
    {
        if(a*a + b*b == c*c){
            Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);
        }
    }
    static void Main(string[] args)
    {
        for(int c = 2; c < 100; c++){
            for(int b = 1; b < c; b++){
                for(int a = 1; a < b; a++){
                    is_these_3_Pythagorean(a,b,c);
                }
            }
        }
    }
}
