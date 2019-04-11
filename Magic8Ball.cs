/* The program will allow prompt the user to ask a question and upon asking the question
the Magic 8 Ball will return one of four answers.*/

using System;
using static System.Console;
using System.Threading;


class Magic8Ball
{
    static void Main(string [] args)
    {
        Random ran = new Random();

        WriteLine("Welcome to the Magic 8 Ball!");

        // The while loop will prompt users to asks questions until the user decides to quit

        while (true)
        {
            WriteLine("\n");

            string userQuestion = AskQuestion();

            int numSecSleep = ((ran.Next(5) + 1 * 1000));

            WriteLine("Thinking..");

            Thread.Sleep(numSecSleep);

            if (userQuestion.Length == 0)
            {
                WriteLine("You did not enter a question. Please enter a question");
                continue;
            }

            if (userQuestion.ToLower() == "quit")
            {
                break;
            }

            string MagicAnswer = ReplyToQuestion();

            // Displays the Magic 8 Balls answer to the users question

            WriteLine(MagicAnswer);

        }

    }

    // AskQuestion method allows the user to enter a question 

    private static string AskQuestion()
    {

        Write("Enter your question: ");
        string userQuestion = ReadLine();
        return userQuestion;
    }

    // ReplyToQuestion method generates a random reply to the users question

    private static string ReplyToQuestion()
    {
        Random rstr = new Random();
        string[] replies;
        replies = new string[] { "Yes", "Cannot predict now", "Very doubtful", "No" };

        int index = rstr.Next(replies.Length);

        string reply = replies[index];

        return reply;

    }
}
