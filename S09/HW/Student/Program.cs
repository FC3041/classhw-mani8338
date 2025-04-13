using System.IO;

namespace Studnet
{
    class Program
    {
        class Student
        {
            private string m_fname;
            private string m_lname;
            private int m_stdId;
            private int m_coursesPassed;
            private double m_GPA;

            public Student(string fname, string lname, int stdId, int coursesPassed, double GPA)
            {
                this.m_fname = fname;
                this.m_lname = lname;
                this.m_stdId = stdId;
                this.m_coursesPassed = coursesPassed;
                this.m_GPA = GPA;
            }

            public string ToCsv()
            {
                return m_fname + "," + m_lname + "," + m_stdId + "," + m_coursesPassed + "," + m_GPA;
            }

            public static Student Parse(string csvLine)
            {
                string[] parts = csvLine.Split(',');
                return new Student(
                    parts[0], 
                    parts[1], 
                    int.Parse(parts[2]), 
                    int.Parse(parts[3]), 
                    double.Parse(parts[4]));
            }

            public void Print()
            {
                System.Console.WriteLine("Name: " + m_fname + " " + m_lname + "  StudentID: " + m_stdId +
                                         "  Courses Passed: " + m_coursesPassed +"  GPA: " + m_GPA.ToString());
            }

            public int Credits()
            {
                return m_coursesPassed;
            }
        }

        static void Main(string[] args)
        {
            const string fileName = "students.csv";
            Student[] students = new Student[20];
            int count = 0;

            if(File.Exists(fileName)){
                string[] lines = File.ReadAllLines(fileName);
                foreach(var line in lines){
                    var student = Student.Parse(line);
                    students[count++] = student;
                    Console.WriteLine("Loaded student with credits: " + student.Credits);
                }
            }

            if(args.Length == 0){
                Console.WriteLine("Use list to list all students or give me student details (FirstName LastName ID CoursesPassed GPA)");
                return;
            }

            if(args[0] == "list"){
                if (count == 0){
                    Console.WriteLine("No students found.");
                }else{
                    for(int i = 0; i < count; i++){
                        students[i].Print();
                    }
                }
            }else{
                if (args.Length >= 5){
                    string fname = args[0];
                    string lname = args[1];
                    if(int.TryParse(args[2], out int stdId) && int.TryParse(args[3], out int coursesPassed) && double.TryParse(args[4], out double GPA)){
                        if(count < students.Length){
                            students[count++] = new Student(fname, lname, stdId, coursesPassed, GPA);
                            Console.WriteLine("Student " + fname + " " + lname + " with ID " + stdId + " registered successfully!");

                            File.AppendAllLines(fileName,new[]{students[count-1].ToCsv()});
                        }else{
                            Console.WriteLine("Maximum reached");
                        }
                    }else{
                        Console.WriteLine("student Id and GPA should be double. courses passed should be integer");
                    }
                }else{
                    Console.WriteLine("Enter the information correctly");
                }
            }
        }
    }
}
