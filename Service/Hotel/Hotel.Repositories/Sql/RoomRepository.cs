using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Entity;
using System.Data.SqlClient;

namespace Hotel.Repositories.Sql
{
    public class RoomRepository : IRoomRepository
    {
        #region Queries

        private const string SELECT_ROOMS = "SELECT [Id], [Number], [Reserved], [RoomQuantity] FROM [dbo].[tblHotelRoom]";

        #endregion

        #region Fields

        private readonly string _connectionSting;

        #endregion

        #region Constructors

        public RoomRepository(string connectionString)
        {
            this._connectionSting = connectionString;
        }

        #endregion

        #region IRoomRepository

        public List<Room> GetRooms()
        {
            using (var connection = new SqlConnection(this._connectionSting))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = SELECT_ROOMS;

                    using (var reader = command.ExecuteReader())
                    {
                        List<Room> rooms = new List<Room>();
                        while(reader.Read())
                        {
                            Room room = new Room();
                            room.Id = (int)reader["Id"];
                            room.Number = (int)reader["Number"];
                            room.Quantity = (int)reader["RoomQuantity"];
                            room.Reserved = (bool)reader["Reserved"];
                            rooms.Add(room);
                        }
                        return rooms;
                    }
                }
            }
        }

        public List<Room> GetAvailableRooms()
        {
            using (var connection = new SqlConnection(this._connectionSting))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = SELECT_ROOMS;

                    using (var reader = command.ExecuteReader())
                    {
                        List<Room> rooms = new List<Room>();
                        while (reader.Read())
                        {
                            Room room = new Room();
                            room.Id = (int)reader["Id"];
                            room.Number = (int)reader["Number"];
                            room.Quantity = (int)reader["RoomQuantity"];
                            room.Reserved = (bool)reader["Reserved"];
                            if(room.Reserved != true)
                                rooms.Add(room);
                        }
                        return rooms;
                    }
                }
            }
        }
        #endregion
    }
}
