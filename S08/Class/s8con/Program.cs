namespace s8con;

class Program
{  
    public static void reverse_string(string s,out string srev){
        srev = "";
        foreach(char c in s)
            srev = c + srev;
    }
    public static int add(int a,int b){
        return a+b;
    }
    static void Main(string[] args)
    {
        // int sum = 0;
        // system.Console.WriteLine("Nums?");
        // string s = Console.ReadLine();
        // while(true){
        //     if(string.IsNullorEmpty(s)){
        //     break;
        //     }
        //     int n;
        //     // if(! int.TryParse(s,out n)){

        //     // }
        //     sum += int.Parse(s);
        // }
        //Console.WriteLine(sum);
        
        // for(int = 0; int < args.Length; i++){
        //     System.Console.WriteLine($"args{i}:{args[i]}");
        // }

        string name = "fateme";
        string srev;
        reverse_string(name,out srev);
        Console.WriteLine(srev);
        Console.WriteLine("Hello, World!");
    }  
}
