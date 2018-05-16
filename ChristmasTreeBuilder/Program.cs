using System;

namespace ChristmasTreeBuilder
{
    // Users can input an integer number to build a Christmas tree onto the console.
    class Program
    {
        static void Main(string[] args)
        {
            IPrint treeBuilder = new TreeBuilder();
            IValidator inputValidator = new IntValidator();

            Console.WriteLine("Welcome to Christmas Tree Builder!");
            Console.WriteLine("Please input the height of your tree! Enter nothing to quit.");

            string input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {
                // Validate input before building the tree.
                if(inputValidator.Validate(input))
                {
                    int inputHeight = int.Parse(input);
                    treeBuilder.Print(inputHeight);
                    Console.WriteLine("Input another height for a new tree! Enter nothing to quit.");
                }

                input = Console.ReadLine();
            }
        }
    }
}
