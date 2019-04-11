/* The program indentifies two squid wranglers, their id number and the number
of squid that they have wrangled*/

using System;
using static System.Console;

// This program tests the SquidWranglers class
class TestSquidWrangler
{
    static void Main()
    {
        // Creates two squid wrangelers (objects)
        SquidWranglers first = new SquidWranglers();
        SquidWranglers second = new SquidWranglers();

        first.Name = "Jon Doe";
        first.IdNumber = 1234;
        first.SquidWrangled = 18;
        second.Name = "Jane Doe";
        second.IdNumber = 5678;
        second.SquidWrangled = 22;

        Display(first);
        Display(second);
        
    }

    // Displays the the squid wrangler's name, id number and the number of squid wrangled
    static void Display(SquidWranglers tsw)
    {
        WriteLine("{0, -10} {1, -10} {2, 5}", tsw.Name, tsw.IdNumber, tsw.SquidWrangled);
    }
}


class SquidWranglers
{
    // Constructors for the squid wranglers which are name, id number and the number of squid wrangled
    private string name;
    private int idNumber;
    private int squidWrangled;

    // Gets and sets the the squid wrangler's name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Gets and sets the squid wrangler's id number
    public int IdNumber
    {
        get { return idNumber; }
        set { idNumber = value; }
    }

    // Gets and sets the number of squid wrangled
    public int SquidWrangled
    {
        get { return squidWrangled; }
        set { squidWrangled = value; }
    }

}