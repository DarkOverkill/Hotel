using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Entity
{
    public class Reservation
    {
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public int GuestID { get; set; }
        public int RoomID { get; set; }
    }
}
