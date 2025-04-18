// week 2 Assignment 2.4.2
// Wed, April 16 2025
//Write program to find thhe largest of three numbers

using System;

class LargestNumber
{
    static void Main()
    {
        int num1 = 25;
        int num2 = 63;
        int num3 = 10;

        int largest = num1;

        if (num2 > largest)
        {
            largest = num2;
        }
        if (num3 > largest)
        {
            largest = num3;
        }

        Console.WriteLine("The largest number is: " + largest);
    }
}