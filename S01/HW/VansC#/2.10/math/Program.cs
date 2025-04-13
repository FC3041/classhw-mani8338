namespace math;

class Program
{
    public static double abs(double x)
    {
        if(x >= 0.0){
            return x;
        }else{
            return -x;
        }
    }
    public static double max(double x,double y)
    {
        if(x >= y){
            return x;
        }else{
            return y;
        }
    }
    public static bool near(double x,double y,double closeness = 0.001)
    {
        if(abs(x - y) <= max(abs(x),abs(y))*closeness){
            return true;
        }else{
            return false;
        }
    }
    public static int Factorial(int n)
    {
        int result = 1;
        for(int i = 1; i < n+1; i++){
            result *= i;
        }return result;
    }
    public static double power(double x,int y)
    {
        double result = 1;
        for(int i = 0; i < y; i++){
            result *= x;
        }return result;
    }
    public static double CalculateEulerNumber(double precision)
    {
        double e = 0;
        double x = precision + 1.0;
        int i = 0;
        while(x > precision){
            x = 1.0 / Factorial(i);
            e += x;
            i++;
        }
        return e;
    }
    public static double exp(double x,double precision){
        double ex = 0;
        double y = precision + 1.0;
        int i = 0;
        while(y > precision){
            y = power(x,i)/Factorial(i);
            ex += y;
            i++;
        }return ex;
    }
    public static double exp2(int x,double precision)
    {
        double ex = 1.0;
        double y = 1.0;
        double i = 1.0;
        while(y >= precision){
            y *= x/i;
            ex += y;
            i++;
        }return ex;
    }
    public static double sin(double x,double precision)
    {
        double R = 3.1415926535 * x / 180;
        double si = 0;
        double y = precision + 1.0;
        double i = 1.0;
        int sign = -1;
        while(y >= precision){
            y = power(R,(int)i)/Factorial((int)i);
            si -= sign * y;
            sign *= -1;
            i += 2;
        }return si;
    }
    
    public static double square_root(double x,double precision)
    {
        if(x < 0){
            Console.WriteLine("in real numbers negative numbers don't have square roots");
            return -1;
        }
        else{
            double lowerBound = 0;
            double upperBound = max(x,1);
            double midpoint = 0.0;

            while(upperBound - lowerBound > precision){
                midpoint = (upperBound+lowerBound)/2;
                if(power(midpoint,2) > x){
                    upperBound = midpoint;
                }else{
                    lowerBound = midpoint;
                }
            }
            return midpoint;
        }
    }

    public static double nth_root(double x,int n,double precision)
    {
        if((x < 0) & (n % 2 == 0)){
            Console.Write("in real numbers negative numbers don't have even roots ");
            return -1;
        }
        else{
            double lowerBound;
            double upperBound;
            if(x >= 0){
                lowerBound = 0;
                upperBound = max(x,1);
            }
            else{
                lowerBound = max(x,-1);
                upperBound = 0;                
            }
            
            double midpoint = 0.0;

            while(upperBound - lowerBound > precision){
                midpoint = (upperBound+lowerBound)/2;
                if(power(midpoint,n) > x){
                    upperBound = midpoint;
                }else{
                    lowerBound = midpoint;
                }
            }
            return midpoint;
        }
    }

    public static double ln(double x,double precision)
    {
        if(x <= 0){
            Console.Write("Argoman should be more than zero ");
            return -1;
        }
        else{
            double lowerBound;
            double upperBound;
            double midpoint = 0.0;
            if(x < 1){
                lowerBound = -1;
                upperBound = 0;
                while(upperBound - lowerBound > precision){
                    midpoint = (upperBound+lowerBound)/2;
                    if(exp(midpoint,0.00001) > x){
                        upperBound = midpoint;
                    }
                    else{
                        lowerBound = midpoint;
                    }
                }
            }
            else{
                lowerBound = 0;
                upperBound = x;
                while(upperBound - lowerBound > precision){
                    midpoint = (upperBound+lowerBound)/2;
                    if(exp(midpoint,0.00001) > x){
                        upperBound = midpoint;
                    }
                    else{
                        lowerBound = midpoint;
                    }
                }
            }
            return midpoint;
            }
    }
    static void Main(string[] args)
    {
        Console.WriteLine(CalculateEulerNumber(0.001)+"\n");
        Console.WriteLine(exp(2,0.000001));
        Console.WriteLine(exp(1,0.000001)+"\n");
        Console.WriteLine(exp2(2,0.000001));
        Console.WriteLine(exp2(1,0.000001)+"\n");
        double x = exp(2,0.000001);
        double y = exp2(2,0.000001);
        Console.WriteLine(near(x,y)+"\n");
        Console.WriteLine(sin(0,0.0001));
        Console.WriteLine(sin(45,0.0001));
        Console.WriteLine(sin(90,0.0001)+"\n");

        Console.WriteLine(square_root(2,0.000001));
        Console.WriteLine(square_root(4,0.000001));
        Console.WriteLine(square_root(10,0.000001));
        Console.WriteLine(square_root(-1,0.000001)+"\n");

        Console.WriteLine(nth_root(2,2,0.000001));
        Console.WriteLine(nth_root(8,3,0.00000001));
        Console.WriteLine(nth_root(10,4,0.000001));
        Console.WriteLine(nth_root(-1,4,0.000001));
        Console.WriteLine(nth_root(-1,3,0.000000001)+"\n");

        Console.WriteLine(ln(2.7,0.0001));
        Console.WriteLine(ln(5.44,0.000001));
    }
    

}
