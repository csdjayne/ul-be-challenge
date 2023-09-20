using Sharprompt;
using UL.BackendChallenge;
using static UL.BackendChallenge.Enums;

bool tryAgain = true;

while (tryAgain)
{
    // I've used Sharprompt to simplify the handling of user input.
    var programOption = Prompt.Select<ProgramOptions>("What would you like to do?");

    switch (programOption)
    {
        case ProgramOptions.Factorial:
            CalculateFactorial();
            break;
        case ProgramOptions.FizzBuzz:
            RunFizzBuzz();
            break;
        default:
            throw new ArgumentException($"Invalid program option: {programOption}");
    }

    tryAgain = Prompt.Confirm("Try again?");
}

static void CalculateFactorial()
{
    var factorialInput = Prompt.Input<int>(
        "Enter a number and press enter to calculate the Factorial of the number",
        validators: new[] { CustomPromptValidators.NonNegative(Factorial.NEGATIVE_NUMBER_EXCEPTION_MESSAGE) });

    var result = Factorial.Calculate(factorialInput);

    Console.WriteLine($"The factorial of {factorialInput} is {result}");
    Console.WriteLine("Factorial calculation finished!");
}

static void RunFizzBuzz()
{
    var results = FizzBuzz.Generate(100);
    results.ForEach(x => Console.WriteLine(x));

    Console.WriteLine("FizzBuzz finished!");
}