using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        private readonly bool ascendente;
        public CompareByName(bool ascendente)
        {
            this.ascendente = ascendente;
        }

        public int Compare(Player x, Player y)
        {
            if (ascendente)
            {
                return string.Compare(x.Name, y.Name);
            }
            else
            {
                return string.Compare(y.Name, x.Name);
            }
        }
    }
}