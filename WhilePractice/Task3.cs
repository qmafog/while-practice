﻿namespace WhilePractice
{
    public static class Task3
    {
        /// <summary>
        /// Calculate the following sum
        /// 1/1^5 + 1/2^5 + 1/3^5 + ... + 1/n^5, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double SumSequenceElements(int n)
        {
            double sum = 1.0;
            int i = 2;
            while (i <= n)
            {
                sum += 1 / Math.Pow(i, 5);
                i++;
            }

            return sum;
        }
    }
}
