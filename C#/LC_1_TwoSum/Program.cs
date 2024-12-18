using System.Data;

public class Program
{
    public static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = TwoSum(nums, target);
        foreach (int i in result)
        {
            Console.Write(i + " ");
        }
    }
    
    public static int[] TwoSum(int[] nums, int target)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    result.Add(i);
                    result.Add(j);
                }
            }
        }
        return result.ToArray();
    }
}