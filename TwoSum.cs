using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Leetcode.Algorithm
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// You can return the answer in any order.
    /// </summary>
    public class TwoSum
    {
        public int[] TwoSumCalculate(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();
            dic.Add(nums[0], 0);

            var result = new int[2];

            for (int i = 1; i < nums.Length; i++)
            {
                int k = target - nums[i];

                if(dic.ContainsKey(k))
                {
                    result[0] = dic[k];
                    result[1] = i;

                    return result;
                }
                dic.TryAdd(nums[i], i);
            }

            return result;
        }
    }
}
