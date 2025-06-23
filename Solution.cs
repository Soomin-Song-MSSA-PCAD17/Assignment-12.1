namespace LeetCode383
{
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int[] characters = new int[26];

            // determine how many of each characetr is required for ransom note
            foreach (char c in ransomNote)
            {
                characters[c - 'a']++;
            }

            // determine how many of each character is provided by magazine
            foreach (char c in magazine)
            {
                characters[c - 'a']--;
            }

            // see if any of the characters are inadequately provided
            foreach (int i in characters)
            {
                if (i > 0) { return false; }
            }

            return true;
        }
    }
}
