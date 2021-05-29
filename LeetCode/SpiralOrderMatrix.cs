class Solution {
    public List<int> spiralOrder(List<List<int>> A) {
        List<int> res = new List<int>();
        int T =0, B = A.Count -1, L=0, R = A[0].Count-1, dir =0;
        int i =0;
        while(T<=B && L<=R){
            if(dir == 0){
                for(i = L;i<=R;i++)
                    res.Add(A[T][i]);
                T++;
            }
            else if(dir ==1){
                for(i = T; i<= B;i++)
                    res.Add(A[i][R]);
                R--;
            }
            else if(dir ==2){
                for(i = R; i>=L;i--)
                    res.Add(A[B][i]);
                B--;
            }
            else if(dir ==3){
                for(i =B; i>=T; i--)
                    res.Add(A[i][L]);
                L++;
            }
            dir = (dir+1)%4;
        }
        return res;
    }
}
