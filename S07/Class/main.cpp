#include<iostream>
#include<vector>
#include<string>
#include<stdio.h>
#include<windows.h>


using namespace std;

class myVector{
    public:
        myVector(int capacity=10):m_capacity(capacity),m_buffer(new int[capacity])
        {}
        ~myVector()
        {
            delete [] this -> m_buffer;
            this -> m_capacity = 0; //this -> is a pointer to this class 
        }

        void add(int e)
        {
            m_buffer[m_size] = e;
            m_size++;
        }

        int at(int idx)
        {
            return m_buffer[idx];
        }
    private:
        int m_capacity;
        int m_size;
        int* m_buffer;
};

int main2()
{
    myVector v;
    v.add(2);
    v.add(5);

    cout << v.at(0) << " " << v.at(1) << endl;

    return 0;
}

class myfile
{
    string m_filename;
    FILE* m_fileHandle;

    public:
        myfile(const string& filename): m_filename(filename){
            m_fileHandle = fopen(m_filename.c_str(),"r");
        }
        ~myfile()
        {
            fclose(m_fileHandle);
        }
        void writeln(const string& str)
        {
            fprintf(m_fileHandle,str.c_str());
        }
};

// TODO 1
// KeepTime:
// {
//     keepTime("for loop")
//  ..
// ..
//}

int main()
{
    unsigned long long l = GetTickCount64();
    cout << l << endl;
    l = GetTickCount64();
    // myfile f("test.txt");
    // f.writeln("test\n");
    return 0;
}


// GetThickCount