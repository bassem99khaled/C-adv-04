using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__adv_04
{
    internal class Location : IEquatable<Location>
    {
        public int x {  get; set; }
        public int y { get; set; }

        public int z { get; set; }
        public override string ToString()
        
            => $" ( {x} , {y} , {z})";

        bool IEquatable<Location>.Equals(Location? other)
        => this.x.Equals(other.x) && this.y.Equals(other.y) && this.z.Equals(other.z);
        
    }
}
