#include<iostream>

using namespace std;

class MyStr{
    public:
        int m_size;
        char* m_PChars;

        MyStr(): m_size(0),m_PChars(nullptr){};

        MyStr(const char* chars){
            m_PChars = (char*)malloc(sizeof(char)*m_size);
            int i;
            for(i = 0; chars[i] != '\0'; i++);
            m_size = i+1;

            for(i = 0; i < m_size; i++){
                m_PChars[i] = chars[i];
            }m_PChars[m_size] = '\0'; 
        }

        MyStr(const char* chars, int start, int count):m_size(count)
        {
            m_PChars = (char*)malloc(sizeof(char)*m_size);
            int i;
            for(i = 0; chars[i] != '\0'; i++){
                m_PChars[i] = chars[start+i];
            }m_PChars[count] = '\0';           
        }
        void printStr()
        {
            cout << m_PChars << endl;
        }
};

int main()
{
    MyStr s1;

    MyStr s2("Malihe Hajihosseini",7,12);
    s2.printStr();

    return 0;
}