class NumberGuessingGame
{
    public static void numberGuessingGame()
    {
        try 
        { 
            int guessesRemaining = 0, i;
       
            //output messages to the user
            string welcomeMessage =
                "Guess a number \n"
                + "between 1 and 50 \n"
                + "Select your difficulty: enter 1 for easy, 2 for medium, 3 for hard";

            string easyDiff =
                "Easy difficulty selected you have {0} guesses remaining";

            string mediumDiff =
                "Medium difficulty selected you have {0} guesses remaining";

            string hardDiff =
               "Hard difficulty selected you have {0} guesses remaining";

            string invalidDiff =
                "Invalid difficulty selected. Hit and Hope mode activated. You have {0} guesses remaining";

            string guessTheNumber =
                "Guess the number: ";

            string successMessage =
                "Congratulations you have guessed the correct number!";

            string failMessage =
                "Uh oh. You've run out of guesses. The number was {0}.\n Better luck next time!";

            string lowerMessage =
                "The number is less than {0}. \n You have {1} guesses remaining:";

            string higherMessage =
                "The number is greater than {0}. \n You have {1} guesses remaining:";

            string playAgainMessage =
                "Would you like to play again? (Y/N):";

            Console.WriteLine(welcomeMessage);

            //read the input from the user
            string difficulty = Console.ReadLine();

            //start easy, medium or hard game

            switch (difficulty) 
            {
                case "1":
                    guessesRemaining = 7;
                    Console.WriteLine(string.Format(easyDiff, guessesRemaining));
                    break;
                case "2":
                    guessesRemaining = 5; 
                    Console.WriteLine(string.Format(mediumDiff, guessesRemaining));
                    break;
                case "3":
                    guessesRemaining = 3;
                    Console.WriteLine(string.Format(hardDiff, guessesRemaining));
                    break;
                default:
                    guessesRemaining = 1;
                    Console.WriteLine(string.Format(invalidDiff, guessesRemaining));
                    break;
            }  

            //generate a random number
            Random random = new Random();
            int randomNum = random.Next(1, 50);

            //compare user guess with number & inform user of number of guess left

            for (i = 0; i < guessesRemaining; i++)
            {
                Console.WriteLine(guessTheNumber);
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == randomNum)
                {
                    Console.WriteLine(successMessage);
                    break;
                } 
                else if (randomNum < guess) 
                {
                    Console.WriteLine(string.Format(lowerMessage, guess, guessesRemaining-(1+i)));
                }
                else if (randomNum > guess)
                {
                    Console.WriteLine(string.Format(higherMessage, guess, guessesRemaining - (1 + i)));
                }
            }

            //end game if run out of guesses
            if (i == guessesRemaining)
            {
                Console.WriteLine(string.Format(failMessage, randomNum));
            }

            Console.WriteLine(playAgainMessage);
            string playAgain = Console.ReadLine();

            //playAgain valid response array
            string[] playAgainArr = [
                "Y",
                "y",
                "N",
                "n"
            ];

            //check valid y/n response if not throw error and end game
            validAnswer(playAgainArr, playAgain);

            if (playAgain == "Y" || playAgain == "y")
            {
                numberGuessingGame();
            }

            static void validAnswer(string[] playAgainArr, string playAgain)
            {
                if (!playAgainArr.Contains(playAgain))
                {
                    throw new InvalidAnswerException("Invalid Answer. Game session ended.");
                }
            }
        }
        catch (InvalidAnswerException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    class InvalidAnswerException : Exception
    {
        public InvalidAnswerException(string message) : base(message) { }
    }

    static void Main(string[] args)
    {
        numberGuessingGame();
    }
}