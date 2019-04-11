/* The program will calculate the number of words in a ad at $0.11 per word*/

using System;
using static System.Console;

// This program tests the ClassifiedAd class

class TestNewspaperAd
{
    static void Main()
    {
        // Creates two ads (objects)
        ClassifiedAd first = new ClassifiedAd();
        ClassifiedAd second = new ClassifiedAd();

        // Number of words for each ad
        first.NumWords = 45;

        second.NumWords = 38;

        // Displays the cost for each add based off the number of words
        Display(first);
        Display(second);

    }

    static void Display(ClassifiedAd ca)
    {
        WriteLine("The total for {0} words is {1}", ca.NumWords, ca.Price);
    }
}

class ClassifiedAd
{
    // Constructors for number of words and price for x amount of words

    private int numWords;
    private double price;

    // Constant fee for each word
    public const double WORD_PER_WORD = 0.11;

    // Gets and sets the number of words
    public int NumWords
    {
        get { return numWords; }
        set { numWords = value; }
    }

    // Gets the price of the number of words
    public double Price
    {
        get
        {
            price = numWords * WORD_PER_WORD;
            return price;
        }
    }
}
