using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        public CompareByName(bool order)
        {
            Order = order;
        }
        public bool Order { get;}

        public int Compare(Player x, Player y)
        {
            int order;

            if (Order)
            {
                order = x.Name.CompareTo(y.Name);
            }
            else
            {
                order = y.Name.CompareTo(x.Name);
            }
            return order;
        }
    }
}