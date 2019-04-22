using System;
using System.Collections.Generic;

namespace Guesser {

public class Program //basic boilerplate code
{
  public static void Main()
  {
      Console.WriteLine("Would you like to pick the number or guess the number(p/g)");
      string which = Console.ReadLine();
      if(which == "g"){
      Random random = new Random();
      int num = random.Next(1,100);
      bool guessed = false;
      Console.WriteLine(num);

      while(guessed == false){
        Console.WriteLine("Enter a guess(1-100)");
        int guess = int.Parse(Console.ReadLine());
        if(guess == num)
        {

          Console.WriteLine("You guessed it");
          guessed = true;
        } else
          {
          if(guess < num){
            Console.WriteLine("Higher");
          } else
          {
            Console.WriteLine("Lower");
            }
          }
        }
      } else
      {
        Console.WriteLine("Think of a number between 1-100.");
        bool guessed = false;
        Random random = new Random();
        int num = random.Next(1,100);
        int min = 1;
        int max = 100;

        while(guessed == false){
          Console.WriteLine("Okay, is your number " + num + "? Enter higher/lower/correct");
          string response = Console.ReadLine();

          if (response == "higher"){
            min = num+1;
            num = random.Next(min, max);
          } else if (response == "lower"){
            max = num-1;
            num = random.Next(min, max);
          } else {
            Console.WriteLine("Got it! Eat it jerk!");
            guessed = true;
          }
        }
      }
    }
  }
}
