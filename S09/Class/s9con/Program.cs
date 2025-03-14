namespace s9con;

class Program
{
    static void Main(string[] args)
    {
        int x = int.Parse("534");
        int y = 5;
        if(y.CompareTo(x) > 0){
            Console.WriteLine("-");
        }
        Console.WriteLine(y.ToString());

        int i = 5; // on stack. Boxing
        object o = i; // it goes to heep. Everything can turn into object
        int n = (int) o; // Unboxing

        Student s = new Student(
            name: "Zhale Hosseini",
            stdid: 403521,
            natid: 837743647,
            credits: 17,
            active: true);
        Console.WriteLine(s);

        string str = "Zhale Hosseini,403521,837743647,17,True";
        Student sc = Student.Parse(str);
        Console.WriteLine(sc);
    }
}
