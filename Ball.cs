using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__adv_04
{
    // Publisher
    internal class Ball
    {
        public int Id { get; set; }
        private Location location;

        public Location Location

        {
            get => Location;
            set
            {
                if (!value.Equals(location))
                {
                    Location = value;
                    // LocationChanged?.Invoke(Location); //First Event
                    On_LocationChanged(location);
                }

            }
        }

        // public event Action<Location>? LocationChanged;

        public event EventHandler? LocationChanged;

        //  protected void On_LocationChanged(Location newLocation)
        //  {
        //      LocationChanged?.Invoke(Location); //First Event
        //  }

        protected void On_LocationChanged()
        {
            LocationChanged?.Invoke(this, new EventArgs()); //First Event
        }
        public override string ToString()
        
            => $"Ball with id : {Id}";

       



    

    }
}
