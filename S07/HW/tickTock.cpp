#include<iostream>
#include<windows.h>

void f()
{
    long long sum = 0;
    for(int i = 0; i < 10000; i++){
        for(int j = 0; j <= i; j++){
            sum += j + j;
        }
    }
}

void f2()
{
    long long result = 0;
    long long i = 10000000000;
    while(i >= 0){
        result = i * 2;
        if(result % 3 == 0){
            i -= 3;
        }else if(result % 3 == 1){
            i -= 2;
        }else{
            i -= 1;
        }
    }
}

class KeepTime{
    public:
        unsigned long long l1;
        unsigned long long l2;

        KeepTime():l1(GetTickCount64()){
            f();
            l2 = GetTickCount64();
            std::cout << l2 - l1 << std::endl;
        }

        KeepTime(int n):l1(GetTickCount64()){
            f2();
            l2 = GetTickCount64();
            std::cout << l2 - l1 << std::endl;
        }
};

int main()
{
    KeepTime t1;
    KeepTime t2(2);

    std::cout << "\nIf you want to check other stuff just change f or f2 to what you want." << std::endl;
    return 0;
}

