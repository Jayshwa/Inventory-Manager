// Parsing,.cs
// Description: This file contains a class with a method to parse string inputs to integers.
using System;

namespace InventoryManagementSystem
{

    public class Parsing
    {
        public static int ParseInputToInteger(string input)
        {
            // This method attempts to parse a string input to an integer.
            // It returns the parsed integer if successful, or -1 if parsing fails.
            int parsedValue;
            if (int.TryParse(input, out parsedValue))
            {
                return parsedValue;
            }
            else
            {
                return -1; // Return -1 to indicate parsing failure
            }
        }
    }
}