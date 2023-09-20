namespace UL.BackendChallenge
{
    using System.ComponentModel.DataAnnotations;

    internal class CustomPromptValidators
    {
        // We could add even more custom validators if necessary to provide more user friendly messages when invalid inputs are entered.
        public static Func<object?, ValidationResult?> NonNegative(string? errorMessage = default)
        {
            return input =>
            {
                if (input is not int numValue)
                {
                    return ValidationResult.Success;
                }

                if (numValue >= 0)
                {
                    return ValidationResult.Success;
                }

                return new ValidationResult(errorMessage ?? "Value must be greater than zero.");
            };
        }
    }
}
