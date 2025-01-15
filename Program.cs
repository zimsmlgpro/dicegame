namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
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
        }
    }
}
    

