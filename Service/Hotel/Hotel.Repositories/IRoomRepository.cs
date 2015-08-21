using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Entity;

namespace Hotel.Repositories
{
    public interface IRoomRepository
    {
        List<Room> GetRooms();
    }
}
