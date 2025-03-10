#include<iostream>
#include<stdlib.h>

class List{
    public:
        int m_size;
        int m_capcacity;
        int* m_nums;

        List():m_size(0),m_capcacity(0),m_nums(nullptr){}

        List(int size,int capacity,int* nums):m_size(size),m_capcacity(capacity){
            m_nums = (int*)malloc(sizeof(int)*m_capcacity);
            int i;
            for(i = 0; i < m_size; i++){
                *(m_nums+i) = *(nums+i);
            }            
        }

        void print_list()
        {
            std::cout <<"[";
            for(int i = 0; i < m_size; i++){
                if(i == m_size-1){
                    std::cout << m_nums[i] << "]" << std::endl;
                }else{
                    std::cout << m_nums[i] << ", ";
                }
            }
        }

        int my_min()
        {
            int min = m_nums[0];
            for(int i = 0; i < m_size; i++){
                if(m_nums[i] < min){
                    min = m_nums[i];
                }
            }return min;
        }

        void erase(int value)
        {
            for(int i = value; i < m_size-1; i++){
                m_nums[i] = m_nums[i+1];
            }
            m_size--;
        }

        int find_first_index(int value)
        {
            for(int i = 0; i < m_size; i++){
                if(m_nums[i] == value){
                    return i;
                }
            }return -1;
        }
        void sort()
        {
            int OriginalSize = m_size;
            int* nums = (int*)malloc(sizeof(int)*m_capcacity);
            for(int i = 0; m_size != 0; i++){
                int min = my_min();
                erase(find_first_index(min));
                nums[i] = min;
            }
            for(int i = 0; i < OriginalSize; i++){
                m_nums[i] = nums[i];
            }
            m_size = OriginalSize;
            free(nums);
        }

};

int main()
{
    int nums[10] = {12,3,4,19,0,13,-1,9,9,3};
    List L1(10,20,nums);
    L1.sort();
    L1.print_list();

    int nums2[8] = {83,83,83,83,83,83};
    List L2(5,10,nums2);
    L2.sort();
    L2.print_list();

    int nums3[1] = {6};
    List L3(1,1,nums3);
    L3.sort();
    L3.print_list();
    
    return 0;
}