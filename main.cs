
/// Lab No. 2		Exercise No. 1
/// File Name: Lab2.cs
/// @author: Ricardo Huerta
/// Date:  September 13, 2020
///
/// Problem Statement: Write a program that defines a variable initially assigned to the number of coupons you win. 
/// 
/// 
/// Overall Plan:
/// 1) Prompt user to enter number of tickets they have
/// 2) Calculate how many candy bars per 10 tickes. (priority to gumballs)
/// 3) Calculate how many gumballs can be bought with remain tickets
/// 4) Print results to user
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  class MainClass {
    public static void Main (string[] args) {
      Console.WriteLine("How many ticket do you have?");
      int tickets = Int32.Parse(Console.ReadLine());
      int temp = tickets;

      int candy = tickets/10;
      tickets = tickets%10;
      int gum = tickets/3;

      Console.WriteLine("You can get "+ candy + " Candy Bars and " + gum + " Gum ball with " + temp + " tickets.");


    }
  }
}