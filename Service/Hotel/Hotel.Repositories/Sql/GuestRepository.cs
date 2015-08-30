using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Entity;
using System.Data.SqlClient;

namespace Hotel.Repositories.Sql
{
    public class GuestRepository : IGuestRepository
    {
        #region Queries

        public const string SELECT_GUESTS = "SELECT [Id], [Name], [Surname], [Email], [Phone] FROM [dbo].[tblGuest]";

        #endregion

        #region Fields

        public readonly string _conectionString;

        #endregion

        #region Constructor

        public GuestRepository(string connectionString)
        {
            this._conectionString = connectionString;
        }

        #endregion

        #region IGuestRepository

        public List<Guest> GetGuests()
        {
            using (var conection = new SqlConnection(this._conectionString))
            {
                conection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = conection;
                    command.CommandText = SELECT_GUESTS;

                    using (var reader = command.ExecuteReader())
                    {
                        List<Guest> guests = new List<Guest>();
                        while(reader.Read())
                        {
                            Guest guest = new Guest();
                            guest.Id = (int)reader["Id"];
                            guest.Name = (string)reader["Name"];
                            guest.Surname = (string)reader["Surname"];
                            guest.Email = (string)reader["Email"];
                            guest.Phone = (string)reader["Phone"];
                            guests.Add(guest);
                        }
                        return guests;
                    }
                }
            }          
        }

        #endregion
    }
}
