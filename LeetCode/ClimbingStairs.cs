public class Solution {
    public int ClimbStairs(int n) {
        int [] memo = new int[n+2];
        memo[0]=1;
        memo[1]=1;
        memo[2]=2;
        for(int i =3; i<=n; i++){
            memo[i] = memo[i-1] +memo[i-2];
        }
        return memo[n];
    }
}