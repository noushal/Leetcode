public class Solution {
    public bool IsBalanced(string num) {
        int even = 0, odd = 0;
        bool isEven = true;
        for(int i = 0; i < num.Length; i++){
            if(i%2==0){
                even+=num[i]-'0';
            }else{
                odd+=num[i]-'0';
            }
        }
        return even == odd;
    }
}