namespace C_;

class Program
{
    public static void update(int[] nums)
    {
        for(int i = 0; i < nums.Length; i++){
            nums[i]++;
        }
    }

    public static void update(ref int num)
    {
        num++;
    }
    static void Main(string[] args)
    {
        // for(int i = 0; i < 100000; i++){
        //     int[] nums = new int [1000*1000];
        //     Thread.Sleep(1);
        // }
        int a = 10;
        update(a);
        Console.WriteLine(ref a); // int is by value so it doesn't change if we want to fix it we should add ref to Update here and on the function
        Console.WriteLine();

        int[] num = new int[10]{1,2,3,4,5,6,7,8,9,10};
        update(num);

        for(int i = 0; i < num.Length; i++){
            Console.WriteLine(num[i]);
        }
        Console.WriteLine("Hello, World!");
    }
}
