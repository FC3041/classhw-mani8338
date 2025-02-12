namespace AverageOfSquares;

class Program
{
    public static double average_of_squares0(int n)
    {
        double total_sum = 0.0;
        for(int i = 0; i < n; i++){
            total_sum += i*i;
        }
        double avg = total_sum / (n-1);
        return avg;
    }
    public static void average_of_squares0Pr(int n)
    {
        double total_sum = 0.0;
        for(int i = 0; i < n; i++){
            total_sum += i*i;
        }
        double avg = total_sum / (n-1);
        Console.WriteLine(avg);
    }

    public static double average_of_squares1(int n)
    {
        double total_sum = 0.0;
        for(int i = 1; i <= n; i++){
            total_sum += i*i;
        }
        double avg = total_sum / n;
        return avg;
    }
    public static void average_of_squares1Pr(int n)
    {
        double total_sum = 0.0;
        for(int i = 1; i <= n; i++){
            total_sum += i*i;
        }
        double avg = total_sum / n;
        Console.WriteLine(avg);
    }
    static void Main(string[] args)
    {
        Console.WriteLine(average_of_squares0(2));
        Console.WriteLine(average_of_squares0(3));
        Console.WriteLine(average_of_squares0(4));
        Console.WriteLine();
        Console.WriteLine(average_of_squares0(5));
        Console.WriteLine(average_of_squares1(4)+"\n");

        average_of_squares0Pr(3);
        average_of_squares1Pr(2);

        Console.WriteLine("average_of_squares0(n) and average_of_squares1(n-1) are equals because in the first one sum of the the n-1 natural numbers are calculted and then devided by n-1 and in the average_of_squares1(n-1) one the sum of the first n-1(input) natural numbers are calculted and then devided by input which is n-1 ");
    }
    
}
