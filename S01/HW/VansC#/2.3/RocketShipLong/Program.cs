namespace RocketShipLong;

class Program
{
    public static void Print_n_times(int n,char c)
    {
        for(int i = 0; i < n; i++){
            Console.Write(c);
        }
    }
    public static void PrintCone(int n)
    {
        Console.WriteLine("    ^");
        for(int i = 1 ; i != (n/2)+1;i++){
            Print_n_times((n/2)-i+1,' ');
            Print_n_times(i,'/');
            Print_n_times(1,'|');
            Print_n_times(i,'\\');
            Console.WriteLine("");
        }
    }

    public static void PrintTrunk(int n)
    {
        for(int i = 0; i < n; i++){
            Console.WriteLine("+*******+");
        }
    }
    static void Main()
        {
            PrintCone(7);
            Console.WriteLine("+-------+");
            PrintTrunk(4);
            Console.WriteLine("+-------+");
            PrintTrunk(4);
            Console.WriteLine("+-------+");
            PrintCone(7);
        }
        
}
