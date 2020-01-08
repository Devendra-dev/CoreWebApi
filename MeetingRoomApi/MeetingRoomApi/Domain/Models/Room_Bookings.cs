using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingRoomApi.Domain.Models
{
    public class Room_Bookings
    {
        public Double row_id { get; set; }
        public string Login_id { get; set; }
        public String Dept { get; set; }
        public int RoomNo { get; set; }
        public DateTime BookingDate { get; set; }

        public char Slot_ind { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public DateTime update_date { get; set; }

        public char VCUsed { get; set; }
    }

}
