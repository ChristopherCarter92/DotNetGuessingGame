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
        string[] Words = { "cat", "hat", "rat", "bat", "rattatat" };
        Random RandomNumber = new Random();

        public void Play()
        {
            Target = RandomNumber.Next(Words.Length);


            Console.Write(" Guess which word I am thinking of... is it ");
            for (int i = 0; i < Words.Length; i++)
            {
                if (i == (Words.Length - 1))
                    Console.Write("or " + Words[i] + "? ");
                else
                    Console.Write(Words[i] + ", ");
            }

            Input = Console.ReadLine();

            if (Input == Words[Target])
            {
                Console.WriteLine("Awww dang... You guessed it!");
            }
            else
            {
                Console.WriteLine("Hehehe NOPE. Try again!");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                Play();
            }


            Console.ReadKey();
        }
    }
}
