//53. Maximum Subarray
class Solution
{
public:
    int maxSubArray(vector<int> &nums)
    {
        int maxSum = INT_MIN;
        int curSum = 0;
        for (int i = 0; i < nums.size(); i++)
        {
            curSum += nums[i];

            if (maxSum < curSum)
                maxSum = curSum;
            if (curSum < 0)
                curSum = 0;
        }
        return maxSum;
    }
};

/*
static int MaxSum(int[] arr){
		int maxSum = Int32.MinValue;
		int curSum = 0;
		for(int i=0;i< arr.Length; i++){
			curSum += arr[i];
			if(maxSum < curSum)
				maxSum = curSum;
			if(curSum <0)
				curSum =0;
		}
		return maxSum;
	}
*/