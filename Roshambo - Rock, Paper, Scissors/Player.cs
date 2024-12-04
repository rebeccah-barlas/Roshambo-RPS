using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo___Rock__Paper__Scissors
{
    public abstract class Player
    {
        public string Name { get; set; }
        public Roshambo RoshamboPick { get; set; }
        public Player (string name)
        {
            Name = name;
        }
        public abstract Roshambo GenerateRoshambo();
    }
}
