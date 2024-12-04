using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo___Rock__Paper__Scissors
{
    public class RandomPlayer : Player
    {
        public RandomPlayer (string name) : base (name) { }
        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();
            return (Roshambo)random.Next(0, 3); // 0 is inclusive, 3 is exclusive - will generate a random integer 0-2 (0 may be rock/1 may be paper/2 may be scissors)
        }
    }
}
