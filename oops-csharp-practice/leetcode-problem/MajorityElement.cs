public class Solution {
    public int MajorityElement(int[] nums) {
        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if(!dict.ContainsKey(num))
                dict.Add(num, 1);
            else
                dict[num] += 1;
        }
        int biggest = dict.Values.Max();
        
        return dict.First(k => k.Value == biggest).Key;
    }
}