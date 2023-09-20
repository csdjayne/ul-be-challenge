namespace UL.BackendChallenge
{
    using System.Numerics;

    public class Factorial
    {
        // We could alternatively store messages such as this in a resource file, particularly if we are factoring in i18n.
        public const string NEGATIVE_NUMBER_EXCEPTION_MESSAGE = "Cannot calculate Factorial for negative numbers.";


        /// <summary>
        /// Calculates Factorial for the given number
        /// 
        /// NOTES:
        /// As we are dealing with a process that can produce incredibly large numbers,
        /// we can't use int or long past 20! without it overflowing so I've used BigInteger instead to give a more accurate output
        /// </summary>
        /// <param name="f">Number to calculate Factorial for</param>
        /// <returns>Factorial of the input f</returns>
        /// <exception cref="ArgumentException">Occurs if the input f is a negative number</exception>
        public static BigInteger Calculate(BigInteger f)
        {
            if (f < 0)
                throw new ArgumentException(NEGATIVE_NUMBER_EXCEPTION_MESSAGE);

            return f == 0 || f == 1
                ? 1
                : f * Calculate(f - 1);
        }
    }
}
