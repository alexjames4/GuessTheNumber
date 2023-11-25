class NumberGuessingGame
{
    public static void numberGuessingGame()
    {
        int guessesRemaining = 0;
        //output messages to the user
        string welcomeMessage =
            "Guess a number \n"
            + "between 1 and 50 \n"
            + "Select your difficulty: enter 1 for easy, 2 for medium, 3 for hard";

        string easyDiff =
            $"Easy difficulty selected you have {guessesRemaining} guesses remaining";
        
        string mediumDiff =
            $"Medium difficulty selected you have {guessesRemaining} guesses remaining";
        
        string hardDiff =
            $"Hard difficulty selected you have {guessesRemaining} guesses remaining";

        string invalidDiff =
            "Invalid difficulty selected. Hit and Hope mode activated.";

        Console.WriteLine(welcomeMessage);
        
        //read the input from the user
        string difficulty = Console.ReadLine();

        //start easy, medium or hard game
        

        switch (difficulty) 
        {
            case "1":
                guessesRemaining = 7;
                break;
            case "2":
                guessesRemaining = 5; 
                break;
            case "3":
                guessesRemaining = 3;
                break;
            default:
                Console.WriteLine(invalidDiff);
                guessesRemaining = 1;
                break;
        }  

        

        //generate a random number

        //compare user guess with number

        //inform user of number of guesses left

        //end game if run out of guesses


    }
    static void Main(string[] args)
    {
        numberGuessingGame();
    }
}