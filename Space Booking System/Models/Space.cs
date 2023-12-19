using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Booking_System.Models
{
    internal class Space
    {

        public int SpaceID { get; set; }
        public string SpaceName { get; set; }
        public int Capacity { get; set; }

        public List<Booking> Bookings { get; set; }

    }
}