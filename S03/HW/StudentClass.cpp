#include<iostream>
#include<string.h>
#include<stdlib.h>
const int COURSE4 = 50;

using namespace std;


class Student{
    public:
        char m_FirstName[20];
        char m_LastName[20];
        int m_StdId;
        int m_Credits[COURSE4];
        int m_CoursesPassed;
        char* m_CourseName[COURSE4];
        double m_Grades[COURSE4];

        double Calculate_GPA()
        {
            double Sum_of_Grades = 0;
            double Sum_of_Credits = 0;
            for(int i = 0; i < m_CoursesPassed; i++){
                Sum_of_Grades += m_Grades[i] * m_Credits[i];
                Sum_of_Credits += m_Credits[i];
            }
            return Sum_of_Grades / Sum_of_Credits;
        }

        void ListCourses()
        {
            for(int i = 0; i < m_CoursesPassed; i++){
                cout <<m_CourseName[i]<<"-> "<<m_Credits[i]<<" -> "<< m_Grades[i]<< endl;
            } 
        }

        Student()
        {
            cout <<"Please Enter your Fitst Name: ";
            cin >> m_FirstName;
            cout << "Please Enter your Last Name: ";
            cin >> m_LastName;
            cout << "Please Enter your Student Id: ";
            cin >> m_StdId;
            
            m_CoursesPassed = 0;
        }

        void giveInfo()
        {
            cout << "name: " << m_FirstName << " " << m_LastName << endl;
            cout << "student id: " << m_StdId << endl;
        }

        void register_course(int credits, const char* name,double grade)
        {
            m_Credits[m_CoursesPassed] = credits;
            m_Grades[m_CoursesPassed] = grade;
            char* namecopy = new char[strlen(name)+1];
            strcpy(namecopy,name);
            m_CourseName[m_CoursesPassed] = namecopy;
            m_CoursesPassed++;
        }

        ~Student(){
            for(int i = 0; i < m_CoursesPassed; i++){
                delete[]m_CourseName[i];
            }
        }
};

int main()
{
    Student s;
    s.m_CoursesPassed = 0;
    int credits;
    double grade;
    char buffer[20];

    //Student();
    
    while(true){
        cout << "Course Name? ";
        cin >> buffer;
        if(*buffer == '/'){
            break;
        }
        cout << "Credits of " << buffer << "? ";
        cin >> credits;
        if(credits <= 0){
            break;
        }
        cout << "Your grade in " << buffer << "? ";
        cin >> grade;
        if(!(0 <= grade && grade <= 20)){
            break;
        }
        s.register_course(credits,buffer,grade);
    }
    s.giveInfo();
    s.ListCourses();
    cout << "GPA = "<<s.Calculate_GPA() << endl;

    return 0;
}