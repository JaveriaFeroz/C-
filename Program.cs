class GuessGame
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int min = 1;
        int max = 100;
        int guess;
        int guesses;
        int number;
        bool playAgain = true;
        string response;
 

        while (playAgain)
        {
            guess = 0;
            guesses = 0;
            number = random.Next(min , max+1);
            while (guess!=number)
            {
                Console.WriteLine("Choose any number " + min + "-" + max + ":");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("guess: " + guess);
                if(guess > number)
                {
                    Console.WriteLine("Choosen number is too high.");
                }

                else if (guess < number) 
                {
                    Console.WriteLine("Choosen number is too low.");
                }
                guesses++;
            }

            Console.WriteLine("number: " + number);
            Console.WriteLine("guesses: " + guesses);
            Console.WriteLine("You win!");
            Console.WriteLine("Would you like to play again? (Y/N): ");
            response = Console.ReadLine();
            response = response.ToUpper();
            if (response == "Y")
            {
                playAgain= true;
            }    
            else
            {
                playAgain= false;
            }

            
        }
        Console.WriteLine("Thank you for playing 'IGuess!");
        Console.ReadKey();
    }
}