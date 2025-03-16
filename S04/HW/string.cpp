#include<iostream>
#include<cstdlib>

class String{
    public:
        int m_length;
        char* m_str;

    String():m_length(0),m_str(nullptr){}

    String(int size,const char* str):m_length(size){
        int Size = m_length+1;
        // m_length++;
        int x;
        m_str = (char*)malloc(sizeof(char)*Size);
        for(int i = 0; i <= m_length; i++){
            *(m_str+i) = *(str+i);
            x = i;
        }*(m_str+x) = '\0';
    }

    void print_string()
    {
        std::cout << "\"";;
        for(int i = 0; i < m_length; i++){
            std::cout << *(m_str+i);            
        }std::cout << "\"" << std::endl;  
    }

    void append_char(char c)
    {
        // m_length++;
        // m_str = (char*)realloc(m_str,sizeof(char)*m_length);
        resize(m_length+1);
        *(m_str+m_length-2) = c;
        *(m_str+m_length-1) = '\0';
    }

    void assign(int newLen,const char* sTr)
    {
        newLen++;
        resize(newLen);
        for(int i = 0; i < newLen; i++){
            *(m_str+i) = *(sTr+i);
        }
    }

    void append(String s1,String s2)
    {
        int newSize = s1.m_length+s2.m_length-1;
        char* newStr = (char*)malloc(sizeof(char)*newSize);
        for(int i = 0; i < s1.m_length-1; i++){
            newStr[i] = s1.m_str[i];
        }
        for(int i = 0; i < s2.m_length; i++){
            newStr[s1.m_length-1+i] = s2.m_str[i];
        }
        newStr[newSize-1] = '\0';
        free(m_str);
        m_str = newStr;
        m_length = newSize;
    }
    int count(char c)
    {
        int Count = 0;
        for(int i = 0; i < m_length;i++){
            if(m_str[i] == c){
                Count++;
            }
        }return Count;
    }
    void next_line()
    {
        std::cout<<"\n";
    }

    int size()
    {
        return m_length;
    }

    private:
        void resize(int newSize){
            newSize++;
            m_str = (char*)realloc(m_str,sizeof(char)*newSize);
            m_length = newSize-1;
        }  
};

int main()
{
    // String 1
    char sTr[7] = "Rostam";
    int length = 6;
    String s(length,sTr);
    // String 2
    char sTr2[4] = " & ";
    int length2 = 3;
    String s2(length2,sTr2);
    // String 3
    char sTr3[7] = "Sohrab";
    int length3 = 6;
    String s3(length3,sTr3);
    // String 4
    char sTr4[9] = "Fereydun";
    int length4 = 8;
    String s4(length4,sTr4);
    // String 5
    char* sTr5;
    int length5 = 0;
    String s5(length5,sTr5);
    // String 6
    char sTr6[15] = "Rostam Zal Sam";
    int length6 = 14;
    String s6(length6,sTr6);
    // String 7
    char sTr7[9] = "Siyavash";
    int length7 = 8;
    String s7(length7,sTr7);
    // String 8
    char sTr8[9] = {'A','f','r','a','s','i','a','b'};
    int length8 = 8;
    String s8(length8,sTr8);

    std::cout << " Print" << std::endl;
    s.print_string();
    std::cout <<""<< std::endl;

    std::cout << "  Append_char" << std::endl;
    s4.print_string();
    s4.append_char('K');
    s4.print_string();
    std::cout <<""<< std::endl;

    std::cout << "Append" << std::endl;
    s.print_string();
    s2.print_string();
    s3.print_string();
    s5.append(s,s2);
    s5.append(s5,s3);
    s5.print_string();
    std::cout <<""<< std::endl;

    std::cout << "     count" << std::endl;   
    s6.print_string();
    std::cout << s6.count('a') << std::endl;
    std::cout <<""<< std::endl;

    std::cout << "assign and next line and size" << std::endl;
    s7.assign(11,"Kay Khosrow");
    s7.print_string();
    s7.next_line();
    s8.print_string();
    std::cout<<s8.size()<<std::endl;


    return 0;
}