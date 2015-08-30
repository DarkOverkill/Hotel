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
            return "Success";
        }
        public RoomDTO[] GetRooms()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["HotelDatabase"].ConnectionString;
            IRoomRepository repository = new RoomRepository(connectionString);

            var rooms = repository.GetRooms();

            var RoomDTOs = new List<RoomDTO>();

            foreach (var room  in rooms)
            {
                RoomDTOs.Add(new RoomDTO() { Id = room.Id, Number = room.Number, Quantity = room.Quantity, Reserved = room.Reserved });
            }

            return RoomDTOs.ToArray();
        }

        public RoomDTO[] GetAvailableRooms()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["HotelDatabase"].ConnectionString;
            IRoomRepository repository = new RoomRepository(connectionString);

            var rooms = repository.GetAvailableRooms();

            var RoomDTOs = new List<RoomDTO>();

            foreach (var room in rooms)
            {
                RoomDTOs.Add(new RoomDTO() { Id = room.Id, Number = room.Number, Quantity = room.Quantity, Reserved = room.Reserved });
            }

            return RoomDTOs.ToArray();
        }

        public GuestDTO[] GetGuests()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HotelDatabase"].ConnectionString;
            IGuestRepository repository = new GuestRepository(connectionString);

            var guests = repository.GetGuests();

            var GuestDTOs = new List<GuestDTO>();

            foreach(var guest in guests)
            {
                GuestDTOs.Add(new GuestDTO() { Id = guest.Id, Name = guest.Name, Surname = guest.Surname, Email = guest.Email, Phone = guest.Phone });
            }
            return GuestDTOs.ToArray();
        }

        public void RoomReservation(DateTime arrival, DateTime departure, string guestNameSurname, int roomNumber)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HotelDatabase"].ConnectionString;
            IReservationRepository repository = new ReservationRepository(connectionString);
            repository.RoomReservation(arrival, departure, guestNameSurname, roomNumber);
        }

    }
}
