using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Cat : Animal, IMammal
    {
        public Cat()
        {
            NumberOfNipples = 6;
        }
        public override string Sound()
        {
            return base.Sound() + "Miau";
        }
        public int NumberOfNipples
        {
            get;
        }
    
    }
}