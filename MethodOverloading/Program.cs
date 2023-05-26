using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;

namespace MethodOverloading
{
    public class Program

    {
     /* Create a method named Add, that accepts two integers and returns the sum of those two integers
Now create an overload of the Add method to account for being able to add two decimals together
Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”
For example:

“5 dollars”

"1 dollar”

“16 dollars”*/
    public static int Add(int num1, int num2 )
        {
            return num1 + num2;
        }
    public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
    public static string Add(int num1 , int num2,bool isTrue )
        {
            var sum = num1 + num2;
            if (isTrue == true && sum > 1)
            {
                return $"{sum} dollars";

            }
            else if (isTrue == true && sum == 1)
            {
                return $"{sum} dollar ";
            } 
            else if(isTrue == true && sum<1)
            {
                return $"{sum} dollars";
            } 
            else
            {
                return sum.ToString() ;
            }
        }
        static void Main(string[] args)
        {
            var x = 24;
            var y = 88;
            var answer =Add(x,y);
            var a = 32.01m;
            var b = 45.0m;
            var decimalAnswer=Add(a,b);
            var thirdAnswer=Add(0,0,true);
            Console.WriteLine($"int add:{answer} decimal add:{decimalAnswer}");
            Console.WriteLine(thirdAnswer);
        }
    }  
     
}
