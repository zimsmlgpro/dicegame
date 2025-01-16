namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true; //Setting the variable to run this until it is set to false

            while (playAgain)
            {
                Random random = new Random();  // Runs at the beginning every time
                int diceRoll = random.Next(1, 6);  // Get a number between 1 and 6

                Console.WriteLine($"Guess the roll of the dice? (A number between 1 and 6):");  // Asks for the number from the user
                int userGuess = Convert.ToInt32(Console.ReadLine()); //Takes users guess and converts it to a integer

                if (userGuess == diceRoll)
                {
                    Console.WriteLine("You win! The dice roll was " + diceRoll + ".");
                }
                else
                {
                    Console.WriteLine("You're a fucking moron. The number was " + diceRoll + ". Go read a book, you troglodyte");
                }

                Console.WriteLine("Press 'R' to play again or any other key to quit.");
                string userChoice = Console.ReadLine(); //Get user input

                if (userChoice.ToLower() != "r") //If the user doesn't press any variation of r
                {
                    playAgain = false; //Stops the whole loop
                    Console.WriteLine("Thanks for giving my Dice Game a try!");
                }
            }
        }
    }
}
    

