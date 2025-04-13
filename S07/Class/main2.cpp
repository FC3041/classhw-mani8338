#include<iostream>

class bigobj{
    char buf[1000*1000];
};

void mest(bigobj& b)
{
    std::cout << "done mest" << std::endl;
}
void test(bigobj& b)  /*if we don't include & or * then this 1 MB will be copied to a point where stack 
can't handle it anymore so we use addrease to avoid this problem*/ 
{
    mest(b);
    std::cout << "done test" << std::endl;
}

int main()
{
    bigobj bo;   //stack has a limited memory
    bigobj* pbo = new bigobj; // on hip
    std::cout << "done" << std::endl;

    test(bo);

    return 0;
}