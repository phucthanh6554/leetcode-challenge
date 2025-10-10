namespace Leetcode.Algorithm
{
    /// <summary>
    /// https://leetcode.com/problems/taking-maximum-energy-from-the-mystic-dungeon/description/?envType=daily-question&envId=2025-10-10
    /// </summary>
    public class TakingMaximumEnergyProblem
    {
        public int MaximumEnergy(int[] energy, int k)
        {
            var dp = new int[energy.Length];

            for (int i = 0; i < energy.Length; i++)
            {
                if(i - k < 0)
                    dp[i] = energy[i];
                else
                {
                    dp[i] = Math.Max(energy[i], energy[i] + dp[i - k]);
                }
            }

            var max = int.MinValue;

            for(int i = dp.Length - k; i < dp.Length; i++)
                max = Math.Max(max, dp[i]);

            return max;
        }
    }
}
