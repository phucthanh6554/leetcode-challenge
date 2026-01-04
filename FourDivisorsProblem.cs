namespace Leetcode.Algorithm
{
    /// <summary>
    /// https://leetcode.com/problems/four-divisors/?envType=daily-question&envId=2026-01-04
    /// </summary>
    public class FourDivisorsProblem
    {
        public int SumFourDivisors(int[] nums)
        {
            var totalSum = 0;

            foreach (var num in nums)
            {
                int count = 0;
                int currentSum = 0;

                for (int i = 1; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        if (i * i == num)
                        {
                            count++;
                            currentSum += i;
                        }
                        else
                        {
                            count += 2;
                            currentSum += i + (num / i);
                        }
                    }

                    if (count > 4) break;
                }

                if (count == 4)
                {
                    totalSum += currentSum;
                }
            }

            return totalSum;
        }
    }
}
