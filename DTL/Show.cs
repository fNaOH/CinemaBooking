using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_SE1620_ASS1.DTL
{
    internal class Show
    {
        public int ShowID { get; set; }
        public int RoomID { get; set; }
        public int FilmID { get; set; }
        public DateTime ShowDate { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }
        public int Slot { get; set; }

       
        public Show()
        {
        }

        public Show(int roomID, int filmID, DateTime showDate, double price, int slot,int showID,bool status)
        {
            RoomID = roomID;
            FilmID = filmID;
            ShowDate = showDate;
            Price = price;
            Slot = slot;
            ShowID= showID;
            Status = status;

        }
        

    }
}
