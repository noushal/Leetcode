public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int count = 0;
        for(int i = 0; i < items.Count; i++){
            if(ruleKey == "type" && ruleValue == items[i][0]){
                count++;
            }else if(ruleKey == "color" && ruleValue == items[i][1]){
                count++;
            }else if(ruleKey == "name" && ruleValue == items[i][2]){
                count++;
            }
        }
        return count;
    }
}