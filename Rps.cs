using System;


namespace APPLICATIONS
{
    /* Class GameOne */
    public class GameOne
    {
        public void RPSGame()
        {

            /* Strings and ints */
            string inputCPU;
            string inputPlayer;
            int randomInt;

            /* Sets the game to ask if user wants to play again */
            bool playAgain = true;
            
            /* While user chooses to play again and game starts over */
            while (playAgain)
            {
                
                /* Player has one in score */
                int scorePlayer = 0;
                /* Computer has one in in score */
                int scoreCPU = 0;
                
                /* While the player has 3 point or less */
                while (scorePlayer< 3 && scoreCPU< 3)
                {
                    
                    /* Change text color to red */
                    Console.ForegroundColor = ConsoleColor.Red;  
                    Console.WriteLine("--- PLAY ROCK, PAPER AND SCISSORS ---");
                    /* Change text color to gray */
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    /* Ask user to choose an option */
                    Console.Write("Choose between Rock, Paper and Scissors:    ");
                    /* Read user option */
                    inputPlayer = Console.ReadLine();
                    /* Returns input to uppercase */
                    inputPlayer = inputPlayer.ToUpper();
                    /* Randomize method */
                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);
                    /* Clear console */    
                    Console.Clear();
                    /* Switch - case */
                    switch (randomInt)
                    {
                        /* Case 1 */
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose: Rock.");
                            if (inputPlayer == "ROCK")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Oops. Draw again!\n\n");
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("You chose: Paper. You won this round.\n\n");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
{
    /* Changes text-color to blue */
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Computer won this round.\n\n");
    /* Changes text-color to gray */
    Console.ForegroundColor = ConsoleColor.Gray;
    /* Add score to the computer */
    scoreCPU++;
}
break;  
                /* Case 2 */
                        case 2:
                            inputCPU = "PAPER";
Console.WriteLine("Computer chose: Paper.");
if (inputPlayer == "PAPER")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Oops. Draw again!\n\n");
    Console.ForegroundColor = ConsoleColor.Gray;
}
else if (inputPlayer == "ROCK")
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Computer won this round.\n\n");
    Console.ForegroundColor = ConsoleColor.Gray;
    scoreCPU++;
}
else if (inputPlayer == "SCISSORS")
{
    /* Change text-color to yellow */
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("You chose: Scissors. You won this round.\n\n");
    /* Change text-color to gray */
    Console.ForegroundColor = ConsoleColor.Gray;
    /* Add score to player */
    scorePlayer++;
}
break;
/* Case 3 */
                        case 3:
                            inputCPU = "SCISSORS";
Console.WriteLine("Computer chose: Scissors.");
if (inputPlayer == "SCISSORS")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Oops. Draw again!\n\n");
    Console.ForegroundColor = ConsoleColor.Gray;
}
else if (inputPlayer == "ROCK")
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("You chose: Rock. You won this round.\n\n");
    Console.ForegroundColor = ConsoleColor.Gray;
    scorePlayer++;
}
else if (inputPlayer == "PAPER")
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Computer won this round.\n\n");
    Console.ForegroundColor = ConsoleColor.Gray;
    scoreCPU++;
}
break;
default:
                            Console.WriteLine("Invalid entry!");
break;
                    }
                    /* Scores */
                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);
                    

                }
                /* If player has more than 3 points */
                if (scorePlayer == 3)
{
        /* Change text-color to red and print player won */
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You won the game!");
    Console.ForegroundColor = ConsoleColor.Gray;


}
/* if computer has more than 3 points */
else if (scoreCPU == 3)
{
    /* Change text-color to red and print CPU won */
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Computer won the game!");
    Console.ForegroundColor = ConsoleColor.Gray;
}
else
{

}
/* Ask user if he or she wants to play again */
Console.WriteLine("Do you want to play again?(y/n)");
string loop = Console.ReadLine();
/* If yes, loop the game again */
if (loop == "y")
{
    playAgain = true;
    Console.Clear();
}
/* If no, stop the game and clear console */
else if (loop == "n")
{
    playAgain = false;
    Console.Clear();
}
    }

}
    }
}