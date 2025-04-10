import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class LongestConsecutiveSequence
{
    public static void main(String[] args) {
        int[] nums = {9,1,-3,2,4,8,3,-1,6,-2,-4,7};
        int result = LongestConsecutiveUsingList(nums);
        int result2 = LongestConsecutive(nums);
        System.out.println(result);
        System.out.println(result2);
    }

    public static int LongestConsecutive(int[] nums) {
        Arrays.sort(nums);
        int count = 1;
        int result = 0;
        int index = 0;
        do{
            for(int i = index; i < nums.length-1; i++){
                index = i;
                if(nums[i] == nums [i+1])
                    continue;
                else if(nums[i] + 1 == nums[i+1])
                    count++;
                else 
                    break;
            }
            if(count > result)
                result = count;
            index = index +1;
            count = 1;
        }while (index + 1 < nums.length);
        return result;
    }

    public static int LongestConsecutiveUsingList(int[] nums){ //O(n)
        if(nums.length ==0)
            return 0;
        List<Integer> numbers = new ArrayList<>();
        int result = 0;
        int count = 1;
        for(Integer num : nums){
            if(!numbers.contains(num))
                numbers.add(num);
        }
        int numToCompare = numbers.get(0);
        boolean noMore = true;
        do{
            count = 1;
            numToCompare = numbers.get(0);
            do{
                noMore = true;
                if(numbers.contains(numToCompare - count)){
                    numbers.remove(numbers.indexOf((numToCompare - count)));
                    noMore = false;
                    count++;
                }
            }while(!noMore);
            do{
                noMore = true;
                if(numbers.contains(numToCompare + 1)){
                    count++;
                    numbers.remove(numbers.indexOf((numToCompare + 1)));
                    numToCompare++;
                    noMore = false;
                }
            }while(!noMore);
            if(count > result)
                result = count;
            numbers.remove(0);
        }while(numbers.size()!=0);
        return result;
    }
    
}