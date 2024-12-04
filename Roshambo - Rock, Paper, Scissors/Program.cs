using Roshambo___Rock__Paper__Scissors;
using System.ComponentModel;
using System.Security.Cryptography;

bool playAgain = true;
int humanTotal = 0;
int opponentTotal = 0;
do
{
    Console.WriteLine("Welcome to Rock Paper Scissors!");
    bool validOpponent = false;
    Player opponent = null; // initialized variable to hold the opponent choice
    do
    {
        Console.WriteLine("Choose your opponent: You can pick either \"Wildcats\" or \"Bulldogs\"");
        string opponentChoice = Console.ReadLine().ToLower();
        if (opponentChoice == "wildcats")
        {
            opponent = new RockPlayer("Wildcats");
            validOpponent = true;
        }
        else if (opponentChoice == "bulldogs")
        {
            opponent = new RandomPlayer("Bulldogs");
            validOpponent = true;
        }
        else
        {
            Console.WriteLine("Invaid choice");
        }
    } while (validOpponent == false);

    Console.WriteLine($"Your opponent is: {opponent.Name}");
    Console.WriteLine();
    HumanPlayer human = new HumanPlayer();
    human.NameAndChoice();
    Roshambo opponentAttack = opponent.GenerateRoshambo(); // new variable "opponentAttack" to hold the attack choice made by the opponent (RockPlayer or RandomPlayer)
    Console.WriteLine($"{opponent.Name} chose to attack with {opponentAttack}");
    Console.WriteLine($"{human.Name} chose to attack with {human.RoshamboPick}");

    bool opponentWin = false;
    bool humanWin = false;

    if (opponentAttack == human.RoshamboPick)
    {
        Console.WriteLine("Tie!");
    }
    else if
        ((opponentAttack == Roshambo.Rock && human.RoshamboPick == Roshambo.Scissors) ||
        (opponentAttack == Roshambo.Scissors && human.RoshamboPick == Roshambo.Paper) ||
        (opponentAttack == Roshambo.Paper && human.RoshamboPick == Roshambo.Rock))
    {
        Console.WriteLine($"{opponent.Name} wins!");
        opponentWin = true;
    }
    else
    {
        Console.WriteLine($"{human.Name} wins!");
        humanWin = true;
    }
    TallyScore(ref humanTotal, ref opponentTotal, humanWin, opponentWin); // must specify "ref" to pass by reference rather than by value
    Console.WriteLine($"Score tally for opponent: {opponentTotal}");
    Console.WriteLine($"Score tally for {human.Name}: {humanTotal}");
    Console.WriteLine("Would you like to play again? (y/n)");
    string userAgree = Console.ReadLine().ToLower();
    if (userAgree == "y")
    {
        playAgain = true;
    }
    if (userAgree == "n")
    {
        playAgain = false;
        Console.WriteLine("Thanks for playing! Goodbye!");
    }
} while (playAgain == true);

static void TallyScore (ref int humanTotal, ref int opponentTotal, bool humanWin, bool opponentWin)
{
    if (opponentWin == true)
    {
        opponentTotal++;
    }
    else if (humanWin == true)
    {
        humanTotal++;
    }
}



