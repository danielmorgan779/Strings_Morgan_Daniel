using System;

namespace Strings_Morgan_Daniel
{
    class Program
    {
        static void Main(string[] args)
        {   // Asks to input a character and assigns it to a char called myChar
            Console.WriteLine("Input a Character!");
            char myChar = Console.ReadKey().KeyChar;

            //Checks whether the char inputted is in fact a letter
            bool isLetter = Char.IsLetter(myChar);

            // Prints out
            Console.WriteLine($"\n{myChar} is a letter: {isLetter}.");

            // Asks user to input some words and assigns it to a variable called sentence
            Console.WriteLine("Please input a string of words about anything.");
            string sentence = Console.ReadLine();

            // Asks user to input some words and assigns it to a variable called word
            Console.WriteLine("Enter a  single word");
            string word = Console.ReadLine();

            // checks to see if the sentence contains the word they inputted
            bool isPresent = sentence.Contains(word);

            // Tells the user whether or not it is true or false
            Console.WriteLine($"{word} exists in {sentence}, {isPresent}");


        }
    }
}
