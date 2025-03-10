#include<iostream>
#include<string.h>
#include<stdlib.h>

using namespace std;

class Student{
    public:
    int m_stdNum; //m_ is member variable. it is better to use in Classes to recognize variables in Classes
        char m_FirstName[20];
        char m_LastName[20];
        int m_CoursesPassed;
        int m_Credits[40];
        double m_Grades[40];
        char* m_CourseNames[40];

        double GetGPA()
        {
            double sumGrade = 0;
            double sumCredits = 0;
            for(int i = 0; i < m_CoursesPassed; i++){
                sumGrade += m_Credits[i] * m_Grades[i];
                sumCredits += m_Credits[i];
            }
            return sumGrade / sumCredits;

        }
        void list_courses()
        {
            for(int i = 0; i < m_CoursesPassed; i++){
                cout << m_CourseNames[i] <<": "<<m_Credits[i]<<": "<<m_Grades[i] <<endl;
            }
        }
        void register_course(int credits,const char* name,double grade){
            m_Credits[m_CoursesPassed] = credits;
            m_Grades[m_CoursesPassed] = grade;
            char* namecopy = new char[strlen(name)+1];
                //(char*) malloc(strlen(name)+1);
            strcpy(namecopy,name);
            m_CourseNames[m_CoursesPassed] = namecopy;
            m_CoursesPassed++;
        }
};

int main()
{
    Student s;
    s.m_CoursesPassed = 0;
    char bufc[20];
    double grade;
    int credits;
    while(true){
        cout << "course name? ";
        cin >> bufc;
        if(*bufc == 'A'){
            break;
        }
        cout << "course credits? ";
        cin >> credits;
        cout << "course grade? ";
        cin >> grade;
        s.register_course(credits,bufc,grade);

    }
    s.list_courses();
    cout << s.GetGPA() << endl;

    return 0;
}