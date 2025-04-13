
public class Student{
    private string name;
    private int stdid;
    private int natid;
    private int credits;
    private bool active;

    public Student(string name,int stdid,int natid,int credits,bool active)
    {
        this.name = name;
        this.stdid = stdid;
        this.natid = natid;
        this.credits = credits;
        this.active = active;
    }

    // 
    
    public override string ToString() =>
        $"{name},{stdid},{natid},{credits},{active}";
    //another way of doing the above thing

    public void printme() => Console.WriteLine(this.ToString);

    public static Student Parse(string str)
    {
        string[] tokens = str.Split(',');
        var name = tokens[0];
        var stdid = int.Parse(tokens[1]);
        var natid = int.Parse(tokens[2]);
        var credits = int.Parse(tokenss[3]);
        var active = bool.Parse(tokens[4]);
        return new Student(name,stdid,natid,credits,active);
    }
    public override bool Equals(object obj)
    {
        Student other = (Student) obj;
        return 
            name.Equals(other.name) &&
            stdid.Equals(other.name) &&
            natid.Equals(other.name) &&
            credits.Equals(other.name) &&
            active.Equals(other.name);
    }
}
