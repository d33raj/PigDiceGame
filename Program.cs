namespace PigDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************PIG DICE GAME**********************");
            Console.WriteLine("Welcome To the Game: First to 20 Points Wins the Game");
            PigDice();
        }

        static void PigDice()
        {
            Random r = new Random();
            int totalScore = 0;
            bool gameover = false;

            while (!gameover)
            {
                int currentScore = 0;
                bool currentTurn = false;
                while (!currentTurn)
                {
                    totalScore += currentScore;
                    Console.WriteLine($"Your Total score is: {totalScore}");
                    Console.WriteLine("\nPress 'r' to Roll or 'h' to Hold: ");
                    char choice = Convert.ToChar(Console.ReadKey().KeyChar);

                    if (choice == 'r')
                    {
                        int rollTheDice = r.Next(1, 7);
                        if(rollTheDice == 1)
                        {
                            Console.WriteLine("\nYou Rolled 1. No new points added. Turn Ends Now.");
                            Console.WriteLine("Starting a New Turn.");
                            Console.WriteLine("*********************************************");
                            totalScore = 0;
                            currentTurn = true;
                        }
                        else
                        {
                            currentScore= rollTheDice;
                            Console.WriteLine($"\nYour Current Score is: {currentScore}");
                        }         
                    }

                    else if (choice == 'h')
                    {
                        Console.WriteLine($"\nYou held! Your total score is now {totalScore}");
                        if (totalScore >= 20)
                        {
                            Console.WriteLine("Congratulations You have Scored 20 or more points.\nYou Won the Game.");
                            gameover = true;
                        }
                        currentTurn = true;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input. Please press 'r' to roll or 'h' to hold.");
                    }
                }
            }
        }
    }
}
