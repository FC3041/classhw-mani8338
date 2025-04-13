namespace MoreAsciiiArt;

class Program
{
    public static void printNtimes(int n,char c)
    {
        for(int i = 0; i < n; i++){
            Console.Write(c);
        }Console.Write("\n");
    }
    public static void printNtimes2(int n,char c)
    {
        for(int i = 0; i < n; i++){
            Console.Write(c);
        }Console.Write("\n");
    }
    public static void draw_triangle(int n)
    {
        for(int i = 1; i <= n; i++){
            if(i % 2 == 1){
                printNtimes(i,'*');
            }
            else{
                printNtimes(i,'%');
            }
        }
    }
    public static void Print_n_times(int n,char c)
    {
        for(int i = 0; i < n; i++){
            Console.Write(c);
        }
    }
    public static void PrintCone(int n)
    {
        Print_n_times((n/2)+1,' ');
        Console.WriteLine('^');
        for(int i = 1 ; i != (n/2)+1;i++){
            Print_n_times((n/2)-i+1,' ');
            Print_n_times(i,'/');
            Print_n_times(1,'|');
            Print_n_times(i,'\\');
            Console.WriteLine("");
        }
    }
    static void Main(string[] args)
    {
        int n = 4;
        draw_triangle(n);
        PrintCone(7);
        for(int i = 1; i <= 9; i++){
            PrintCone(i);
        }
    }
}
