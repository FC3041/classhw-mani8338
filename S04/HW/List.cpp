#include<iostream>
#include<stdlib.h>

using namespace std;

class List{
    public:
        int m_length;
        int m_capacity;
        double* m_nums;

        List():m_length(0),m_capacity(0),m_nums(nullptr){}

        List(int size,double* nums):m_length(size),m_capacity(size){
            m_nums = (double*)malloc(sizeof(double)*m_capacity);
            for(int i = 0; i < m_length; i++){
                *(m_nums+i) = *(nums+i);
            }
        }
        ~List(){free(m_nums);}

        void print_List()
        {
            cout <<"[";    
            for(int i = 0; i < m_length; i++){
                if(i == m_length-1){
                    cout << m_nums[i] <<"]" << endl;
                }
                else{
                    cout << m_nums[i] << ", ";
                }               
            }    
        }
        
        private:
            void resize(double newSize)
            {
                m_nums = (double*)realloc(m_nums,sizeof(double)*newSize);
                m_length = newSize;
            }

            void resize2() {
            if(m_capacity == 0){
                m_capacity = 1;
            }else{
                m_capacity *= 2;
            }m_nums = (double*)realloc(m_nums,sizeof(double) * m_capacity);
            }

        public:
            void append(int n) {
            if(m_length >= m_capacity){
                resize2();
            }m_nums[m_length++] = n;
            }

            void add_Lists(List L2)
            {
                int OldSize = m_length;
                resize(m_length+L2.m_length);
                for(int i = OldSize; i < OldSize+L2.m_length; i++){
                    m_nums[i] = *(L2.m_nums+i-OldSize);
                }
            }

            void pop(int n)
            {
                double* newArray = (double*)malloc(sizeof(double)*m_length);
                for(int i = 0; i < m_length; i++){
                    *(newArray+i) = *(m_nums+i);
                }
                resize(m_length-1);
                for(int i = 0; i < n; i++){
                    *(m_nums+i) = *(newArray+i);
                }
                for(int i = n+1; i < m_length; i++){
                    *(m_nums+i-1) = *(newArray+i);
                }
            }
            int count(int x)
            {
                int n = 0;
                for(int i = 0; i < m_length; i++){
                    if(m_nums[i] == x){
                        n++;
                    }                    
                }return n;
            } 
            int find_first_index(int x)
            {
                int y;
                for(int i = 0; i < m_length; i++){
                    y = i;
                    if(m_nums[i] == x){
                        break;
                    }
                }return y;
            } 
            void reverse()
            {
                double* newArray = (double*)malloc(sizeof(double)*m_length);
                for(int i = 0; i < m_length; i++){
                    *(newArray+i) = *(m_nums+i);
                }
                for(int i = 0; i < m_length; i++){
                    *(m_nums+i) = *(newArray+m_length-i-1);
                }
            }  

            void clear()
            {
                m_length = 0;
                m_nums = nullptr;
            }     
};

int main()
{
    // print the list
    double nums[6] = {0x53,0x61,0x72,0x69,0x6E,0x61};
    int length = 6;
    // append 
    double nums2[4] = {0x1,0x2,0x7,0x9};
    int length2 = 4;
    // add lists
    double nums3[7] = {2,4,6,7,7,5,3};
    double nums4[4] = {-1,0,2,6};
    int length3 = 7;
    int length4 = 4;
    // pop
    double nums5[8] = {1,2,3,87,5,41,7,8};
    int length5 = 8;
    // count
    double nums6[10] = {1,2,3,6,6,6,1,6,9,6};
    int length6 = 10;
    // find index
    double nums7[6] = {83,97,114,105,115,98};
    int length7 = 6;
    // reverse
    double nums8[5] = {7,7,9,5,5};
    int length8 = 5;
    // clear
    double nums9[7] = {0x83,0x93,0x88,0x78,0x65,0x87,0x87};
    int lenght9 = 7;

    
    cout << "        Print List1" << endl;
    List L1(length,nums);
    L1.print_List();
    cout << "" << endl;

    cout << "    Append" << endl;
    List L2(length2,nums2);
    L2.append(6);
    L2.print_List();
    cout << "" << endl;

    cout << "               L3+L4" << endl;
    List L3(length3,nums3);
    List L4(length4,nums4);
    L3.add_Lists(L4);
    L3.print_List();
    cout << "" << endl;

    cout << "         Pop" << endl;
    List L5(length5,nums5);
    L5.print_List();
    L5.pop(2);
    L5.print_List();
    cout << "" << endl;

    cout << "count" << endl;
    List L6(length6,nums6);
    cout<< L6.count(6) << endl;
    cout << "" << endl;

    cout <<"find index" << endl;
    List L7(length7,nums7);
    cout << L7.find_first_index(114) << endl;
    cout << "" << endl;

    cout <<"    reverse" << endl;
    List L8(length8,nums8);
    L8.reverse();
    L8.print_List();
    cout << "" << endl;

    cout << " clear " << endl;
    List L9(lenght9,nums9);
    L9.clear();
    L9.print_List(); 


    return 0;
}