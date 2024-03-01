using System;
using Test1_Anagram;

namespace Test1_Anagram

{
    internal class UserUI : Anagram
    {
        public void Run()
        {
            Console.WriteLine("Well Come to Program");

            var anagram = new Anagram();
            string userInput;

            do
            {
                Console.WriteLine("Please Enter a Word: ");
                userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Invalid input. Please enter a valid word. ");
                }

            } while (string.IsNullOrEmpty(userInput));

<<<<<<< HEAD
            Console.WriteLine("Reversed Word: " + anagram.Reverse(userInput));
=======
            Console.WriteLine("Reversed Word: " + anagram.ReversedWord(userInput));
>>>>>>> origin/main
        }
        
        public static void Main(string[] args)
        {
            var program = new UserUI();
            program.Run();
        }
    }
}