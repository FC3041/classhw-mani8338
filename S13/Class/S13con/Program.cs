namespace S13con;

class Program
{
    // public static void PrintPerson(Student s)
    // {
    //     System.Console.WriteLine(s.FullName);
    // }
    // public static void PrintPerson(Teacher t)
    // {
    //     System.Console.WriteLine(t.FullName);
    // }
    public static void PrintPerson(IPerson ps)
    {
        foreach(var p in ps)
        {
            System.Console.WriteLine(p.FullName);
        }
    }
    public static void Main(string[] args)
    {
        Student[] students = new Student[]{
            new Student{FirstName = "Ali",LastName = "Hamedi", GPA =18.5},
            new StudentStudent{FirstName = "AA",LastName="BB",GPA=16.5}
        };
        Teacher t = new Teacher(){
            FirstName = "sssss",LastName = "oooooo",
        };
        PrintPerson(s);PrintPerson(t);
    }
}
