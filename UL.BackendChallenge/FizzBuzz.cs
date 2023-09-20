namespace UL.BackendChallenge
{
    public class FizzBuzz
    {

        /// <summary>
        /// Generates FizzBuzz until given number
        /// 
        /// NOTES:
        /// Instead of writing to the console directly, I've outputted to a list first so that we can unit test this easier
        /// (instead of having to override Console output using Console.SetOut)
        /// I've also included a parameter called fizzBuzzUntil to allow us to specify a number other than 100 for testing purposes.
        /// </summary>
        /// <param name="fizzBuzzUntil">Generate FizzBuzz until this number</param>
        /// <returns>List of strings that represent the FizzBuzz output that has been generated</returns>
        public static List<string> Generate(int fizzBuzzUntil)
        {
            var lines = new List<string>();

            for (int i = 1; i <= fizzBuzzUntil; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    lines.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    lines.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    lines.Add("Buzz");
                }
                else
                {
                    lines.Add(i.ToString());
                }
            }

            return lines;
        }
    }
}
