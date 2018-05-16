using System;
using System.Text;

namespace ChristmasTreeBuilder
{
    // Outputs a tree of asterisks onto the console.
    public class TreeBuilder : IPrint
    {
        // Outputs a tree with the height of the parameter.
        public void Print(int height)
        {
            StringBuilder sb = new StringBuilder();
            int asteriskCount = 1;
            for (int i = 0; i < height; i++)
            {
                sb.Append(new string('*', asteriskCount));
                asteriskCount += 2;

                Console.WriteLine(FormatRow(sb, height + i));
            }
        }

        // Formats a section of the tree/row. Adds spacing to properly align the parts.
        private string FormatRow(StringBuilder sb, int totalLength)
        {
            string row = sb.ToString().PadLeft(totalLength);
            sb.Clear();
            return row;
        }
    }
}
