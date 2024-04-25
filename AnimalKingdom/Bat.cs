using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public Bat()
        {
            NumberOfNipples = 2;

            NumberOfWings = 2;
        }
       public override string Sound()
        {
            // Google says I reply
            return base.Sound() + "Ti ti ti ti";
        }

        public int NumberOfNipples
        {
            get;
        }

        public int NumberOfWings
        {
            get;
        }
    }
}