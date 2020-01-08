using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingRoomApi.Domain.Models
{
    public class Meeting_Room
    {
        public int RoomId { get; set; }
        public int RoomNo { get; set; }
        public string RoomName { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public string Accessories { get; set; }
        public char Status { get; set; }

        public string Area { get; set; }
        public string SubArea { get; set; }

        public char IsVCRoom { get; set; }

        public string IP_NO { get; set; }
    }
}
