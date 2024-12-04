using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo___Rock__Paper__Scissors
{
    public class RockPlayer : Player
    {
        public RockPlayer(string name) : base(name) { } // "(string name)" is the parameter, "base (name)" is a constructor call to the base class
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}
