namespace Leetcode.Algorithm
{
    public class LongestValidParentheseProblem
    {
        public int LongestValidParentheses(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            var dp = new bool[s.Length];

            var stack = new Stack<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == '(')
                    stack.Push(i);
                else
                {
                    if(stack.Count > 0)
                    {
                        var index = stack.Pop();
                        dp[index] = true;
                        dp[i] = true;
                    }
                }
            }

            var max = 0;
            var current = 0;

            for(var i = 0; i < s.Length; i++)
            {
                if (dp[i])
                {
                    current++;
                }
                else
                {
                    current = 0;
                }

                max = Math.Max(max, current);
            }

            return max;
        }
    }
}
