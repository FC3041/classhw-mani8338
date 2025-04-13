namespace LeapYear;

class Program
{
    public static bool is_LeapYear(int year)
    {
        if(year % 400 == 0){
            return true;
        }
        else if(year % 100 == 0){
            return false;
        }
        else if(year % 4 == 0){
            return true;
        }
        else{
            return false;
        }
    }
    public static void is_LeapYear2(int year)
    {
        if(year % 400 == 0){
            Console.WriteLine("True");
        }
        else if(year % 100 == 0){
            Console.WriteLine("False");
        }
        else if(year % 4 == 0){
            Console.WriteLine("True");
        }
        else{
            Console.WriteLine("False");
        }
    }
    static void Main(string[] args)
    {
        is_LeapYear2(1792);
        is_LeapYear2(1796);
        is_LeapYear2(1800);
        is_LeapYear2(1804);
        is_LeapYear2(1900);
        is_LeapYear2(1904);
        is_LeapYear2(2000);
        is_LeapYear2(2004);
        Console.WriteLine("\n"+is_LeapYear(1792));
        Console.WriteLine(is_LeapYear(1796));
        Console.WriteLine(is_LeapYear(1800));
        Console.WriteLine(is_LeapYear(1804));
        Console.WriteLine(is_LeapYear(1900));
        Console.WriteLine(is_LeapYear(1904));
        Console.WriteLine(is_LeapYear(2000));
        Console.WriteLine(is_LeapYear(2004));
    }
}
