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
            Dictionary<char, bool> mapping = new Dictionary<char, bool>();
            int max = 0;
            int current = 0;

            int firstStart = 0;
            int index = 0;

            while(index  < s.Length)
            {
                if (!mapping.ContainsKey(s[index]))
                    current++;
                else
                {
                    mapping.Clear();
                    firstStart += 1;
                    index = firstStart;
                    current = 0;
                    continue;
                }

                mapping.TryAdd(s[index], false);
                max = current > max ? current : max;
                index++;
            }

            return max;
        }
    }
}
