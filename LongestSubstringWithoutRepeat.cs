using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithm
{
    /// <summary>
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// Given a string s, find the length of the longest substring without repeating characters.
    /// </summary>
    public class LongestSubstringWithoutRepeat
    {
        public int LengthOfLongestSubstring(string s)
        {
            if(string.IsNullOrEmpty(s))
                return 0;
            
            var max = 0;
            var i = 0;
            
            var dict = new Dictionary<char, int>();

            for (var j = 0; j < s.Length; j++)
            {
                if (dict.ContainsKey(s[j]) && dict[s[j]] >= i)
                {
                    i = dict[s[j]] + 1;
                }
                
                dict[s[j]] = j;
                max = Math.Max(max, j - i + 1);
            }
            
            return max;
        }
    }
}
