﻿namespace WhilePractice
{
    public static class Task2
    {
        /// <summary>
        /// Calculate the following sum
        /// 1/(1*2) - 1/(2*3) + 1/(3*4) + ... + (-1)^(n+1) / (n * (n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double SumSequenceElements(int n)
        {
            decimal sum = 0.0m;
            decimal sign = 1.0m;
            int i = 1;

            while (i <= n)
            {
                sum += sign * (1.0m / (i * (i + 1)));
                sign *= -1.0m;
                i++;
            }

            return (double)sum;
        }
    }
}
