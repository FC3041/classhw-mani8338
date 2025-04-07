public interface IPerson<_Type>
{
    string FirstName { get; set; }
    string LastName { get; set; }
    string FullName { get; }
}
public class Student: IPerson, IComparable<Student>
{
    public string FirstName { get; set; }   
    public string LastName { get; set; }

    public string FullName
    {
        get
        {
            return FirstName+" "+LastName;
        }
    }
    public double GPA{get;set;}
    public override string ToString() => $"{FullName}\t{GPA}";
}

public class Teacher: IPerson
{
    public string FirstName { get; set; }   
    public string LastName { get; set;}

    public string FullName
    {
        get
        {
            return FirstName+" "+LastName;
        }
    }
}