public class Solution {
    public int LengthOfLastWord(string s) {
        int count = 0;

        for (int i = s.Length - 1; i >= 0; i--) {
            if (s[i] != ' ') {
                count++;
            } else if (count > 0) {
                break;
            }
        }

        return count;
    }
}
