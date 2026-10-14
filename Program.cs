
namespace Programming_Qs___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Player One enter your chosen number : ");
            int NumberToGuess = Convert.ToInt32(Console.ReadLine());
            while (NumberToGuess < 1 || NumberToGuess > 10)
            {
            	Console.WriteLine("Not a valid choice, please enter another number: ");
            	NumberToGuess = Convert.ToInt32(Console.ReadLine());
            }
            int guess = 0;
            int NumberOfGuesses = 0;
            while (Guess != NumberToGuess && NumberOfGuesses < 5)
            {
            	Console.WriteLine("Player Two have a guess: ");
            	Guess = Convert.ToInt32(Console.ReadLine());
            	NumberOfGuesses++;
            }
            if (Guess == NumberToGuess)
            {
            	Console.WriteLine("Player Two wins");
            }
            else
            {
            	Console.WriteLine("Player One wins");
            }

        }
    }
}
