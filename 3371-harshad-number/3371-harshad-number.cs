public class Solution {
    public int SumOfTheDigitsOfHarshadNumber(int x) {
        int sum = 0;
        int temp = x;

        while(x > 0){
            sum += x % 10;
            x /= 10;
        }
        return (temp % sum == 0)? sum : -1;
    }
}