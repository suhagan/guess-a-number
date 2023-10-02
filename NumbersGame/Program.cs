/* SUHAGAN MOSTAHID TANIA */
/* NET 23 */




/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");*/

using System;

Console.WriteLine("Welcome! I'm thinking of a number. Can you guess which one? You get five tries.");

checkGuess();



void checkGuess()
{
    // Generating a random number here
    Random rnd = new Random();
    int number = rnd.Next(1, 20);

    bool gameOver = false;
    int numberOfGuess = 5; //Total number of guesses as mentioned 5 

    while (gameOver == false)
    {
        Console.WriteLine("guess any number: ");
        int guess = Convert.ToInt32(Console.ReadLine());
        numberOfGuess--; // controlling the number of guesses,
                         // by decreasing them 1 each time until it
                         // becomes 0.

        if(guess != number && numberOfGuess == 0) // if the number of
                                                  // guesses are 0, and
                                                  // still the guessed
                                                  // number doesn't
                                                  // match, the game is over.
        {
            Console.WriteLine("Sorry, you failed to guess the number in five tries!");
            gameOver = true;
        }
        if (guess < number)
        {
            Console.WriteLine("Sorry, you guessed too low!");
        }
        else if (guess > number)
        {
            Console.WriteLine("Sorry, you guessed too high!");
        }
        else if (guess == number) // if the gueessed number
                                  // match, the game is over.
        {
            Console.WriteLine("Woho! You did it!");
            gameOver = true;
        }

    }

    Console.WriteLine("press ENTER to exit the program.");
    Console.ReadLine();

}


