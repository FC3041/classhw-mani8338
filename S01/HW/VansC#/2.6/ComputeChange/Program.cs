namespace ComputeChange;

class Program
{
    public static int floor(double x)
    {
        int z;
        if(x >= 0){
            z = (int)x;
        }else{
            z = (int)x - 1;
        } 
        return z;
    } 
    public static void Compute_change(int dollar,int cent)
    {
        int dif = dollar * 100 - cent;
        int quarters = floor((double)dif/25);
        dif -= quarters * 25;
        int dime = floor((double)dif/10);
        dif -= dime * 10;
        int  nickel = floor((double)dif/5);
        dif -= nickel * 5;
        int pennies = floor((double)dif/1);
        dif -= pennies * 5;
        Console.Write(quarters+" quarters\n"+dime+" dime\n"+nickel+" nickel\n"+pennies+" pennies\n");

    }
    static void Main(string[] args)
    {
        Compute_change(1,8);
        Console.WriteLine();
        Compute_change(2,7);
    }
}
