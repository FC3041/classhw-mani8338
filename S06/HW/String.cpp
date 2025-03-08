#include<iostream>
#include<stdlib.h>

int strLen(char* str)
{
    int len = 0;
    for(int i = 0; str[i] != '\0'; i++){
        len++;
    }return len;
}

class String{
    public:
        int m_size;
        char* m_str;

    String():m_size(0),m_str(nullptr){};

    String(int size,const char* str):m_size(size)
    {
        m_str = (char*)malloc(sizeof(char)*(m_size+1));
        for(int i = 0; i < m_size; i++){
            *(m_str+i) = *(str+i);
        }*(m_str+m_size) = '\0';
    }
    ~String(){
        free(m_str);
    }
    
    void print_string()
    {
        for(int i = 0; i < m_size; i++){
            std::cout << *(m_str+i);
        }std::cout << "\n";
    }

    int len()
    {
        return m_size;
    }

    void add(char* str,char*& strDst) // s1+s2 will be put inside of strDst
    {
        int newSize = m_size + strLen(str);
        strDst = (char*)malloc(sizeof(char)*(newSize+1));
        for(int i = 0; i < m_size; i++){
            *(strDst+i) = *(m_str+i);
        }
        for(int i = 0; i < strLen(str); i++){
            *(strDst+i+m_size) = *(str+i);
        }*(strDst+newSize) = '\0';      
    }

    bool is_in(char* sub)
    {
        int lenSub = strLen(sub);
        if(m_size < lenSub){
            return false;
        }else{
            for(int i = 0; i <= m_size-lenSub; i++){
                bool Continue = true;
                for(int j = 0; j < lenSub; j++){
                    if(*(m_str+i+j) != *(sub+j)){
                    Continue = false;
                    break;
                    }
                }
                if(Continue){
                    return true;
                }                
            }return false;
        }
    }
};

int main()
{
    char sTr[14] = "Salm Tor Iraj";
    char sTr1[5] = {'S','a','l','m'};
    char sTr2[4] = {'T','o','r'};
    char sTr3[5] = {'I','r','a','j'};
    char* sTr4 = nullptr;
    char sTr5[10] = "Manuchehr";
    char sTr6[6] = "SalmR";
    String s(13,sTr);
    s.print_string();
    std::cout << s.len() << std::endl;
    
    String s1(4,sTr1);
    String s2(3,sTr2);
    String s3(4,sTr3);
    String s4(0,sTr4);
    String s5(9,sTr5);

    s2.add(sTr3,sTr4);
    std::cout << sTr4 << std::endl << std::endl;

    if(s.is_in(sTr1)){
    std::cout<< "True" << std::endl;
    }else{
        std::cout << "False" << std::endl;
    }
    if(s.is_in(sTr5)){
    std::cout<< "True" << std::endl;
    }else{
        std::cout << "False" << std::endl;
    }
    if(s.is_in(sTr6)){
    std::cout<< "True" << std::endl;
    }else{
        std::cout << "False" << std::endl;
    }

    return 0;
}