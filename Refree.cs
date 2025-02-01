using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__adv_04
{
    internal class Refree
    {
        public string? name {  get; set; }

        public void Look(Location newLocation)
        { Console.WriteLine($"{this} is Looking Towards this Location { newLocation }....."); }
        public override string ToString()
            => $"Refree : {name}";
    }
}
