class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(RemoveElement([0, 1, 2, 2, 3, 0, 4, 2],2)); //output 5,  nums = [0,1,4,0,3,_,_,_]
        Console.WriteLine(RemoveElement([3, 2, 2, 3],3)); //output 2, nums = [2,2,_,_]
    }
    public static int RemoveElement(int[] nums, int val)
    {
        int count = 0;  // position for next valid element
        for (int i = 0; i < nums.Length; i++)
        {
           if (nums[i] != val)
           {

                //You must copy valid elements forward (nums[j] = nums[i]), not just count them.
                nums[count] = nums[i];
                count++;
           }
        }
        return count;
    }
}