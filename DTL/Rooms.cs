using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_SE1620_ASS1.DTL
{
    internal class Rooms
    {
        public int RoomID { get; set; }
        public string Name { get; set; }
        public int NumberRows { get; set; }
        public int NumberCols { get; set; }

        public Rooms(int roomID, string name, int numberRows, int numberCols)
        {
            RoomID = roomID;
            Name = name;
            NumberRows = numberRows;
            NumberCols = numberCols;
        }

        public Rooms()
        {
        }
    }
}
