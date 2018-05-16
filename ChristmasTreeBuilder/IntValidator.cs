using System;

namespace ChristmasTreeBuilder
{
    // Used for validating integers before the input is used internally.
    public class IntValidator : IValidator
    {
        // Check if the input is a valid integer.
        public bool Validate(string input)
        {
            // Check for nulls and empty.
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            // Check for negative values.
            if(input[0].Equals('-'))
            {
                Console.WriteLine("The input is less than 0! Please try another number.");
                return false;
            }

            try
            {
                int inputNumber = int.Parse(input);

                return true;
            }
            // Check for bad input.
            catch (FormatException)
            {
                Console.WriteLine("The input \"{0}\" is not in a proper format. Please try again.", input);
                return false;
            }
            // Check for overflows.
            catch (OverflowException)
            {
                Console.WriteLine("The input \"{0}\" is greater than an int. Please input a smaller number!", input);
                return false;
            }
        }
    }
}
