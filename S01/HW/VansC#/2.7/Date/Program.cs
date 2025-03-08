namespace Date;

class Program
{
    public static int FindTheNumberOfDaysInMonth(int monthNumber)
    {
        string[] months = {"January","February","March","April","May","June","July","August","September","October","November","December"};
        int[] days = {31,28,31,30,31,30,31,31,30,31,30,31};
        if((monthNumber >= 1) && (monthNumber <= 12)){
            return days[monthNumber-1];
        }else{
            return 0;
        }
    }
    public static int days_before_date(int year,int month,int day)
    {
        string[] months = {"January","February","March","April","May","June","July","August","September","October","November","December"};
        int[] days = {31,28,31,30,31,30,31,31,30,31,30,31};
        int total_days = day - 1;
        for(int i = 0; i < month-1; i++){
            total_days += days[i];
        }
        return total_days;
    }
    public static string day_of_the_week(int year,int month,int dayNum)
    {
        string[] months = {"January","February","March","April","May","June","July","August","September","October","November","December"};
        int[] days = {31,28,31,30,31,30,31,31,30,31,30,31};
        string[] daysOfTheWeek = {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
        int eghtelaf_rooz_ha_Mod7 = 0;
        Console.WriteLine("this only works for the year 2025");
        if(month == 1){
            eghtelaf_rooz_ha_Mod7 = (dayNum-1)%7;
            return daysOfTheWeek[(2+eghtelaf_rooz_ha_Mod7)%7];
        }
        else if((month > 1)&&(month <= 12)){
            days[0] = 30;
            for(int i = 0; i < month-1; i++){
                eghtelaf_rooz_ha_Mod7 += days[i];
            }
            eghtelaf_rooz_ha_Mod7 += dayNum;
            eghtelaf_rooz_ha_Mod7 = eghtelaf_rooz_ha_Mod7 % 7;
            int x = (2+eghtelaf_rooz_ha_Mod7)%7;
            return daysOfTheWeek[x];
        }
        else{
            return "invalid input";
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine(FindTheNumberOfDaysInMonth(1));
        Console.WriteLine(FindTheNumberOfDaysInMonth(2));
        Console.WriteLine(FindTheNumberOfDaysInMonth(7));
        Console.WriteLine(FindTheNumberOfDaysInMonth(9));
        Console.WriteLine(FindTheNumberOfDaysInMonth(12));
        Console.WriteLine(FindTheNumberOfDaysInMonth(13)+"\n");
        Console.WriteLine(days_before_date(2025,8,23));
        Console.WriteLine(days_before_date(2025,1,1));
        Console.WriteLine(days_before_date(2025,12,29)+"\n");
        Console.WriteLine(day_of_the_week(2025,2,7));
        Console.WriteLine(day_of_the_week(2025,8,25));
        Console.WriteLine(day_of_the_week(2025,7,22));
    }
}
