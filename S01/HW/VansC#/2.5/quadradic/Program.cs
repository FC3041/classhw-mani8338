namespace quadradic;

class Program
{
    public static void SolveTheEquation(double A,double B,double C)
    {
        // Ax^2+Bx+C = 0
        if(A == 0.0){
            if((B == 0.0) & (C == 0.0)){
                Console.WriteLine("all the real numbers");
            }
            else if((B == 0.0) & (C != 0.0)){
                Console.WriteLine("there is no solution to this equation");
            }
            else if((B != 0.0) & (C == 0.0)){
                Console.WriteLine("0 is the answere");
            }
            else{
                double x = -1*C/B;
                Console.WriteLine(x + " is the solution to this equation");
            }
        }
        else{
            double delta = B*B - 4*A*C;
            if(delta < 0){
                Console.WriteLine("no solution");
            }
            else if(delta == 0){
                Console.WriteLine(-B/(2*A)+" is the solution");
            }
            else{
                Console.WriteLine((-B+delta)/(2*A) + " and "+ (-B-delta)/(2*A)+" are the solutions");
            }
        }
    }
    static void Main(string[] args)
    {
        SolveTheEquation(0.0,0.0,0.0);
        SolveTheEquation(0.0,0.0,19);
        SolveTheEquation(0.0,5.0,0.0);
        SolveTheEquation(0.0,5.0,-5.5);
        SolveTheEquation(1.0,4.0,4.0);
        SolveTheEquation(3.0,1.0,4.0);
        SolveTheEquation(1.0,2.0,1.0);
    }
}
