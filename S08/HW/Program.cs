using System;

class Program
{
    public static void reverseWords(string sentence, out string revSentence)
    {
        revSentence = ""; 
        string word = "";      
        for(int i = sentence.Length - 1; i >= 0; i--){
            if(sentence[i] != ' '){
                word = sentence[i] + word;
            }
            else if(word != ""){
                if (revSentence != ""){
                    revSentence += " ";
                }
                revSentence += word;
                word = ""; 
            }
        }
        if(word != ""){
            if(revSentence != ""){
                revSentence += " ";
            }revSentence += word;
        }
    }
    public static void reverseS2D(string S,out string reS)
    {
        reS = "";
        foreach(char c in S){
            reS = c + reS;
        }
    }

    static void Main(string[] args)
    {
        string S = "friends are valuable";
        string reS;
        string reS2D;

        reverseWords(S, out reS);
        reverseS2D(S,out reS2D);

        Console.WriteLine("the reverse of S \"" + S + "\" is \n" + reS + "\n");
        Console.WriteLine("the reverse2 of S \"" + S + "\" is \n" + reS2D);
    }
}
        
