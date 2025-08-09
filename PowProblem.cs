namespace Leetcode.Algorithm
{
    public class PowProblem
    {
        public double MyPow(double x, int n)
        {
            if(n < 0)
            {
                x = 1 / x;
                n = -n;
            }

            return PowIterative(x, n);
        }

        private double PowIterative(double x, int n)
        {
            double result = 1;

            while(n > 0)
            {
                if ((n & 1) == 1)
                    result *= x;

                x *= x;

                n /= 2;
            }

            return result;
        }

        private double PowRecursive(double x, int n)
        {
            if (n == 0)
                return 1;

            var half = PowRecursive(x, n / 2);

            if(n % 2 == 0)
                return half * half;

            return half * half * x;
        }
    }
}
