/// Lab No. 1		Exercise No. 1
/// File Name: MyFirstProgram.cs
/// @author: Ricardo Huerta
/// Date:  September 13, 2020
///
/// Problem Statement: Ask the user to enter two numbers, calculate the sum of
/// these two numbers, and display the sum to the screen
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for two integers
/// 3) Calculate the sum of the integers
/// 4) Print the sum of the integers to the screen
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyFirstProgram
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add two numbers for you.");
            Console.WriteLine("Enter one number and press enter, then enter second number and press enter and enter third number:");

            // declare two integer variables
            int n1, n2,n3, sum, product;
            double divide;

            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());

            // calculate the sum of these two numbers
            sum = n1 + n2+ n3;
            product = n1 * n2 * n3;
            divide = product/sum;


            // print a message along with the sum of the two numbers
            Console.WriteLine("The sum of those three numbers is");
            Console.WriteLine(sum);
            Console.WriteLine("The product of those three numbers is");
            Console.WriteLine(product);
            Console.WriteLine("The sum divide by those three numbers is");
            Console.WriteLine(divide);

            //Just to pause the screen.
            Console.ReadLine();

        }
    }
}
