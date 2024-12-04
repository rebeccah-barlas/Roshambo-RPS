using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo___Rock__Paper__Scissors
{
    public class HumanPlayer : Player
    {
        public HumanPlayer() : base("") { } // constructor call to the base class - "("")" after base means the base class is being called with an empty string
        public void NameAndChoice()
        {
            Console.WriteLine("Please enter your name");
            Name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Hello {Name}");
            bool validChoice = false;

            do
            {
                Console.WriteLine("Select your move: rock, paper, or scissors?");
                string userChoice = Console.ReadLine();
                switch (userChoice.ToLower())
                {
                    case "rock":
                        RoshamboPick = Roshambo.Rock;
                        validChoice = true;
                        break;
                    case "paper":
                        RoshamboPick = Roshambo.Paper;
                        validChoice = true;
                        break;
                    case "scissors":
                        RoshamboPick = Roshambo.Scissors;
                        validChoice = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        validChoice = false;
                        break;
                }
            } while (validChoice == false);
        }
        public override Roshambo GenerateRoshambo()
        {
            return RoshamboPick;
        }
    }
}
