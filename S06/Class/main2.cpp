#include<iostream>
#include<stdlib.h>
#include<stdexcept>

using namespace std;

template<typename T>

class MyList{
    public:
        int m_size;
        int m_capacity;
        T* m_pNums;

        MyList():m_size(0),m_capacity(0),m_pNums(nullptr){};

        MyList(int size,int capacity,T* nums):m_size(size),m_capacity(capacity){
            m_pNums = (T*)malloc(sizeof(T)*capacity);
            for(int i = 0; i < m_size; i++){
                m_pNums[i] = nums[i];
            }
        }
        void print_list()
        {
            cout << "size: " << m_size << "\tcapacity: " << m_capacity << endl;
            for(int i = 0; i < m_size; i++){
                cout << m_pNums[i] << ",";
            }cout <<"\n";
        }
        int len(){return m_size;}

        void append(T value)
        {
            if(m_size == m_capacity)
            {
                if(m_size == 0){resize(1);}
                else{
                    resize(m_capacity*2);
                }
            }
            m_pNums[m_size] = value;
            m_size++;
        }

        void insert(int index,T value)
        {
            if(m_size == m_capacity)
            {
                if(m_size == 0){resize(1);}
                else{
                    resize(m_capacity*2);
                }
            }
            for(int i = m_size; i > index; i--){
                m_pNums[i] = m_pNums[i-1]; 
            }
            m_pNums[index] = value;   
            m_size++;
        }
        
        void reverse()
        {
            T* newArray = (T*)malloc(sizeof(T) * m_size);
            for(int i = 0; i < m_size; i++){
                newArray[i] = m_pNums[i];
            }
            for(int i = 0; i < m_size; i++){
                m_pNums[i] = newArray[m_size - i - 1];
            }
            free(newArray);
        }
        T at(int index)
        {
            if((index < m_size) && (index > -1)){
                return m_pNums[index];
            }
            throw out_of_range("index out of range");
        }

    private:
        void resize(int newSize)
        {
            T* newNums = (T*)malloc(sizeof(T)*newSize);
            for(int i = 0; i< m_size; i++){
                newNums[i] = m_pNums[i];
            }
            free(m_pNums);
            m_pNums = newNums;
            m_capacity = newSize;
        }
};

int main()
{
    MyList<int>l2;

    int nums[5] = {1,2,3,4,5};
    MyList L1(5,10,nums);
    L1.print_list();
    L1.insert(1,9);
    L1.print_list();
    L1.insert(1,7);
    cout <<L1.len()<<endl;
    L1.reverse();
    L1.print_list();

    return 0;
}