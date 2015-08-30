using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositories
{
    public interface IReservationRepository
    {
        void RoomReservation(DateTime arrival, DateTime departure, string guestName, int roomID);
    }
}
