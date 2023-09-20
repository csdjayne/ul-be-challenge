namespace UL.BackendChallenge
{
    using System.ComponentModel.DataAnnotations;

    public static class Enums
    {
        public enum ProgramOptions
        {
            [Display(Name = "Calculate Factorial of a number")]
            Factorial,

            [Display(Name = "Play FizzBuzz up to 100")]
            FizzBuzz,
        }
    }
}
