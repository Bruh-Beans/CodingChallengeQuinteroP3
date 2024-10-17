using System;
using System.Runtime.InteropServices;

class Challenges

{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my coding challenge program. There will be a variety of functions you will have to choose from. Please pick one");
        Console.WriteLine("Today we are going to use the adder called SUM. Please input 2 numbers for us to add. \n");

        var number1 = Console.ReadLine();
        int number1int = int.Parse(number1);

        Console.WriteLine("Awesome! Please input a 2nd number");

        var number2 = Console.ReadLine();
        int number2int = int.Parse(number2);

        Console.WriteLine("The sum of the bnumber: " + number1 + " and the number: " + number2 + " is equal to: + " + Sum(number1int, number2int));
        Sum(number1int, number2int);

        //Convert Minutes to Seconmds
        Console.WriteLine("Lets try converting minutes to seconds \nGive me a number to converyt from minutes to seconds");
        var number3 = Console.ReadLine();
        int number3int = int.Parse(number3);

        Console.WriteLine(number3 + " Minutes converted to seconds is: " + Convert(number3int));

        //Add one to any number
        Console.WriteLine("Lets try adding 1 to any number \nGive me a number to add the number 1 to");
        var number4 = Console.ReadLine();
        int number4int = int.Parse(number4);
        Console.WriteLine(number4 + " One added to the number selected is: " + PlusOne(number4int));

        //Calculate any age in days
        Console.WriteLine("Lets try calculating your age in days \nGive me a number to calculate into days");
        var number5 = Console.ReadLine();
        int number5int = int.Parse(number5);

        Console.WriteLine(number5 + " Converted into days is: " + CalcAge(number5int));

        //Calculate any age in days
        Console.WriteLine("Lets try calculating the area of a triangle \nGive me the base of the triangle");
        var number6 = Console.ReadLine();
        int number6int = int.Parse(number6);

        Console.WriteLine("Awesome! Please input the height");

        var number7 = Console.ReadLine();
        int number7int = int.Parse(number7);

        Console.WriteLine("The area of the triangle with the length: " + number6 + " and the height: " + number7 + " is equal to: " + triArea(number6int, number7int));
        Sum(number1int, number2int);
        //Determine if a number is less than or equal to zero
        Console.WriteLine("Lets try Determining is a value is equal to or less than zero\nGive me a number to determine if it is equal to or less than zero");
        var number8 = Console.ReadLine();
        int number8int = int.Parse(number8);
        Console.WriteLine(number8 + " is equal to or less than zero: " + lessThanOrEqualToZero(number8int));

    }



    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }
    public static int Convert(int number)
    {
        return number * 60;
    }

    public static int PlusOne(int number)
    {
        return number + 1;
    }

    public static int CalcAge(int number)
    {
        return number * 365;
    }
    public static float triArea(float number6, int number7)
    {
        return (number6 * number7) / 2 ;
    }

    public static bool lessThanOrEqualToZero(int number)
    {
        return (number <= 0) ? true : false;
    }
}