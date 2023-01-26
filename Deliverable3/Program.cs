//Author: Davaanyam Baljinnyam
//Date: 1/24/2023
//Description: Deliverable 3 odd or even

using System;
using System.Diagnostics;

namespace Deliverable3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean done = false;

            while (!done)
            {
                try
                {

                    int input = 0;
                   string series = "";

                    while (true)
                    {
                       Console.WriteLine("Enter an interger number betwen 1 and 100: ");
                       input = int.Parse(Console.ReadLine());

                       if (input >= 1 && input <= 100)
                       {
                          break;
                       }
                       else
                       {
                        Console.WriteLine("You have entere an interger not betwen 1 and 100! ");
                       }
                    }
                    while (true)
                     {

                       Console.WriteLine("Specify the series type: Even or Odd ");
                       series = Console.ReadLine();

                       if (series == "Even" || series == "even" || series == "Odd" || series == "odd")
                       {
                          break;
                       }
                       else
                       {
                        Console.WriteLine("You have not entered Even or Odd!");
                       }
                    }



                    if (series == "Odd" || series == "odd")
                    {
                        Console.WriteLine("You have selected " + series + "series. The numbes between 0 and " + input + " are:");
                       for (int i = 1; i <= input; i = i + 2)
                       {
                        Console.WriteLine(i);
                       }
                    }
                    if (series == "even" || series == "Even")
                    {
                       Console.WriteLine("You have selected " + series + "series. The numbes between 0 and " + input + " are:");
                       for (int i = 0; i <= input; i = i + 2)
                       {
                        Console.WriteLine(i);
                       }
                    }
                    done = true;
                }
                catch
                {
                    Console.WriteLine("The data type you entered is not integer");
                }
            }
        }
    }
}