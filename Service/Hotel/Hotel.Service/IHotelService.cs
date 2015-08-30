using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Hotel.Service.DTOs;

namespace Hotel.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHotelService" in both code and config file together.
    [ServiceContract]
    public interface IHotelService
    {
        [OperationContract]
        string Registered();

        [OperationContract]
        RoomDTO[] GetRooms();

        [OperationContract]
        RoomDTO[] GetAvailableRooms();

        [OperationContract]
        GuestDTO[] GetGuests();

        [OperationContract]
        void RoomReservation(DateTime arrival, DateTime departure, string guestNameSurname, int roomNumber);
    }
}
