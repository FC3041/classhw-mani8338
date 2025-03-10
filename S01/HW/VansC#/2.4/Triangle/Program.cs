namespace Triangle;

class Program
{
    public static void PrintCNtimes(int n,char c)
        {
            for(int i = 0; i < n; i++){
                Console.Write(c);
            }
            Console.WriteLine();
        }
        public static void PrintCNtimes2(int n,char c)
        {
            for(int i = 0; i < n; i++){
                Console.Write(c);
            }
            //Console.WriteLine();
        }
        public static void PrintNTimes(int n)
        {
            for(int i = 1; i <= n; i++){
                PrintCNtimes(i,'*');
            }
        }
        public static void PrintNTimes2(int n,char c)
        {
            for(int i = 1; i <= n; i++){
                PrintCNtimes(i,c);
            }
        }

        public static void Print_right_triangle(int n)
        {
            for(int i = n-1; i >= 0; i--){
                PrintCNtimes2(i,' ');
                PrintCNtimes(n-i,'*');
            }
        }
        static void Main(string[] args)
        {
            PrintNTimes(20);
            PrintNTimes2(20,'%');
            Print_right_triangle(20);
        }
        
}
