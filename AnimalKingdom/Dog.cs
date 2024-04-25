using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Dog : Animal, IMammal
    {
        public Dog()
        {
            NumberOfNipples = 10;
        }
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
        public int NumberOfNipples
        {
            get;
        }
    }
}