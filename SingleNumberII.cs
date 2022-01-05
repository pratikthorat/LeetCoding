using System.Collections.Generic; 

public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, int> elemCounter = new Dictionary<int, int>();
        foreach(int num in nums) {
            if(elemCounter.ContainsKey(num)){
                elemCounter[num] += 1;
            }
            else{
                elemCounter.Add(num, 1);
            }
        }
        
        foreach(KeyValuePair<int, int> ele in elemCounter) {
            if(ele.Value == 1) {
                return ele.Key;
            }
        }
        return -1;
    }
}