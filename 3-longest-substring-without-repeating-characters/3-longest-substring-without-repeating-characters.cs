public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var maxLength = 0;
        int i = 0;
        while(i<s.Length) {
            var charDict = new Dictionary<char, int>();
            var  currentLength = 0;
            var j = i;
            while(j<s.Length) {
                var indexFirstAppear = charDict.GetValueOrDefault(s[j], -1);
                if(indexFirstAppear >= 0) {
                    i = indexFirstAppear;
                    break;
                }
                else {
                    charDict.Add(s[j], j);
                    currentLength += 1;
                }
                j += 1;
            }
            if(currentLength >= maxLength) {
                maxLength = currentLength;
            }
            i += 1;
        }
        return maxLength;
    }
}