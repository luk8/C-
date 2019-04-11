/* The program calculates the test scores*/

using System;
using static System.Console;

class ScoreMonger
{
    static void Main()
    {
        // Constant is the number of test scores

        const int NUM_OF_SCORES = 5;

        // Test scores for five students

        float studentOne = 89.88F;
        float studentTwo = 79F;
        float studentThree = 95.4F;
        float studentFour = 63.52F;
        float studentFive = 77.75F;

        // Calculating the average scores

        float totalScores = studentOne + studentTwo + studentThree + studentFour + studentFive;
        float avgScores = totalScores / NUM_OF_SCORES;
        String scores = avgScores.ToString("F1");

        // Display average scores

        WriteLine("The average score is {0}", scores); 
    }
}
