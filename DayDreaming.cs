/* The program calucates the amount of time the user spends day dreaming*/

using System;
using static System.Console;

class DayDreaming
{
    static void Main()
    {
        const int MIN_IN_HOUR = 60; // Constant is the number of minutes in an hour

        // Declared minutes, hours and minutes left

        int minutes;
        int hours;
        int minsLeft;

        // User enters the amount of time spent day dreaming in minutes

        Write("Enter the amount of minutes you spend day dreaming");

        // Users entry is converted to an integer

        minutes = Convert.ToInt32(ReadLine());

        hours = minutes / MIN_IN_HOUR;

        minsLeft = minutes % MIN_IN_HOUR;

        // Displays the amount of time spent day dreaming in hours and minutes

        WriteLine("You spend {0} hours and {1} minutes day dreaming", hours, minsLeft);
    }
}
