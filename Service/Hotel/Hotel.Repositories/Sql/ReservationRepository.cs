using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Hotel.Entity;
using System.Globalization;

namespace Hotel.Repositories.Sql
{
    public class ReservationRepository : IReservationRepository
    {
            private enum _Id { guest = 0, room };

            #region Queries

            public string RESERV_ROOM = "INSERT INTO [dbo].[tblReservation] ([Arrival], [Departure], [GuestId], [RoomId]) VALUES ('";

            #endregion

            #region Fields

            public readonly string _conectionString;

            #endregion

            #region Constructor

            public ReservationRepository(string connectionString)
            {
                this._conectionString = connectionString;
            }

        #endregion

        #region IReservationRepositoty

        public void RoomReservation(DateTime arrival, DateTime departure, string guestName, int roomNumber)
        {
            List<string> searchId = new List<string>();
            List<string> commands = new List<string>();
            string GET_GUEST_ID = "SELECT Id FROM [dbo].[tblGuest] WHERE tblGuest.Name = '" + guestName.Split(' ')[0] + "' AND tblGuest.Surname = '" + guestName.Split(' ')[1] + "';";
            string GET_ROOM_ID = "SELECT Id FROM [dbo].[tblHotelRoom] WHERE tblHotelRoom.Number = " + roomNumber;
            string UPDATE_ROOM_RESERVE_STATUS = "UPDATE [dbo].[tblHotelRoom] SET Reserved = 1 WHERE NUMBER = " + roomNumber;
            commands.Add(GET_GUEST_ID);
            commands.Add(GET_ROOM_ID);
            using (var conection = new SqlConnection(this._conectionString))
            {
                conection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = conection;
                    for (int i = 0; i < commands.Count; i++)
                    {
                        command.CommandText = commands[i];
                        using (var reader = command.ExecuteReader())
                        {
                            reader.Read();
                            searchId.Add(reader["Id"].ToString());
                        }
                    }
                    RESERV_ROOM = RESERV_ROOM + arrival.ToString("d", CultureInfo.CreateSpecificCulture("en-US")) + "', '" +
                                                departure.ToString("d", CultureInfo.CreateSpecificCulture("en-US")) + "', '" +
                                                searchId[(int)_Id.guest] + "', '" + searchId[(int)_Id.room] + "');";                   
                }
                var insert_command = new SqlCommand(RESERV_ROOM, conection);
                insert_command.ExecuteNonQuery();

                var update_command = new SqlCommand(UPDATE_ROOM_RESERVE_STATUS, conection);
                update_command.ExecuteNonQuery();
            }
        }

        #endregion      
    }    
}
