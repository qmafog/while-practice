namespace WhilePractice
{
    public static class Task1
    {
        /// <summary>
        /// Calculate the following sum 1/1 + 1/2 + 1/3 + ... + 1/n, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double SumSequenceElements(int n)
        {
            double sum = 1.0;
            int i = 2;
            while (i <= n)
            {
                sum += 1.0 / i;
                i++;
            }

            return sum;
        }
    }
}
