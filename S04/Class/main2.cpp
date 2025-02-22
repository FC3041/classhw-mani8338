#include<iostream>
#include<string.h>

class Date{
    int day;
    int month;
    int year;
};

class Person{
    public:
        int m_NID;
        char m_fname[20];
        char m_lname[20];
        Date m_BD;

        Person(int NID,char* fname,char* lname,Date BD):m_NID(NID),m_BD(BD){
            int x,y;
            for(int i = 0; i < sizeof(m_fname) && fname[i] != '\0'; i++){
                m_fname[i] = fname[i];
                x = i;
            }m_fname[x] = '\0';

            for(int j = 0; j < sizeof(m_lname) && lname[i] != '\0'; j++){
                m_lname[j] = lname[j];
                y = j;
            }m_lname[y] = '\0';
        };  

        void print_person()
        {
            std::cout<<"Name: " <<m_fname<<std::endl;
            std::cout<<"Family: "<<m_lname<<std::endl;
        }
};

int main()
{
    Date d;
    Person

}