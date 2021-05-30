public class Solution {
    public int Fib(int n) {
        if(n <=0) return 0;
        else if(n <=2) return 1;
        else{
            int [] fib = new int[n+2];
            fib[0] = 0;
            fib[1] = 1;
            fib[2] = 1;
            for(int i = 3; i<=n;i++)
                fib[i] = fib[i-1]+fib[i-2];
            
            return fib[n];
        }
    }
    
}