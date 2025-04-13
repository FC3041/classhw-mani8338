using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace S10con;

class Program
{
    public static void Main(string[] args)
    {
        if(args.Length == 0)
        {
            using(Student s = new Student("Hadi")){}
            System.Console.WriteLine("in block");
        }
        System.Console.WriteLine("end of Main");
    }
    public static void Main5(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        using(StringWriter sw = new StringWriter(sb))
        {
            sw.WriteLine("test");
        }
        System.Console.WriteLine(sb.ToString());
    }
    public static void Main4(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        StringBuilder sb = new StringBuilder(1000000);

        for(int i = 0; i < 750000; i++){
            sb.Append(i.ToString());
            sb.Append(',');
            //s += i.ToString() + ",";
        }
        System.Console.WriteLine(sb.ToString().Length);
        sw.Stop();
        System.Console.WriteLine(sw.Elapsed.ToString());
    }
    public static void Main3(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        string s = "";
        for(int i = 0; i < 50000; i++){
            s += i.ToString() + ",";
        }
        System.Console.WriteLine(s.Length);
        sw.Stop();
        System.Console.WriteLine(sw.Elapsed.ToString());
    }
    public static void Main2(string[] args)
    {
        // string[] lines = File.ReadAllLines("test.txt");
        // File.WriteAllLines("test2.txt",lines);
        if(args.Length > 2 || args.Length < 1)
        {
            System.Console.WriteLine("Usage: Program.exe <input_file>");
            return;
        }
        string outFile = null;
        if(args.Length > 1){
            outFile = args[1];
        }
        int linecount = 0;
        int charcount = 0;
        int wordcount = 0;
        using(StreamReader reader = new StreamReader(args[0])) //"using" automatically put disposal at the end
        {
            string line;
            while(null != (line = reader.ReadLine()))
            {
                linecount++;
                foreach(string s in line.Split(' ', StringSplitOptions.RemoveEmptyEntries))
                {
                    wordcount++;
                    charcount += s.Length;
                }
            }
            //reader.Dispose(); // بستن فایل
        }

        string outstr =  $"{linecount} {charcount} {wordcount}";
        if(outFile != null){
            using(StreamWriter writer = new StreamWriter(outFile))
            {
                writer.WriteLine(outstr);
            }
        }  
        else{
            System.Console.WriteLine(outstr);
        }      
        
    }
}
