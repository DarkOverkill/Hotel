using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Hotel.Repositories;
using Hotel.Repositories.Sql;
using Hotel.Service.DTOs;
using System.Configuration;

namespace Hotel.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HotelService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HotelService.svc or HotelService.svc.cs at the Solution Explorer and start debugging.
    public class HotelService : IHotelService
    {
        public string Registered()
        {
            return "Room succesful reserved!!";
        }
        public RoomDTO[] GetRooms()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["HotelDatabase"].ConnectionString;
            IRoomRepository repository = new RoomRepository(connectionString);

            var rooms = repository.GetRooms();

            var RoomDTOs = new List<RoomDTO>();

            foreach (var room  in rooms)
            {
                RoomDTOs.Add(new RoomDTO() { Id = room.Id, Number = room.Number, Quantity = room.Quantity});
            }

            return RoomDTOs.ToArray();
        }
    }
}
