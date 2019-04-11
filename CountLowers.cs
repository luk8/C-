/* The program allows the user to enter random characters. Upper case, lower case and numbers.
The program will add lower case letters and add all other characters. The program will print the total 
number of lower case letters and a total of the other characters*/

using System;
using static System.Console;

class CountLowers
{
    static void Main()
    {
        // Declare the variables being used by the program

        int lower = 0;
        int otherChar = 0;
        string userInput;
        char userString;

        /* The Do While loop will prompt the user to enter a character, if the character is a lower case 
         letter it will count it. If not, it will count it as a other character*/       

        do
        {
            Write("Enter a character or '}' to quit the program: ");
            userInput = ReadLine();
            userString = Convert.ToChar(userInput);

            if (char.IsLower(userString))
            {
                ++lower;
            }
            else
            {
                ++otherChar;
            }

        } while (userString != '}');

        /* Once the user hits the character to end the program the program will over an other character
        so it isn't counted with the other character total*/

        otherChar = otherChar - 1;

        // The total lower case letters and total other characters will print out
        WriteLine("Total lower case letters: " + lower.ToString());
        WriteLine("Total other characters: " + otherChar.ToString());
    }
}