using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame2
{
    class Game
    {
        int Guess = 0;
        int Target = 5;
        string Input = "";
        string[] Words = { "happy", "sad", "bored", "excited", "antsy", "glad", "mad", "angry", "curious" };
        Random RandomNumber = new Random();

        public void Play()
        {
            Target = RandomNumber.Next(Words.Length);


            Console.Write(" Guess which mood I'm in... ");
            for (int i = 0; i < Words.Length; i++)
            {
                //if (i == (Words.Length - 1))
                //    Console.Write("or " + Words[i] + "? ");
                //else
                //    Console.Write(Words[i] + ", ");
            }

            Input = Console.ReadLine();

            if (Input == Words[Target])
            {
                Console.WriteLine("Awww dang... You guessed it!");
                Console.WriteLine("Would you like to play again?");
                Console.WriteLine("Enter Y for YES! Or Anything else for No...");
                Input = Console.ReadLine();
                if (Input.ToLower().Equals("y"))
                {
                    Play();
                }else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Nah, not quite. Try again!");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                Play();
            }


            Console.ReadKey();
        }
    }
}
