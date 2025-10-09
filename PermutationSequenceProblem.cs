namespace Leetcode.Algorithm;

public class PermutationSequenceProblem
{
    public string GetPermutation(int n, int k)
    {
        var fact = new int[n + 1];
        fact[0] = 1;
        
        for(var i = 1; i <= n; i++)
            fact[i] = fact[i - 1] * i;

        var permutationList = new List<int>(n);

        for (var i = 1; i <= n; i++)
            permutationList.Add(i);

        var result = string.Empty;

        k -= 1;
        
        for (var i = n - 1; i >= 0; i--)
        {
            var idx = k / fact[i];
            k %= fact[i];
            
            result += permutationList[idx];
            permutationList.RemoveAt(idx);
        }
        
        return result;
    }

    private string BruteForce(int n, int k)
    {
        var arr = new int[n];
        
        for(var i = 1; i <= n; i++)
            arr[i - 1] = i;

        var permutation = k % Factorial(n);

        if (permutation == 0)
        {
            Array.Reverse(arr);
            return string.Join(string.Empty, arr);
        }

        if (permutation == 1)
        {
            return string.Join(string.Empty, arr);
        }
        
        for(var i = 0; i < permutation; i++)
            NextPermutation(arr);
        
        return string.Join(string.Empty, arr);
    }
    
    public int Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("n must be non-negative");

        var result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;

        return result;
    }
    
    public void NextPermutation(int[] nums) {
        int pivot = -1;

        for(var i = nums.Length - 1; i >= 1; i--) {
            if(nums[i] > nums[i - 1])
            {
                pivot = i - 1;
                break;
            }
        }

        if(pivot == -1)
        {
            Array.Sort(nums);
            return;
        }

        for(var i = nums.Length - 1; i > pivot; i--) {
            if(nums[i] > nums[pivot])
            {
                (nums[i], nums[pivot]) = (nums[pivot], nums[i]);
                break;
            }
        }

        var start = pivot + 1;
        var end = nums.Length - 1;

        while(start < end) {
            (nums[start], nums[end]) = (nums[end], nums[start]);
            start++;
            end--;
        }
    }
}