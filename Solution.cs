public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
      var seenItems = new Dictionary<int, int>();
      var result = new int[2];
        
      for (int i = 0; i < nums.Length; i++)
      {
        var diff = target - nums[i];
        if(seenItems.ContainsKey(diff))
        {
          result[0] = i;
          result[1] = seenItems[diff];
          break;
        }
        else
        {
          seenItems[nums[i]] = i;
        }
      }
		
      return result;
    }
}
