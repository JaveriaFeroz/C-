class game
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        string player;
        string computer;
        string answer;

        while (playAgain)
        {
            player = "";
            computer = "";

            while (player != "ROCK" && player != "PAPER" && player != "SCISSOR")
            {
                Console.WriteLine("ENTER ROCK, PAPER OR SCISSOR: ");
                player = Console.ReadLine();
                player = player.ToUpper();
            }

            switch (random.Next(1, 4))
            {
                case 1:
                    computer = "ROCK";
                    break;
                case 2:
                    computer = "PAPER";
                    break;
                case 3:
                    computer = "SCISSOR";
                    break;
            }
            Console.WriteLine("PLAYER: " + player);
            Console.WriteLine("COMPUTER: " + computer);



            switch (player)
            {
                case "ROCK":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("It's a draw");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("You lose");
                    }
                    else if (computer == "SCISSOR")
                    {
                        Console.WriteLine("You win");
                    }
                    break;

                case "PAPER":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("You Win");

                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("It's a draw");

                    }
                    else if (computer == "SCISSOR")
                    {
                        Console.WriteLine("You lose");
                    }
                    break;

                case "SCISSOR":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("You lose");

                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("You Win");
                    }
                    else if (computer == "SCISSOR")
                    {
                        Console.WriteLine("It's a draw");

                    }
                    break;
            }
            Console.WriteLine("Would you like to play again? (Y/N):");
            answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "Y")
            {
                playAgain= true;
            }
            else
            {
                playAgain= false;
            }
            Console.WriteLine("Thanks for playing");

        }
    }
}