/* The program will ask that the user enter the length, width and height of 
the room in cubic feet then will calculate the length, width and height entered by the user.
The volume of the room in cubic feet will be returned.*/

using System;
using static System.Console;

class Calculamatron
{
    static void Main()
    {
        // Declare the variables to be used in the program

        int length, width, height;
        int cubicVol;

        // The program will prompt the user to enter the length, width and height
               
        Write("Enter the length of the room: ");
        length = Convert.ToInt32(ReadLine());

        Write("Enter the width of the room: ");
        width = Convert.ToInt32(ReadLine());

        Write("Enter the height of the room: ");
        height = Convert.ToInt32(ReadLine());

        // The CalVolume method will calculate the provided length, width and height

        cubicVol = CalVolume(length, width, height);

        // Display the volume of the room in cubic feet

        WriteLine("The volume of the room is {0} cubic feet", cubicVol.ToString("F1"));

    }

    /* The CalVolume method will calucate the volume which is the length times width
     times height and will return the volume to the main method*/
       
    private static int CalVolume(int length, int width, int height)
    {
        int volume;
        volume = length * width * height;
        return volume;
    }
}