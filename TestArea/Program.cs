// C# program for the conversion
// kmph to mph and vice versa
using System;

class GFG
{

    // Function to convert kmph to mph
    static double kmphTOmph(double kmph)
    {
        return 0.6214 * kmph;
    }

    // Function to convert mph to kmph
    static double mphTOkmph(double mph)
    {
        return mph * 1.60934;
    }

    // Driver code to check the above function
    public static void Main()
    {
        double kmph = 200;
        double mph = 100;
        Console.WriteLine("speed in miles/hr is " + kmphTOmph(kmph));
        Console.WriteLine("speed in km/hr is " + mphTOkmph(mph));
    }
}

// This code is contributed by vt_m