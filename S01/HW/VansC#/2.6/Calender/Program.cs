namespace Calender;

class Program
{
    public static void print_month(int monthNumber)
    {
        string[] months = {"January","February","March","April","May","June","July","August","September","October","November","December"};
        if((monthNumber >= 1) && (monthNumber <= 12)){
            Console.WriteLine(months[monthNumber-1]);
        }
        else{
            Console.WriteLine("We only have 12 months so monthNumber should be between 1 and 12");
        }
    }
    static void Main(string[] args)
    {
        print_month(9);
        print_month(8);
        print_month(1);
        print_month(9);
        print_month(94);
        Console.WriteLine();
        for(int i = 1; i < 13; i++){
            print_month(i);
        }
    }
}
