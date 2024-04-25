using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Bee :Animal, ICanFly
    {
        public Bee()
        {
            NumberOfWings = 2;
        }
        public override string Sound()
        {
            return base.Sound() + "Zzzzzzz";
        }

        public int NumberOfWings
        {
            get;
        }
    }
}