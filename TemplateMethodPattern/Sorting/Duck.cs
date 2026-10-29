using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.CompareTo
{
    internal class Duck : IComparable <Duck>
    {
        string name;
        int weight;

        public Duck(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public int CompareTo(Duck? other)
        {
            if ( other == null)
            {
                return 1;
            }

            return other.weight.CompareTo(this.weight);
        }

        public override string ToString()
        {
            return $"{name} weights {weight}";
        }
    }
}
