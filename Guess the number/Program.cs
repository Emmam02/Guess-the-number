
using System;

namespace GuessTheNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int secretNumber = randomNumber.Next(1, 101);
            int numberGuessed = 0;
     

            do
            {
                Console.WriteLine("Enter a number between 1 and 100 :");
                numberGuessed = Convert.ToInt32(Console.ReadLine());
                if (secretNumber < numberGuessed)
                {
                    Console.WriteLine("Go lower");
                }
                else if (secretNumber > numberGuessed)
                {
                    Console.WriteLine("Go higher");
                }
            } while (secretNumber != numberGuessed);

            Console.WriteLine("You guessed it, it was {0}!", secretNumber);
        }
    }
}