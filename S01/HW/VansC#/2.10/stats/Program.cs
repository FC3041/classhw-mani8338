namespace stats;

class Program
{
    public static int min(int[] nums,int size)
    {
        int min = nums[0];
        for(int i = 0; i < size; i++){
            if (nums[i] < min){
                min = nums[i];
            }
        }return min;
    }
    public static int max(int[] nums,int size)
    {
        int max = nums[0];
        for(int i = 0; i < size; i++){
            if (nums[i] > max){
                max = nums[i];
            }
        }return max;
    }
    public static double average(int[] nums,int size)
    {
        int total_sum = 0;
        for(int i = 0; i < size; i++){
            total_sum += nums[i];
        }
        double avg = total_sum/(double)size;
        return avg;
    }
    static void Main(string[] args)
    {
        int[] nums = new int[40];
        string input;
        int i = 0;
        bool go = true;
        double total_sum = 0.0;
        while(go){
            Console.Write("Give me an integer(type -1 if you want to stop): ");
            input = Console.ReadLine();
            if(int.TryParse(input,out int x))
            {
                if(x == -1){
                    go = false;
                }
                else{
                    total_sum += x;
                    nums[i] = x;
                    i++;
                }
            }
            else{
                Console.WriteLine("a valid int please!");
            }
        }
        if(i > 0){
            Console.WriteLine("number of entries = "+i);
            Console.WriteLine("average = "+total_sum/(i));
            Console.WriteLine("minimum = "+min(nums,i));
            Console.WriteLine("maximum = "+max(nums,i));
           
        }
        else{
            Console.WriteLine("No Valid int was given");
        }
       
   
    }
}
