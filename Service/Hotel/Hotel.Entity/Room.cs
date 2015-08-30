using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Entity
{
    public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Quantity { get; set; }
        public bool Reserved { get; set; }
    }
}
