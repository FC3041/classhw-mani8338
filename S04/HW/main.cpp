#include<iostream>
#include<vector>
#include<string>

int main()
{
    std::vector<int>nums;
    for(int i = 0; i < 83; i++){
        std::cout << "capacity: " << nums.capacity() << "\t" << "size: "<< nums.size()<< std::endl;
        nums.push_back(i);
    }
    return 0;
}