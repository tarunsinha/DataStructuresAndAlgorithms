#include <bits/stdc++.h>
class Solution {
public:
    string mergeAlternately(string word1, string word2) {
        int word1Length = word1.length();
        int word2Length = word2.length();
        
        string res ="";
        int i=0,  j=0;
        while(word1Length >0 && word2Length >0){
            word1Length--; word2Length--;
            res+=word1[i++];
            res+=word2[j++];            
        }
        
        while(word1Length>0){
            word1Length--;
            res+=word1[i++];
        }
        
        while(word2Length>0){
            word2Length--;
            res+=word2[j++];
        }
        return res;
    }
};