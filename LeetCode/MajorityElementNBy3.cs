public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        int first = Int32.MaxValue;
        int second = Int32.MaxValue;
        int count1=0, count2 =0;
        int n = nums.Length;
        
        for(int i=0;i<n;i++){
            if(first == nums[i])
                count1++;
            else if(second == nums[i])
                count2++;
            
            else if(count1==0){
                first = nums[i];
                count1 =1;
            }
            else if(count2 ==0){
                second = nums[i];
                count2 =1;
            }
            else{
                count1--;count2--;
            }
        }
        count1=0; count2=0;
        
        for (int i = 0; i < n; i++) {
            if (nums[i] == first)
                count1++;
     
            else if (nums[i] == second)
                count2++;
        }
        List<int> res = new List<int>();
        if (count1 > n / 3){
            res.Add(first);
        }
        if (count2 > n / 3){
            res.Add(second);
        }    
        
        return res;
    }
}