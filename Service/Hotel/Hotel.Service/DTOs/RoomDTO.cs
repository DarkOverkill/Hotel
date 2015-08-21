using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Hotel.Service.DTOs
{
    [DataContract]
    public class RoomDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int Number { get; set; }

        [DataMember]
        public int Quantity { get; set; }
    }
}