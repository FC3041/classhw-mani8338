#include<iostream>
#include<stdlib.h>

using namespace std;

class Mylist{
    public:
        int m_size;
        int* m_Pnums;

    Mylist(int size,int* nums):m_size(size){
        nums = (int*) malloc(sizeof(int)*size);
        int i;
        for(i = 0; i < m_size; i++){
            m_Pnums[i] = nums[i];
        }
    }

    private:
    void resize(int newsize)
    {
        int* newMem = (int*)malloc(sizeof(int)*newsize);
        for(int i = 0; i < m_size; i++){
            newMem[i] = m_Pnums[i];
        }
        free(m_Pnums);
        m_size = newsize;
        m_Pnums = newMem;
    }

    public:
    void append(int n){
        resize(m_size+1);
        m_Pnums[m_size-1] = n;
    }
};

int main()
{
    int nums[5] = {1,2,3,4,5};
    Mylist L(5,nums);
    // for(int i = 0; i < 5; i++){
    //     cout << nums[i] << endl;
    // }
    L.append(14);
    cout << nums[5] << endl;
}