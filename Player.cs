using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__adv_04
{
    //Subscriber01
    internal class Player
    {
        public string? Name { get; set; }
        public string? Team { get; set; }
        public void Run(object? Sender , EventArgs e)
        {
            Console.WriteLine($"{this} is Running  To {ballSender?.newlocation}....");
        }
        public override string ToString()
            => $"PLayer : {Name} ,  in Team : {Team}";
    }
}
